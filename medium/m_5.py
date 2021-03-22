# https://leetcode.com/problems/longest-palindromic-substring/
# 5. Longest Palindromic Substring

class Solution:
    def longestPalindrome(self, s: str) -> str:
        s = [c for c in s]
        retVal = [s[0]]
        stack = []
        for i in range(1, len(s)):
            
            # Checking for types aa, abba, cbba
            j = i
            stack = s[:i][:] #Converting string to list of chars
            rec = []
            while len(stack) > 0 and j < len(s) and stack.pop() == s[j]:
                rec.append(s[j])
                j = j + 1
            if len(rec) > 0:
                if len(rec[::-1]+ rec) > len(retVal):
                    retVal = rec[::-1]+ rec
                
            # Checking for types aba, ccacc
            j = i
            stack = s[:i][:]
            rec = []
            first = stack.pop()
            while len(stack) > 0 and j < len(s) and stack.pop() == s[j]:
                rec.append(s[j])
                j = j + 1
            if len(rec) > 0:
                if len(rec[::-1]+ [first] + rec) > len(retVal): 
                    retVal = rec[::-1]+ [first] + rec
                
        return "".join(retVal)
            