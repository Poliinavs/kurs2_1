// polskZap.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
//при лобавлении -+ проверять чтобы не было */, если есть выводим , на */ удалить 
#include <iostream>
#include <stack>
using namespace std;
stack <char> operat;


void Print()
{
	while (!operat.empty()) {
		cout << operat.top();
		operat.pop();

	}
}
void pror(char c) {
	switch (c) {
		case '(':
			//Print();
			operat.push(c);
			break;
		case ')':
			while (operat.top()!='(') {
				cout << operat.top();
				operat.pop();
			}
			operat.pop();
			break;
		case '+':
			if (!operat.empty()) {
				if (operat.top() == '*' || operat.top() == '/') {
					cout << operat.top();
					operat.pop();
					pror(c);
				}
				else
					operat.push(c);
			}
			else
				operat.push(c);
			break;
		case '-':
			if (!operat.empty()) {
				if (operat.top() == '*' || operat.top() == '/') {
					cout << operat.top();
					operat.pop();
					pror(c);
				}
				else
					operat.push(c);
			}
			else
				operat.push(c);
			break;
		case '*':
			operat.push(c);
			break;
		case '/':
				operat.push(c);
			break;
		default:
				cout << c;

			break;
	}

}
bool PolishNotation(string expr) {
	bool k = true;
	for (int i = 0; i < expr.length(); i++) {
		if (((int)expr[i] > 39 && (int)expr[i] < 48) || ((int)expr[i] > 64 && (int)expr[i] < 91) || ((int)expr[i] > 96 && (int)expr[i] < 123))
			k = true;
		else
			return false;
	}
	for (int i = 0; i < expr.length(); i++) {
		pror(expr[i]);
	}
	Print();

	return true;
}

int main()
{
	setlocale(LC_ALL, "rus");

	string expr="a/(a+b/(a+b))+a*a/b";
	//string expr = "(a+b)*(c+d)-e";
	/*cout<< "enter str:";
	cin >> expr;*/
	if (!PolishNotation(expr))
		cout << "Введены неверные данные";


}

