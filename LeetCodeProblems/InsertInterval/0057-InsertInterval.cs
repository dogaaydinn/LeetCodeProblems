namespace LeetCodeProblems.InsertInterval;

public class InsertInterval
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>();
        int i = 0;
        int n = intervals.Length;
        
        while (i < n && intervals[i][1] < newInterval[0])
        {
            result.Add(intervals[i]);
            i++;
        }

        while (i < n && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        result.Add(newInterval);
        
        while (i < n)
        {
            result.Add(intervals[i]);
            i++;
        }

        return result.ToArray();
    }
}