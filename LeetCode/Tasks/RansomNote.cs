namespace LeetCode.Tasks;

public class RansomNote
{
    /*
     Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
       
       Each letter in magazine can only be used once in ransomNote.
     */
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] cons = new int[26];
        foreach (var t in magazine)
        {
            cons[t - 'a']++;
        }

        foreach (var t in ransomNote)
        {
            cons[t - 'a']--;
            if (cons[t - 'a'] == -1)
            {
                return false;
            }
        }
        return true;
    }
}