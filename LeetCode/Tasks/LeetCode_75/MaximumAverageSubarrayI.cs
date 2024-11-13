namespace LeetCode.Tasks.LeetCode_75;

public class MaximumAverageSubarrayI
{
    /*
     You are given an integer array nums consisting of n elements, and an integer k.
       
       Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. 
       Any answer with a calculation error less than 10-5 will be accepted.
     */
    public double FindMaxAverage(int[] nums, int k) {
        int tempsum =0;
        int maxSum =0;
        for(int i =0; i<k; i++)
        {
            tempsum+=nums[i];
            maxSum =tempsum;
        }
        for( int i = 1; i< nums.Length-k+1; i++)
        {
            tempsum -= nums[i-1];
            tempsum += nums[i+k-1];
            
            if(tempsum > maxSum)
            {
                maxSum = tempsum;
            }
        }
        double maxAverage = maxSum/(double)k;
        return maxAverage;
    }
}