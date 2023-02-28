using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryClass;

namespace _28._02_hw
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Dictionary obj = new Dictionary();
            obj.AddWord("car", "автомобиль");
            obj.Print();
            Console.WriteLine(obj.GetEnglishTranslate("car"));
            Console.WriteLine(obj.GetRussianTranslate("автомобиль"));
            Console.ReadKey();
        }
    }
}
