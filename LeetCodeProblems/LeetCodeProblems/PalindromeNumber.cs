namespace LeetCodeProblems;

public class PalindromeNumber
{
    public bool IsPalindrome(int x) {
        string result = Convert.ToString(x);
        char[] charArray = result.ToCharArray();
        char [] compare = new char [charArray.Length];
        int k =0;
        for (int i = charArray.Length - 1; i >= 0; i--){
            compare [i] = charArray [k];
            k++;
        }
 
        for (int y = 0; y < charArray.Length; y++){
            if (compare [y] != charArray [y]){
                return false;
            }
        }


        return true;
    
    }
}