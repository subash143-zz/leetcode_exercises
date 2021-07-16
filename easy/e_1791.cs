// https://leetcode.com/problems/find-center-of-star-graph/
// 1791. Find Center of Star Graph


public class Solution {
    public int FindCenter(int[][] edges) {
        var dict = new Dictionary<int, int>();
        foreach(var edge in edges){
            if(!dict.ContainsKey(edge[0])){
                dict[edge[0]] = 0;
            }
            if(!dict.ContainsKey(edge[1])){
                dict[edge[1]] = 0;
            }
            dict[edge[0]]++;
            dict[edge[1]]++;
        }
        
        int retVal = edges[0][0];
        foreach(var key in dict.Keys){
            if(dict[key] > dict[retVal]){
                retVal = key;
            }
        }
        
        return retVal;
    }
}