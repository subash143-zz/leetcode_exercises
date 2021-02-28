// https://leetcode.com/problems/count-items-matching-a-rule/
// 1773. Count Items Matching a Rule

public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int index = (ruleKey == "type") ? 0 : (ruleKey == "color") ? 1: 2;
        int retVal = 0;
        foreach(List<string> list in items){
            if (list[index] == ruleValue){
                retVal ++;
            }
        }
        return retVal;
    }
}