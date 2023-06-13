// Deykstr.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;
const int V = 9;
char Words[V] = { 'A','B','C','D','E','F','G','H','I' };
//алгоритм Дейкстры
void Dijkstra(int GR[V][V], int st)
{
	int distance[V], count, i, min_dist;
	bool visited[V];
	for (i = 0; i < V; i++)  
	{
		distance[i] = INT_MAX; visited[i] = false;
	}
	distance[st] = 0; 
	for (count = 0; count < V - 1; count++) 
	{
		int min = INT_MAX;
		for (i = 0; i < V; i++)
			if (!visited[i] && distance[i] <= min) 
			{
				min = distance[i]; min_dist = i;
			}
		
		visited[min_dist] = true;
		for (int sm = 0; sm < V; sm++) 
			if (!visited[sm] && GR[min_dist][sm] && distance[min_dist] != INT_MAX && distance[min_dist] + GR[min_dist][sm] < distance[sm]) 
				distance[sm] = distance[min_dist] + GR[min_dist][sm];
	}
	cout << "Стоимость пути из начальной вершины до остальных:\t\n";
	for (i = 0; i < V; i++)
		if (distance[i] != INT_MAX)
		cout << Words[st] << " > " << Words[i] << " = " << distance[i] << endl;
		else cout << Words[st] << " > " << Words[i] << " = " << "маршрут недоступен" << endl;
}
//главная функция
int main()
{
	setlocale(LC_ALL, "Rus");
	int start=10, GR[V][V] = {
			{0, 7, 10, 0, 0, 0, 0, 0, 0},
			{7, 0, 0, 0, 0, 9, 27, 0, 0},
			{10, 0, 0, 0, 31, 8, 0, 0, 0},
			{0, 0, 0, 0, 32, 0, 0, 17, 21},
			{0, 0, 31, 32, 0, 0, 0, 0, 0},
			{0, 9, 8, 0, 0, 0, 0, 11, 0},
			{0, 27, 0, 0, 0, 0, 0, 0, 15},
			{0, 0, 0, 17, 0, 11, 0, 0, 15},
			{0, 0, 0, 21, 0, 0, 15, 15, 0} };
	string st;
	cout << "Начальная вершина >> "; cin >> st;
	

	if (st.length() == 1) {
		for (int i = 0; i < 9; i++) {
			if (st[0] == Words[i]) {
				start = i;
			}
		}
		if(start==10)
			return main();
	}
	else {
		return main();
	}

	Dijkstra(GR, start);
}
