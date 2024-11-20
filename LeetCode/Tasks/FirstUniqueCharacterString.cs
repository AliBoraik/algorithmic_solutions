namespace LeetCode.Tasks;

public class FirstUniqueCharacterString
{
    /*
        Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
     */
    public int FirstUniqChar(string s)
    {
        var cons = new int[26];
        foreach (var ch in s)
        {
            cons[ch - 'a']++;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (cons[s[i] - 'a'] == 1)
                return i;
        }
        return -1;
    }
}