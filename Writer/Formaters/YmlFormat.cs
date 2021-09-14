using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Formaters
{
    class YmlFormat : IFormatable
    {
        public string GetContent()
        {
            return "Archivo en formato Yml";
        }
        public string GetExtension()
        {
            return FormatType.yml.ToString();
        }
    }
}
