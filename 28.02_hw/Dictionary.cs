using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interaface;

namespace DictionaryClass
{
    public class Dictionary:ITranslate, IAddWord, Print
    {
        SortedList<string, string> dictionary;//key-english word, value - russian word
        SortedList<string, string> _Dictionary { get { return dictionary; } }
        public Dictionary() 
        {
            dictionary = new SortedList<string, string>();
        }

        public void AddWord(string EngWord, string RusWord)
        {
            dictionary.Add(EngWord, RusWord);
        }

        public string GetEnglishTranslate(string EngWord)
        {
            foreach(var i in dictionary)
            {
                if(i.Key == EngWord)
                {
                    return i.Value.ToString();
                }
            }
            return null;
        }

        public string GetRussianTranslate(string RusWord)
        {
            foreach(var i in dictionary)
            {
                if( i.Value == RusWord)
                {
                 return i.Key.ToString();
                }
            }
            return null;
        }

        public void Print()
        {
            foreach (var i in dictionary)
            {
                Console.WriteLine(i.Key.ToString() + "\t" + i.Value.ToString());
            }
        }
    }
}
