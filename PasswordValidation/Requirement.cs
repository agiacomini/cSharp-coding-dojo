using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Password.Validation
{
    public class Requirement : IRequirement
    {
        private string name = string.Empty;
        public string Name { get { return name; } }

        public class RequirementBuilder
        {
            private readonly Requirement requirement;

            public RequirementBuilder()
            {
                requirement = new Requirement();
            }

            public RequirementBuilder withName(string name)
            {
                requirement.name = name;
                return this;
            }

            public Requirement Build()
            {
                return requirement;
            }
        }

        public bool Apply(Password password)
        {
            throw new NotImplementedException();
        }

        public string ErrorMessage()
        {
            throw new NotImplementedException();
        }
    }
}