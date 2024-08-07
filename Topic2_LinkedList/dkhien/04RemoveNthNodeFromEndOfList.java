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
    public ListNode removeNthFromEnd(ListNode head, int n) {
        if (head == null || head.next == null) return null;
        ListNode ptr1 = head;
        ListNode ptr2 = head;

        // ptr2 starts first, n steps ahead of ptr1
        for (int i = 0; i < n; i++) {
            if (ptr2.next == null) {
                return head.next;
            }
            ptr2 = ptr2.next;
        }

        // Move ptr1 and ptr2 until ptr2 reaches the end
        while (ptr2.next != null) {
            ptr1 = ptr1.next;
            ptr2 = ptr2.next;
        }

        // ptr1 should now be at the (n-1)th node from the end -> remove the next node
        ptr1.next = ptr1.next.next;

        return head;
    }
}