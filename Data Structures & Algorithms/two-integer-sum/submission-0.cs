public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      Dictionary <int , int > counts = new Dictionary < int , int > ();
     for(int i = 0 ; i < nums.Length ; i ++ ) { 
      int complent = target - nums[i];
       if(counts.ContainsKey(complent)) { 
        return new int[] {counts[complent], i};
       }
       counts[nums[i]] = i ;
    
    }
    return null ;
}
}