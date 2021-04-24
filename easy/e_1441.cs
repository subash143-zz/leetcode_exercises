// https://leetcode.com/problems/build-an-array-with-stack-operations/
//  1441. Build an Array With Stack Operations

public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        var retVal = new List<string>();
        
        int j = 0;
        for(int i = 0; i< n; i++){
            if(j < target.Length){
                if(i+1 != target[j]){
                    retVal.Add("Push");
                    retVal.Add("Pop");
                }else{
                    retVal.Add("Push");
                    j++;
                }
            }
        }
            
        
        return retVal;
        
    }
}