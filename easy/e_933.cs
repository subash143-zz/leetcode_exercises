// https://leetcode.com/problems/number-of-recent-calls/
// 933. Number of Recent Calls


// SOLUTION 1: Using List
public class RecentCounter {

    List<int> pings;
    public RecentCounter() {
        pings = new List<int>();
    }
    
    public int Ping(int t) {
        
        pings.Add(t);
        pings = pings.Where(x=> x >= t-3000).ToList();
        return pings.Count;
        
    }
}

// SOLUTION 2: More effecient (Using Queue)
public class RecentCounter {

    Queue pings;
    public RecentCounter() {
        pings = new Queue();
    }
    
    public int Ping(int t) {
        
        pings.Enqueue(t);
        while((int)pings.Peek() < t-3000){
            pings.Dequeue();
        }
        return pings.Count;
        
    }
}