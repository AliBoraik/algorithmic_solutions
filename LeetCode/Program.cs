// See https://aka.ms/new-console-template for more information

using LeetCode.Models;
using LeetCode.Tasks;
using LeetCode.Tasks.LeetCode_75;

var r = new NTreePreorderTraversal();

var root = new Node
{
    val = 1,
    children = new List<Node>
    {
        new Node
        {
            val = 3,
            children = new List<Node>()
            {
                new Node()
                {
                    val = 5
                },
                new Node
                {
                    val = 6
                }
            }
        },
        new Node()
        {
            val = 2
        }
    }
};

var rr = r.Preorder(root);

foreach (var VARIABLE in rr)
{
    Console.WriteLine(VARIABLE + "- ");
}

