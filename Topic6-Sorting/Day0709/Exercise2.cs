//https://leetcode.com/problems/merge-intervals/description/

/*
+ To sort 2d array based on first element of array
+ To get the first array as based condition
+ To loop from the second array and compare to value of 2 elements in the first array
    + If it's overlapping => update value of the current first and second element
    + Otherwise => add current first and second element into result and update a new one

Space complexity: O(N)
Time complexity: O(NLogN)  
*/

namespace Day0709
{
    public class Exercise2
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (row1, row2) => row1[0].CompareTo(row2[0]));

            List<int[]> result = new();

            int first = intervals[0][0];
            int second = intervals[0][1];

            for (int i = 1; i < intervals.Length; ++i)
            {
                if (first <= intervals[i][0] && intervals[i][0] <= second)
                {
                    first = Math.Min(first, intervals[i][0]);
                    second = Math.Max(second, intervals[i][1]);
                }
                else
                {
                    result.Add([first, second]);

                    first = intervals[i][0];
                    second = intervals[i][1];
                }
            }

            result.Add([first, second]);

            return result.ToArray();
        }
    }
}