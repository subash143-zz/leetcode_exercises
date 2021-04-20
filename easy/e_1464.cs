// https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
// 1464. Maximum Product of Two Elements in an Array

public class Solution {
    public int MaxProduct(int[] nums) {
        int max = -1;
        int secondMax = -1;
        
        foreach(int num in nums){
            if(num > max){
                int temp = max;
                max = num;
                secondMax = temp;                
            }
            else if(num > secondMax){
                secondMax = num;
            }
        }
        
        return (max-1)*(secondMax-1);
    }
}