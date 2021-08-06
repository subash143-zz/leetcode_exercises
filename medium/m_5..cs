// https://leetcode.com/problems/longest-palindromic-substring/
// 5. Longest Palindromic Substring

public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length == 0)
            return string.Empty;
        
        string retVal = string.Empty;
        
        for(int i = 0; i < s.Length; i++){
           string longestOdd = CheckOddPalindrome(s, i);
           string longestEven = CheckEvenPalindrome(s, i);
           if(longestOdd.Length > retVal.Length)
               retVal = longestOdd;
           if(longestEven.Length > retVal.Length)
               retVal = longestEven;
        }
        return retVal;
        
    }
    
    public string CheckOddPalindrome(string s, int i){
        int left = i;
        int right = i;
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            left--;
            right++;
        }
        return s.Substring(left + 1, right - left - 1);
    }
    
    public string CheckEvenPalindrome(string s, int i){
        int left = i;
        int right = i + 1;
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            left --;
            right++;
        }
        return s.Substring(left + 1, right - left - 1);
    }
    
}