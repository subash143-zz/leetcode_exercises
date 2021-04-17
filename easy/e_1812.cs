// https://leetcode.com/problems/determine-color-of-a-chessboard-square/
// 1812. Determine Color of a Chessboard Square

public class Solution {
    public bool SquareIsWhite(string coordinates) {
        return ((int)coordinates[0] - 96) % 2 == 0 ^ int.Parse(coordinates[1].ToString()) %2 == 0;
    }
}