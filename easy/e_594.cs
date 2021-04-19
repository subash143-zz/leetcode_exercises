// https://leetcode.com/problems/longest-harmonious-subsequence/
// 594. Longest Harmonious Subsequence

public class Solution {
    public int FindLHS(int[] nums) {
        Array.Sort(nums);
        
        int i = 0;
        
        int retVal = 0;
        int currentMax = 0;
        
        for(int j = 0; j < nums.Length; j++){
            if(nums[j] - nums[i] == 1){
                currentMax = j - i;
            }
            else if(nums[j] - nums[i] > 1){
                while(nums[j] - nums[i] != 1 && i < j){
                    i++;
                }
                currentMax = j - i;
            }
            
            if(currentMax > retVal){
                retVal = currentMax;
            }
        }
        return retVal == 0 ? retVal : retVal + 1; //Handling edge case for empty array
    }
}
