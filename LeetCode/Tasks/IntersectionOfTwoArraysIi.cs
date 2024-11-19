namespace LeetCode.Tasks;

public class IntersectionOfTwoArraysIi
{
    /*
     Given two integer arrays nums1 and nums2, return an array of their intersection. 
     Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
     */
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var dic = new Dictionary<int, int>();
        foreach (var num in nums1)
        {
            if (!dic.TryAdd(num, 1))
            {
                dic[num] += 1;
            }
        }

        var result = new List<int>();
        foreach (var num in nums2)
        {
            if (dic.ContainsKey(num) && dic[num] > 0) {
                result.Add(num);
                dic[num]--;
            }
        }
        return result.ToArray();
    }
}