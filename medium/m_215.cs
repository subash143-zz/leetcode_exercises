// https://leetcode.com/problems/kth-largest-element-in-an-array/
// 215. Kth Largest Element in an Array

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        Array.Sort(nums);
        return(nums.Length - k);
    }
}