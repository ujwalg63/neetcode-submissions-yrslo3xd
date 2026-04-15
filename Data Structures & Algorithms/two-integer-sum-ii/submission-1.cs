public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i=0, j = numbers.Length -1;
        while(i<j)
        {
            if(numbers[i] + numbers[j] == target)
            {
                return new int[]{i+1, j+1};
            }
            if(numbers[i] + numbers[j] < target)
            {
                i++;
            }
            if(numbers[i] + numbers[j] > target)
            {
                j--;
            }
        }
        return new int[]{i+1, j+1};
    }
}
