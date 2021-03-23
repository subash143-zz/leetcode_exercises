// https://leetcode.com/problems/rotate-array/
// 189. Rotate Array

public class Solution {
    public void Rotate(int[] nums, int k) {
        int last = nums.Length - 1;
        
        for(int j = 0; j < k; j++){
            int temp = nums[last];
        
            int i = 0;
            while(i < last){
                nums[last-i] = nums[last-i-1];
                i++;
            }
            nums[0] = temp;
        }
        
    }
}