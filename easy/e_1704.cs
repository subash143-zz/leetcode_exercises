// https://leetcode.com/problems/determine-if-string-halves-are-alike/
// 1704. Determine if String Halves Are Alike

public class Solution {
    public bool HalvesAreAlike(string s) {
        List<char> vowels = new List<char>{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        return s.Substring(0, s.Length/2).Count(x=> vowels.Contains(x)) == s.Substring(s.Length/2).Count(x=> vowels.Contains(x));
    }
}