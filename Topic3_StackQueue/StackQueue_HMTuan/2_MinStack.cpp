// Time complexity: O(1) for each operation (push, pop, getMin)
// Space complexity: O(n) - using Stack to store <val, currMin> pairs
// Explanation: The code explains itself =))

class MinStack {
public:
    stack<pair<int, int>> st;
    MinStack() {
    }
    
    void push(int val) {
        int currMin;
        if(st.empty()){
            currMin = val;
        }else{
	    // if stack not empty: Compare current min(st.top().second) & pushing value to update
            currMin = min(st.top().second, val);  
        }
        st.push({val, currMin});
    }
    
    void pop() { 
        if(!st.empty()){
            st.pop();
        } 
    }
    
    int top() {
        if(!st.empty())
            return st.top().first;
        else
            return -1;
    }
    
    int getMin() {
        if(!st.empty())
            return st.top().second;
        else
            return -1;
    }
};

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack* obj = new MinStack();
 * obj->push(val);
 * obj->pop();
 * int param_3 = obj->top();
 * int param_4 = obj->getMin();
 */