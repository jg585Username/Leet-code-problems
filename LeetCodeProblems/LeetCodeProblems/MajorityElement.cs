namespace LeetCodeProblems;

public class MajorityElement
{
    public int Solution(int[] nums) {
        Array.Sort(nums);
        return nums[(nums.Length -1)/2];
    }
}