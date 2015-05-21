#include<iostream>
#include<algorithm>
#include<map>
#include<string>
#include<bitset>

using namespace std;


struct ListNode {
	int val;
	ListNode *next;
	ListNode(int x) : val(x), next(NULL) {}
	
};
ListNode* removeNthFromEnd(ListNode* head, int n) {
	ListNode* current = head;
	ListNode* traverser = head;

	int k = n;

	while (k != 0){
		traverser = traverser->next;
		k--;
	}

	if (traverser == NULL)
		return head->next;

	while (traverser->next != NULL){
		current = current->next;
		traverser = traverser->next;

	}
	current->next = current->next->next;
	return head;
}
int main(){}
