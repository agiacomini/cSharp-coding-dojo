using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Password.Validation;

namespace Password.Validation
{
    public class ContainsANumberRequirement : IRequirement
    {
        public bool Apply(Password password)
        {
            return password.Pwd.Any(char.IsDigit);
        }

        public string ErrorMessage()
        {
            return Constants.ERROR_NUMBER;
        }
    }
}