using System.ComponentModel;

namespace LeetCode.Tasks;

public class FindMajorityElement
{
    /*
     * Given an array nums of size n, return the majority element.
       
       The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
     */
    public int MajorityElement(int[] nums) {
        int count = 0;
        int element = 0;

        foreach (int num in nums) {
            if (count == 0) {
                element = num;
            }
            if (element == num) {
                count++;
            } else {
                count--;
            }
        }

        return element;
    }
}