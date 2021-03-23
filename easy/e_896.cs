// https://leetcode.com/problems/monotonic-array/
// 896. Monotonic Array


public class Solution {
    public bool IsMonotonic(int[] A) {
        if(A.Length < 2){
            return true;
        }
        
        bool? isIncreasing = null;
        
        for(int i = 1; i< A.Length; i++){
            if(A[i] > A[i-1] && (isIncreasing == null  || isIncreasing.Value )){
                if(isIncreasing == null){
                    isIncreasing = true;
                }
            }
            else if(A[i] < A[i-1] && (isIncreasing == null  || !isIncreasing.Value )){
                if(isIncreasing == null){
                    isIncreasing = false;
                }
            }
            else if(A[i] == A[i-1]){}
            else {
                return false;
            }
        }
        return true;
    }
}