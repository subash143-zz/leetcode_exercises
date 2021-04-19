//  https://leetcode.com/problems/subdomain-visit-count/
// 811. Subdomain Visit Count

public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        var dict = new Dictionary<string, int>();
        
        IList<string> retVal = new List<string>();
        
        foreach(string s in cpdomains){
            int count = int.Parse(s.Split(' ')[0].Trim());
            string domain = s.Split(' ')[1];
            
            var domainSplits = domain.Split('.');
            for(int i = 0; i < domainSplits.Length; i++){
                var key = string.Join('.', domainSplits.Skip(i).Take(domainSplits.Length-i));
                
                if(!dict.ContainsKey(key)){
                    dict[key] = 0;
                }
                dict[key] += count;
            }
            
        }
        
        foreach(var key in dict.Keys){
            retVal.Add($"{dict[key]} {key}");
        }
        
        return retVal;
    }
}