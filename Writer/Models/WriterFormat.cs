using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Writter_Kata.Enum;
using Writter_Kata.Interfaces;

namespace WriterKata.Models
{
    class WriterFormat : IWriter
    {
        private IFormatable _formater;
        public WriterFormat(IFormatable formater)
        {
            _formater = formater;
        }
        public void Change(FormatType formatType, string path)
        {
            var fullPath = $@"C:\Users\desarrollo02\Documents\{path}";
            string[] files = Directory.GetFiles(fullPath);
            Parallel.ForEach(files, (fileName) =>
            {
                saveFile(fileName, formatType);
            });
        }
        void saveFile(string fileName, FormatType formatType)
        {
            var sub = fileName.Split(@".");
            var name = sub[sub.Length - 2];
            if (!File.Exists($@"{name}.{formatType}"))
            {
                File.Copy(fileName, $@"{name}.{formatType}");
                File.Delete(fileName);
            }
        }

        public void Write(string fileName, FormatType formatType, string storageEnum)
        {
            string ruta = @"C:\Users\desarrollo02\Documents\format";
            if (!File.Exists($@"{ruta}\{fileName}.{formatType}"))
                File.Create($@"{ruta}\{fileName}.{formatType}");
        }
    }
}
