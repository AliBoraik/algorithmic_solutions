namespace LeetCode.Tasks;

public class BackspaceStringCompare
{
    /*
     * Given two strings s and t, return true if they are equal when both are typed into empty text editors.
     * '#' means a backspace character.
       
       Note that after backspacing an empty text, the text will continue empty.
     */
    public bool BackspaceCompare(string s, string t)
    {
        var ss = new Stack<char>();
        var tt = new Stack<char>();
        foreach (var ch in s)
        {
            if (ch == '#')
            {
                if(ss.Count > 0) 
                    ss.Pop();
            }
            else
                ss.Push(ch);
        }
        foreach (var ch in t)
        {
            if (ch == '#')
            {
                if(tt.Count > 0) 
                    tt.Pop();
            }
            else
                tt.Push(ch);
        }
        var sss = new string(ss.ToArray());
        var ttt = new string(tt.ToArray());
        return sss == ttt;
    }
}