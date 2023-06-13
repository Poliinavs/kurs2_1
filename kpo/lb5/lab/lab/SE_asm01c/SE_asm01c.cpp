#include<iostream>
#include<tchar.h>
using namespace std;
extern "C" {
	int _stdcall getmin(int *arr,int length);
	int _stdcall getmax(int	*arr, int length);
}
int _tmain(int argc, _TCHAR* argv[]) {
	const int length = 10;
	int array[length] = { 1, 2, 3, 4, 0, 9, 7, 13, 9, 10 };
	cout << "getmax+getmin: " << getmin(array, length) + getmax(array, length);
}