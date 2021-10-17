// https://leetcode.com/problems/valid-sudoku/
// 36. Valid Sudoku

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var hashSet = new HashSet<char>();
        for(int i = 0; i < 9; i++){
            hashSet.Clear();
            for(int j = 0; j < 9; j++){
                if(board[i][j] != '.'){
                    if(hashSet.Contains(board[i][j])){
                        return false;
                    }
                    hashSet.Add(board[i][j]);
                }   
            }
        }
        
        for(int i = 0; i < 9; i++){
            hashSet.Clear();
            for(int j = 0; j < 9; j++){
                if(board[j][i] != '.'){
                    if(hashSet.Contains(board[j][i])){
                        return false;
                    }
                    hashSet.Add(board[j][i]);
                }
            }

        }
        
        for(int i = 0; i< 9; i= i + 3){
            for(int j = 0; j< 9; j = j + 3){
            hashSet.Clear();
                for(int k = i; k < i + 3; k++){
                    for(int l = j; l < j + 3; l++){
                        if(board[k][l] != '.'){
                            if(hashSet.Contains(board[k][l])){
                                return false;
                            }
                            hashSet.Add(board[k][l]);
                        }
                    }
                }
                
            }
        }

        return true;
        
    }
}