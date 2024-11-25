using System.Text;

namespace LeetCode.Tasks.LeetCode_75;

public class MergeStringsAlternately
{
    /*
     * You are given two strings word1 and word2. Merge the strings by adding letters in alternating order,
     * starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.
       
       Return the merged string.
     */
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder comp = new StringBuilder();
        int smallLength = word1.Length > word2.Length ? word2.Length : word1.Length;
        for (int i = 0; i <smallLength; i++)
        {
            comp.Append(word1[i]);
            comp.Append(word2[i]);
        }
        comp.Append(word1.Length > word2.Length
            ? word1.Substring(smallLength, word1.Length - smallLength)
            : word2.Substring(smallLength, word2.Length - smallLength));
        return comp.ToString();
    }
}