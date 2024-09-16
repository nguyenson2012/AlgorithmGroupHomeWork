// Time complexity: O(n)
// Space complexity: O(n)

class Solution {
    public int evalRPN(String[] tokens) {
        Stack<Integer> stack = new Stack<>();
        
        for (String token : tokens) {
            // If token is an operator, pop 2 operands from the stack and perform the operation
            if (token.equals("+") || token.equals("-") || token.equals("*") || token.equals("/")) {
                Integer op2 = stack.pop();
                Integer op1 = stack.pop();
                switch (token) {
                    case "+": 
                        stack.push(op1 + op2);
                        break;
                    case "-":
                        stack.push(op1 - op2);
                        break;
                    case "*":
                        stack.push(op1 * op2);
                        break;
                    case "/":
                        stack.push(op1 / op2);
                        break;
                }
            } else {
                // If token is an operand, push it to the stack
                stack.push(Integer.parseInt(token));
            }
        }
        
        // The result is the only element left in the stack
        return stack.pop();
    }
}