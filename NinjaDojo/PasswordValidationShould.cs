using Password.Validation;

namespace NinjaDojo;

[TestClass]
public class PasswordValidationShould
{
    List<IRequirement> listRequirement;
    PasswordValidation passwordValidation_2V;

    public PasswordValidationShould()
    {
        this.listRequirement = new List<IRequirement>();
        listRequirement.Add(new NumberOfCharacterRequirement(6));
        listRequirement.Add(new ContainsACapitalLetterRequirement());
        listRequirement.Add(new ContainsALowercaseRequirement());
        listRequirement.Add(new ContainsANumberRequirement());
        listRequirement.Add(new ContainsAnUnderscoreRequirement());

        this.passwordValidation_2V = new PasswordValidation(listRequirement);
    }

    [TestMethod]
    public void TestMethod1()
    {
        Password.Validation.Password password = new("123b456");

        bool result = passwordValidation_2V.IsValid(password);

        CollectionAssert.AreEquivalent(passwordValidation_2V.ListOfError, 
                                        new List<string>{Constants.ERROR_UNDERSCORE, Constants.ERROR_CAPITAL_LETTER});
    }
}