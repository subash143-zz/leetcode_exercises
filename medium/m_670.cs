// https://leetcode.com/problems/maximum-swap/
// 670. Maximum Swap

public class Solution {
    public int MaximumSwap(int num) {
        var inputs = num.ToString().Select(x=>int.Parse(x.ToString())).ToList();
        
        var sorted = inputs.OrderByDescending(c => c).ToList();
    
        int i = 0;
        while(i < sorted.Count){
            if(inputs[i] != sorted[i]){
                int swap1 =  inputs.LastIndexOf(sorted[i]);
                
                var temp = inputs[swap1];
                inputs[swap1] = inputs[i];
                inputs[i] = temp;
                
                return int.Parse(string.Join("", inputs));
                
                
            }
            i++;
        }
        
        return int.Parse(string.Join("", inputs));
        
    }
}