namespace LeetCode.Tasks.LeetCode_75;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height) {
        int l=0;
        int r=height.Length-1;
        int max=0;
        while(l<r)
        {
            var currentMax=(r-l)*Math.Min(height[l],height[r]); 
            if(currentMax>max) 
                max= currentMax;
            if(height[l]<=height[r])
                l++;
            else
                r--;
        }
        
        return max;
    }
}