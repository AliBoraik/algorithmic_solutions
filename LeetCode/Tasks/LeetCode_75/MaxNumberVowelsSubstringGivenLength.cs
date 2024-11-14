namespace LeetCode.Tasks.LeetCode_75;

public class MaxNumberVowelsSubstringGivenLength
{
    /*
     Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.
       
       Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.
     */
    public int MaxVowels(string s, int k)
    {
        int maxNum = 0;
        for (int i = 0; i < k; i++)
        {
            if (IsVowelLetters(s[i]))
                maxNum++;
        }
        var tempSum = maxNum;
        for (int i = 1; i < s.Length - k + 1; i++)
        {
            if (!IsVowelLetters(s[i - 1]))
            {
                tempSum--;
            }
            if (IsVowelLetters(s[i+k-1]))
            {
                tempSum++;
            }
            if(tempSum > maxNum)
            {
                maxNum = tempSum;
            }
        }
        return maxNum;
    }

    private static bool IsVowelLetters(char ch)
    {
        return ch is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}