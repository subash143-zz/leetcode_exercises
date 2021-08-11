// https://leetcode.com/problems/longest-common-subsequence/    
// 1143. Longest Common Subsequence

public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        
        var matrix = new int[text1.Length + 1][];
        for(int i = 0 ; i< matrix.Length; i++){
            matrix[i] = new int[text2.Length + 1];
        }
        
        for(int i = 0; i<= text1.Length; i++){
            for(int j = 0; j <= text2.Length; j++){
                if(i == 0 || j == 0){
                    matrix[i][j] = 0;
                    continue;
                }else{
                    if(text1[i-1] == text2[j - 1]){
                        matrix[i][j] = matrix[i-1][j-1] + 1;
                    }else{
                        matrix[i][j] = Math.Max(matrix[i-1][j], matrix[i][j-1] );
                    }
                }
            }
        }
        
        // for(int i = 0; i<= text1.Length; i++){
        //     for(int j = 0; j <= text2.Length; j++){
        //         Console.Write(" " + matrix[i][j]);
        //     }
        //     Console.WriteLine("");
        // }
        
        return matrix[text1.Length][text2.Length];
        
        
    }
}