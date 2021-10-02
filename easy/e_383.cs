// https://leetcode.com/problems/ransom-note/
// 383. Ransom Note


public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var ransomDict = new Dictionary<char, int>();
        foreach(char c in ransomNote){
            if(!ransomDict.ContainsKey(c)){
                ransomDict[c] = 0;
            }
            ransomDict[c]++;
        }
        
        var magazineDict = new Dictionary<char, int>();
        foreach(char c in magazine){
            if(!magazineDict.ContainsKey(c)){
                magazineDict[c] = 0;
            }
            magazineDict[c]++;
        }
        
        foreach(var key in ransomDict.Keys){
            if(!magazineDict.ContainsKey(key) || magazineDict[key] < ransomDict[key]){
                return false;
            }
        }
        
        return true;
    }
}
