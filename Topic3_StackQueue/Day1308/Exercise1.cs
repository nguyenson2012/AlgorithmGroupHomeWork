//https://leetcode.com/problems/valid-parentheses/

/*
+ Using stack
+ Always push open parenthesis
+ If current char is closed parenthesis => compare that to the top element in stack(open parenthesis)
    =>if it is different => false;

+ Check whether stack is empty or not

Space complexity: O(n)
Time complexity: O(n)
*/

namespace Day1308
{
    public class Exercise1
    {
        public bool IsValid(string str)
        {
            Stack<char> stack = new();

            foreach (char s in str)
            {
                if (s == '(' || s == '[' || s == '{')
                {
                    stack.Push(s);
                }
                else
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    if ((top == '(' && s != ')') ||
                       (top == '[' && s != ']') ||
                       (top == '{' && s != '}'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}