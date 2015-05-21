#include<iostream>
#include<bitset>
#include<cstdint>

using namespace std;





uint32_t flipBit(uint32_t n , int idx){
	return n ^ (1 << idx);
}

uint32_t reverseBits(uint32_t n) {
	for (int i = 0; i < 32; i++)
	{
		n = flipBit(n, i);
	}

	return n;
}


void printNumber(int n, int len)
{
	if (!len)
		return;

	printNumber(n >> 1, len - 1);	// remove last bit
	cout << (n & 1);						// print last bit
}

int countDig(int n){
	int cnt = 0;
	while (n)
	{
		cnt++;
		n = n >> 1;
	}
	return cnt;
}

int countBits(int n){
	int cnt = 0;
	while (n)
	{
		if (n & 1)
		{
			cnt++;
		}
		n = n >> 1;
	}
	return cnt;
}

int countZeros(int n){
	int cnt = 0;
	while (n)
	{
		if (!(n & 1))
		{
			cnt++;
		}
		n = n >> 1;
	}
	return cnt;
}

int printDig(int n){
	while (n){
		if (n & 1)
		{
			cout << "1";
		}
		else
			cout << "0";
		n = n >> 1;
	}
	return n;
}

int main(){
	int x;

	cout << printDig(32) << endl;
	printNumber(32, 6);
	cout << endl;;
	cout << countDig(33)<< endl;
	cout << countBits(33) << endl;
	cout << countZeros(33) << endl;
	cout << (4 >> 1) <<endl;
	cout << (1 << 3) << endl;
	cout << (3 << 5) << endl;
	printNumber((uint32_t)43261596, 32);
	cout << endl;
	cout << reverseBits((uint32_t)43261596) << endl;
	printNumber(reverseBits((uint32_t)43261596) , 32);
	cin >> x;
}

