#include <iostream>
#include <stdlib.h>
using namespace std;

int main() {

	string st;
	cout << "AMOUNT "; cin >> st;


	if (st.length() >= 1 && st[0]!='0') {
		for (int i = 0; i < st.length(); i++) {
			if(st[i]<47 || st[i]>58)
				return main();
		}
	}
	else {
		return main();
	}


	int N=atoi(st.c_str());
	//cin >> N;
	int* arr = new int[N];
	int* lenght = new int[N];
	int* path = new int[N];
	for (int i = 0; i < N; i++)
	{
		lenght[i] = 1;
		path[i] = -1;
	}
	srand(time(0));
	for (int i = 0; i < N; i++)
	{
		arr[i] = 1 + rand() % 20;
		cout << arr[i] << " ";

	}
	cout << endl;


	for (int j = 1; j < N; j++) {
		for (int k = 0; k < j; k++) {
			if (arr[j] > arr[k]) {
				if (lenght[j] <= lenght[k]) {
					lenght[j] = lenght[k] + 1;
					path[j] = k;
				}
			}
		}
	}


	

	cout << "Lenght\n";
	for (int i = 0; i < N; i++)
	{
		cout << lenght[i] << " ";
	}
	cout << endl;

	cout << "Position\n";
	for (int i = 0; i < N; i++)
	{
		cout << path[i] << " ";
	}
	cout << endl;

	int max = 0;
	int check = 0;
	
	for (int i = 0; i < N; i++)
	{
		if (lenght[i] > max)
		{
			check = i;
			max = lenght[i];
		}
	}
	cout <<"Amount: " << max << endl;


	int out[100];
	for (int i = max; i >= 0; i--)
	{
		out[i] = arr[check];
		check = path[check];
	}
	for (int i = 1; i < max + 1; i++)
	{
		cout << out[i] << " ";
	}
	delete[] arr;
	delete[] lenght;
	delete[] path;
}

