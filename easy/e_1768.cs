// https://leetcode.com/problems/merge-strings-alternately/
// 1768. Merge Strings Alternately

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var retVal = "";
        
        int i = 0;
        int j = 0;
        bool first = true;
        while(i < word1.Length && j < word2.Length){
            retVal += word1[i];
            retVal += word2[j];
            i++;
            j++;
        }
        
        if(i < word1.Length){
            while(i < word1.Length){
                retVal += word1[i];
                i++; 
            }
        }
        else if(j < word2.Length){
            while(j < word2.Length){
                retVal += word2[j];
                j++;
            }
        }
        
        return retVal;
        
    }
}