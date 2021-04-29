// https://leetcode.com/problems/n-repeated-element-in-size-2n-array/
// 961. N-Repeated Element in Size 2N Array

public class Solution {
    public int RepeatedNTimes(int[] A) {
        return A.GroupBy(x=>x).Where(x=>x.Count() > 1).Select(x=>x.Key).First();
    }
}