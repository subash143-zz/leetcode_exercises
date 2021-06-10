// https://leetcode.com/problems/max-increase-to-keep-city-skyline/
// 807. Max Increase to Keep City Skyline

public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        
        int retVal = 0;
        
        for(int i = 0; i< grid.Length; i++){
            int rowMax = grid[i].Max();
            for(int j = 0; j< grid[i].Length; j++){
                int current = grid[i][j];
                int columnMax = grid.Select(x=>x[j]).Max();
                retVal += (Math.Min(rowMax, columnMax) > current  ? Math.Min(rowMax, columnMax) - current : 0);
            }
        }
        return retVal;
    }
}