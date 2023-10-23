using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Password.Validation.Strategy
{
    public class FailOneRuleStrategy : IValidationPasswordStrategy
    {
        public bool ApplyValidationPasswordStrategy(List<string> listOfError)
        {
            if(listOfError.Count <= 1)
                return true;
            return false;
        }
    }
}