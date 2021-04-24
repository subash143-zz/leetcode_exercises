// https://leetcode.com/problems/merge-in-between-linked-lists/
// 1669. Merge In Between Linked Lists

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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        var retVal = list1;
        
        //Go untill the ath element of the first list
        int i = 0;
        while(i+1 != a){
            list1 = list1.next;
            i++;
        }
        
        //Assign new variable for tracking and move it till be for later addition
        var tail = list1;
        while(i != b){
            tail = tail.next;
            i++;
        }
        tail = tail.next;
        
        //Attach next node at ath position of first node
        list1.next = list2;
        
        //Move till the end
        while(list1.next != null){
            list1 = list1.next;
        }
        
        //Attach previously added tail
        list1.next = tail;
        
        //Return the head
        return retVal;
    }
}