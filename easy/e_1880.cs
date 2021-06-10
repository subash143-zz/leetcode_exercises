// https://leetcode.com/problems/check-if-word-equals-summation-of-two-words/
// 1880. Check if Word Equals Summation of Two Words

public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        string word1 = "";
        foreach(char c in firstWord){
            word1 += "" + (int)(c - 97) ;
        }
        
        string word2 = "";
        foreach(char c in secondWord){
            word2 += "" +  (int)(c - 97);
        }
        
        string target = "";
        foreach(char c in targetWord){
            target += "" + (int)(c - 97);
        }
        
        return int.Parse(word1) + int.Parse(word2) == int.Parse(target);
    }
}