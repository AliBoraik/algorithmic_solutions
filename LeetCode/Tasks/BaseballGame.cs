namespace LeetCode.Tasks;

public class BaseballGame
{
    /*
     * You are keeping the scores for a baseball game with strange rules. At the beginning of the game, you start with an empty record.
       
       You are given a list of strings operations, where operations[i] is the ith operation you must apply to the record and is one of the following:
       
       An integer x.
       Record a new score of x.
       '+'.
       Record a new score that is the sum of the previous two scores.
       'D'.
       Record a new score that is the double of the previous score.
       'C'.
       Invalidate the previous score, removing it from the record.
       Return the sum of all the scores on the record after applying all the operations.
       
       The test cases are generated such that the answer and all intermediate calculations fit in a 32-bit integer and that all operations are valid.
     */
    public int CalPoints(string[] operations)
    {
        var stack = new Stack<int>();
        int result = 0;
        foreach (var t in operations)
        {
            switch (t)
            {
                case "D":
                {
                    stack.Push(stack.Peek() * 2);
                    result += stack.Peek() * 2;
                }
                    break;
                case "C":
                {
                    result -= stack.Pop();
                }
                    break;
                case "+":
                {
                    var prev1 = stack.Pop();
                    var prev2 = stack.Peek();
                    var newItem = prev1 + prev2;
                    stack.Push(prev1);
                    stack.Push(newItem);
                    result += newItem;
                    break;
                }
                default:
                {
                    if (int.TryParse(t, out int value))
                    {
                        stack.Push(value);
                        result += value;
                    }

                    break;
                }
            }
        }
        return result;
    }
}