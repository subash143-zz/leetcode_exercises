// https://leetcode.com/problems/truncate-sentence/
// 1816. Truncate Sentence

public class Solution {
    public string TruncateSentence(string s, int k) {
        var retVal = new StringBuilder();
        
        foreach(char c in s){
            retVal.Append(c);
            if(c == ' ') k--;
            if(k == 0) break;
        }
        
        return retVal.ToString().Trim();
    }
}
