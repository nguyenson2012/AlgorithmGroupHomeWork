// Time complexity: O(log n) 
// Space complexity: O(log n) - use recursion -> maintain call stack
// Explanation: Using a divide-and-conquer approach with recursion to efficiently calculate // the power by halving the exponent at each step.

class Solution {
public:
    double calc(double x, int n){
        if(n == 0){
            return 1;
        }
        double half = calc(x, n/2);
        if(n % 2 == 0){
            return half * half;
        }else{
            return half * half * x;
        }
    }

    double myPow(double x, int n) {
        if(n == 0){
            return 1.0;
        }else if(n > 0){
            return calc(x, n);
        }else{
            return 1 / calc(x, n);
        }
    }
};