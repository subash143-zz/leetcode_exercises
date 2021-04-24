// https://leetcode.com/problems/merge-strings-alternately/
// 1768. Merge Strings Alternately

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var retVal = new StringBuilder();
        
        int i = 0;
        int j = 0;
        while(i < word1.Length && j < word2.Length){
            retVal.Append(word1[i]);
            retVal.Append(word2[j]);
            i++;
            j++;
        }
        
        if(i < word1.Length){
            while(i < word1.Length){
                retVal.Append(word1[i]);
                i++; 
            }
        }
        else if(j < word2.Length){
            while(j < word2.Length){
                retVal.Append(word2[j]);
                j++;
            }
        }
        
        return retVal.ToString();
        
    }
}