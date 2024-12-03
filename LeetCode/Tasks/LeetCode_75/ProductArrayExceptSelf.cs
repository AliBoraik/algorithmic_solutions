namespace LeetCode.Tasks.LeetCode_75;

public class ProductArrayExceptSelf
{
    /*
     * Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
       
       The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
       
       You must write an algorithm that runs in O(n) time and without using the division operation.
     */
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] output = new int[nums.Length];
        int product = 1;
        bool zeros = false;
        foreach (var t in nums)
        {
            if (t != 0 )
                product *= t;
            else
            {
                if(zeros)
                    return output;
                zeros = true;
            }
        }
        for (int i = 0; i < output.Length; i++)
        {
            if (zeros)
            {
                output[i] = nums[i] == 0 ? product : 0;
            }
            else
            {
                output[i] = product / nums[i];
            }
        }
        return output;
    }
}