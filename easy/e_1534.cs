// https://leetcode.com/problems/count-good-triplets/
// 1534. Count Good Triplets

public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        
        int retVal = 0;
        
        for(int i = 0; i< arr.Length; i++){
            for(int j = i+1; j < arr.Length; j++){
                if(Math.Abs(arr[i] - arr[j]) <= a){
                    //Skip checking for "k" if the conditions for "i" and "j" are not satisfied : Prevents extra processing
                    for(int k = j+1; k < arr.Length; k++){
                        if(Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c){
                            retVal++;
                        }
                    }
                }
            }
        }
        
        return retVal;
    }
}