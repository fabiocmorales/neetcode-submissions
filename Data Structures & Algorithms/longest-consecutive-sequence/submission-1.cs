public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        Array.Sort(nums);
        nums = nums.Distinct().ToArray();

        if (nums.Length == 0) return 0;

        var longestStreak = 1;
        var currentStreak = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1] + 1)
            {
                currentStreak++;
            }
            else
            {
                currentStreak = 1;
            }

            longestStreak = Math.Max(longestStreak, currentStreak);
        }

        return longestStreak;
    }
}