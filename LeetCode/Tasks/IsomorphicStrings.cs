namespace LeetCode.Tasks;

public class IsomorphicStrings
{
    /*
     Given two strings s and t, determine if they are isomorphic.
       
       Two strings s and t are isomorphic if the characters in s can be replaced to get t.
       
       All occurrences of a character must be replaced with 
       another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.
     */
    public bool IsIsomorphic(string s, string t) {
        int[] map1 = new int[128];  // Stores frequency of s
        int[] map2 = new int[128];  // Stores frequency of t

        for(int i=0; i<s.Length; i++) {
            char sCh = s[i];
            char tCh = t[i];

            if(map1[sCh]==0 && map2[tCh]==0) {
                map1[sCh] = tCh;
                map2[tCh] = sCh;
            }
            else if(map1[sCh] != tCh || map2[tCh] != sCh) {
                return false;
            }
        }
        return true;
    }
}