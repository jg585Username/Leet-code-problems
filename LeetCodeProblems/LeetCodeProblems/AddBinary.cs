using System.Text;

namespace LeetCodeProblems;

public class AddBinary
{
    public string Solution(string a, string b) {
        StringBuilder result = new StringBuilder();
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry == 1) {
            int sum = carry;

            if (i >= 0) sum += a[i--] - '0';
            if (j >= 0) sum += b[j--] - '0';

            result.Insert(0, (sum % 2));  
            carry = sum / 2;              
        }

        return result.ToString();
    }
}