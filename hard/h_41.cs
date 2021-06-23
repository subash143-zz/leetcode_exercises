// https://leetcode.com/problems/first-missing-positive/
// 41. First Missing Positive

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var dict = new HashSet<int>();
        foreach(int num in nums){
            if(!dict.Contains(num)){
                dict.Add(num);
            }
        }
        
        int minVal = 1;
        for(minVal = 1; minVal<= nums.Length; minVal++){
            if(!dict.Contains(minVal)){
                return minVal;
            }
        }
        return minVal;
    }
}