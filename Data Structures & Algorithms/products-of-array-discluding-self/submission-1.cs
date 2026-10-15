public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        if(nums.Count(x => x == 0) > 1)
        {
            return Enumerable.Repeat(0, nums.Length).ToArray();
        }

        var productOfAllNumbers = nums.Aggregate(1, (acc, x) => acc * x);
        var result = nums.ToArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (nums[i] != 0)
            {
                result[i] = productOfAllNumbers / nums[i];
            }
            else
            {
                result[i] = nums.Where(x => x != 0).Aggregate(1, (acc, x) => acc * x);
            }

        }

        return result;
    }
}