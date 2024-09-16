//https://leetcode.com/problems/implement-queue-using-stacks/

/*
+ Push as usual
+ Before peeking or popping => revert stack

Space complexity: O(n)
Time complexity: O(n)
*/

namespace Day1608
{
    public class Exercise2
    {
        public class MyQueue
        {
            private Stack<int> stack;
            private Stack<int> temp;
            public MyQueue()
            {
                stack = new();
                temp = new();
            }

            public void Push(int x)
            {
                stack.Push(x);
            }

            public int Pop()
            {
                while (stack.Count > 0)
                    temp.Push(stack.Pop());

                int top = temp.Pop();

                while (temp.Count > 0)
                    stack.Push(temp.Pop());

                return top;
            }

            public int Peek()
            {
                while (stack.Count > 0)
                    temp.Push(stack.Pop());

                int peek = temp.Peek();

                while (temp.Count > 0)
                    stack.Push(temp.Pop());

                return peek;
            }

            public bool Empty()
            {
                return stack.Count == 0;
            }
        }
    }
}