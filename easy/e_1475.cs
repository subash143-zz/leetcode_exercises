// https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop/
// 1475. Final Prices With a Special Discount in a Shop

public class Solution {
    public int[] FinalPrices(int[] prices) {
        for(int i = 0; i < prices.Length; i++){
            int discount = getDiscountedPrice(prices, i);
            prices[i] = prices[i] - discount;
        }
        return prices;
    }
    
    public int getDiscountedPrice(int[] prices, int startIndex){
        int retVal = 0;
        for(int i = startIndex + 1; i< prices.Length; i++){
            if(prices[i] <= prices[startIndex]){
                retVal = prices[i];
                break;
            }
        }   
        return retVal;
    }
}