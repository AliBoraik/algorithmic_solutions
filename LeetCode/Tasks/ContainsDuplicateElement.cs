namespace LeetCode.Tasks;

public class ContainsDuplicateElement
{
    /*
     Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
     */
    public bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!set.Add(num))
            {
                return true;
            }
        }
        return false;
    }
}