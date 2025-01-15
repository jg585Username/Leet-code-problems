namespace LeetCodeProblems;

public class RomanToInteger
{
    public int GetValue(char c){
        switch (c) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
    public int RomanToInt(string s) {
        int total = 0;
        char [] result = s.ToCharArray();
        for (int i = 0; i < result.Length; i++){
            int currentVal = GetValue(s[i]);
            if (i < result.Length - 1 && currentVal < GetValue(result[i + 1]))
            {
                total -= currentVal;
            }
            else
            {
                total += currentVal;
            }
        }

        return total;
 
    }
}