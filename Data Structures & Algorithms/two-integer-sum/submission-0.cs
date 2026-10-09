public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if(numToIndex.ContainsKey(target - num))
            {
                return new int[] { numToIndex[target - num], i };
            }
            numToIndex[num] = i;
        }
        throw new ArgumentException("No two sum solution");
    }
}