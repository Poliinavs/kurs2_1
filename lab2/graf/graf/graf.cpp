//// graf.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <queue>
#include <stack>
#include <vector>
#include <array>
using namespace std;
const int N = 10;
int i, j;
bool* visited = new bool[N];
//матрица смежности графа
int graph[N][N] =
{
{0, 1, 0, 0, 1, 0, 0, 0, 0, 0},
{1, 0, 0, 0, 0, 0, 1, 1, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
{0, 0, 0, 0, 0, 1, 0, 0, 1, 0},
{1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
{0, 0, 0, 1, 1, 0, 0, 0, 1, 0},
{0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
{0, 1, 1, 0, 0, 0, 1, 0, 0, 0},
{0, 0, 0, 1, 0, 1, 0, 0, 0, 1},
{0, 0, 0, 0, 0, 0, 0, 0, 1, 0}
};


//поиск в глубину
void DeepFS(int start)
{
	//int column;
	//cout << strok + 1 << " ";
	//visited[strok] = true;
	//for (column = 0; column <= N; column++)
	//	if ((graph[strok][column] != 0) && (!visited[column]))//мы можем перейти из одной цифры в друг и !visited[r]=false следоват еще не заходили в r
	//		DeepFS(column);
    stack <int> q; 
  
    bool visited[N]; 
    int view_cell; 
    for (int i = 0; i < N; i++)
    {
         visited[i] = false;
    }
    q.push(start); 
    visited[start] = true; 
    while (!q.empty())
    {
        view_cell = q.top(); 
        cout << view_cell + 1 << " ";

       
        q.pop();
        for (int i = 0; i < N; i++)
        {
            if (!visited[i] && graph[view_cell][i])
            {
                q.push(i);
                visited[i] = true;
            }
        }
    }

}

void WidthFS(int start) {//1
    queue <int> q;
    bool visited[N]; 
    int view_cell;
    for (int i = 0; i < N; i++)
    {
        visited[i] = false;
    }
    q.push(start);
  visited[start] = true; 
    while (!q.empty())
    {
        view_cell = q.front(); 
        cout << view_cell + 1 << " ";

        
        q.pop();
        for (int i = 0; i < N; i++)
        {
            if (!visited[i] && graph[view_cell][i])
            {
                q.push(i);
                visited[i] = true;
            }
        }
    }
}
struct Edge {
    int src, dest;
};

//главная функция
void main()
{
    setlocale(LC_ALL, "Rus");
    //////////////
    cout << "\nСписок рёбер: " << endl;
    int arr_1[11] = { 1,1,2,2,3,4,4,5,6,7,9 };
    int arr_2[11] = { 2,5,7,8,8,6,9,6,9,8,10 };

    for (int i = 0; i < N; i++)
    {
        cout << '{' << arr_1[i] << ", " << arr_2[i] << '}';
        cout << " {" << arr_2[i] << ", " << arr_1[i] << '}' << endl;
    }

    //
    cout << "\nСписок смежности: " << endl;
    int arrEdges[10][10] =
    { {2,5},
        {7,8},
        {8},
        {6,9},
        {1,6},
        {4,5,9},
        {2,8},
        {2,3,7},
        {4,6,10},
        {9}
    };

    for (int i = 0; i < N; i++)
    {
        cout << i + 1 << "->";

        for (int j = 0; j < N; j++)
        {
            if (arrEdges[i][j] == 0)
            {
                break;
            }
            cout << arrEdges[i][j] << " ";
        }
        cout << endl;
    }
    cout << endl;

	int start=1;
	cout << "Матрица смежности графа: " << endl;
	for (i = 0; i < N; i++)
	{
		visited[i] = false;
		for (j = 0; j < N; j++)
			cout << " " << graph[i][j];
		cout << endl;
	}
	cout << "\nСтартовая вершина: " << start;
	//массив посещенных вершин
	cout << "\nПорядок обхода в глубину: ";
	DeepFS(start-1);
	delete[]visited;
    //поиск в ширину
    cout << "\n\nПорядок обхода в ширину: "; //1
    WidthFS(start-1);
    cout << endl << endl;
}



/*cout << "Список смежности"<<endl;
    vector<Edge> edges =
    {
        {1, 2},{2, 1}, {1, 5}, {5, 1}, {2, 7},{7, 2}, {2, 8},{8, 2}, {5, 6}, {6, 5}, {8, 7}, {7, 8}, {8, 3},{3, 8}, {4, 9},{9,4}, {4, 6}, {6, 4}, {6, 9}, {9,6}, {10, 9}, {9, 10}
    };
    int n = 11;
    vector<vector<int>> adjList;
    adjList.resize(n);
    for (auto & edge: edges)
    {
        adjList[edge.src].push_back(edge.dest);
    }
    for (int i = 1; i < n; i++)
    {
        cout << i << "--> {";
        for (int v : adjList[i]) {
            cout << v << " ";
        }
        cout <<"}" << endl;
    }*/
    /* cout << "Список ребер" << endl;
     for (int i = 1; i < n/2; i++)
     {
         for (int v : adjList[i]) {
             cout << "{" << i<<","<<v<<"}";
         }
         cout << endl;
     }*/