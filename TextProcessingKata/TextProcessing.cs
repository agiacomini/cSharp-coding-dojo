
using System.Text.RegularExpressions;

namespace TextProcessingKata;

public class TextProcessing
{
    Dictionary<string, int> _map = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
    public static readonly string PATTERN_FIND_PUNCTUATION = "[^\\w\\s\\d]";
    string[] _topTenWord = new string[10];
    public bool Process(string inputString)
    {
        List<string> inputStringSplitted = CleanInputString(inputString).Split(" ").ToList();
        foreach (string word in inputStringSplitted)
        {
            AddOrUpdateKeyMapValue(word);
        }
        return true;
    }

    private void AddOrUpdateKeyMapValue(string word)
    {
        if(!_map.Any(i => i.Key.ToLower().Equals(word.ToLower())))
        {
            _map.Add(word, 1);
            return;
        }
        _map[word] = _map[word] + 1;
    }

    private string CleanInputString(string inputString)
    {
        return Regex.Replace(inputString, PATTERN_FIND_PUNCTUATION, "");
    }

    private void CheckWordInsideMap(string word)
    {
        string mapValue = string.Empty;
        _map.ContainsKey(word);
    }

    private void TopTenWord()
    {

    }
}
