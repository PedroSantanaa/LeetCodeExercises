public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    Dictionary<int, int> indices = new Dictionary<int, int>();
    for (int i = 0; i < nums.Count; i++)
    {
      var diff = target - nums[i];
      if (nums.Contains(diff) && Array.IndexOf(nums, diff) != i)
      {
        return new int[] { i, Array.IndexOf(nums, diff) };
      }

    }
  }
}