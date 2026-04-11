public class Solution {
    public int LongestConsecutive(int[] nums) {
        //most optimal solution
        //create set from the given nums array.
        int longestSeq = 0;
        HashSet<int> set = new HashSet<int>(nums);
        foreach(int i in set)
        {
            if(!set.Contains(i-1))
            {
                int length =1;
                while(set.Contains(i+length))
                {
                    length = length+1;
                }
                longestSeq = Math.Max(length, longestSeq);
            }
        }
        return longestSeq;
    }
}
