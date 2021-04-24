// https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/
// 921. Minimum Add to Make Parentheses Valid

public class Solution {
    public int MinAddToMakeValid(string S) {
        var stack = new Stack();
        
        foreach(char c in S){
            if(stack.Count != 0 && (char)stack.Peek() == '(' && c == ')'){
                stack.Pop();
            }
            else{
                stack.Push(c);
            }
        }
        
        return stack.Count;
    }
}