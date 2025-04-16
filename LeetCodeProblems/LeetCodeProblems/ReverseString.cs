namespace LeetCodeProblems;

public class ReverseString
{
    public void Solution(char[] s) {
        int front = 0;
        int back = s.Length - 1;
        while (front < back){
            char temp  = s[front];
            s[front] = s[back];
            s[back] = temp;
            front++;
            back--;
        }
    }
}