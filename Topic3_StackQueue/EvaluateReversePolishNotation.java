import java.util.Stack;

public class EvaluateRPN {
    // Method to evaluate Reverse Polish Notation
    // Time Complexity: O(N), where N is the number of tokens in the input array.
    // Space Complexity: O(N),In the worst case, the stack may hold all the operands before applying any operators.
    public int evalRPN(String[] tokens) {
        Stack<Integer> stack = new Stack<>(); // Initialize a stack to hold operands

        // Loop through each token in the input array
        for (String token : tokens) {
            switch (token) {
                // If the token is '+', pop the top two elements, add them, and push the result
                case "+":
                    stack.push(stack.pop() + stack.pop());
                    break;

                // If the token is '-', pop the top two elements, subtract the second from the first, and push the result
                case "-":
                    int b = stack.pop();
                    int a = stack.pop();
                    stack.push(a - b);
                    break;

                // If the token is '*', pop the top two elements, multiply them, and push the result
                case "*":
                    stack.push(stack.pop() * stack.pop());
                    break;

                // If the token is '/', pop the top two elements, divide the first by the second, and push the result
                case "/":
                    b = stack.pop();
                    a = stack.pop();
                    stack.push(a / b);
                    break;

                // If the token is a number, parse it and push it onto the stack
                default:
                    stack.push(Integer.parseInt(token));
            }
        }

        // The result of the RPN expression is the last remaining element in the stack
        return stack.pop();
    }

    public static void main(String[] args) {
        EvaluateRPN evaluator = new EvaluateRPN();
        String[] tokens = {"2", "1", "+", "3", "*"};
        System.out.println(evaluator.evalRPN(tokens));
    }
}