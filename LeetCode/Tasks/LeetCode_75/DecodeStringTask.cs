using System.Text;

namespace LeetCode.Tasks.LeetCode_75;

public class DecodeStringTask
{
    /*
    Given an encoded string, return its decoded string.

   The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly
    k times. Note that k is guaranteed to be a positive integer.

   You may assume that the input string is always valid; there are no extra white spaces, square brackets are well-formed,
    etc. Furthermore, you may assume that the original data does not contain any digits and that digits are only for
    those repeat numbers, k. For example, there will not be input like 3a or 2[4].

   The test cases are generated so that the length of the output will never exceed 105.
 */
    public string DecodeString(string s)
    {
        var repeat = 0;
        var sb = new StringBuilder(s.Length);
        var st = new Stack<(int start, int repeat)>();

        foreach (var c in s)
            switch (c)
            {
                case '[':
                    st.Push((sb.Length, repeat));
                    repeat = 0;
                    break;
                case ']':
                {
                    var (start, times) = st.Pop();

                    for (var length = sb.Length - start; times > 1; times--) sb.Append(sb, start, length);

                    break;
                }
                default:
                {
                    if (char.IsDigit(c))
                        repeat = 10 * repeat + (c - '0');
                    else
                        sb.Append(c);

                    break;
                }
            }

        return sb.ToString();
    }
}