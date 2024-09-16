//https://leetcode.com/problems/decode-string/

namespace Day2108
{
    public class Exercise1
    {

        //Recursion

        /*
        + To loop until find any digit => start of suitable string
            + Step 1: To ignore '['
            + Step 2: To build string
            + Step 3: To ignore ']'
            + Step 4: To loop number times to build string based on step 2
        + Otherwise
            + add to current string

        Space complexity: O(maxK * n) => maxK is the maximum repeat
        Time complexity: O(maxK * n) => maxK is the maximum repeat
        */
        public class Solution1
        {
            public string DecodeString(string str)
            {
                int index = 0;
                return _backTracking(str, ref index);
            }

            private string _backTracking(string str, ref int index)
            {
                string result = "";

                while (index < str.Length && str[index] != ']')
                {
                    if (char.IsDigit(str[index]))
                    {
                        // Xử lý số để tìm ra số lần lặp
                        int number = 0;
                        while (index < str.Length && char.IsDigit(str[index]))
                        {
                            number = number * 10 + (str[index] - '0');
                            index++;
                        }

                        // To ignore '['
                        index++;

                        // Start recursion
                        string decodedString = _backTracking(str, ref index);

                        // To ignore ']'
                        index++;

                        // to build string based on number
                        for (int i = 0; i < number; i++)
                            result += decodedString;
                    }
                    else
                    {
                        // if it's type char => add to result
                        result += str[index];
                        index++;
                    }
                }

                return result;
            }
        }

        //Stack
        public class Solution2
        {
            public string DecodeString(string str)
            {
                Stack<string> stack = new();
                foreach (char s in str)
                {
                    if (s != ']')
                        stack.Push(s.ToString());
                    else
                    {
                        string tempString = "";
                        //pop until find suitable string
                        while (stack.Count != 0 && stack.Peek().All(c => char.IsLower(c)))
                            tempString += stack.Pop();

                        tempString = new string(tempString.Reverse().ToArray());

                        //remove open square bracket
                        stack.Pop();

                        string tempNumber = "";
                        //pop until find suitable number
                        while (stack.Count != 0 && int.TryParse(stack.Peek(), out int check))
                            tempNumber += stack.Pop();

                        int number = int.Parse(tempNumber.Reverse().ToArray());

                        stack.Push(new string(_buildReverseString(tempString, number)));

                    }
                }

                string result = "";
                while (stack.Count != 0)
                    result += stack.Pop();

                return new string(result.Reverse().ToArray());
            }
            private char[] _buildReverseString(string s, int number)
            {
                string result = "";

                for (int i = 1; i <= number; ++i)
                    result += s;
                return result.Reverse().ToArray();
            }
        }
    }
}