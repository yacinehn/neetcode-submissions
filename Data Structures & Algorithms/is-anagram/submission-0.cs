public class Solution {
    public bool IsAnagram(string s, string t) {
     // not same length directly mean false    
      if(s.Length != t.Length) { 
        return false ; 
      }
      // we create dictionaries to store the order ;
      Dictionary <char , int> sCounter = new Dictionary <char , int>{};
      Dictionary <char , int> tCounter = new Dictionary <char , int>{};
      for(int i = 0 ; i < s.Length ; i ++) { 
         sCounter[s[i]] = sCounter.GetValueOrDefault(s[i], 0) + 1;
         tCounter[t[i]] = tCounter.GetValueOrDefault(t[i], 0) + 1;
      }
      return sCounter.Count == tCounter.Count && !sCounter.Except(tCounter).Any();
    }
}
