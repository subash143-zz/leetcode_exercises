// https://leetcode.com/problems/unique-morse-code-words/
// 804. Unique Morse Code Words

public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        var codes = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        var encoded = new List<string>();
        foreach(string word in words){
            var code  = "";
            foreach(char c in word){
                code += codes[(int)c - 97];
            }
            encoded.Add(code);
        }
        return encoded.Distinct().Count();
    }
}