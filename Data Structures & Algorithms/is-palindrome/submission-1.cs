public class Solution {
    public bool IsPalindrome(string s) {
       StringBuilder sb = new StringBuilder(s.Length);
       foreach(char c in s)
       {
            if(char.IsLetterOrDigit(c))
            {
                sb.Append(char.ToLower(c));
            }
       }
       int i=0, j = sb.Length-1;
       while(i<j)
       {
            if(sb[i] == sb[j])
            {
                i++;
                j--;
            }
            else
            {
                return false;
            }
       }
       return true;
    }
}
