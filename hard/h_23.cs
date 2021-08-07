// https://leetcode.com/problems/merge-k-sorted-lists/
// 23. Merge k Sorted Lists

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var newMin = GetMin(lists);
        if(newMin == -1) return null;
        
        var retVal = lists[newMin];
        var head = retVal;
        lists[newMin] = lists[newMin].next;
        
        while(true){
            newMin = GetMin(lists);
            if(newMin == -1) break;
            retVal.next = lists[newMin];
            lists[newMin] = lists[newMin].next;
            retVal = retVal.next;
        }
        
        return head;
        
    }
    
    public int GetMin(ListNode[] list){
        int minPosition = -1;
        for(int i = 0; i < list.Length; i++){
            if(minPosition == -1 && list[i] != null){
                minPosition = i;
            }else{
                if(list[i] != null && list[minPosition] != null  && list[i].val < list[minPosition].val){
                    minPosition = i;
                }
            }
        }
        return minPosition;
    }
}