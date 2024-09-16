//https://leetcode.com/problems/min-stack/

/*
+ Using stack
+ I will have 2 stacks which have the same size
    + First: push all elements
    + Second: push minimum element at the top

Space complexity: O(n^2)
Time complexity: O(1)
*/
namespace Day1308
{
    public class Exercise2
    {
        public class MinStack
        {
            private Stack<int> stack;
            private Stack<int> minStack;
            public MinStack()
            {
                stack = new();
                minStack = new();
            }

            public void Push(int val)
            {
                stack.Push(val);
                minStack.Push(Math.Min(val, minStack.Count == 0 ? val : minStack.Peek()));
            }

            public void Pop()
            {
                stack.Pop();
                minStack.Pop();
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                return minStack.Peek();
            }
        }
    }
}