using LeetCode.Models;

namespace LeetCode.Tasks;

public class RemoveLinkedListElements
{
    /*
     * Given the head of a linked list and an integer val,
     * remove all the nodes of the linked list that has Node.val == val, and return the new head.
     */
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode temp = new ListNode();
        ListNode curr = temp;
        temp.next = head;
        while(curr.next != null ){
            if(curr.next.val == val) curr.next = curr.next.next;
            else curr = curr.next;
        }
        return temp.next;
    }
}