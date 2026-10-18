public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // we create a dictionary to keep track of anagrams 
        var result = new Dictionary<string, List<string>>();
       // ofc we loop in each string
        foreach (string str in strs) {
            // converting to array so we can sort 
            char[] s = str.ToCharArray();
            // sorting 
            Array.Sort(s);
            // getting it back to string 
            string sortedString = new string(s);
            // both possbility 
            if (result.ContainsKey(sortedString)) {
                result[sortedString].Add(str);  
            } else {
                result[sortedString] = new List<string> { str };  
            }
        }
        // returning the values as list 
        return result.Values.ToList();
    }
}
