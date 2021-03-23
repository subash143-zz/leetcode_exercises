// https://leetcode.com/explore/interview/card/top-interview-questions-hard/116/array-and-strings/827/
// Product of Array Except Self


public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prod = 1;
        int[] p = new int[nums.Length];
        for(int i = 0; i<p.Length; i++){
            p[i] = 1;
        }
        
        for(int i = 0; i< nums.Length; i++){
            p[i] = prod;
            prod *= nums[i];
        }
        
        prod = 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            p[i] *= prod;
            prod *= nums[i];
        }
        
        return p;
        
    }
        
}