using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;

namespace Writter_Kata.Interfaces
{
    interface IFactory
    {
        IWriter CreateWrite(FormatType formatType);
    }
}
