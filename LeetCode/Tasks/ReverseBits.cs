namespace LeetCode.Tasks;

public class ReverseBits
{
    /*
     * Reverse bits of a given 32 bits unsigned integer.
     */
    public uint reverseBits(uint n) {
        uint res=0;
        for(int i=0;i<32;i++)
        {
            uint lsb=n & 1;
            uint lsbReverse=lsb<<(31-i);
            res |= lsbReverse;
            n >>= 1;
        }
        return res;
    }
}