// https://leetcode.com/problems/kth-largest-element-in-an-array/
// 215. Kth Largest Element in an Array

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        for(int i = 0; i <= k; i++){
            for(int j = i +1; j < nums.Length; j++){
                if(nums[i] < nums[j]){
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
            }
        }
        
        return nums[k-1];
        
    }
}