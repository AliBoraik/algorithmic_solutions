
namespace LeetCode.Tasks.LeetCode_75;

public class MaxNumberKSumPairs
{
    /*
     * You are given an integer array nums and an integer k.
       
       In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.
       
       Return the maximum number of operations you can perform on the array.
     */
    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int l = nums.Length - 1;
        int s = 0;
        int counter = 0;
        while (s < l)
        {
            if (nums[s] + nums[l] == k)
            {
                counter++;
                s++;
                l--;
            }else if (nums[s] + nums[l] > k)
            {
                l--;
            }
            else
                s++;
        }
        return counter;
    }
}