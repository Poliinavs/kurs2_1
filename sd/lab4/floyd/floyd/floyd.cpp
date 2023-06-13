////// floyd.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//////
////
#include <iostream>
using namespace std;
const int maxV = 1000;


const int V = 6;
int C[V][V];
int D[V][V] = {
		   {0, 28, 21, 59, 12, 27},
		   {7, 0, 24, 0, 21, 9},
		   {9, 32, 0, 13, 11, 0},
		   {8, 0, 5, 0, 16, 0},
		   {14, 13, 15, 10, 0, 22},
		   {15, 18, 0, 0, 6, 0}
 };
//алгоритм Флойда-Уоршелла
void FU()
{
	for (int i = 0; i < V; i++)
	{
		for (int j = 0; j < V; j++)
		{
			if (D[i][j] == 0)
				D[i][j] = INT_MAX;
			if (i == j)
				D[i][j] = 0;
			C[i][j] = j+1;
		}
	}

	for (int k = 0; k < V; k++)
		for (int i = 0; i < V; i++)
			for (int j = 0; j < V; j++)
				if (D[i][k] && D[k][j] && i != j)
					if (D[i][k] + D[k][j] < D[i][j] ) {
						D[i][j] = D[i][k] + D[k][j];
						C[i][j] = C[i][k];
					}

	for (int i = 0; i < V; i++)
	{
		for (int j = 0; j < V; j++) cout << D[i][j] << "\t";
		cout << endl;
	}
	cout << "Матрица последовательности вершин: "<<endl;
	for (int i = 0; i < V; i++)
	{
		for (int j = 0; j < V; j++) cout << C[i][j] << "\t";
		cout << endl;
	}
}
//главная функция
void main()
{
	setlocale(LC_ALL, "Rus");
	cout << "Матрица кратчайших путей:" << endl;
	FU();
}
