namespace LeetCodeProblems;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length){
            return false;
        }

        int [] count = new int [26];

        foreach (char c in magazine){
            count[c - 'a']++;
        }

        foreach (char c in ransomNote){
            count[c - 'a']--;
        }

        for (int i =0; i < count.Length; i++){
            if (count[i] < 0){
                return false;
            }
        }
        return true;
    }
}