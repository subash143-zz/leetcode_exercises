# https://leetcode.com/problems/pascals-triangle-ii/
# 119. Pascal's Triangle II

class Solution:
    def getRow(self, rowIndex: int) -> List[int]:
        if rowIndex == 0:
            return [1]
        elif rowIndex == 1:
            return [1,1]
        store = [[1],[1,1]]
        for i in range(2, rowIndex+1):
            row = [1]
            for j in range(1, i):
                row.append(store[i-1][j-1] + store[i-1][j])
            row.append(1)
            store.append(row)
        return store[-1]
        