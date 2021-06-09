// https://leetcode.com/problems/find-and-replace-pattern/
// 890. Find and Replace Pattern

public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        var retVal = new List<string>();
        foreach(string word in words){
            if(IsPatternMatch(pattern, word)){
                retVal.Add(word);
            }
        }
        return retVal;
    }
    
    public bool IsPatternMatch(string word1, string word2){
        if(word1.Length != word2.Length) return false;
        var dict = new Dictionary<char, char>();
        
        //Looping through a word1
        for(int i = 0; i < word1.Length; i++){
            //Check if theres a rule
            if(!dict.ContainsKey(word1[i])){
                //Check if theres a rule that maps to this value since we cannot have multiple keys map to same value
                if(dict.Values.Contains(word2[i])) return false;
                dict[word1[i]] = word2[i];
            } else{
                if(word2[i] != dict[word1[i]]) return false;
            }
        }
        return true;
    }
}
