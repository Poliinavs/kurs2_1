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
		/*	if (!operat.empty()) {
				if (operat.top() == '-' || operat.top() == '+')
					cout << c;
				else
					operat.push(c);
			}
			else*/
			operat.push(c);
			break;
		case '/':
			/*if (operat.top() == '-' || operat.top() == '+')
				cout << c;
			else*/
				operat.push(c);
			break;
		default:
			if(((int)c>64 && (int)c<91)||((int)c > 96 && (int)c < 123))
			cout << c;
			break;
	}
	
}


int main()
{
	setlocale(LC_ALL, "rus");
	//string expr="(a+b)*x+(m*n)";
	string expr = "k*k*(6+p)/k";
	//string expr = "(a+b)*(c+d)-e";
	/*cout<< "enter str:";
	cin >> expr;*/
	
	for (int i=0; i < expr.length(); i++) {
		pror(expr[i]);
	}
	Print();

}

