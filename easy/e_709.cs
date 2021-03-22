// https://leetcode.com/problems/to-lower-case/
// 709. To Lower Case

public class Solution {
    public string ToLowerCase(string str) {
        string retVal = "";
        foreach(char c in str){
            if(c < 90 && c > 64){
                retVal += (char)(c + 32);
            }
            else{
                retVal += c;
            }
        }
        return retVal;
    }
}