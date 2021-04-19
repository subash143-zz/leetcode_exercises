// https://leetcode.com/problems/destination-city/
// 1436. Destination City

public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        List<string> start = new List<string>();
        List<string> end = new List<string>();
        
        foreach(List<string> path in paths){
            end.Add(path.Last());
            start.Add(path.First());
        }
        
        return end.Where(x=> !start.Contains(x)).First();
    }
}