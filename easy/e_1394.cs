// https://leetcode.com/problems/find-lucky-integer-in-an-array/
// 1394. Find Lucky Integer in an Array

public class Solution {
    public int FindLucky(int[] arr) {
        var dict = new Dictionary<int, int>();
        
        foreach(int num in arr){
            if(!dict.ContainsKey(num)){
                dict[num] = 1;
            }else{
                dict[num]++;
            }
        }
        
        int retVal = -1;
        
        foreach(int key in dict.Keys){
            if(dict[key] == key && retVal < key) retVal = key;
        }
        
        return retVal;
    }
}