// https://leetcode.com/problems/number-of-islands/
// 200. Number of Islands

public class Solution {
    public int NumIslands(char[][] grid) {
        
        int retVal = 0;
        
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[i].Length; j++){
                if(grid[i][j] == '1'){
                    retVal++;
                    Traverse(grid, i, j, grid.Length, grid[i].Length);    
                }
            }
        }
        return retVal;
    }
    
    public void Traverse(char[][] grid, int i, int j, int i_max, int j_max){
        if(i < 0 || j < 0 || i >= i_max || j >= j_max || grid[i][j] == '0'){
            return;
        }
        grid[i][j] = '0';
        
        Traverse(grid, i+1, j, i_max, j_max);
        Traverse(grid, i-1, j, i_max, j_max);
        Traverse(grid, i, j+1, i_max, j_max);
        Traverse(grid, i, j-1, i_max, j_max);
    }
}