# https://leetcode.com/problems/pascals-triangle/
# 118. Pascal's Triangle

class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        if numRows == 0:
            return []
        elif numRows == 1:
            return [[1]]
        retVal = [[1],[1,1]]
        for i in range(2, numRows):
            row = [1]
            for j in range(1, i):
                row.append(retVal[i-1][j-1] + retVal[i-1][j])
            row.append(1)
            retVal.append(row)
        return retVal
        
        