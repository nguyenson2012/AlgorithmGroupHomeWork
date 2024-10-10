/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* next;
    Node* random;
    
    Node(int _val) {
        val = _val;
        next = NULL;
        random = NULL;
    }
};
*/

// Time complexity: O(n) 
// Space complexity: O(n) - use unordered_map to store <original node, copy node> pair 
// Explanation: Traverse twice the list: 1st, create empty corresponding copied node.
//  					 2nd, assign next, random pointer to copied node.

class Solution {
public:
    Node* copyRandomList(Node* head) {
        unordered_map<Node*, Node*> map;
        Node* curr = head;
        // Store corresponding copied node to original node in hash map
        while(curr){
            map[curr] = new Node(curr->val);
            curr = curr->next;
        }

        curr = head;
        // Mapping the next, random pointer of original node to correspoding one;
        while(curr){
            map[curr]->next = map[curr->next];
            map[curr]->random = map[curr->random];

            curr = curr->next;
        }

        return map[head];
    }
};