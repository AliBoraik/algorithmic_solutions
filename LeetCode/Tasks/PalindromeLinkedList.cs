using LeetCode.Models;

namespace LeetCode.Tasks;

public class PalindromeLinkedList
{
    /*
     * Given the head of a singly linked list, return true if it is a
       palindrome
        or false otherwise.
     */
    public bool IsPalindrome(ListNode head)
    {
        var slow = head;
        var fast = head;
        ListNode prev = null;

        //reverse first half of the list
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            ListNode next = slow.next;
            slow.next = prev;
            prev = slow;
            slow = next;
        }

        //if list has odd number of elements skip middle element
        if (fast != null)
            slow = slow.next;

        //compare first and second half of the list
        while (slow != null)
        {
            if (slow.val != prev.val)
                return false;

            slow = slow.next;
            prev = prev.next;
        }

        return true;
    }
}