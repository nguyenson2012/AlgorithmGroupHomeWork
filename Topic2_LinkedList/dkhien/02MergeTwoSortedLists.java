// Time Complexity: O(n)
// Space Complexity: O(1)

class Solution {
    public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
        ListNode result = new ListNode();
        ListNode current = result;

        while (list1 != null && list2 != null) {
            // Choose the smaller value to add to the result list
            if (list1.val <= list2.val) {
                current.next = list1;
                list1 = list1.next;
            } else {
                current.next = list2;
                list2 = list2.next;
            }

            // Iterate
            current = current.next;
        }

        // Add the remaining nodes to the result list
        if (list1 != null) {
            current.next = list1;
        } else if (list2 != null) {
            current.next = list2;
        }

        return result.next;

    }
}