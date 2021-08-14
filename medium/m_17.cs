// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
// 17. Letter Combinations of a Phone Number

public class Solution {
    
    Dictionary<char, char[]> dict = new Dictionary<char, char[]>(){
        {'0', new char[]{'0'}},
        {'1', new char[]{'1'}},
        {'2', new char[]{'a', 'b', 'c'}},
        {'3', new char[]{'d', 'e', 'f'}},
        {'4', new char[]{'g', 'h', 'i'}},
        {'5', new char[]{'j', 'k', 'l'}},
        {'6', new char[]{'m', 'n', 'o'}},
        {'7', new char[]{'p', 'q', 'r', 's'}},
        {'8', new char[]{'t', 'u', 'v'}},
        {'9', new char[]{'w', 'x', 'y', 'z'}}        
    };
    
    public IList<string> LetterCombinations(string digits) {
        var retVal = new List<string>();
        if(digits.Length == 0) return retVal;
        
        retVal.AddRange(dict[digits[0]].Select(x=>x.ToString()));
        
        for(int i = 1; i< digits.Length; i++){
            char c = digits[i];
            
            var newList = new List<string>();
            foreach(char alpha in dict[c]){
                 
                foreach(var item in retVal){
                    newList.Add(item + alpha);
                }
            }
            
            retVal = newList;
        }
        
        return retVal;
    }
}