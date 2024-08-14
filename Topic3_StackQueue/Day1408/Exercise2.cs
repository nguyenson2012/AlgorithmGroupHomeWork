//https://leetcode.com/problems/evaluate-reverse-polish-notation/


/*
+ Using stack
    + If element is number => push to stack
    + If not
        + Get 2 elements from the top => count result => add result into stack for the next calculation

Space complexity: O(n)
Time complexity: O(n)
*/
namespace Day1408
{
    public class Exercise2
    {
        public int EvalRPN(string[] tokens)
        {
            if (tokens.Length == 1) return int.Parse(tokens[0]);

            int result = 0;
            Stack<int> stack = new();

            foreach (string token in tokens)
            {
                if (int.TryParse(token, out int number))
                {
                    stack.Push(number);
                }
                else
                {
                    int number2 = stack.Pop();
                    int number1 = stack.Pop();

                    if (token == "+")
                        result = number1 + number2;
                    else if (token == "-")
                        result = number1 - number2;
                    else if (token == "*")
                        result = number1 * number2;
                    else
                        result = number1 / number2;

                    stack.Push(result);

                }
            }


            return result;
        }
    }
}