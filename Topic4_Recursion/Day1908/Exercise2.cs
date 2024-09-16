//https://leetcode.com/problems/pascals-triangle

/*
+ To have base array which only has one element
+ To build next 1d array based on temp array

Space complexity: O(n^2)
Time complexity: O(n^2)
*/

namespace Day1908
{
    public class Exercise2
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = [];
            List<int> temp = new() { 1 };

            result.Add(temp);

            for (int i = 2; i <= numRows; ++i)
            {
                List<int> array = _buildArray(temp, i);

                result.Add(array);

                temp = array;

            }


            return result;
        }

        private List<int> _buildArray(List<int> arr, int n)
        {
            List<int> result = new(new int[n]);

            for (int i = 0; i < n; ++i)
            {
                if (i == 0)
                    result[i] = arr[i];
                else if (i == n - 1)
                    result[i] = arr[i - 1];
                else
                    result[i] = arr[i - 1] + arr[i];

            }
            return result;
        }
    }
}