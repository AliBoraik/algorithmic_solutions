namespace LeetCode.Tasks.LeetCode_75;

public class Subsequence
{
    /*
     * Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
       
       A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) 
       of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
     */
    public bool IsSubsequence(string s, string t)
    {
        int i = 0, j = 0;
        while (i < s.Length && j < t.Length) {
            if (s[i] == t[j]) {
                i++;
            }
            j++;
        }
        return i == s.Length;
    }
}