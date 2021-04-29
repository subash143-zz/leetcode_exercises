// https://leetcode.com/problems/largest-number-at-least-twice-of-others/
// 747. Largest Number At Least Twice of Others

public class Solution {
    public int DominantIndex(int[] nums) {
        int largest = nums[0];
        int largeIndex = 0;
        
        for(int i =0; i<nums.Length; i++){
            if(nums[i] > largest){
                largest = nums[i];
                largeIndex = i;
            }
        }
        
        foreach(int num in nums){
            if(num != largest){
                if(largest/2 < num){
                    return -1;
                }
            }
        }
        
        return largeIndex;
    }
}