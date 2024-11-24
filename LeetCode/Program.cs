// See https://aka.ms/new-console-template for more information

using LeetCode.Tasks;
using LeetCode.Tasks.LeetCode_75;

var r = new RecentCounter();

Console.WriteLine(r.Ping(1));
Console.WriteLine(r.Ping(100));

var rr = r.Ping(3001);

Console.WriteLine(r.Ping(3002));