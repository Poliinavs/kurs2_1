// asm_04.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <fstream>
#include "Def.h"

using namespace std;

int main()
{
	int liter = 0;
	char* str = new char[127];
	cout << "text: ";
	cin.getline(str, 127);

	cout << endl << "num:"; cin >> liter;

	ofstream out;
	out.open("C:\\instit\\kusr2\\kpo\\lab4\\asm_04\\asm_04\\serialization.txt");
	if (out.is_open())
	{

		out.clear();

		
		out.write(str, sizeof(char[127]));
		out.write(reinterpret_cast<char*>(&liter), sizeof(int));

		out.close();

	}
	else {
		cout << "Не удалось открыть файл ";
	}
	char* str1 = new char[127];
	int liter1;
	ifstream in;
	in.open("C:\\instit\\kusr2\\kpo\\lab4\\asm_04\\asm_04\\serialization.txt");
	if (in.is_open())
	{
		in.read(str1, sizeof(char[127]));
		in.read(reinterpret_cast<char*>(&(liter1)), sizeof(int));
		in.close();

		cout <<"text deserialization: " << str1 << "\nnum deserialization: " << liter1;
	}
	else {
		cout << "Не удалось открыть файл ";
	}

	ofstream file;
	file.open("C:\\instit\\kusr2\\kpo\\lab4\\asm_04\\ASM\\ASM_04.asm");
	if (file.is_open())
	{
		file.clear();

		file<<asm1;
		file << "STR2   DB \"text: " << str1 << " num: "<< liter1 << "\", 0" << endl << endl;

		file << asm2;
	

		file.close();
	}
	else {
		cout << "Не удалось открыть файл ";
	}

	
}


