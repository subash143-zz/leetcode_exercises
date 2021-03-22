// https://leetcode.com/problems/degree-of-an-array/
// 697. Degree of an Array

public class Solution {
    public int FindShortestSubArray(int[] nums) {
        
        var dict = new Dictionary<int, List<int>>();
        for(int i = 0; i<nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict[nums[i]] = new List<int>();
            }
            dict[nums[i]].Add(i);
        }
        
        int retVal = int.MaxValue;
        int max_rep = dict.Select(x=>x.Value.Count()).Max();
        foreach(var item in dict.Where(x=>x.Value.Count() == max_rep)){
            int cur_min = item.Value.Last()-item.Value.First() + 1;
            if(cur_min < retVal){
                retVal = cur_min;
            }
        }
        return retVal;
        
    }
}