namespace LeetCodeProblems;

public class UglyNumberII
{
    public int nthUglyNumber(int n) {
        // Array to store the first n ugly numbers
        int[] uglyNumbers = new int[n];
        uglyNumbers[0] = 1; // The first ugly number is 1
        
        // Pointers for multiples of 2, 3, and 5
        int i2 = 0, i3 = 0, i5 = 0;
        
        // Next multiples of 2, 3, and 5
        int nextMultipleOf2 = 2;
        int nextMultipleOf3 = 3;
        int nextMultipleOf5 = 5;
        
        // Loop to generate ugly numbers until we reach the nth one
        for (int i = 1; i < n; i++) {
            // Choose the smallest of the next multiples
            int nextUglyNumber = Math.Min(nextMultipleOf2, Math.Min(nextMultipleOf3, nextMultipleOf5));
            uglyNumbers[i] = nextUglyNumber;
            
            // Increment the pointer for which the smallest multiple was used
            if (nextUglyNumber == nextMultipleOf2) {
                i2++;
                nextMultipleOf2 = uglyNumbers[i2] * 2;
            }
            if (nextUglyNumber == nextMultipleOf3) {
                i3++;
                nextMultipleOf3 = uglyNumbers[i3] * 3;
            }
            if (nextUglyNumber == nextMultipleOf5) {
                i5++;
                nextMultipleOf5 = uglyNumbers[i5] * 5;
            }
        }
        
        // The last element in the array is the nth ugly number
        return uglyNumbers[n - 1];
    }
}