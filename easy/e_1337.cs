// https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/
// 1337. The K Weakest Rows in a Matrix

public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        var dict = new Dictionary<int, int>();
        
        for(int i = 0; i< mat.Length; i++){
            dict[i] = mat[i].Sum();
        }
        
        
        // Use OrderBy method.
        return dict.OrderBy(i => i.Value).Take(k).Select(x => x.Key).ToArray();
    }
}