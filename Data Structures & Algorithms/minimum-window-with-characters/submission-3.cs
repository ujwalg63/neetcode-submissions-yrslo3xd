public class Solution {
    //Most Optimal solution
    public string MinWindow(string s, string t) {
        if(t == "")
        {
            return "";
        }
        Dictionary<char, int> need = new Dictionary<char, int>();
        foreach(char i in t)
        {
            if(!need.ContainsKey(i))
            {
                need[i] = 0;
            }
            need[i]++;
        }
        Dictionary<char, int> window = new Dictionary<char, int>();
        int haveCount = 0, needCount = need.Count;
        int[] res = {-1,-1};
        int resLen = int.MaxValue;
        int left = 0;
        for(int right = 0; right<s.Length; right++)
        {
            char c = s[right];
            if(!window.ContainsKey(c))
            {
                window[c] = 0;
            }
            window[c]++;
            if(need.ContainsKey(c) && window[c] == need[c])
            {
                haveCount +=1;
            }
            while(haveCount == needCount)
            {
                if((right-left+1) < resLen)
                {
                    resLen = right-left+1;
                    res[0] = left;
                    res[1] = right;
                }
                char leftchar = s[left];
                window[leftchar]--;
                if(need.ContainsKey(leftchar) && window[leftchar] < need[leftchar])
                {
                    haveCount -= 1;
                }
                left++;
            }
        }
        return resLen == int.MaxValue? "" : s.Substring(res[0], resLen);
    }
}
