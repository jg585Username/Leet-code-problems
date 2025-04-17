namespace LeetCodeProblems;

public class ReverseVowelsString
{
    public string ReverseVowels(string s) {
        int front = 0;
        int back = s.Length - 1;
        char[] chars = s.ToCharArray();
        bool IsVowel(char c) {
            return "aeiouAEIOU".Contains(c);
        }
        while (front < back){
            while (front < back && !IsVowel(chars[front])) front++;
            while (front < back && !IsVowel(chars[back])) back--;
            if (IsVowel(char.ToLower(s[front])) && IsVowel(char.ToLower(s[back]))){
                char temp = chars[front];
                chars[front] = chars[back];
                chars[back] = temp;
                front++;
                back--;
            }
        }
        return new string(chars);
    }
}