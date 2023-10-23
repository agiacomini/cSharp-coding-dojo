using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Password.Validation
{
    public interface IRequirement
    {
        public string ErrorMessage();
        public bool Apply(Password password);
    }
}