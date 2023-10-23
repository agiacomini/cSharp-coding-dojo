using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Password.Validation.Strategy
{
    public interface IValidationPasswordStrategy
    {
        bool ApplyValidationPasswordStrategy(List<string> listOfError);
    }
}