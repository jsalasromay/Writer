using System;
using System.Collections.Generic;
using System.Text;
using WriterKata.Models;
using Writter_Kata.Enum;
using Writter_Kata.Interfaces;

namespace Writter_Kata
{
    class Factory : IFactory
    {
        private readonly Dictionary<FormatType, IFormatable> _formatList;
        public Factory(Dictionary<FormatType, IFormatable> formatList)
        {
            _formatList = formatList;
        }

        public IWriter CreateWrite(FormatType formatType)
        {
            return new WriterFormat(_formatList[formatType]);
        }

    }
}
