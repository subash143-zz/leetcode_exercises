# https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
# 1662. Check If Two String Arrays are Equivalent

class Solution(object):
    def arrayStringsAreEqual(self, word1, word2):
        """
        :type word1: List[str]
        :type word2: List[str]
        :rtype: bool
        """
        return "".join(word1) == ''.join(word2)