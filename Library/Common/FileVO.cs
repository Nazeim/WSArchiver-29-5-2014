using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Library.Common
{
    public class FileVO : NameBasedVO
    {
        public enum FileType:short
        {
            UNKNOWN = 0,

            DOC = 1,
            DOCX = 2,

            XLS = 3,
            XLSX = 4,

            PDF = 5,

            BMP = 6,
            PNG = 7,
            JPG = 8,
            JPEG = 9,
            GIF = 10,
            TIFF = 11,

            MP3 = 12,
            WMA = 13,
            WAV = 14,

            FLV = 15,
            MOV = 16,
            AVI = 17,
            WMV = 18,
            MP4 = 19,
            MPG = 20,
            MPEG = 21,

            HTM = 22,
            HTML = 23,

            TXT = 24
        }

        private DocumentVO document;
        private DateTime additionDateTime;
        private FileType type = FileType.UNKNOWN;
        private byte[] fileData;


        public byte[] FileData
        {
            get { return fileData; }
            set { fileData = value; }
        }

        public FileType Type
        {
            get { return type; }
            set { type = value; }
        }

        public DateTime AdditionDateTime
        {
            get { return additionDateTime; }
            set { additionDateTime = value; }
        }

        public int DocumentId
        {
            get
            {
                return document.Id;
            }
        }

        public DocumentVO Document
        {
            get { return document; }
            set { document = value; }
        }

        public bool IsImage()
        {
            switch (Type)
            {
                case FileType.BMP:
                case FileType.GIF:
                case FileType.JPEG:
                case FileType.JPG:
                case FileType.PNG:
                case FileType.TIFF:
                    return true;
                default:
                    return false;
            }
        }
    }
}
