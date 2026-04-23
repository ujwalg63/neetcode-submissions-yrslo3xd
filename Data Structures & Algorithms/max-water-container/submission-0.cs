public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length-1;
        int maxarea = 0;
        while(left < right)
        {
            int min = Math.Min(heights[left], heights[right]);
            int area = min * (right - left);
            maxarea = Math.Max(maxarea, area);
            if(heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxarea;
    }
}
