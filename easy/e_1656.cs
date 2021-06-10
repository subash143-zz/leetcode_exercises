// https://leetcode.com/problems/design-an-ordered-stream/
// 1656. Design an Ordered Stream

public class OrderedStream {

    string[] array;
    int pointer = 0;
    public OrderedStream(int n) {
        array = new string[n];
    }
    
    public IList<string> Insert(int idKey, string value) {
        array[idKey-1] = value;
        
        List<string> retVal= new List<string>();
        if(pointer == idKey-1){
            while(pointer < array.Length && array[pointer] != null){
                retVal.Add(array[pointer]);
                pointer++;
            }
        }
        
        return retVal;
    }
}

/**
 * Your OrderedStream object will be instantiated and called as such:
 * OrderedStream obj = new OrderedStream(n);
 * IList<string> param_1 = obj.Insert(idKey,value);
 */