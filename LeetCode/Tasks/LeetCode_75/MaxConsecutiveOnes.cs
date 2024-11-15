namespace LeetCode.Tasks.LeetCode_75;

public class MaxConsecutiveOnes
{
    /*
     Given a binary array nums and an integer k, return the maximum number 
     of consecutive 1's in the array if you can flip at most k 0's.
     */
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0;
        int right;

        for (right = 0; right < nums.Length; right++) {
            if (nums[right] == 0) {
                k--;
            }

            if (k < 0) {
                if (nums[left] == 0) {
                    k++;
                }
                left++;
            }
        }
        return right - left;
    }
}