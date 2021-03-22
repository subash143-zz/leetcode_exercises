// https://leetcode.com/problems/remove-element/
// 27. Remove Element

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        for(int j = 0; j< nums.Count(); j++){
            if(nums[j] != val){
                nums[i] = nums[j];
                i++;
            }
        }
        return i;
    }
}