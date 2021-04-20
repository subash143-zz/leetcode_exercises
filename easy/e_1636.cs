// https://leetcode.com/problems/sort-array-by-increasing-frequency/
// 1636. Sort Array by Increasing Frequency

public class Solution {
    public int[] FrequencySort(int[] nums) {
        var dict = new Dictionary<int, int>();
        
        foreach(int num in nums){
            if(!dict.ContainsKey(num)){
                dict[num] = 0;
            }
            dict[num] ++;
        }
                
        int i = 0 ;
        foreach(int key in dict.Keys.OrderBy(x=>dict[x]).ThenByDescending(x=>x)){
            int count = dict[key];
            for(int j = 0; j < count; j++){
                nums[i] = key;
                i++;
            }
        }
        
        return nums;
        
    }
}