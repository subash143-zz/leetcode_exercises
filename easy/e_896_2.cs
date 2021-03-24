// https://leetcode.com/problems/monotonic-array/
// 896. Monotonic Array


public class Solution {
    public bool IsMonotonic(int[] A) {
        
        bool increasing = true;
        bool decreasing = true;
        for(int i = 0; i< A.Length-1; i++){
            if(A[i] > A[i+1]){
                increasing = false;
            }
            else if(A[i] < A[i+1]){
                decreasing = false;
            }
        }
        
        return increasing || decreasing;
        
    }
}