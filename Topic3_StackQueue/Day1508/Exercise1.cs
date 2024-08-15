//https://leetcode.com/problems/daily-temperatures/

/*
+ Using monotomic decreasing
    + to ensure that stack is monotomic decreasing => the top element is smallest and the last element is biggest
    + If not => pop until find right position for the current element

Space complexity: O(n)
Time complexity: O(n^2)
*/

namespace Day1508
{
    public class Exercise1
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int length = temperatures.Length;

            Stack<int> stack = new();

            int[] result = new int[length];

            for (int curDay = 0; curDay < length; ++curDay)
            {
                //to ensure that stack is monotomic decreasing 
                //(the top element is smallest and the last element is biggest)
                while (stack.Count != 0 && temperatures[curDay] > temperatures[stack.Peek()])
                {
                    int prevDay = stack.Pop();

                    result[prevDay] = curDay - prevDay;
                }
                stack.Push(curDay);
            }

            return result;
        }
    }
}