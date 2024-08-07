/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public void reorderList(ListNode head) {
        List<ListNode> nodeList = new ArrayList<>();
        ListNode temp = head;

        while (temp != null) {
            nodeList.add(temp);
            temp = temp.next;
        }

        // Traverse half of the list
        for (int i = 0; i < nodeList.size() / 2; i++) {
            ListNode node = nodeList.get(i);

            // The next node to link to should have index size - 1 - i
            ListNode nextNode = nodeList.get(nodeList.size() - 1 - i);
            
            if (i == nodeList.size() / 2 - 1 && nodeList.size() % 2 == 0) {
                // If the list has even number of nodes, the next node of the middle node should be null
                nextNode.next = null;
            } else if (i == nodeList.size() / 2 - 1 && nodeList.size() % 2 != 0) {
                // If the list has odd number of nodes, the next node of the middle node should be the last node
                nextNode.next = node.next;
                nextNode.next.next = null;
            } else {
                // Normal case
                nextNode.next = node.next;
            }

            // Link the current node to the next node
            node.next = nextNode;
        }
    }
}