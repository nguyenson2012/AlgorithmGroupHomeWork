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
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        int carry = 0;

        // Idea: Add each digit like in elementary school
        while (true) {

            // Calculate the sum of the current digits
            // If one of the lists is null, the value of that list is 0
            int sum;
            if (l1 == null && l2 != null) {
                sum = l2.val + carry;
                l2 = l2.next;
            } else if (l1 != null && l2 == null) {
                sum = l1.val + carry;
                l1 = l1.next;
            } else if (l1 != null && l2 != null) {
                sum = l1.val + l2.val + carry;
                l1 = l1.next;
                l2 = l2.next;
            } else {
                break;
            }

            // Calculate the carry and the value of the current digit
            carry = sum / 10;
            sum %= 10;

            // Create a new node and link it to the result list
            ListNode res = new ListNode(sum);
            current.next = res;
            current = res;
        }

        // Add the last carry if any
        if (carry > 0) {
            ListNode carryNode = new ListNode(carry);
            current.next = carryNode;
        }

        return dummy.next;
    }
}