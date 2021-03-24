// https://leetcode.com/problems/cells-with-odd-values-in-a-matrix/
// 1252. Cells with Odd Values in a Matrix

public class Solution {
    public int OddCells(int m, int n, int[][] indices) {
     
        bool[] rows = new bool[m];
        bool[] cols = new bool[n];
        
        foreach(int[] index in indices){
            rows[ index[0]] = !rows[ index[0]];
            cols[ index[1]] = !cols[ index[1]];
        }
        
        int retVal = 0;
        foreach(bool row in rows){
            foreach(bool column in cols){
                if(row != column){
                    retVal ++;
                }
            }
        }
        
        return retVal;
        
    }
}