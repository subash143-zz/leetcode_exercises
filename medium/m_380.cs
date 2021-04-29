// https://leetcode.com/problems/insert-delete-getrandom-o1/
// 380. Insert Delete GetRandom O(1)
public class RandomizedSet {

    List<int> DataStructure;
    Random _random = new Random();
    /** Initialize your data structure here. */
    public RandomizedSet() {
        DataStructure = new List<int>();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if(DataStructure.Contains(val)){
            return false;
        }
        DataStructure.Add(val);
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if(DataStructure.Contains(val)){
            DataStructure.Remove(val);
            return true;
        }
        return false;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        return DataStructure[_random.Next(0, DataStructure.Count())];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */