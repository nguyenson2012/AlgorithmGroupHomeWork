// Use DFS to count the number of islands
// Time complexity : O(n^2)
// Space complexity : O(n) (The number of recusive function calls in the call stack)
class Solution {
public:
    int dx[4] = {-1, 0, 0, 1};
    int dy[4] = {0, -1, 1, 0};
    void loang(int i, int j, vector<vector<char>>& grid) {
        grid[i][j] = '0';
        for (int k = 0; k < 4; k++) {
            int i1 = i + dx[k], j1 = j + dy[k];
            if (i1 >= 0 && i1 < grid.size() && j1 >= 0 && j1 < grid[i].size() &&
                grid[i1][j1] == '1') {
                loang(i1, j1, grid);
            }
        }
    }
    int numIslands(vector<vector<char>>& grid) {
        int res = 0;
        for (int i = 0; i < grid.size(); i++) {
            for (int j = 0; j < grid[i].size(); j++) {
                if (grid[i][j] == '1') {
                    loang(i, j, grid);
                    res++;
                }
            }
        }
        return res;
    }
};