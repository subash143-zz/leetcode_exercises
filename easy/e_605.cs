// https://leetcode.com/problems/can-place-flowers/
// 605. Can Place Flowers

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int retVal = 0;
        for(int i = 0; i < flowerbed.Length; i++){
            if(flowerbed[i] == 1) continue;
            int prev = (i == 0) ? 0: flowerbed[i-1];
            int next = (i == flowerbed.Length-1) ? 0: flowerbed[i+1];
            
            if(prev == 0 && next == 0){
                retVal ++;
                flowerbed[i] = 1;
            }
            if(retVal == n) return true;
        }
        
        return retVal >= n;
    }
}