// Time complexity: O(n)
// Space complexity: O(n)

import java.util.Stack;

class Solution {
    public boolean isValid(String s) {
        Stack<Character> stack = new Stack<>();

        for (char c : s.toCharArray()) {
            // If c is an opening bracket, push it to the stack
            if (c == '(' || c == '[' || c == '{') {
                stack.push(c);
            } else {
                if (stack.isEmpty()) {
                    return false;
                }
                char top = stack.pop();

                // If c is a closing bracket, check if it matches the top of the stack
                // If not, return false (invalid)
                if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{')) {
                    return false;
                }
            }
        }

        // If the stack is empty, the string is valid because all brackets are matched
        return stack.isEmpty();
    }
}