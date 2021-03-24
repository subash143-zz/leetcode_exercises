// https://leetcode.com/problems/spiral-matrix/
// 54. Spiral Matrix


/*
////////----APPROACH TAKEN----////////
1. Define the borders top, left, bottom and right
2. Iterate top left -> top right -> bottom right -> bottom left -> top left
3. Conditions : Size of matrix != size of array we are creating to return
4. Update top, left, right, bottom boundary values after moving through a single row/column

*/

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        
        List<int> retVal = new List<int>();
        
        if(matrix.Length == 0 || matrix == null) return retVal ;
        
        int size = matrix.Length * matrix[0].Length;
                
        int top = 0;
        int left = 0;
        int bottom = matrix.Length - 1;
        int right = matrix[0].Length - 1;
        
        
        while(retVal.Count() < size){
            for(int i = left; i<= right && retVal.Count() < size; i++){
                retVal.Add(matrix[top][i]);
            }
            top++;
            
            for(int i = top; i<= bottom && retVal.Count() < size; i++){
                retVal.Add(matrix[i][right]);
            }
            right--;
            
            for(int i = right; i >= left && retVal.Count() < size; i--){
                retVal.Add(matrix[bottom][i]);
            }
            bottom--;
            
            for(int i = bottom; i >= top && retVal.Count() < size; i--){
                retVal.Add(matrix[i][left]);
            }
            left++;
            
        }
        return retVal;

    }
}