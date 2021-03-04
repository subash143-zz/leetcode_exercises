// https://leetcode.com/problems/design-a-stack-with-increment-operation/
// 1381. Design a Stack With Increment Operation

public class CustomStack {
    List<int> Stack = new List<int>();
    int MaxSize = 0;
    
    public CustomStack(int maxSize) {
        this.MaxSize = maxSize;
    }
    
    public void Push(int x) {
        if(this.Stack.Count() == this.MaxSize){
            return;
        }
        this.Stack.Add(x);
    }
    
    public int Pop() {
        
        if(this.Stack.Count() == 0) return -1;
        int retVal = this.Stack.Last();
        this.Stack.RemoveAt(this.Stack.Count()-1);
        return retVal;
    }
    
    public void Increment(int k, int val) {
        if(k > this.Stack.Count()){
            k = this.Stack.Count();
        }
        for(int i = 0; i < k; i++){
            this.Stack[i] += val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */