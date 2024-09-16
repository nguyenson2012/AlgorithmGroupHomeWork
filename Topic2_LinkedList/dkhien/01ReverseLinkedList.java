// Time Complexity: O(n)
// Space Complexity: O(1)

class Solution {
    public ListNode reverseList(ListNode head) {
        if (head == null) return null;
        if (head.next == null) return head;
        
        ListNode newHead = new ListNode();
        newHead.next = null;
        
        while (head.next != null) {
            // Copy value to current node of the new list
            newHead.val = head.val;

            // Create the next node
            ListNode next = new ListNode();
            next.val = head.next.val;
            
            // Connect next node to current node (next -> current) to reverse
            next.next = newHead;
            
            // Iterate
            newHead = next;
            head = head.next;
        }

        return newHead;
    }
}