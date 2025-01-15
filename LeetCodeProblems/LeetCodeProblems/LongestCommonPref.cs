namespace LeetCodeProblems;

public class LongestCommonPref
{
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) {
            return "";
        }

        string result = strs[0];
        
        for (int i = 1; i < strs.Length; i++) {
            char[] compare = result.ToCharArray();
            char[] str = strs[i].ToCharArray();
            int track = 0; 
            
            // If the current string is shorter or equal in length to the current prefix.
            if (strs[i].Length <= result.Length) {
                for (int k = 0; k < strs[i].Length; k++) {
                    if (compare[k] != str[k]) {
                        track = k;
                        break;
                    }
                    // If we reach the last character and there's no mismatch,
                    // set track to the full length of the current string.
                    track = k + 1;
                }
            }
            // If the current string is longer than the current prefix.
            else {
                for (int k = 0; k < result.Length; k++) {
                    if (compare[k] != str[k]) {
                        track = k;
                        break;
                    }
                    // set track to the full length of result.
                    track = k + 1;
                }
            }
            
            // Update the common prefix.
            result = result.Substring(0, track);
            
            // If at any point there is no common prefix, return early.
            if (result == "") {
                return "";
            }
        }
        return result;
    }
}