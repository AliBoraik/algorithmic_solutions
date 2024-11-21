namespace LeetCode.Tasks;

public class LongestPalindromeTask
{
    /*
      Given a string s which consists of lowercase or uppercase letters, return the length of the longest 
       palindrome
        that can be built with those letters.
       
       Letters are case sensitive, for example, "Aa" is not considered a palindrome.
     */
    public int LongestPalindrome(string s) {
        int[] arr = new int[123]; // 65 to 90: uppercase, 97 to 122 lowercase
        foreach(char ch in s)
            arr[ch]++;

        int ans = 0;
        foreach(int val in arr) 
        {
            ans += (val / 2) * 2; // val/2 to not include 0 count
            if(ans % 2 == 0 && val % 2 == 1) // to consider single letter for center
                ans++; // after this ans will always be odd number meaning center char is considered
        }
        return ans;
    }
}