// Time complexity: O(log n)
// Space complexity: O(n) - 2 additional vector left, right
// Explanation: Using Merge Sort

class Solution {
public:
    void merge(vector<int> &nums, int begin, int mid, int end){
        vector<int> left(nums.begin() + begin, nums.begin() + mid + 1);
        vector<int> right(nums.begin() + mid + 1, nums.begin() + end + 1);
        int i = 0, j = 0;
        while(i < left.size() && j < right.size()){
            if(left[i] <= right[j]){
                nums[begin] = left[i];
                ++i;
            }else{
                nums[begin] = right[j];
                ++j;
            }
            ++begin;
        }
        while(i < left.size()){
            nums[begin] = left[i];
            ++i;
            ++begin;
        }
        while(j < right.size()){
            nums[begin] = right[j];
            ++j;
            ++begin;
        }
    }

    void mergeSort(vector<int> &nums, int begin, int end){
        if(begin >= end)
            return;
        int mid = (begin + end) / 2;
        mergeSort(nums, begin, mid);
        mergeSort(nums, mid+1, end);
        merge(nums, begin, mid, end);
    }

    vector<int> sortArray(vector<int>& nums) {
        mergeSort(nums, 0, nums.size() - 1);
        return nums;
    }
};