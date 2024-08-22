// Time complexity: O(n*k) 
// Space complexity: O(n) 
// Explanation: Instead of moving a pointer, moving the circular by using deque
//		Pop k-1 people and push them back of deque
//		Eliminate the k th person. 

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