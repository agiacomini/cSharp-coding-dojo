using System.Collections.Specialized;
using TextProcessingKata;

namespace CodingDojo
{
    public class TextProcessingShould
    {
        string inputString = string.Empty;
        List<KeyValuePair<string, int>> expectedTopTenList = new List<KeyValuePair<string, int>>();

        [Fact]
        public void The_top_ten_list_of_most_common_word_are_equals_to_expected()
        {
            // Given
            inputString = "Hello, this is an example for you to practice. You should grab this text and make it as your test case.";
            expectedTopTenList.Add(new KeyValuePair<string, int>("you", 2));
            expectedTopTenList.Add(new KeyValuePair<string, int>("this", 2));
            expectedTopTenList.Add(new KeyValuePair<string, int>("your", 1));
            expectedTopTenList.Add(new KeyValuePair<string, int>("to", 1));
            expectedTopTenList.Add(new KeyValuePair<string, int>("text", 1));
            expectedTopTenList.Add(new KeyValuePair<string, int>("test", 1));
            expectedTopTenList.Add(new KeyValuePair<string, int>("should", 1));
            expectedTopTenList.Add(new KeyValuePair<string, int>("practice", 1));
            expectedTopTenList.Add(new KeyValuePair<string, int>("make", 1));
            expectedTopTenList.Add(new KeyValuePair<string, int>("it", 1));

            // When
            List<KeyValuePair<string, int>> topTenList = TextProcessing.CalculateTopTenWords(inputString);
        
            // Then
            // Assert.Equal (expectedTopTenList, topTenList);
            // Assert.True(CollectionsUtil.Equals(expectedTopTenList, topTenList));

            Assert.True(!expectedTopTenList.Except(topTenList).Any() && expectedTopTenList.Count == topTenList.Count);
        }

        [Fact]
        public void The_word_number_is_correct()
        {
            // Given
            inputString = "Hello, this is an example for you to practice. You should grab this text and make it as your test case.";
        
            // When
            int wordNumber = TextProcessing.WordNumber(inputString);
        
            // Then
            Assert.Equal(21, wordNumber);
        }

        [Fact]
        public void Reading_time_of_a_783_word_text_is_equal_to_4_minutes()
        {
            // Given
            inputString = BlogPost.stringWith783Words;
        
            // When
            int readingTime = TextProcessing.CalculateReadingTime(inputString);
        
            // Then
            Assert.Equal(4, readingTime);
        }

        [Fact]
        public void Reading_time_of_a_700_word_text_is_equal_to_3_minutes()
        {
            // Given
            inputString = BlogPost.stringWith700Words;
        
            // When
            int readingTime = TextProcessing.CalculateReadingTime(inputString);
        
            // Then
            Assert.Equal(3, readingTime);
        }

        [Fact]
        public void Reading_time_of_a_536_word_text_is_equal_to_2_minutes()
        {
            // Given
            inputString = BlogPost.stringWith536Words;
        
            // When
            int readingTime = TextProcessing.CalculateReadingTime(inputString);
        
            // Then
            Assert.Equal(2, readingTime);
        }
    }
}