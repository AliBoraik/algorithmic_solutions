// See https://aka.ms/new-console-template for more information

using LeetCode.Models;
using LeetCode.Tasks;
using LeetCode.Tasks.LeetCode_75;

var r = new DeleteMiddleNodeLinkedList();

var head = new ListNode
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
                val = 4,
                next = new ListNode
                {
                    val = 5,
                }
            }
        }
    }
};

var result = r.DeleteMiddle(head);
while (result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}
