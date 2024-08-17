// Time complexity: O(1) for all operations
// Space complexity: O(n) for the stack

class MinStack {
    // Use a pair to store the value and the minimum value at that point
    Stack<Pair<Integer, Integer>> stack = new Stack<>();
    
    public void push(int val) {
        int min = val;
        if (!stack.isEmpty()) {
            // Get minimum between the current value and the minimum value of the previous element
            min = Math.min(val, stack.peek().getValue());
        }

        // Push the value and the minimum value to the stack
        stack.push(new Pair<>(val, min));
    }
    
    public void pop() {
        stack.pop();
    }
    
    public int top() {
        return stack.peek().getKey();
    }
    
    public int getMin() {
        return stack.peek().getValue();
    }
}