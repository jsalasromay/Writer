using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;

namespace Writter_Kata.Interfaces
{
    interface IWriter
    {
        void Write(string fileName, FormatType formatType, String storageEnum);
    }
}
