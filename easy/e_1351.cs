// https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/
// 1351. Count Negative Numbers in a Sorted Matrix

public class Solution {
    public int CountNegatives(int[][] grid) {
        int retVal = 0;
        
        foreach(int[] row in grid){
            for(int i = row.Length-1; i >=0 ; i--){
                if(row[i] < 0){
                    retVal++;
                }
                else{
                    break;
                }
            }
        }
        return retVal;
    }
}