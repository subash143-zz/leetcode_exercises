// https://leetcode.com/problems/distance-between-bus-stops/
// 1184. Distance Between Bus Stops
public class Solution {
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
        int total = 0;
        int one = 0;
        if(start > destination){
            int temp = start;
            start = destination;
            destination = temp;
        }
        
        for(int i = 0; i< distance.Length; i++){
            if(i >= start && i < destination){
                one += distance[i];
            }
            total += distance[i];
        }
        
        return total - one > one ? one : total - one;
    }
}