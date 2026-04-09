public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if(nums.Length == 0)
        {
            return 0;
        }
        Array.Sort(nums);
        int res = 0, streak = 0;
        int curr = nums[0];
        int i =0;
        while(i<nums.Length)
        {
            if(curr != nums[i])
            {
                curr = nums[i];
                streak = 0;  
            }
            while(i<nums.Length && curr == nums[i])
            {
                i++;
            }
            streak++;
            curr++;
            res = Math.Max(res, streak);
        }
        return res;
    }
}
