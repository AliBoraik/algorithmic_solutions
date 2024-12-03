using System.Text;

namespace LeetCode.Tasks.LeetCode_75;

public class ReverseVowelsString
{
    /*
     * Given a string s, reverse only all the vowels in the string and return it.
       
       The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
     */
    public string ReverseVowels(string s)
    {
        if (s.Length == 0)
            return s;
        var stringBuilder = new StringBuilder(s);
        int start = 0;
        int end = s.Length -1;
        while (start <= end)
        {
            while (start <= end &&!IsVowels(s[start]))
            {
                start++;
                if (start >= end)
                    return stringBuilder.ToString();
            }
            
            while (end >= start && !IsVowels(s[end]))
            {
                end--;
                if(end <= start)
                    return stringBuilder.ToString();
            }
            char v = stringBuilder[start];
            stringBuilder[start] = s[end];
            stringBuilder[end] = v;
            start++;
            end--;
        }
        return stringBuilder.ToString();
    }

    private bool IsVowels(char ch)
    {
        return "aeiouAEIOU".Contains(ch);
    }
}