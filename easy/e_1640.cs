// https://leetcode.com/problems/check-array-formation-through-concatenation/
// 1640. Check Array Formation Through Concatenation

public class Solution {
    public bool CanFormArray(int[] arr, int[][] pieces) {
        string ar = string.Join("", arr);
        int count = 0;
        foreach(int[] pcs in pieces){
            string split = string.Join("", pcs);
            count += split.Length;
            if(!ar.Contains(split)){
                return false;
            }
        }
        return true && count == ar.Length;
    }
}