using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interaface
{
    public interface ITranslate
    {
        string GetEnglishTranslate(string word);
        string GetRussianTranslate(string word);
    }
}
