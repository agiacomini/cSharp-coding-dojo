using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Password.Validation;

namespace Password.Validation
{
    public class ContainsAnUnderscoreRequirement : IRequirement
    {
        public bool Apply(Password password)
        {
            return password.Pwd.Contains('_');
        }

        public string ErrorMessage()
        {
            return Constants.ERROR_UNDERSCORE;
        }
    }
}