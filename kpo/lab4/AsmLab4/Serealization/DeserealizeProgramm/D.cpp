#include "stdafx.h"
#include "D.h"

using namespace std;

void Deserializer::Invoke() {

	file = ifstream("D:\\LP_3sem-main\\лабы\\AsmLab4\\Serealization\\Debug\\bin.txt");


	short strsize;

	data->String = new char[127];

	file.read(reinterpret_cast<char*>(&strsize), sizeof(short));
	file.read(data->String, sizeof(char) * strsize);
	file.read(reinterpret_cast<char*>(&(data->Int)), sizeof(int));

	file.close();
}
