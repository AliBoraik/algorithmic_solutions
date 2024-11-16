namespace LeetCode.Tasks.LeetCode_75;

public class LongestSubarrayAfterDeletingOneElement
{
    /*
     Given a binary array nums, you should delete one element from it.
       
       Return the size of the longest non-empty subarray containing only 
       1's in the resulting array. Return 0 if there is no such subarray.
     */
    public int LongestSubarray(int[] nums) {
        int prevWindow = 0;
        int currWindow = 0;
        int maxLength = 0;
        foreach (var num in nums)
        {
            if (num == 0)
            {
                maxLength = Math.Max(maxLength, prevWindow + currWindow);
                prevWindow = currWindow;
                currWindow = 0;
            }
            else
                currWindow++;
        }
        if (currWindow == nums.Length)
            return currWindow - 1;
        return Math.Max(maxLength, prevWindow + currWindow);
    }
}