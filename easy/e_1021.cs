// https://leetcode.com/problems/remove-outermost-parentheses/
// 1021. Remove Outermost Parentheses

public class Solution {
    public string RemoveOuterParentheses(string S) {
        var retVal = new StringBuilder();
        var stack = new Stack();
        string current = "";
        
        foreach(char c in S){
            
            current += c;
            
            if(c == ')' && (char)stack.Peek() == '(' ){
                stack.Pop();
            }
            else {
                stack.Push(c);
            }
            
            if(stack.Count == 0 && current.Length >= 2){
                retVal.Append(current.Substring(1, current.Length-2));
                current = "";
            }
        }
        
        return retVal.ToString();
    }
}