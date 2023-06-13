#include "stdafx.h"

using namespace std;

void Serealizer::Invoke()
{
	file = ofstream("D:\\LP_3sem-main\\лабы\\AsmLab4\\Serealization\\Debug\\bin.txt");


	short strsize = strlen(data.String) + 1;


	file.clear();

	file.write(reinterpret_cast<char*>(&strsize), sizeof(short));
	file.write(data.String, sizeof(char) * strsize);
	file.write(reinterpret_cast<char*>(&data.Int), sizeof(int));

	file.close();
}
