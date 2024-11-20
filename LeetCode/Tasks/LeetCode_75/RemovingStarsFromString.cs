namespace LeetCode.Tasks.LeetCode_75;

public class RemovingStarsFromString
{
    /*
     You are given a string s, which contains stars *.
       
       In one operation, you can:
       
       Choose a star in s.
       Remove the closest non-star character to its left, as well as remove the star itself.
       Return the string after all stars have been removed.
       
       Note:
       
       The input will be generated such that the operation is always possible.
       It can be shown that the resulting string will always be unique.
     */
    public string RemoveStars(string s)
    {
        var stack = new Stack<char>();
        foreach (var ch in s)
        {
            if (ch != '*')
            {
                stack.Push(ch);
            }else
                stack.Pop();
        }
        return string.Join("",stack.Reverse());
    }
}