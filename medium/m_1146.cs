// https://leetcode.com/problems/snapshot-array/
// 1146. Snapshot Array

public class SnapshotArray {
    Dictionary<int, Dictionary<int, int>> dict = new Dictionary<int, Dictionary<int, int>>();
    int snap_id = 0;
    int[] array;

    public SnapshotArray(int length) {
        array = new int[length];
    }
    
    public void Set(int index, int val) {
        array[index] = val;
        if(!dict.ContainsKey(snap_id)){
            dict[snap_id] = new Dictionary<int, int>();
        }
        dict[snap_id][index] = val;
    }
    
    public int Snap() {
        return snap_id++;
    }
    
    public int Get(int index, int snap_id) {
        // Checking if Snap is in last added key, else go to previous one till snap_id 0
        while(snap_id >= 0){
            if(!dict.ContainsKey(snap_id) || !dict[snap_id].ContainsKey(index)){
                snap_id--;
            }
            else{
                return dict[snap_id][index];
            }
        }
        //If no changes are tracked in snap, default value will be returned
        return 0;
    }
}

/**
 * Your SnapshotArray object will be instantiated and called as such:
 * SnapshotArray obj = new SnapshotArray(length);
 * obj.Set(index,val);
 * int param_2 = obj.Snap();
 * int param_3 = obj.Get(index,snap_id);
 */