namespace LeetCode.Tasks.LeetCode_75;

public class UniqueNumberOccurrences
{
    /*
     Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.
     */
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> occurrences = new Dictionary<int, int>();
        HashSet<int> uniqueOccurrences = new HashSet<int>();

        foreach (var num in arr) {
            occurrences[num] = occurrences.GetValueOrDefault(num, 0) + 1;
        }

        foreach (var count in occurrences.Values) {
            if (!uniqueOccurrences.Add(count)) {
                return false;
            }
        }
        return true;
    }
}