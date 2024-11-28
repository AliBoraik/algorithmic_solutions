// See https://aka.ms/new-console-template for more information

using LeetCode.Models;
using LeetCode.Tasks;
using LeetCode.Tasks.LeetCode_75;

var r = new RemoveLinkedListElements();

ListNode head = new ListNode()
{
    val = 1,
    next = new ListNode
    {
        val = 2,
        next = new ListNode
        {
            val = 3,
            next = new ListNode
            {
                val = 4
            }
        }
    }
};

var rr = r.RemoveElements(head , 2);

while (rr != null)
{
    Console.WriteLine(rr.val);
    rr = rr.next;
}

