using TextProcessingKata;

namespace CodingDojo
{
    public class TextProcessingShould
    {
        string inputString = string.Empty;
        TextProcessing textProcessing = new TextProcessing();
        [Fact]
        public void Text_return_correct_result()
        {
            // Given
            inputString = "Hello, this is an example for you to practice. You should grab this text and make it as your test case.";
        
            // When
            bool result = textProcessing.Process(inputString);
        
            // Then
            Assert.True(result, "My message");
        }
    }
}