namespace LeetCode.Tasks;

public class ContainsDuplicateIi
{
    /*
     Given an integer array nums and an integer k, return true if there are two distinct 
     indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
     */
    public bool ContainsNearbyDuplicate(int[] nums, int k) 
    {
        HashSet<int> numIndices = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (!numIndices.Add(nums[i])) 
            {
                return true;
            }
            
            if (numIndices.Count > k) 
            {
                numIndices.Remove(nums[i - k]);
            }
        }

        return false;
    }
}