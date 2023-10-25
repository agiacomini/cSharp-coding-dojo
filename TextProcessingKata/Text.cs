using System.Text.RegularExpressions;

namespace TextProcessingKata
{
    public class Text : ITextOperation
    {
        public string Content { get; set; } = string.Empty;
        List<string> _contentSplitted = new List<string>();
        Dictionary<string, int> _map = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public List<KeyValuePair<string, int>> TopTenWords { get; set; } = new();

        public Text(string originalString)
        {
            this.Content = originalString;
            ExtractWords();
        }

        public void ProcessText()
        {
            foreach (string word in _contentSplitted)
            {
                AddOrUpdateKeyMapValue(word);
            }
            UpdateTopTenWord();
        }

        private void UpdateTopTenWord()
        {
            TopTenWords = _map.OrderByDescending(key => key.Value).Take(10).ToList();
        }

        private void ExtractWords()
        {
            MatchCollection matchList = Regex.Matches(this.Content, TextProcessingRegex.PATTERN_FIND_WORD);
            this._contentSplitted = matchList.Cast<Match>().Select(match => match.Value).ToList();
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

        public int NumberOfWordsSplitted()
        {
            return _contentSplitted.Count;
        }

        public int ReadingTime()
        {
            double result = _contentSplitted.Count / 200.00;
            double integerPart = Math.Truncate(result);
            double decimalPart = result - integerPart;
            double extraTime = decimalPart * 0.60;
            double extraTimeRounded = Math.Round(extraTime);
            return (int)(integerPart + extraTimeRounded);
        }
    }
}