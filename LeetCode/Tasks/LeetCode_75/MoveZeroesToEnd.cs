namespace LeetCode.Tasks.LeetCode_75;

public class MoveZeroesToEnd
{
    /*
     * Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
       
       Note that you must do this in-place without making a copy of the array.
     */
    public void MoveZeroes(int[] nums)
    {
        int left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] != 0)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
            }
        }
    }
}