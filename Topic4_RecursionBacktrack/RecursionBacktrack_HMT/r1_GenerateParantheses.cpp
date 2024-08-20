// Time complexity: O(2^2n) - There are 2n position, each position have 2 possible options '(', ')'
// Space complexity: O(n) 
// Explanation: Using a recursive DFS approach to explore all possible valid combinations of parentheses.
//              We prioritize adding an open parenthesis whenever possible.
//		And, we add a closing parenthesis only when it won't result in an invalid sequence.

class Solution {
public:
    vector<string> ans;
    int pairN;
    void dfs(int openP, int closeP, string temp){
        if(openP == pairN && closeP == pairN){
            ans.push_back(temp);
            return;
        }

        if(openP < pairN)
            dfs(openP + 1, closeP, temp + "(");

        if(openP > closeP)
            dfs(openP, closeP + 1, temp + ")");
    }

    vector<string> generateParenthesis(int n) {
        pairN = n;
        dfs(0, 0, "");
        return ans;
    }
};