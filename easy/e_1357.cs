// https://leetcode.com/problems/sort-integers-by-the-number-of-1-bits/
// 1356. Sort Integers by The Number of 1 Bits

public class Solution {
    public int[] SortByBits(int[] arr) {
        
        for(int i = 0; i < arr.Length; i++){
            for(int j = i+1; j < arr.Length; j++){
                int jCount = Convert.ToString(arr[j], 2).Count(x=>x == '1');
                int iCount = Convert.ToString(arr[i], 2).Count(x=>x == '1');
                if(jCount < iCount || (jCount == iCount && arr[j] < arr[i])){
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        return arr;
    }
}