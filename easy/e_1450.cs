// https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time/
// 1450. Number of Students Doing Homework at a Given Time

public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        int retVal = 0;
        
        for(int i = 0; i< startTime.Length; i++){
            if(startTime[i] <= queryTime && queryTime <= endTime[i]){
                retVal++;
            }
        }
        
        return retVal;
    }
}

