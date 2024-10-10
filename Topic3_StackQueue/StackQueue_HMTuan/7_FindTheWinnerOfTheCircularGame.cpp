// Time complexity: O(n*k) - multiple k because we have to push k element after pop of each iterate
// Space complexity: O(n) - Using deque
// Explanation: Everything is relative.  
//	Instead of the arrow moves clockwise, the circle is the one that actually move 	
// 	Ex: n = 5, k = 2 
//	Step 0:	1 2 3 4 5 
//	Step 1: 2 3 4 5 1 (i = 1, pop the front and push it in the back of queue)
// 	Step 2: 3 4 5 1	  (pop the front)
// 	Step 3: 4 5 1 3   (i = 1, pop the front and push it in the back of queue)
//	Step 4: 5 1 3     (pop the front)
//	Step 5: 1 3 5 
// 	Step 6: 3 5 
//	.....

class Solution {
public:
    int findTheWinner(int n, int k) {
        deque<int> dq;
        for(int i = 1; i <= n; i++){
            dq.push_back(i);
        }
        while(dq.size() > 1){
            for(int i = 1; i < k; i++){
                int front = dq.front();
                dq.pop_front();
                dq.push_back(front);
            }
            dq.pop_front();
        }
        return dq.front();
    }
};