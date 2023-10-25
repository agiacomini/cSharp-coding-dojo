using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextProcessingKata
{
    public class TextProcessingRegex
    {
        public static readonly string PATTERN_FIND_PUNCTUATION = "[^\\w\\s\\d]";
        public static readonly string PATTERN_FIND_WORD = "[^\\s]+";
    }
}