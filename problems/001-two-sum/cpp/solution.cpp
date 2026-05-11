#include <iostream>
#include <vector>
using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        // Wulfric: write your solution here
    }
};

int main() {
    Solution sol;

    // Example 1: expected [0, 1]
    vector<int> nums1 = {2, 7, 11, 15};
    vector<int> result1 = sol.twoSum(nums1, 9);
    cout << "Example 1: [" << result1[0] << ", " << result1[1] << "]" << endl;

    // Example 2: expected [1, 2]
    vector<int> nums2 = {3, 2, 4};
    vector<int> result2 = sol.twoSum(nums2, 6);
    cout << "Example 2: [" << result2[0] << ", " << result2[1] << "]" << endl;

    // Example 3: expected [0, 1]
    vector<int> nums3 = {3, 3};
    vector<int> result3 = sol.twoSum(nums3, 6);
    cout << "Example 3: [" << result3[0] << ", " << result3[1] << "]" << endl;

    return 0;
}
