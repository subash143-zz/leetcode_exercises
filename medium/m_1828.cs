// https://leetcode.com/problems/queries-on-number-of-points-inside-a-circle/
// 1828. Queries on Number of Points Inside a Circle

public class Solution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        
        var retVal = new int[queries.Length];
        int i = 0;
        foreach(var circle in queries){
            int x = circle[0];
            int y = circle[1];
            int r = circle[2];
            
            foreach(var point in points){
                int x1 = point[0];
                int y1 = point[1];
                
                if((x1-x)*(x1-x) + (y1-y)*(y1-y) <= r*r){
                    retVal[i]++;
                }
            }
            
            i++;
        }
        
        return retVal;
    }
}