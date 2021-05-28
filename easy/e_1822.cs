// https://leetcode.com/problems/sign-of-the-product-of-an-array/
// 1822. Sign of the Product of an Array

public class Solution {
    public int ArraySign(int[] nums) {
        int retVal = 1;
        
        foreach(int num in nums)
        {
            if(num < 0) retVal *= (-1);
            else if(num == 0) return 0;
        }
        
        return retVal;
    }
}
