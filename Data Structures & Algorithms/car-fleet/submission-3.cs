public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var list = position.Select((pos, i) => (pos, speed: speed[i])).OrderBy(tuple => tuple.pos).ToList();
        var output = 0;
        var minHoursToReachTarget = 0d;

        for (var i = list.Count - 1; i >= 0; i--)
        {
            var hoursToReachTarget = (double)(target - list[i].pos) / list[i].speed;

            if (hoursToReachTarget <= minHoursToReachTarget) continue;

            output++;
            minHoursToReachTarget = hoursToReachTarget;
        }
        return output;
    }
}