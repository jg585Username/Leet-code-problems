namespace LeetCodeProblems;

public class TwoSum
{
    public int[] TwoSumSolution (int[] nums, int target) {
        int [] result = new int [2];
        for (int i = 0; i < nums.Length - 1; i++){
            for (int k = i+1; k < nums.Length; k++){
                if (nums[i] + nums[k] == target){
                    result [0] = i;
                    result [1] = k;
                }
            }
        }
        return result;
    }
}