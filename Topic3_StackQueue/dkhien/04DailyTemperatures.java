// Time complexity: O(n)
// Space complexity: O(n)

class Solution {
    public int[] dailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.length];

        Stack<Integer> stack = new Stack<>();

        for (int i = 0; i < temperatures.length; i++) {
            // If the current temperature is higher than the temperature at the top of the stack, then we have found the next warmer temperature.
            while (!stack.isEmpty() && temperatures[i] > temperatures[stack.peek()]) {
                // Pop the index of the temperature that is lower than the current temperature
                int top = stack.pop();
                // Calculate the distance between the current temperature and the temperature at the top of the stack
                result[top] = i - top;
            }
            stack.push(i);
        }

        return result;

    }
}