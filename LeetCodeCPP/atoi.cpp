#include<iostream>
#include<algorithm>
#include<map>
#include<string>
#include<bitset>

using namespace std;

int STI(string str);

int main(){
	int x;
	//cout << STI("+-2") << endl;
	cout << STI("      -11919730356x""") << endl;
	cout << STI("+1"" - 1123u3761867")<< endl;
	cout << STI("-23.4") << endl;
	           //2147483647
	cout << STI("21474839") << endl;
	cout << STI("0") << endl;
	cout << STI("a1") << endl;
	cout << STI("123-") << endl;
	cout << STI("-++123") << endl;
	cout << STI("1") << endl;


	cin >> x;
}




int STI(string str){
	int size = str.size();
	int start = 0;
	int end = size;
	bool isneg = false;

	while (str[start] == ' ')
	{
		start++;
	}
	if (str[start] == '+' || str[start] == '-')
	{
		if (str[start] == '-')
			isneg = !isneg;

		start++;
	}
	for (int i = start; i < size; i++)
	{
		if ((int)str[i] < (int)'0' || (int)str[i] > (int)'9'){
			end = i;
			break;
		}
	}
	size = end - start;
	int res = 0;
	if (size == 0)
	{
		return 0;
	}
	else if (size > 10){
		if (isneg)
			return INT_MIN;
		
		else
			return INT_MAX;
	}
	else if (size == 1 && (str[start] == '-' || str[start] == '+')){
		return 0 ;
	}
	else {
		for (int i = start; i < end; i++)
		{
			int toAdd = (int)(str[i] - '0') * pow(10, size - (i - start) - 1);
			if (!isneg && ((long long)res + toAdd >= INT_MAX))
				return INT_MAX;

			else if (isneg && (-res - toAdd <= INT_MIN))
				return INT_MIN;

			res += (int)(str[i] - '0') * pow(10, size - (i - start) - 1);

		}

		if (isneg)
			return -res;
		else
			return res;
	}
}