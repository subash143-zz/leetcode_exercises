// https://leetcode.com/problems/cinema-seat-allocation/
// 1386. Cinema Seat Allocation

public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        int retVal = 0;
        var dict = new Dictionary<int, string>();
        
        foreach(var item in reservedSeats){
            int x = item[0];
            int y = item[1];
            if(!dict.ContainsKey(x)){
                dict[x] = "23456789";
            }
            dict[x] = dict[x].Replace(y.ToString(), "x");
        }
        
        retVal += (n - dict.Keys.Count())*2;
        
        foreach(int i in dict.Keys){
            string item = dict[i];
            if(!item.Contains("x")){
                retVal += 2;
            }
            else{
                if(item.Contains("2345")){
                    retVal++;
                }
                else if(item.Contains("4567")){
                    retVal++;
                }
                else if(item.Contains("6789")){
                    retVal++;
                }
                
            }
        }
        
        return retVal;
    }
}