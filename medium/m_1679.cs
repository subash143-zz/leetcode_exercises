// https://leetcode.com/problems/max-number-of-k-sum-pairs/
// 1679. Max Number of K-Sum Pairs

public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        var count = 0;
        foreach(int num in nums){
            if(!dict.ContainsKey(num)){
                dict[num] = 0;
            }
            dict[num]++;
        }
        
        foreach(int num in nums){
            int toFind = k - num;
            if(dict.ContainsKey(num) && dict.ContainsKey(toFind)){
                if(num == toFind){
                    if(dict[num] >= 2){
                        count++;
                        dict[num]-= 2;
                        if(dict[num] == 0) dict.Remove(num);
                        
                    }
                }
                else{
                    count++;
                    dict[num]--;
                    dict[toFind]--;
                    if(dict[num] == 0) dict.Remove(num);
                    if(dict[toFind] == 0) dict.Remove(toFind);
                }
            }
        }
        return count;
    }
}