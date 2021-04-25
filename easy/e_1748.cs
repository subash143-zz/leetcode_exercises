// https://leetcode.com/problems/sum-of-unique-elements/
// 1748. Sum of Unique Elements

public class Solution {
    public int SumOfUnique(int[] nums) {
        Dictionary<int, int> dict = nums.GroupBy(x=>x).ToDictionary(y=>y.Key, y=>y.Count());
        return nums.GroupBy(x=>x).ToDictionary(y=>y.Key, y=>y.Count()).Where(x=>x.Value == 1).Select(x=>x.Key).Sum();
    }
}