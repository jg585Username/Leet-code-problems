namespace LeetCodeProblems;

public class ValidPalindrome
{
    public bool IsPalindrome(string s) {
        int back = s.Length-1;
        int front = 0;
        while (front < back){
            while (front < back && !char.IsLetterOrDigit(s[front])) {
                front++;
            }
            while (front < back && !char.IsLetterOrDigit(s[back])) {
                back--;
            }
            if (char.ToLower(s[front]) != char.ToLower(s[back])){
                return false;
            }
            front++;
            back--;
        }
        return true;
    }
}