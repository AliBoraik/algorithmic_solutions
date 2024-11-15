namespace LeetCode.Tasks;

public class FindCanSorted
{
    /*
     You are given a 0-indexed array of positive integers nums.
       
       In one operation, you can swap any two adjacent elements if they have the same number of 
       set bits
       . You are allowed to do this operation any number of times (including zero).
       
       Return true if you can sort the array in ascending order, else return false.
     */
    private int Count(int n) {
        int b = 0;
        while (n != 0) {
            n = n & (n - 1);
            b++;
        }
        return b;
    }
    public bool CanSortArray(int[] nums) {
        var l = 0;
        var h = nums[0];
        for (var i = 1; i < nums.Length; ++i) {
            var bit = Count(h) != Count(nums[i]);
            if (bit) 
                l = h;
            if (nums[i] > h)
                h = nums[i];
            if (nums[i] < l)
                return false;
        }
        return true;
    }
}