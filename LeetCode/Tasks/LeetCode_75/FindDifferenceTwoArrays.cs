namespace LeetCode.Tasks.LeetCode_75;

public class FindDifferenceTwoArrays
{
    /*
     Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:
       
       answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
       answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
       Note that the integers in the lists may be returned in any order.
     */
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> set1 = [..nums1];
        HashSet<int> set2 = [..nums2];
        set1.ExceptWith(nums2);
        set2.ExceptWith(nums1);
        return new List<IList<int>> { set1.ToList(), set2.ToList() };
    }
}