namespace LeetCode.Tasks.LeetCode_75;

public class AsteroidCollisionTask
{
    /*
      We are given an array asteroids of integers representing asteroids in a row.
       
       For each asteroid, the absolute value represents its size, and the sign represents its direction 
       (positive meaning right, negative meaning left). Each asteroid moves at the same speed.
       
       Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller 
       one will explode. If both are the same size, both will explode. Two asteroids moving in the same direction will never meet.
     */
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();
        foreach (int asteroid in asteroids) {
            if (asteroid > 0) {
                stack.Push(asteroid);
            } else {
                while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid)) {
                    stack.Pop();
                }
                
                if (stack.Count == 0 || stack.Peek() < 0) {
                    stack.Push(asteroid);
                } else if (stack.Peek() == Math.Abs(asteroid)) {
                    stack.Pop();
                }
            }
        }
        int[] result = new int[stack.Count];
        for (int i = stack.Count - 1; i >= 0; i--) {
            result[i] = stack.Pop();
        }
        
        return result;
    }
}