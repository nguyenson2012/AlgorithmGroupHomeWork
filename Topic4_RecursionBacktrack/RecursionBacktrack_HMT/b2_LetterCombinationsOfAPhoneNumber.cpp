// Time complexity: O(n^len) n-number of digits per letters(3), len-length of string digits 
// Space complexity: O(len * n^len) - recursion stack
// Explanation: Recursion call until the end of string digits
//		Each recursion add 1 of the corresponding letter

class Solution {
public:
    int len;
    vector<string> ans;
    string mapping[10] = {"",    "",    "abc",  "def", "ghi",
            "jkl", "mno", "pqrs", "tuv", "wxyz"};

    void Try(int i, string digits, string combination){
        if(i == len){
            ans.push_back(combination);
            return;
        } 
        int key = digits[i] - '0';
        string value = mapping[key];
        for(char c : value){
            Try(i + 1, digits, combination + c);
        }
    }
    
    vector<string> letterCombinations(string digits) {
        len = digits.size();
        if(len == 0)
            return ans;

        Try(0, digits, "");
        return ans;
    }
};