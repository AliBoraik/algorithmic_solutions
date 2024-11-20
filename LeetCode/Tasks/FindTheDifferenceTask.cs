namespace LeetCode.Tasks;

public class FindTheDifferenceTask
{
    public char FindTheDifference(string s, string t)
    {
        int result = 0;
        foreach (char c in t) result += c;
        foreach (char c in s) result -= c;
        return (char)result;    
    }
}