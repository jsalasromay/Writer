using System;
using Writter_Kata.Enum;
using Writter_Kata.Models;

namespace Writter_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quieres escribir en un archivo en local o en la nube: format/cloud");
            string storage = Console.ReadLine();
            Console.WriteLine("Introduzca el archivo que desea:");
            string name = Console.ReadLine();
            Console.WriteLine(@"Introduzca el formato en que desea el archivo: 
    1-json
    2-txt
    3-xml
    4-yml");
            int choice;
            Int32.TryParse(Console.ReadLine(), out choice);
            
            Container container = new Container(storage);

            var writter = container.Factory.CreateWrite((FormatType)choice);
            writter.Write(name, (FormatType)choice, storage);

            Console.WriteLine("Quieres cambiar el formato de los archivos en local o en la nube: format/cloud");
            string storage2 = Console.ReadLine();
            Console.WriteLine(@"Introduzca el formato al que desea cambiarlos: 
    1-json
    2-txt
    3-xml
    4-yml");
            int choice2;
            Int32.TryParse(Console.ReadLine(), out choice2);
            writter.Change((FormatType)choice2, storage2);
        }
    }
}
