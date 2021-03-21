// https://leetcode.com/problems/binary-search/
// 704. Binary Search

public class Solution {
    public int Search(int[] nums, int target) {
                
        int left = 0;
        int right = nums.Length;
        while(true){
            int middle = (left + right)/2;
            
            if(nums[middle] == target){
                return middle;
            }
            else if(left == middle || right == middle || left == right){
                break;
            }
            else if(nums[middle] > target){
                right = middle;
            }
            else{
                left = middle;
            }
            
        }
        return -1;        
    }
    
}