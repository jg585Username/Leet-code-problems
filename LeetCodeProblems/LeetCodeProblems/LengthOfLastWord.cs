namespace LeetCodeProblems;

public class LengthOfLastWord
{
    public int LenOfLastWord(string s) {
        int count = 0;
        int i = s.Length - 1;

        while (i >= 0 && s[i] == ' ') {
            i--;
        }

        while (i >= 0 && s[i] != ' ') {
            count++;
            i--;
        }

        return count;
    }
}