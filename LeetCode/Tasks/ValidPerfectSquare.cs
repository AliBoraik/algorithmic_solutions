namespace LeetCode.Tasks;

public class ValidPerfectSquare
{
    /*
     * Given a positive integer num, return true if num is a perfect square or false otherwise.
       
       A perfect square is an integer that is the square of an integer. In other words, it is the product of some integer with itself.
       
       You must not use any built-in library function, such as sqrt.
     */
    public bool IsPerfectSquare(int num)
    {
        long i = 0;
        for (; i * i < num; i++);
        return num == i * i;
    }
}