// https://leetcode.com/problems/first-unique-character-in-a-string/
// 387. First Unique Character in a String

public class Solution {
    public int FirstUniqChar(string s) {
        var dict = new Dictionary<int, int>();
        
        for(int idx = 0; idx < s.Length; idx++){
            if(dict.ContainsKey(s[idx])){
                dict[s[idx]] = -1;
            }else{
                dict[s[idx]] = idx;
            }
        }
        
        int retVal = Int32.MaxValue;
        foreach(var group in dict){
            if(dict[group.Key] != -1){
                if(dict[group.Key] < retVal){
                    retVal = dict[group.Key];
                }
            }
        }
        
        return retVal == Int32.MaxValue ? -1: retVal;
    }
}