using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saraff.Twain;
using System.Drawing.Imaging;
using System.Drawing;

namespace Library.BLL
{
    public class ScannerManager
    {
        private string filePath;
        private Saraff.Twain.Twain32 _twain32;
        FilesManager filesManager = new FilesManager();

        public class FileAcquiredEventArgs : EventArgs
        {
            public string filePath;
        }

        public ScannerManager()
        {
            _twain32 = new Twain32();
            _twain32.AppProductName = ConfigurationManager.PROGRAM_NAME;
            _twain32.ShowUI = false;
        }

        public event EventHandler<FileAcquiredEventArgs> FileAcquired;

        protected void OnFileAcquired(FileAcquiredEventArgs e)
        {
            if (FileAcquired != null)
            {
                FileAcquired(this, e);
            }
        }

        public List<string> GetDevices()
        {
            _twain32.OpenDSM();

            List<string> all = new List<string>();

            for (int i = 0; i < _twain32.SourcesCount; i++)
            {
                all.Add(_twain32.GetSourceProductName(i));
            }

            _twain32.CloseDSM();

            return all;
        }

        private bool SetDevice(int deviceIndex)
        {
            try
            {
                _twain32.OpenDSM();
                _twain32.CloseDataSource();
                _twain32.SourceIndex = deviceIndex;
                _twain32.OpenDataSource();

                return true;
            }
            catch (TwainException)
            {
                return false;
            }
        }

        public void ScanToTempDir()
        {
            SetDevice(ConfigurationManager.ScanningDeviceIndex);
            SetResolution(ConfigurationManager.ScanningResolution);

            Guid guid = Guid.NewGuid();
            filePath = string.Format("{0}\\{1}.{2}", ConfigurationManager.GetTempStorageDirectoryPath(), guid.ToString(), "JPG");
            filesManager.ClearTempDirectory();

            try
            {
                _twain32.Acquire();
                _twain32.AcquireCompleted += new System.EventHandler(_twain32_AcquireCompleted);
            }
            catch
            {
                OnFileAcquired(new FileAcquiredEventArgs() { filePath = "" });
            }
        }

        public List<float> GetResolutions(int deviceIndex)
        {
            SetDevice(deviceIndex);
            Twain32.Enumeration _resolutions = _twain32.GetResolutions();
            List<float> resolutions = new List<float>();

            for (int i = 0; i < _resolutions.Count; i++)
            {
                resolutions.Add((float)_resolutions[i]);
            }
            _twain32.CloseDataSource();

            return resolutions;
        }

        private bool SetResolution(float resolutionIndex)
        {
            try
            {
                //_twain32.OpenDataSource();
                _twain32.SetResolutions(resolutionIndex);
                //_twain32.CloseDataSource();
            
                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<string> GetPixelType()
        {
            _twain32.OpenDataSource();
            Twain32.Enumeration _pixelTypes = _twain32.GetPixelTypes();
            List<string> pixelTypes = new List<string>();

            for (int i = 0; i < _pixelTypes.Count; i++)
            {
                pixelTypes.Add(_pixelTypes[i].ToString());

            }
            _twain32.CloseDataSource();

            return pixelTypes;
        }

        private bool SetPixelType(int pixelTypeIndex)
        {
            try
            {
                _twain32.SetPixelType((TwPixelType)pixelTypeIndex);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Close()
        {
            try
            {
                _twain32.CloseDSM();
            }
            catch
            {

            }

            try
            {
                _twain32.CloseDataSource();
            }
            catch
            {

            }
        }

        public void Dispose()
        {
            Close();

            try
            {
                _twain32.Dispose();
            }
            catch
            {

            }
        }

        public bool CanScan()
        {
            _twain32.OpenDSM();
            int count = _twain32.SourcesCount;
            _twain32.CloseDSM();

            return count > 0;
        }

        private void _twain32_AcquireCompleted(object sender, EventArgs e)
        {
            if (_twain32.ImageCount > 0)
            {
                Image image = _twain32.GetImage(0);
                try
                {
                    image.Save(filePath, ImageFormat.Jpeg);
                    OnFileAcquired(new FileAcquiredEventArgs() { filePath = this.filePath });
                }

                catch
                {
                    OnFileAcquired(new FileAcquiredEventArgs() { filePath = "" });
                }
            }
            else
            {
                OnFileAcquired(new FileAcquiredEventArgs() { filePath = "" });
            }

        }
    }
}
