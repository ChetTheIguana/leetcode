#include <iostream>
#include <vector>
using namespace std;

struct ListNode {
    int val;
    ListNode* next;
    ListNode(int x) : val(x), next(nullptr) {}
};

class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        // Wulfric: write your solution here
        return nullptr;
    }
};

// Helper: build linked list from vector
ListNode* buildList(vector<int> vals) {
    ListNode dummy(0);
    ListNode* curr = &dummy;
    for (int v : vals) {
        curr->next = new ListNode(v);
        curr = curr->next;
    }
    return dummy.next;
}

// Helper: print linked list
void printList(ListNode* head) {
    cout << "[";
    while (head) {
        cout << head->val;
        if (head->next) cout << ",";
        head = head->next;
    }
    cout << "]" << endl;
}

int main() {
    Solution sol;

    // Example 1: expected [7,0,8]
    ListNode* l1 = buildList({2, 4, 3});
    ListNode* l2 = buildList({5, 6, 4});
    cout << "Example 1: ";
    printList(sol.addTwoNumbers(l1, l2));

    // Example 2: expected [0]
    l1 = buildList({0});
    l2 = buildList({0});
    cout << "Example 2: ";
    printList(sol.addTwoNumbers(l1, l2));

    // Example 3: expected [8,9,9,9,0,0,0,1]
    l1 = buildList({9, 9, 9, 9, 9, 9, 9});
    l2 = buildList({9, 9, 9, 9});
    cout << "Example 3: ";
    printList(sol.addTwoNumbers(l1, l2));

    return 0;
}
