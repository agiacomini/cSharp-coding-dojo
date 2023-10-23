using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Password.Validation;
using Password.Validation.Strategy;

namespace Password.Validation
{
    public class PasswordValidation
    {
        // Default Strategy: Apply Strategy that provides all Requirements should be respected
        private IValidationPasswordStrategy _strategy = new ApplyAllRulesStrategy();
        public List<IRequirement> ListRequirement { get; } = new();
        public List<string> ListOfError { get; } = new();
        public void SetStrategy(IValidationPasswordStrategy strategy)
        {
            this._strategy = strategy;
        }

        public PasswordValidation(List<IRequirement> listRequirement)
        {
            this.ListRequirement = listRequirement;
        }

        public bool IsValid(Password password)
        {
            foreach (IRequirement requirement in ListRequirement)
            {
                if (requirement.Apply(password) != true) 
                {
                    ListOfError.Add(requirement.ErrorMessage());
                }
            }
            return ApplyStrategy();
        }

        private bool ApplyStrategy()
        {
            return _strategy.ApplyValidationPasswordStrategy(ListOfError);
        }
    }
}