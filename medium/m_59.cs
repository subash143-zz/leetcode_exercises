// https://leetcode.com/problems/spiral-matrix-ii/
// 59. Spiral Matrix II

public class Solution {
    public int[][] GenerateMatrix(int n) {
        
        var retVal = new int[n][];
        for(int i = 0; i< n; i++){
            retVal[i] = new int[n];
        }
        
        int rowStart = 0;
        int rowEnd = n - 1;
        int colStart = 0;
        int colEnd = n - 1;
        
        int num = 1;
        while(num <= n*n){
            for(int col = colStart; col<=colEnd ; col++){
                retVal[rowStart][col] = num;
                num++;
            }
            rowStart++;
            
            for(int row = rowStart; row <= rowEnd; row++){
                retVal[row][colEnd] = num;
                num++;
            }
            colEnd--;
            
            for(int col = colEnd; col >= colStart; col--){
                retVal[rowEnd][col] = num;
                num++;
            }
            rowEnd--;
            
            for(int row = rowEnd; row >= rowStart; row--){
                retVal[row][colStart] = num;
                num++;
            }
            colStart++;
            
            
        }
        
        return retVal;
        
    }
}