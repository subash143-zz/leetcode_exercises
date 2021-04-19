// https://leetcode.com/problems/top-k-frequent-elements/
// 347. Top K Frequent Elements

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        
        foreach(int num in nums){
            if(!dict.ContainsKey(num)){
                dict[num] = 0;
            }
            dict[num]++;
        }
        
        return dict.Keys.OrderByDescending(x=> dict[x]).Take(k).ToArray();
        
    }
}