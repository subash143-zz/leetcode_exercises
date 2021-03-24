// https://leetcode.com/problems/array-nesting/
// 565. Array Nesting

/*
----------APPROACH---------------
1. Loop through all the numbers
2. Set visited number = -1 for record
3. Loop untill -1 is found; count++
4. Return the greatest count
*/


public class Solution {
    public int ArrayNesting(int[] nums) {
        
        var retVal = 0;
        for(int i=0; i<nums.Length; i++){
            var index = i;
            var count = 0;
            while(nums[index] != -1){
                count++;
                var idx = index;
                index = nums[index];
                nums[idx] = -1;
            }
            retVal = retVal > count ? retVal : count;
        }
        return retVal;
        
    }
}