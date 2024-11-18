namespace LeetCode.Tasks.LeetCode_75;

public class DetermineIfTwoStringsAreClose
{
    /*
     Two strings are considered close if you can attain one from the other using the following operations:
       
       Operation 1: Swap any two existing characters.
       For example, abcde -> aecdb
       Operation 2: Transform every occurrence of one existing character into another existing character, and do the same with the other character.
       For example, aacabb -> bbcbaa (all a's turn into b's, and all b's turn into a's)
       You can use the operations on either string as many times as necessary.
       
       Given two strings, word1 and word2, return true if word1 and word2 are close, and false otherwise.
     */
    public bool CloseStrings(string word1, string word2) {
        if (word1.Length != word2.Length) {
            return false;
        }

        int[] letters1 = new int[26]; // counter of letters for word1
        int[] letters2 = new int[26]; // counter of letters for word2

        foreach (char letter in word1) { // counting letters in word1 using ASCII tables trick
            letters1[letter - 'a'] += 1;
        }

        foreach (char letter in word2) { // counting letters in word2 using ASCII tables trick
            letters2[letter - 'a'] += 1;
        }

        // checking if word1 & word2 consist of the same letters
        for (int i = 0; i < letters1.Length; i++) {
            if ((letters1[i] > 0) != (letters2[i] > 0)) {
                return false;
            }
        }

        // checking if counters are just permutations of each other
        Array.Sort(letters1); // sorting them
        Array.Sort(letters2);

        for (int i = 0; i < letters1.Length; i++) { // checking if they are equal
            if (letters1[i] != letters2[i]) {
                return false;
            }
        }

        return true;
    }
}