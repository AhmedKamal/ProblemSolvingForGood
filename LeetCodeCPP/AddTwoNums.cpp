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
ListNode* addTwoNumbers(ListNode* l1, ListNode* l2);


int main(){
	int x;

	//cases 
	//2 4 3
	//5 6 4
	//7 0 8
	ListNode n11 = ListNode(9);
	ListNode n21 = ListNode(9);
	//ListNode n31 = ListNode(3);

	n11.next= &n21;
	//n21.next = &n31;


	ListNode n12 = ListNode(1);
	//ListNode n22 = ListNode(6);
	//ListNode n32 = ListNode(4);

	/*n12.next = &n22;
	n22.next = &n32;*/


	ListNode* res = addTwoNumbers(&n11, &n12);

	cin >> x;
}

ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {

	int carry = 0;
	int res = 0;
	ListNode* resList = NULL;
	ListNode* current = resList;
	while (l1 != NULL && l2 != NULL)
	{
		res = l1->val + l2->val;
		res += carry;
		if (res > 9)
		{
			carry = 1;
			res = res - 10;
		}
		else carry = 0;

		if (resList == NULL)
		{
			resList = new ListNode(res);
			current = resList;
		}
		else{
			current->next = new ListNode(res);
			current = current->next;
		}
		l1 = l1->next;
		l2 = l2->next;
	}
	while (l1!= NULL)
	{
		res = l1->val + carry;
		if (res > 9)
		{
			carry = 1;
			res = res - 10;
		}
		else
			carry = 0;
		current->next = new ListNode(res);
		current = current->next;
		l1 = (l1->next);
	}
	while (l2!= NULL)
 	{
		res = l2->val + carry;
		if (res > 9)
		{
			carry = 1;
			res = res - 10;
		}
		else
			carry = 0;
		current->next = new ListNode(res);
		current = current->next;
		l2 = l2->next;
	}

	if (carry != 0)
	{
		current->next = new ListNode(carry);

	}
	return resList;
}