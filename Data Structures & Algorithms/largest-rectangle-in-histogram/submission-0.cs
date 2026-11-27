public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        var stack = new Stack<(int index, int height)>();
        var areaOfLargestRectangle = 0;

        heights = [.. heights, 0];

        for (var i = 0; i < heights.Length; i++)
        {
            while (stack.Count > 0 && stack.Peek().height > heights[i])
            {
                var (index, height) = stack.Pop();
                var width = i - (stack.Count == 0 ? -1 : stack.Peek().index) - 1;
                areaOfLargestRectangle = Math.Max(areaOfLargestRectangle, height * width);
            }

            stack.Push((i, heights[i]));
        }

        return areaOfLargestRectangle;
    }
}