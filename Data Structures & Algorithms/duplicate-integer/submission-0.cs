public class Solution {
    public bool hasDuplicate(int[] nums) {  
     List<int> Tracker = new List<int>();
       for(int i = 0 ; i < nums.Length ; i ++) { 
         if(Tracker.Contains(nums[i])){
            return true ; 
         } else { 
            Tracker.Add(nums[i]);
         }
       }
       return false ;
    }
}