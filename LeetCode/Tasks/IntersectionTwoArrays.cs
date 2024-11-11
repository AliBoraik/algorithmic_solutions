namespace LeetCode.Tasks;

public class IntersectionTwoArrays
{
    /*
     * Given two integer arrays nums1 and nums2, return an array of their 
       intersection
       . Each element in the result must be unique and you may return the result in any order.
     */
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var result = new List<int>();
        var hash = new HashSet<int>();
        foreach (var t in nums1)
        {
            hash.Add(t);
        }
        foreach (var t in nums2)
        {
            if (hash.Contains(t))
            {
                result.Add(t);
                hash.Remove(t);
            }
        }
        return result.ToArray();
    }
}