namespace LeetCode.Tasks;

public class MissingNumberTask
{
    /*
        Given an array nums containing n distinct numbers in the range [0, n],
        return the only number in the range that is missing from the array.
     */
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;

        foreach (int num in nums)
        {
            actualSum += num;
        }

        return expectedSum - actualSum;
    }
}