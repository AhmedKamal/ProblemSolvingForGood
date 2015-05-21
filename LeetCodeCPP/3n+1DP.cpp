#include<stdio.h>
#include<stdlib.h>
#include<iostream>
#include<algorithm>
#include<vector>
using namespace std;

short cycleLen(int n , short* cycles){
	if (n == 1)
	{
		return 1;
	}
	if (cycles[n] != 0)
	{
		return cycles[n];
	}

	if (n % 2 == 0)
	{
		return 1+ cycleLen(n/2 , cycles);
	}
	else
	{
		return 1+ cycleLen(3 *n + 1 , cycles);
	}
}


int main(){

	short cycles[1000001];
	memset(cycles, 0, sizeof(cycles));
	int x, y;
	while (cin >> x >> y){
		int max = 0;

		int i;

		for (i = min(x, y); i <= (int)std::max(x, y); i++)
		{
			short len = cycleLen(i, cycles);
			if (cycles[i] == 0)
			{
				cycles[i] = len;
			}
			if (max < len)
			{
				max = len;
			}
			//cout << i << endl;

		}


		cout << x << " " << y << " " << max << endl;
	}
	
}