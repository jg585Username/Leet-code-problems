namespace LeetCodeProblems;

public class RemoveDuplicates
{
    public int RemoveDup(int[] nums) { 
        //nums is in ascending order

        if (nums == null || nums.Length == 0) {
            return 0;
        }

        int k = 1;
        int [] duplicates = new int[nums.Length];
        for (int i = 1; i < nums.Length; i++){
            if (nums [i] != nums [i - 1]){
                nums[k] = nums[i];
                k++;
            }
        }
        
        return k;
    }
}