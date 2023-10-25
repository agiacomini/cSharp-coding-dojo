using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextProcessingKata
{
    public interface ITextOperation
    {
        public void ProcessText();
        public int NumberOfWordsSplitted();
        public int ReadingTime();
    }
}