using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Password.Validation;

namespace Password.Validation
{
    public class NumberOfCharacterRequirement : IRequirement
    {
        byte minCharacter;

        public NumberOfCharacterRequirement(byte minCharacter)
        {
            this.minCharacter = minCharacter;
        }
        public bool Apply(Password password)
        {
            return password.Length >= minCharacter;
        }

        public string ErrorMessage()
        {
            return Constants.ERROR_NUMBER_OF_CHARACTER + minCharacter.ToString();
        }
    }
}