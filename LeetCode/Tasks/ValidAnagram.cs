using System.Collections;

namespace LeetCode.Tasks;

public class ValidAnagram
{
    /*
    Given two strings s and t, return true if t is ananagram of s, and false otherwise.
    */
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        int[] saphabet = new int[26];
        foreach (var ch in s)
        {
            saphabet[ch - 'a']++;
        }

        foreach (var ch in t)
        {
            if (saphabet[ch - 'a'] > 0)
            {
                saphabet[ch - 'a']--;
            }
            else
                return false;
        }
        return true;
    }
}