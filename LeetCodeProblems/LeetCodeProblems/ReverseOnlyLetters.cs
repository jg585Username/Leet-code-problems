namespace LeetCodeProblems;

public class ReverseOnlyLetters
{
    public string Solution (string s) {
        int front = 0;
        int back = s.Length - 1;
        char[] chars = s.ToCharArray();
        while (front < back){
            if (!char.IsLetter(chars[front])){
                front++;
                continue;
            }
            if (!char.IsLetter(chars[back])){
                back--;
                continue;
            }
            char temp = chars[front];
            chars[front] = chars[back];
            chars[back]= temp;

            front++;
            back--;
        }
        string result = new string(chars);
        return result;
    }
}