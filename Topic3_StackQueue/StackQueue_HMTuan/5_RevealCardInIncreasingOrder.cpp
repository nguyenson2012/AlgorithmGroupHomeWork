// Time complexity: O(n) 
// Space complexity: O(n) - Using deque, vector 
// Explanation: Sort first to get the wanted result.
//		Then, do all steps backwardly

class Solution {
public:
    vector<int> deckRevealedIncreasing(vector<int>& deck) {
        sort(deck.begin(), deck.end());

        int len = deck.size();
        deque<int> dq;
        for(int i = len-1; i >= 0; i--){
            if(!dq.empty()){
                int back = dq.back();
                dq.pop_back();
                dq.push_front(back);
            }
            dq.push_front(i);
        }

        vector<int> ans;
        while(!dq.empty()){
            ans.push_back(deck[dq.front()]);
            dq.pop_front();
        }
        return ans;
    }
};