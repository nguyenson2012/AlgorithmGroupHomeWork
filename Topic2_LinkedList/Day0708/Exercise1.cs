//https://leetcode.com/problems/copy-list-with-random-pointer/

/*
+ To use 2 loops
    + Loop 1: To build dictionary
        + Key: current Node
        + value: new Node
    + Loop 2: To build list
        + To loop defined head list and assign next and random pointer for current Node

Space complexity: O(n)
Time complexity: O(n): 
*/

namespace Day0708
{
    public class Exercise1
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;
            public Node(int val = 0, Node next = null, Node random = null)
            {
                this.val = val;
                this.next = next;
                this.random = random;
            }
        }
        public Node CopyRandomList(Node head)
        {
            Dictionary<Node, Node> myDict = new();
            Node temp = head;

            while (temp != null)
            {
                //to create a new node, instead of using current node
                myDict[temp] = new Node(temp.val);
                temp = temp.next;
            }

            Node dummyNode = new(-1);
            Node result = dummyNode;
            temp = head;

            while (temp != null)
            {
                Node copyNode = myDict[temp];
                copyNode.next = temp.next != null ? myDict[temp.next] : null;
                copyNode.random = temp.random != null ? myDict[temp.random] : null;

                dummyNode.next = copyNode;

                dummyNode = dummyNode.next;
                temp = temp.next;
            }

            return result.next;
        }
    }
}