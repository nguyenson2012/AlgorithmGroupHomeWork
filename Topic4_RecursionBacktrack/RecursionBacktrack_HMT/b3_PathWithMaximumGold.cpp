// Time complexity: O()
// Space complexity: O()
// Explanation: Using dfsBacktrack to traverse all appropriate cells 
//		Set grid[i][j] = 0 if it is visited. 
//		Backtrack grid[i][j] = prev (previous state before being visited)

class Solution {
public:
    int rows, cols, maxGold;
    const pair<int, int> DIRECTIONS[4] = {{0, 1}, {1, 0}, {-1, 0}, {0, -1}};

    void dfsBacktrack(vector<vector<int>> &grid, int i, int j, int currGold){
        // Base case: the cell is not appropriate or has no gold
        if(i < 0  || i >= rows || j < 0 || j >= cols || grid[i][j] == 0){
            return;
        }

        currGold += grid[i][j];
        maxGold = max(maxGold, currGold);

        // If grid[i][j] is visited, set it to 0
        int prev = grid[i][j];
        grid[i][j] = 0;

        for(auto dir : DIRECTIONS){
            dfsBacktrack(grid, i + dir.first, j + dir.second, currGold);
        }

        // Backtrack to the previous state before being visited
        grid[i][j] = prev;
    }

    int getMaximumGold(vector<vector<int>>& grid) {
        rows = grid.size();
        cols = grid[0].size();
        maxGold = 0;

        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                if(grid[i][j] != 0){
                    dfsBacktrack(grid, i, j, 0);
                }
            }
        }
        return maxGold;
    }
};