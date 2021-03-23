// https://leetcode.com/problems/rotate-array/
// 189. Rotate Array

//USING EXTRA MEMORY SPACE

public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] a = new int[nums.Length];
        
        for(int i= 0; i< nums.Length; i++){
            a[(i + k)% nums.Length] = nums[i];
        }
        
        for(int i = 0; i < a.Length; i++){
            nums[i] = a[i];
        }
        
    }
}