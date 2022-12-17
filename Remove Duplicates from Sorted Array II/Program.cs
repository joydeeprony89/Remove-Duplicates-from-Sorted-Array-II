// See https://aka.ms/new-console-template for more information
Solution s = new Solution();
var nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
var answer = s.RemoveDuplicates(nums);
Console.WriteLine(answer);  

public class Solution
{
  public int RemoveDuplicates(int[] nums)
  {
    int i = 0;
    foreach (int n in nums)
    {
      if (i < 2 || n > nums[i - 2])
        nums[i++] = n;
    }
    return i;
  }
}