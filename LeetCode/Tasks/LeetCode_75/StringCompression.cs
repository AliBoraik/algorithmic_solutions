namespace LeetCode.Tasks.LeetCode_75;

public class StringCompression
{
    /*
     * Given an array of characters chars, compress it using the following algorithm:
       
       Begin with an empty string s. For each group of consecutive repeating characters in chars:
       
       If the group's length is 1, append the character to s.
       Otherwise, append the character followed by the group's length.
       The compressed string s should not be returned separately, but instead, be stored in the input character array chars.
        Note that group lengths that are 10 or longer will be split into multiple characters in chars.
       
       After you are done modifying the input array, return the new length of the array.
       
       You must write an algorithm that uses only constant extra space.
     */
    public int Compress(char[] chars)
    {
        var i = 0;
        var j = 0;

        while (i < chars.Length)
        {
            var current = chars[i];
            var counter = 0;

            while (i < chars.Length && chars[i] == current)
            {
                i++;
                counter++;
            }

            chars[j++] = current;

            if (counter > 1)
            {
                foreach (var counterChar in counter.ToString())
                {
                    chars[j++] = counterChar;
                }
            }
        }

        return j;
    }
}