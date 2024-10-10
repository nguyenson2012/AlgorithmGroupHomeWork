// Time complexity: O(n)
// Space complexity: O(1) 
// Explanation: Using recursion division to break down the number into smaller parts
//		e.g: num = 1234. 
//		The code processes the thousand first, then the hundred, tens, and ones

class Solution {
public:
    vector<int> numbers = {
        1000000000, 1000000, 1000, 100, 90, 80, 70, 60, 50, 40, 30, 20,
        19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1
    };  //31 numbers

    vector<string> words = {
        "Billion", "Million", "Thousand", "Hundred", "Ninety", "Eighty",
        "Seventy", "Sixty", "Fifty", "Forty", "Thirty", "Twenty",
        "Nineteen", "Eighteen", "Seventeen", "Sixteen", "Fifteen", "Fourteen",
        "Thirteen", "Twelve", "Eleven", "Ten", "Nine", "Eight", "Seven",
        "Six", "Five", "Four", "Three", "Two", "One"
    };

    string numberToWords(int num) {
        string result;
        for(int i = 0; i < 31; i++){
            if(num >= numbers[i]){
                if(num >= 100) result += numberToWords(num / numbers[i]) + " " + words[i] + " ";
                else result += words[i] + " ";

                num %= numbers[i];

                if (num == 0) break;
            }
        }
        // result.subtr to eliminate the " " at the end of string
        return result.empty() ? "Zero" : result.substr(0, result.size() - 1);
    }
};