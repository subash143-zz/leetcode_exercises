// https://leetcode.com/problems/split-a-string-in-balanced-strings/
// 1221. Split a String in Balanced Strings

public class Solution {
    public int BalancedStringSplit(string s) {
        
        int retVal  = 0;
        int summation = 0;
        foreach(char c in s){
            if(c == 'L'){
                summation += 1;
            }
            else{
                summation -= 1;
            }
            
            if(summation == 0){
                retVal++;
            }
        }
        return retVal;
        
    }
}