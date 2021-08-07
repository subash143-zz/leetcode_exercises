// https://leetcode.com/problems/roman-to-integer/
// 13. Roman to Integer

public class Solution {
    public int RomanToInt(string s) {
        int retVal = 0;
        var keys = new Dictionary<char, int>(){{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};
        
        for(int i = 0; i < s.Length; i++){
            retVal += keys[s[i]];
            if(i > 0 && keys[s[i-1]] < keys[s[i]]){
                Console.WriteLine(keys[s[i - 1]]);
                retVal = retVal - 2 * keys[s[i - 1]];
            }
        }
        
        return retVal;
    }
}