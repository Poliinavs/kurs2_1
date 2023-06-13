#include "stdafx.h"

using namespace std;

void AsmConvenrter::Invoke()
{
	file = ofstream("D:\\LP_3sem-main\\лабы\\AsmLab4\\Serealization\\AssemblerProgramm\\test3.asm");


	file.clear();

	file ASMHEADER;

		 file<< "FILESTR	 DB \"" << data.String << "\", 0" << endl << endl;

		 file<< "FILEINT	 DD " << '0' + data.Int << endl << endl;
			file << "INTSTR		DB \"num: \", 0"<<endl;

	file ASMFOOTER;

	file.close();
}
