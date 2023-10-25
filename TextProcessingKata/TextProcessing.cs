
using System.Text.RegularExpressions;

namespace TextProcessingKata;

public class TextProcessing
{
    public static int CalculateReadingTime(string originalString)
    {
        Text text = new Text(originalString);

        text.DeleteSnippedCodeFromString();

        text.ProcessText();
        return text.ReadingTime();
    }

    public static List<KeyValuePair<string, int>> CalculateTopTenWords(string originalString)
    {
        Text text = new Text(originalString);
        text.ProcessText();
        return text.TopTenWords;
    }

    public static int WordNumber(string originalString)
    {
        Text text = new Text(originalString);
        text.Content = originalString;
        return text.NumberOfWordsSplitted();
    }
}