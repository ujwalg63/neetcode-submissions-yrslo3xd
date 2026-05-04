public class Solution {
    public int CharacterReplacement(string s, int k) {
        int length = 0;
        int l = 0;
        int maxFreq = 0;
        Dictionary<char, int> hashmap = new Dictionary<char, int>();
        for(int r=0; r<s.Length; r++)
        {
            if(!hashmap.ContainsKey(s[r]))
            {
                hashmap[s[r]] = 0;
            }
            hashmap[s[r]]++;
            maxFreq = Math.Max(maxFreq, hashmap[s[r]]);
            int changes = (r-l+1) - maxFreq;
            if(changes<=k)
            {
                length = Math.Max(length, r-l+1);
            }
            else
            {
                hashmap[s[l]]--;
                l++;
            }
        }
        return length;

    }
}
