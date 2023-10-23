using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Password.Validation;

namespace Password.Validation
{
    public class ContainsALowercaseRequirement : IRequirement
    {
        public bool Apply(Password password)
        {
            return password.Pwd.Any(char.IsLower);
        }

        public string ErrorMessage()
        {
            return Constants.ERROR_LOWER_CASE;
        }
    }
}