using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Formaters;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{
    class Container
    {
        public Dictionary<FormatType, IFormatable> FormatList = new Dictionary<FormatType, IFormatable> 
        {
            {FormatType.json, new JsonFormat() },
            {FormatType.txt, new TxtFormat() },
            {FormatType.xml, new XmlFormat() },
            {FormatType.yml, new YmlFormat() }
        };
        public IFactory Factory;

        public Container(string storageEnum)
        {
            if (storageEnum.Equals(StorageEnum.cloud.ToString()))
            {
                Factory = new FactoryCloud(FormatList);
            }
            else if(storageEnum.Equals(StorageEnum.format.ToString()))
            {
                Factory = new Factory(FormatList);
            }
            
        }
    }
}
