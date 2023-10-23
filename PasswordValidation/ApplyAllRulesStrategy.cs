using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Password.Validation.Strategy
{
    public class ApplyAllRulesStrategy : IValidationPasswordStrategy
    {
        public bool ApplyValidationPasswordStrategy(List<string> listOfError)
        {
            if(listOfError.Count == 0)
                return true;
            return false;
        }
    }
}