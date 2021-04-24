// https://leetcode.com/problems/self-dividing-numbers/
// 728. Self Dividing Numbers

public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        var retVal = new List<int>();
        
        for(int i = left; i <= right ; i++){
            if(IsSelfDividing(i)){
                retVal.Add(i);
            }
        }
        return retVal;
        
    }
    
    
    public static bool IsSelfDividing(int n){
        foreach(char c in n.ToString()){
            if(int.Parse(c.ToString()) == 0 || n % int.Parse(c.ToString()) != 0){
                return false;
            }
        }
        return true;
        
    }
}