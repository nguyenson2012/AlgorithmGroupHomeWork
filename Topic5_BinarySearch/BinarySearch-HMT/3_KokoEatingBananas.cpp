// Time complexity: O(log(maxPile * lenPile)
// Space complexity: O(1)
// Explanation: minSpeed is in [1, maxPile]. Using Bi-Search to find the minimum speed.

class Solution {
public:
    int calcHour(vector<int> piles, int speed){
        int hour = 0;
        // round up to finish leftover
        for(int pile : piles){
            hour += (pile + speed - 1) / speed;
        }
        return hour;
    }
    
    int minEatingSpeed(vector<int>& piles, int h) {
        int maxPile;
        for(int pile : piles){
            maxPile = max(maxPile, pile);
        }

        int l = 1, r = maxPile, res = 0;
        while(l <= r){
            int m = l + (r - l) / 2;
            int needHour = calcHour(piles, m);
            if (needHour <= h) {
                // If the hours needed is within the limit, try to find a smaller speed
                r = m - 1;
            } else {
                // If the hours needed exceed the limit, increase the speed
                l = m + 1;
            }
        }
        return l;
    }
};