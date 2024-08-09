//https://leetcode.com/problems/merge-intervals/

/*
+ To sort 2d array based on idx 0
+ We will create 2 variables: "start", and "end" to compare
+ For every single element, I will compare "start" and "end" value at idx i to "start" and "end" of temp variables
    + if there is overlapping => update  "start" and "end" of temp variables
    + if there is no-overlapping => add to list, and update "start" and "end" of temp variables to "start" and "end" of current idx
Space complexity: O(1)
Time complexity: O(nlogn)
*/

namespace Day2307
{
    public class Exercise2
    {
        public int[][] Merge(int[][] intervals)
        {
            List<int[]> listAns = new();

            if (intervals.Length == 1)
                return intervals;

            //Sort based on value of start idx
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

            int startValue = intervals[0][0];
            int endValue = intervals[0][1];

            for (int i = 1; i < intervals.Length; ++i)
            {
                //overlapping
                if (startValue <= intervals[i][0] && intervals[i][0] <= endValue)
                {
                    startValue = Math.Min(startValue, intervals[i][0]);
                    endValue = Math.Max(endValue, intervals[i][1]);
                }
                //non-overlapping
                else
                {
                    listAns.Add([startValue, endValue]);
                    startValue = intervals[i][0];
                    endValue = intervals[i][1];
                }
            }

            listAns.Add([startValue, endValue]);

            return listAns.ToArray();
        }
    }
}