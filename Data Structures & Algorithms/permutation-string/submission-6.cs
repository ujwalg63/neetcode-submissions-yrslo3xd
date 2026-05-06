public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length)
        {
            return false;
        }
        Dictionary<char, int> input = new Dictionary<char, int>();
        foreach(char i in s1)
        {
            if(!input.ContainsKey(i))
            {
                input[i] = 0;
            }
            input[i]++;
            
        }
        Dictionary<char, int> window = new Dictionary<char, int>();
        int left = 0;
        for(int r=0; r<s2.Length; r++)
        {
            if(!window.ContainsKey(s2[r]))
            {
                window[s2[r]] = 0;
            }
            window[s2[r]]++;

            if((r-left+1) == s1.Length)
            {
                if(window.Count == input.Count && 
                window.All(kvp => input.ContainsKey(kvp.Key) && input[kvp.Key] == kvp.Value))
                {
                    return true;
                }

                window[s2[left]]--;
                if(window[s2[left]] == 0)
                {
                    window.Remove(s2[left]);
                }
                left++;
            }
           
        }
        return false;
    }
}
