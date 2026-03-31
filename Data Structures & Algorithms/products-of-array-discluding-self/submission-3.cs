//Brute force solution (O(n2))
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] resultant = new int[nums.Length];
        
        for(int i=0; i<nums.Length; i++)
        {
            int prod = 1;
            for(int j=0; j<nums.Length; j++)
            {
                // if(nums[i] == nums[j])
                // {
                //     continue;
                // }
                if(i!=j)
                {
                    prod = prod * nums[j];
                }
            }
            resultant[i] = prod;
        }
        return resultant;
    }
}
