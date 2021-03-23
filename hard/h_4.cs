// https://leetcode.com/problems/median-of-two-sorted-arrays/
// 4. Median of Two Sorted Arrays

public class Solution {
    public int required_items = 0;
    public List<int> items = new List<int>();
    
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        required_items = (nums1.Length + nums2.Length)%2 == 0 ? 2 : 1;
        
        int j = 0;
        int i = 0;
        int final = 0;
        int median = (nums1.Length + nums2.Length + 1)/2 - 1;
        
        while(i < nums1.Length && j < nums2.Length && !NumbersFound()){
            if(nums1[i] < nums2[j]){
                if(final == median || final == median + 1){
                    items.Add(nums1[i]);
                }
                i++;
                final++;
            }
            else{
                if(final == median || final == median + 1){
                    items.Add(nums2[j]);
                }
                j++;
                final++;
            }
        }
        
        while(i < nums1.Length && !NumbersFound()){
            
            if(final == median || final == median + 1){
                items.Add(nums1[i]);
            }
            i++;
            final++;
            
        }
        while(j < nums2.Length && !NumbersFound()){
            
            if(final == median || final == median + 1){
                items.Add(nums2[j]);
            }
            j++;
            final++;
            
        }
        
        return (double)items.Sum()/items.Count();
        
    }
    
    public bool NumbersFound(){
        return required_items == items.Count();
    }
}