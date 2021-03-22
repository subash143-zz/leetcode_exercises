// https://leetcode.com/problems/longest-substring-without-repeating-characters/
// 3. Longest Substring Without Repeating Characters

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> records = new List<char>();
        int max = 0;
        foreach(char c in s){
            if(!records.Contains(c)){
                records.Add(c);
            }
            else{
                if(records.Count() > max){
                    max = records.Count();
                }
                var skip = records.IndexOf(c);
                records = records.Skip(skip+1).ToList();
                records.Add(c);
            }
        }
        return (max > records.Count()) ? max : records.Count();
    }
    
}