using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;

namespace Writter_Kata
{
    class Factory : IFactory
    {
        IFormatable formater;
        private readonly Dictionary<FormatType, IFormatable> _formatList;
        public Factory(Dictionary<FormatType, IFormatable> formatList)
        {
            _formatList = formatList;
        }

        public IWriter CreateWrite(FormatType formatType)
        {
            return new Writer(formater);
        }

    }
}
