public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var frequencyMap = new Dictionary<int, int>();
        
        foreach (var num in nums)
        {
            if (!frequencyMap.ContainsKey(num))
            {
                frequencyMap[num] = 0;
            }
            frequencyMap[num]++;
        }

        var sortedKeys = frequencyMap.Keys.OrderByDescending(key => frequencyMap[key]).Take(k).ToArray();
        return sortedKeys;
    }
}