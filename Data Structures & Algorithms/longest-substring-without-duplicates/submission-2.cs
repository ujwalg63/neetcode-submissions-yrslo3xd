public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> hashtable = new Dictionary<char,int>();
        int n = s.Length;
        int max_length = 0;
        int left = 0;
        for(int right = 0; right<n; right++)
        {
            if(hashtable.ContainsKey(s[right]) && hashtable[s[right]] >= left)
            {
                left = hashtable[s[right]] + 1;  
            }

            hashtable[s[right]] = right;

            int current_length = right - left + 1;
            max_length = Math.Max(current_length, max_length);
        }
        return max_length;
    }
}
