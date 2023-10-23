using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Password.Validation
{
    public class Constants
    {
        public static readonly string ERROR_CAPITAL_LETTER = "Doesn't contain at least a capital letter";
        public static readonly string ERROR_LOWER_CASE = "Not contains at least a lower case";
        public static readonly string ERROR_NUMBER = "Doesn't contains at least a number";
        public static readonly string ERROR_UNDERSCORE = "Not contains an underscore";
        public static readonly string ERROR_NUMBER_OF_CHARACTER = "Doesn't contains enough characters: Min ";
    }
}