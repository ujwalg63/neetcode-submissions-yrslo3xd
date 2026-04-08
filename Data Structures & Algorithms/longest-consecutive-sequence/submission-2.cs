public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);   
        HashSet<int> dir = new HashSet<int>(nums);
        List<int> store = new List<int>();
        foreach(int i in dir)
        {
            int count = 1;
            int num = i;
            while(dir.Contains(num+1))
            {
                count += 1;
                num = num+1;
            } 
            store.Add(count);
        }
        if(store.Count != 0)
        {
            return store.Max();
        }
        else
        {
            return 0;
        }
    }
}
