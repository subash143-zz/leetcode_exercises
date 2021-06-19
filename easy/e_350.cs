// https://leetcode.com/problems/intersection-of-two-arrays-ii/
// 350. Intersection of Two Arrays II

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        if(nums1.Length == 0 || nums2.Length == 0) 
            return new int[0];
        var dict1 = new Dictionary<int, int>();
        foreach(int num in nums1){
            if(!dict1.ContainsKey(num)){
                dict1[num] = 0;
            }
            dict1[num]++;
        }
        
        var dict2 = new Dictionary<int, int>();
        foreach(int num in nums2){
            if(!dict2.ContainsKey(num)){
                dict2[num] = 0;
            }
            dict2[num]++;
        }
        
        var intersection = new List<int>();
        
        foreach(var group in dict1){
            if(dict2.ContainsKey(group.Key)){
                int count = Math.Min(dict2[group.Key], dict1[group.Key]);
                for(int i = 0; i < count; i++){
                    intersection.Add(group.Key);
                }
            }
        }
        
        return intersection.ToArray();
    }
}