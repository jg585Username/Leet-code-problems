namespace LeetCodeProblems;

public class ValidPalindromeII
{
    public bool ValidPalindrome(string s) {
        int front = 0;
        int back = s.Length - 1;
        int count = 0;
        
        bool IsPalindromeRange(string s, int left, int right) {
            while (left < right) {
                if (s[left] != s[right]) {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        while (front < back){
            if (s[front] != s[back]){
                return IsPalindromeRange(s, front + 1, back) || IsPalindromeRange(s, front, back - 1);
            }
            front++;
            back--;
        }
        return true;
    }
}