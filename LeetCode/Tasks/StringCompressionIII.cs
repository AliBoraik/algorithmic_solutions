using System.Text;

namespace LeetCode.Tasks;

public class StringCompressionIII
{
    /*
     Given a string word, compress it using the following algorithm:
       
       Begin with an empty string comp. While word is not empty, use the following operation:
       Remove a maximum length prefix of word made of a single character c repeating at most 9 times.
       Append the length of the prefix followed by c to comp.
       Return the string comp.
     */
    public string CompressedString(string word)
    {
        StringBuilder comp = new StringBuilder();
        int cnt = 1;
        char ch = word[0];  
        for (int i = 1; i < word.Length; i++) {
            if (word[i] == ch && cnt < 9) {
                cnt++;
            } 
            else {
                comp.Append((char)(cnt + '0'));
                comp.Append(ch);
                ch = word[i];
                cnt = 1;
            }
        }
        comp.Append((char)(cnt + '0'));
        comp.Append(ch);
        
        return comp.ToString();
    }
}