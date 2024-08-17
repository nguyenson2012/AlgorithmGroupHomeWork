//https://leetcode.com/problems/design-circular-queue/

/*
+ Using linked list technique
 + I will have 2 pointers at the beginning and at the end
 + With enqueue => add at the end
 + With dequeue => remove at the beginning

Space complexity: O(k)
Time complexity: O(n)
*/

namespace Day1708
{
    public class Exercise1
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public class MyCircularQueue
        {
            private int _total = 0;
            private ListNode _frontPointer;
            private ListNode _rearPointer;

            public MyCircularQueue(int k)
            {
                _total = k;
                _frontPointer = null;
                _rearPointer = null;
            }

            public bool EnQueue(int value)
            {
                if (IsFull() == true) return false;

                ListNode node = new(value);

                //the first added element
                if (_frontPointer == null && _rearPointer == null)
                {
                    _frontPointer = node;
                    _rearPointer = node;
                }
                else
                {
                    _rearPointer.next = node;
                    _rearPointer = node;
                }

                --_total;
                return true;

            }

            public bool DeQueue()
            {
                if (IsEmpty() == true) return false;

                _frontPointer = _frontPointer.next;

                //if only element in linked list is deleted => assign null to _front and _rear pointer
                if (_frontPointer == null)
                    _rearPointer = null;

                ++_total;
                return true;

            }

            public int Front()
            {
                if (IsEmpty()) return -1;

                return _frontPointer.val;
            }

            public int Rear()
            {
                if (IsEmpty()) return -1;

                return _rearPointer.val;
            }

            public bool IsEmpty()
            {
                return _frontPointer == null && _rearPointer == null;
            }

            public bool IsFull()
            {
                return _total == 0;
            }
        }
    }
}