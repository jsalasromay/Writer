using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{
    class Writer : IWriter
    {
        private IFormatable _formater;
        public Writer(IFormatable formater)
        {
            _formater = formater;
        }
        public void Write(string fileName, FormatType formatType, String storageEnum)
        {
            if (storageEnum.Equals(StorageEnum.cloud.ToString()))
            {
                Console.WriteLine($"SSD/{fileName}.{formatType}");
            }
            else if (storageEnum.Equals(StorageEnum.format.ToString()))
            {
                Console.WriteLine($"C/{fileName}.{formatType}");

            }

        }
    }
}
