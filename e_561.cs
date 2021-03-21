// https://leetcode.com/problems/array-partition-i/
// 561. Array Partition I

public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        
        int retVal = 0;
        for(int i = 0; i< nums.Length; i+=2){
            retVal += nums[i];
        }
        
        return retVal;
    }
}
