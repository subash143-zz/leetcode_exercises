// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
// 26. Remove Duplicates from Sorted Array

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0) return 0;
        int i = 1;
        int prev = nums[0];
        for(int j = 1; j< nums.Length; j++){
            if(nums[j] != prev){
                nums[i] = nums[j];
                prev = nums[i];
                i++;
            }
        }
        return i;
        
    }
}