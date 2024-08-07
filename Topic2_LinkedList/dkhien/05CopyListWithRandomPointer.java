/*
// Definition for a Node.
class Node {
    int val;
    Node next;
    Node random;

    public Node(int val) {
        this.val = val;
        this.next = null;
        this.random = null;
    }
}
*/

class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) return null;

        // Map original node to its clone
        Map<Node, Node> originalToClone = new HashMap<>();
        Node res = new Node(0);
        Node dummy = res;

        // Idea: Clone the list linearly and avoid duplicate cloning by using a map
        while (head != null) {
            // Clone next node, if in map use the existing clone
            Node nextClone;
            if (originalToClone.containsKey(head)) {
                nextClone = originalToClone.get(head);
            } else {
                nextClone = new Node(head.val);
                originalToClone.put(head, nextClone);
            }

            dummy.next = nextClone;

            // Clone random node, if in map use the existing clone
            Node randomClone = null;
            if (head.random != null) {
                if (originalToClone.containsKey(head.random)) {
                    randomClone = originalToClone.get(head.random);
                } else {
                    randomClone = new Node(head.random.val);
                    originalToClone.put(head.random, randomClone);
                }
            }

            dummy.next.random = randomClone;

            // Iterate
            dummy = nextClone;
            head = head.next;
        }

        return res.next;
    }
}