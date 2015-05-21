#include<iostream>
#include<vector>
#include<algorithm>
#include<unordered_map>
using namespace std;


vector<int> twoSum(vector<int>& nums, int target) {

	vector<int> sortednums = nums;
	sort(sortednums.begin(), sortednums.end());
	for (int i = 0; i<nums.size(); i++){
		int newTarget = target - nums[i];
		bool isFound = binary_search(sortednums.begin(), sortednums.end(), newTarget);
		if (isFound)
		{
			int targIndex;
			for (int k = 0; k < nums.size(); k++)
			{
				if (nums[k] == newTarget)
				{
					targIndex = k;
					break;
				}
			}

			if (targIndex != i)
			{
				cout << "index1=" << i + 1 << ", index2=" << targIndex + 1;

				return{ min(i + 1, targIndex + 1), max(i + 1, targIndex + 1) };
			}
			
		}
	}
}

vector<int> twoSumUsingMap(vector<int> & nums, int target){

	unordered_map<int, int> numMap;
	for (int i = 0; i < nums.size(); i++)
		numMap.insert(make_pair(nums[i], i));

	for (int i = 0; i<nums.size(); i++){
		int newTarget = target - nums[i];
		int targIndex;
		if (numMap.find(newTarget) != numMap.end())
		{
			targIndex = numMap.at(newTarget);
			if (targIndex != i)
			{
				cout << "index1=" << i + 1 << ", index2=" << targIndex + 1;
				return{ min(i + 1, targIndex + 1), max(i + 1, targIndex + 1) };
			}
		}
	}
}

int main(){

	vector<int> nums = { 0 , 4 , 3, 0 };
	int x;
	twoSumUsingMap(nums, 0);
	cin >> x;
}

