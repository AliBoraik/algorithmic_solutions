namespace LeetCode.Tasks.LeetCode_75;

public class ContainerWithMostWater
{
    /*
     * You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
       
       Find two lines that together with the x-axis form a container, such that the container contains the most water.
       
       Return the maximum amount of water a container can store.
       
       Notice that you may not slant the container.
     */
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