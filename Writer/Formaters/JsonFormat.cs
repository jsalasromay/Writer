using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Formaters
{
    class JsonFormat : IFormatable
    {
        public string GetContent()
        {
            return "Archivo en formato json";
        }
        public string GetExtension()
        {
            return FormatType.json.ToString();
        }
    }
}
