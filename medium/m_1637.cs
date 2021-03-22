// https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/
// 1637. Widest Vertical Area Between Two Points Containing No Points

public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        var xs = new List<int>();
        int retVal = 0;
        foreach(var point in points){
            xs.Add(point[0]);
        }
        
        xs.Sort();
        
        for(int x=1; x < xs.Count(); x++){
            if(xs[x] - xs[x-1] > retVal){
                retVal = xs[x] - xs[x-1];
            }
        }
        return retVal;
    }
}