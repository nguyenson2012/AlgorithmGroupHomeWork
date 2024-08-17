// Use the two pointers technique to solve the problem
// Time complexity : O(m + n)
// Space complexity: O(m + n) (due to creating a new vector to store the output)

class Solution {
public:
    void merge(vector<int>& nums1, int m, vector<int>& nums2, int n) {
        vector<int> tmp;
        tmp = nums1;
        int pointer1 = 0, pointer2 = 0, index = 0;
        while (pointer1 < m && pointer2 < n) {
            if (tmp[pointer1] < nums2[pointer2]) {
                nums1[index] = tmp[pointer1];
                pointer1++; index++;
            } else {
                nums1[index] = nums2[pointer2];
                pointer2++; index++;
            }
        }
        while (pointer1 < m) {
            nums1[index] = tmp[pointer1];
            pointer1++;
            index++;
        }
        while (pointer2 < n) {
            nums1[index] = nums2[pointer2];
            pointer2++;
            index++;
        }
    }
};