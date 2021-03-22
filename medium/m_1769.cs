// https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/
// 1769. Minimum Number of Operations to Move All Balls to Each Box

public class Solution {
    public int[] MinOperations(string boxes) {
        var retVal = new int[boxes.Length];
        for(int i = 0; i< boxes.Length; i++){
            int val = 0;
            for (int j = 0; j< boxes.Length; j++){
                if(boxes[j] != '0' && j != i){
                    val += Math.Abs(j - i) * int.Parse(boxes[j].ToString());
                }
            }
            retVal[i] = val;
        }
        
        return retVal;
    }
}