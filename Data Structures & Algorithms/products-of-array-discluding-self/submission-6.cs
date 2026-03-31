public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int countOfZeroes = 0;
        int prod = 1;
        for(int i = 0; i<nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                countOfZeroes++;
            }
            if(nums[i] == 0)
            {
                continue;
            }
            else
            {
                prod = prod * nums[i];
            }
        }
        if(countOfZeroes > 1)
        {
            return new int[nums.Length];
        }
        int[] resultant = new int[nums.Length];

        for(int i = 0; i<nums.Length; i++)
        {
            if(countOfZeroes == 0)
            {
                resultant[i] = (prod)/nums[i];
            }
            else
            {
                if(nums[i] != 0)
                {
                    resultant[i] = 0;
                }
                else
                {
                    resultant[i] = prod;
                }
            }
        }
        return resultant;
    }
}
