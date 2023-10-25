using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextProcessingKata
{
    public interface ITextOperation
    {
        public List<KeyValuePair<string, int>> TopTenWords();
        public int NumberOfWordsSplitted();
        public int ReadingTime();
    }
}