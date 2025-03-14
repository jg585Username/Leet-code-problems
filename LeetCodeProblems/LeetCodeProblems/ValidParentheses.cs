namespace LeetCodeProblems;

public class ValidParentheses
{
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                // Push opening brackets onto the stack.
                stack.Push(c);
            } else {
                if (stack.Count == 0) return false;

                char top = stack.Pop();

                if (c == ')' && top != '(') return false;
                if (c == '}' && top != '{') return false;
                if (c == ']' && top != '[') return false;
            }
        }

        return stack.Count == 0;
    }
}