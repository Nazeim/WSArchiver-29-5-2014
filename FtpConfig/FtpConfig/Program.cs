using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FtpConfig
{
    class Program
    {
        public static void Main(string[] args)
        {
          string path=@"C:\Program Files (x86)\FileZilla Server";

          if (args.Length == 0)
              FilePath(path);
          else
            FilePath(args[0]);
        }

        private static void FilePath(string filePath)
        {
            File.Copy("FileZillaServer.xml", filePath);
        }
    }
}