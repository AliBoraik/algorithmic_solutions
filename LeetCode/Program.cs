// See https://aka.ms/new-console-template for more information

using LeetCode.Tasks.LeetCode_75;

var r = new FindDifferenceTwoArrays();

var t = r.FindDifference([1,2,3,3],  [1,1,2,2]);

foreach (var intse in t)
{
    foreach (var i in intse)
    {
        Console.Write(i+", ");
    }
    Console.WriteLine();
}

