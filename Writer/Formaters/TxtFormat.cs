using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Formaters
{
    class TxtFormat : IFormatable
    {
        public string GetContent()
        {
            return "Archivo en formato txt";
        }
        public string GetExtension()
        {
            return FormatType.txt.ToString();
        }
    }
}
