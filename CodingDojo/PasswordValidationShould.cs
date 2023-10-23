using Password.Validation;
using Password.Validation.Strategy;

namespace CodingDojo
{
    public class PasswordValidationShould
    {
        List<IRequirement> listRequirement;
        PasswordValidation passwordValidation;

        public PasswordValidationShould()
        {
            this.listRequirement = new List<IRequirement>();
            listRequirement.Add(new NumberOfCharacterRequirement(6));
            listRequirement.Add(new ContainsACapitalLetterRequirement());
            listRequirement.Add(new ContainsALowercaseRequirement());
            listRequirement.Add(new ContainsANumberRequirement());
            listRequirement.Add(new ContainsAnUnderscoreRequirement());

            this.passwordValidation = new PasswordValidation(listRequirement);
        }

        [Fact]
        public void Password_respect_all_requirements()
        {
            // Given
            Password.Validation.Password password = new("123Ab45_6");
            passwordValidation.SetStrategy(new ApplyAllRulesStrategy());
        
            // When
            bool result = passwordValidation.IsValid(password);
        
            // Then
            Assert.True(result, "123Ab45_6 is a correcrt password");
        }    

        [Fact]
        public void Password_not_respect_underscore_and_capital_requirements()
        {
            // Given
            Password.Validation.Password password = new("123b456");
            passwordValidation.SetStrategy(new ApplyAllRulesStrategy());
        
            // When
            bool result = passwordValidation.IsValid(password);
        
            // Then
            Assert.False(result, "123b456 not respect all requirements");
        }

        [Fact]
        public void Password_not_respect_all_requirements_and_the_list_of_error_contains_two_error()
        {
            // Given
            Password.Validation.Password password = new("123b456");
            passwordValidation.SetStrategy(new ApplyAllRulesStrategy());
        
            // When
            bool result = passwordValidation.IsValid(password);
        
            // Then
            Assert.Equal(2, passwordValidation.ListOfError.Count);
        }

        [Fact]
        public void Passwor_not_respect_all_requirements_and_the_list_of_error_contains_capital_and_underscore_errors()
        {
            // Given
            Password.Validation.Password password = new("123b456");
            passwordValidation.SetStrategy(new ApplyAllRulesStrategy());
        
            // When
            bool result = passwordValidation.IsValid(password);
        
            // Then
            Assert.Collection(passwordValidation.ListOfError, 
                                    (string item) => Assert.Equal(Constants.ERROR_CAPITAL_LETTER, item),
                                    (string item) => Assert.Equal(Constants.ERROR_UNDERSCORE, item));
        }

        [Fact]
        public void Password_not_respect_all_requirements_but_pass_anyway_validation()
        {
            // Given
            Password.Validation.Password password = new("123b4_56");
            passwordValidation.SetStrategy(new FailOneRuleStrategy());
        
            // When
            bool result = passwordValidation.IsValid(password);
        
            // Then
            Assert.True(result, "123b4_56 is valid but not respect capital requirement");
        }

        [Fact]
        public void Password_not_respect_all_requirements_and_not_set_strategy()
        {
            // Given
            Password.Validation.Password password = new("123b4_56");
        
            // When
            bool result = passwordValidation.IsValid(password);
        
            // Then
            Assert.False(result, "123b4_56 is not valid because the default strategy provides all requirements are satisfied");
        }

        [Fact]
        public void Password_respect_all_requirements_and_not_set_stategy()
        {
            // Given
            Password.Validation.Password password = new("123b4_5F6");
        
            // When
            bool result = passwordValidation.IsValid(password);
        
            // Then
            Assert.True(result, "123b4_5F6 is valid because the default strategy provides that all requirements are satisfied");
        }
    }
}