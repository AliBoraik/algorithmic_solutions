namespace LeetCode.Tasks.LeetCode_75;

public class GreatestCommonDivisorStrings
{
    /*
        For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).
       
       Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
     */
    private int Gcd(int n1,int n2)
    {
        if (n2 == 0) {
            return n1;
        }
        return Gcd(n2, n1 % n2);
    }
    public string GcdOfStrings(string str1, string str2) {
        int len1=str1.Length;
        int len2=str2.Length;
        if((str1+str2).Equals(str2+str1)){
            int index=Gcd(len1,len2);
            return str1.Substring(0,index);
        }
        return "";
    }
}