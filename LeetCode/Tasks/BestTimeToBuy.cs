using System.Xml;

namespace LeetCode.Tasks;

public class BestTimeToBuy 
{
    /*
     * First, initialize two parameters – 【min– set as first element of array】 and 【max – 0】.
       
       And in the iteration, if prices[i] is less than min, we will set it as min.
       
       Else, check the diff of prices[i] and min, if the diff is greater than max, than set the diff as max.
     */
    public int MaxProfit(int[] prices)
    {
        int max = 0;
        int min = prices[0];
        
        for(int i=1;i<prices.Length;i++){
            if(prices[i] < min){
                min = prices[i];
            }else if((prices[i] - min) > max )
            {
                max = prices[i] - min;
            }
        }
        return max;
    }
}