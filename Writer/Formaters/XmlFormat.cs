using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Formaters
{
    class XmlFormat : IFormatable
    {
        public string GetContent()
        {
            return "Archivo en formato Xml";
        }
        public string GetExtension()
        {
            return FormatType.xml.ToString();
        }
    }
}
