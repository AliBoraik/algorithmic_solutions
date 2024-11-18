namespace LeetCode.Tasks;

public class WordPatternTask
{
    /*
     Given a pattern and a string s, find if s follows the same pattern.
       
       Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s. Specifically:
       
       1) Each letter in pattern maps to exactly one unique word in s.
       2) Each unique word in s maps to exactly one letter in pattern.
       3) No two letters map to the same word, and no two words map to the same letter.
     */
    public bool WordPattern(string pattern, string s)
    {
        var dictionary = new Dictionary<char, string>();
        var words = s.Split(' ');
        if (words.Length != pattern.Length)
        {
            return false;
        }
        for (var i = 0; i < pattern.Length ; i++)
        {
            if (dictionary.TryGetValue(pattern[i], out var currentPair))
            {
                if (currentPair != words[i])
                {
                    return false;
                }
                continue;
            }
            if (dictionary.ContainsValue(words[i]))
            {
                return false;
            }
            dictionary.Add(pattern[i], words[i]);
        }
        return true;
    }
}

