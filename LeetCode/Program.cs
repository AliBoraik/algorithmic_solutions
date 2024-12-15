// See https://aka.ms/new-console-template for more information

using LeetCode.Models;
using LeetCode.Tasks;
using LeetCode.Tasks.LeetCode_75;

var r = new AddTwoListNumbers();

var l1 = new ListNode
{
    val = 2,
    next = new ListNode
    {
        val = 4,
        next = new ListNode
        {
            val = 3
        }
    }
};

var l2 = new ListNode
{
    val = 5,
    next = new ListNode
    {
        val = 6,
        next = new ListNode
        {
            val = 4,
        }
    }
};

var result = r.AddTwoNumbers(l1, l2);
while (result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}
