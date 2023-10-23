using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Password.Validation;

namespace Password.Validation
{
    public class ContainsACapitalLetterRequirement : IRequirement
    {
        public bool Apply(Password password)
        {
            return password.Pwd.Any(char.IsUpper);
        }

        public string ErrorMessage()
        {
            return Constants.ERROR_CAPITAL_LETTER;
        }
    }
}