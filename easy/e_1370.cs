// https://leetcode.com/problems/increasing-decreasing-string/
// 1370. Increasing Decreasing String

public class Solution {
    public string SortString(string s) {
        var retVal = new StringBuilder();
        var list = s.Select(x=>x).ToList();
        
        while(list.Count() > 0){
            
            //Get Ascending
            var asc = list.Distinct().OrderBy(x=>x);
            foreach(char c in asc){
                retVal.Append(c);
                list.Remove(c);
            }
            
            //GetDescending
            var dsc = list.Distinct().OrderByDescending(x=>x);
            foreach(char c in dsc){
                retVal.Append(c);
                list.Remove(c);
            }
            
        }
        
        return retVal.ToString();        
    }
    
}