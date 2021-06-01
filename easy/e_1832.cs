// https://leetcode.com/problems/check-if-the-sentence-is-pangram/
// 1832. Check if the Sentence Is Pangram

public class Solution {
    public bool CheckIfPangram(string sentence) {
        var hs = new HashSet<char>();
        
        foreach(char c in sentence){
            hs.Add(c);
            
            if(hs.Count() == 26) return true;
        }
        
        return false;
    }
}
