namespace LeetCodeProblems;

public class PlusOne
{
    public int[] Solution(int[] digits) {
        if ( digits[digits.Length - 1] == 9){
            for (int i = digits.Length - 1; i >= 0; i--) {
                if (digits[i] < 9) {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
        digits[digits.Length - 1] =  digits[digits.Length - 1] + 1;
        return digits;
    }
}