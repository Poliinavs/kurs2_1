#include <iostream>
#include <cstring>
using namespace std;
#define V 8

int G[V][V] = {
    {0, 2, 0, 8, 2, 0, 0, 0},
    {2, 0, 3, 10, 5, 0, 0, 0},
    {0, 3, 0, 0, 12, 0, 0, 7},
    {8, 10, 0, 0, 14, 3, 1, 0},
    {2, 5, 12, 14, 0, 11, 4, 8},
    {0, 0, 0, 3, 11, 0, 6, 0},
    {0, 0, 0, 1, 4, 6, 0, 9},
    {0, 0, 7, 0, 8, 0, 9, 0}
};

void Prim() {
    int min = INT_MAX;
    int amount_edge = 0;           
    int row = 0;
    int col = 0;

    int selected[V];

    for (int i = 0; i < V; i++) {
        selected[i] = false;
    }
    for (int i = 0; i < V; i++) { 
        for (int j = 0; j < V; j++) {
            if (G[i][j] < min)
                min = G[i][j];
        }
    }
    selected[min] = true;           
    cout << "Edge" << " : " << "Weight";
    cout << endl;
    while (amount_edge < V - 1) {
        min = INT_MAX;
        for (int i = 0; i < V; i++) {
            if (selected[i]) { 
                for (int j = 0; j < V; j++) {
                    if (!selected[j] && G[i][j]) { 
                        if (min > G[i][j]) {
                            min = G[i][j];
                            row = i;
                            col = j;
                        }

                    }
                }
            }
        }
        cout << row+1 << " - " << col+1 << " :  " << G[row][col];
        cout << endl;
        selected[col] = true;
        amount_edge++;
    }

}

int main() {
    cout << "Algorithm Prima\n";
    Prim();
}


//////#include<iostream>
//////#include<vector>
//////#include<algorithm>
//////using namespace std;
//////int M = 8, N = 8;
//////
//////struct Node // Сохранить график как структуру данных
//////{
//////	int start;
//////	int end;
//////	int length;
//////};
//////bool compare(Node a, Node b)
//////{
//////	return a.length < b.length;
//////}
//////int col = 0;
//////void add(int st, int ed, int len, vector<Node>& arr) {
//////	arr[col].start = st;
//////	arr[col].end = ed;
//////	arr[col].length = len;
//////	col++;
//////}
//////void Kruskal(vector<Node>& arr,vector<bool>& visited)
//////{
//////	add(1, 2, 2 ,arr);
//////	add(1, 5, 2 ,arr);
//////	add(1, 4, 8 ,arr);
//////	add(2, 1, 2 ,arr);
//////	add(2, 5, 5 ,arr);
//////	add(2, 3, 3 ,arr);
//////	add(3, 2, 3 ,arr);
//////	add(3, 5, 12 ,arr);
//////	add(3, 8, 7 ,arr);
//////	add(4, 1, 8 ,arr);
//////	add(4, 2, 10 ,arr);
//////	add(4, 5, 14 ,arr);
//////	add(4, 6, 3 ,arr);
//////	add(5, 1, 2 ,arr);
//////	add(5, 2, 5 ,arr);
//////	add(5, 3, 12 ,arr);
//////	add(5, 8, 8 ,arr);
//////	add(5, 7, 4 ,arr);
//////	add(5, 6, 11 ,arr);
//////	add(5, 4, 14 ,arr);
//////	add(6, 4, 3 ,arr);
//////	add(6, 5, 11 ,arr);
//////	add(6, 7, 6 ,arr);
//////	add(7, 6, 6 ,arr);
//////	add(7, 4, 1 ,arr);
//////	add(7, 5, 4 ,arr);
//////	add(7, 8, 9 ,arr);
//////	add(8, 7, 9 ,arr);
//////	add(8, 5, 8 ,arr);
//////	add(8, 3, 7 ,arr);
//////
//////
//////	M = visited.size();
//////	N = arr.size();
//////	
//////
//////
//////	//for (int i = 0; i < N; i++)
//////	//{
//////	//	cin >> arr[i].start >> arr[i].end >> arr[i].length;
//////	//}
//////	sort(arr.begin(), arr.end(), compare);
//////	int weight = 0;
//////	for (int i = 0; i < N; i++)
//////	{
//////		if (!visited[arr[i].start] || !visited[arr[i].end])
//////		{
//////			weight += arr[i].length;
//////			visited[arr[i].start] = true;
//////			visited[arr[i].end] = true;
//////		}
//////	}
//////	cout << "Минимальный вес связующего дерева:";
//////	cout << weight << endl;
//////}
//////int main()
//////{
//////	
//////	cin >> M >> N;
//////
//////	vector<bool> visited(M);
//////	vector<Node> arr(N);
//////	Kruskal( arr,visited);
//////}

//#include <iostream>
//#include <vector>
//#include <algorithm>
//using namespace std;
//
//#define edge pair<int,int>
//
//class Graph {
//private:
//    vector<pair<int, edge>> G; // graph
//    vector<pair<int, edge>> T; // mst
//    int* parent;
//    int V; // number of vertices/nodes in graph
//public:
//    Graph(int V);
//    void add(int u, int v, int w);
//    int find_set(int i);
//    void union_set(int u, int v);
//    void kruskal();
//    void print();
//};
//Graph::Graph(int V) {
//    parent = new int[V];
//
//   /* i 0 1 2 3 4 5*/
//    /*parent[i] 0 1 2 3 4 5*/
//    for (int i = 0; i < V; i++)
//        parent[i] = i;
//
//    G.clear();
//    T.clear();
//}
//void Graph::add(int u, int v, int w) {
//    G.push_back(make_pair(w, edge(u, v)));
//}
//int Graph::find_set(int i) {
//     /*If i is the parent of itself*/
//    if (i == parent[i])
//        return i;
//    else
//       /*  Else if i is not the parent of itself
//         Then i is not the representative of his set,
//         so we recursively call Find on its parent*/
//        return find_set(parent[i]);
//}
//
//void Graph::union_set(int u, int v) {
//    parent[u] = parent[v];
//}
//void Graph::kruskal() {
//    int i, uRep, vRep;
//    sort(G.begin(), G.end()); // increasing weight
//    for (i = 0; i < G.size(); i++) {
//        uRep = find_set(G[i].second.first);
//        vRep = find_set(G[i].second.second);
//        if (uRep != vRep) {
//            T.push_back(G[i]); // add to tree
//            union_set(uRep, vRep);
//        }
//    }
//}
//void Graph::print() {
//    cout << "Edge :" << " Weight" << endl;
//    for (int i = 0; i < T.size(); i++) {
//        cout << T[i].second.first+1 << " - " << T[i].second.second+1 << " : "
//            << T[i].first;
//        cout << endl;
//    }
//}
//int main() {
//    Graph g(8);
//    g.add(0, 1, 2);
//    g.add(0, 4, 2);
//    g.add(0, 3, 8);
//    g.add(1, 0, 2);
//    g.add(1, 4, 5);
//    g.add(1, 2, 3);
//    g.add(2, 1, 3);
//    g.add(2, 4, 12);
//    g.add(2, 7, 7);
//    g.add(3, 0, 8);
//
//    g.add(3, 1, 10 );
//    g.add(3, 4, 14 );
//    g.add(3, 5, 3 );
//    g.add(4, 0, 2 );
//    g.add(4, 1, 5 );
//    g.add(4, 2, 12 );
//    g.add(4, 7, 8 );
//    g.add(4, 6, 4 );
//    g.add(4, 5, 11 );
//    g.add(4, 3, 14 );
//    g.add(5, 3, 3 );
//    g.add(5, 4, 11 );
//    g.add(5, 6, 6 );
//    g.add(6, 5, 6 );
//    g.add(6, 3, 1 );
//    g.add(6, 4, 4 );
//    g.add(6, 7, 9 );
//    g.add(7, 6, 9 );
//    g.add(7, 4, 8 );
//    g.add(7, 2, 7 );
//
//
//
//    g.kruskal();
//    g.print();
//    return 0;
//}

//#include <stdio.h>
//#include <stdlib.h>
//
//int NV=8;                // Количество вершин в графе
//int NE=8;                // Количество ребер в графе
//
//#define MAX_NODES 100  // Максимальное количество вершин
//#define MAX_EDGES 10   // Максимальное количество ребер в графе
//
//
//struct edge_t {
//    int n1, n2;  // направление
//    int w;      // вес ребра
//} edges[MAX_EDGES]; // Ребра графа
//
//int nodes[MAX_NODES]; // Вершины графа. Значение - "верхняя вершина"
//
//// Функция "сравнения" двух ребер, используемая для сортировки
//int cmp(const void* a, const void* b) {
//	edge_t* c = (edge_t*)a;
//	edge_t*d = (edge_t*)b;
//    return c->w - d->w;
//}
//
//int last_n;
//
//// Функция получает цвет вершины n-й по порядку.
//// если nodes[n] < 0, то вершина n имеет цвет nodes[n]
//// если nodes[n] >= 0, то вершина n имеет цвет такой же,
//// как и вершина с номером nodes[n]
//int getColor(int n) {
//    int c;
//    if (nodes[n] < 0)
//        return nodes[last_n = n];
//    c = getColor(nodes[n]);
//    nodes[n] = last_n;
//    return c;
//}
//
//int col = 0;
//void add(int st, int ed, int len) {
//	edges[col].n1 = st;
//	edges[col].n2 = ed;
//	edges[col].w = len;
//	col++;
//}
//
//
//int main() {
//    int i;
//    // Считываем вход
//
//  
//    for (i = 0; i < 8; i++) nodes[i] = -1 - i;
//
// /*   for (i = 0; i < NE; i++)
//        scanf("%d %d %d", &edges[i].n1, &edges[i].n2, &edges[i].w);*/
//
//
//    	add(1, 2, 2  );
//	add(1, 5, 2  );
//	add(1, 4, 8  );
//	add(2, 1, 2  );
//	add(2, 5, 5  );
//	add(2, 3, 3  );
//	add(3, 2, 3  );
//	add(3, 5, 12  );
//	add(3, 8, 7  );
//	add(4, 1, 8  );
//	add(4, 2, 10  );
//	add(4, 5, 14  );
//	add(4, 6, 3  );
//	add(5, 1, 2  );
//	add(5, 2, 5  );
//	add(5, 3, 12  );
//	add(5, 8, 8  );
//	add(5, 7, 4  );
//	add(5, 6, 11  );
//	add(5, 4, 14  );
//	add(6, 4, 3  );
//	add(6, 5, 11  );
//	add(6, 7, 6  );
//	add(7, 6, 6  );
//	add(7, 4, 1  );
//	add(7, 5, 4  );
//	add(7, 8, 9  );
//	add(8, 7, 9  );
//	add(8, 5, 8  );
//	add(8, 3, 7  );
//
//    // Алгоритм Краскала
//
//    // Сортируем все ребра в порядке возрастания весов
//    qsort(edges, NE, sizeof(edge_t), cmp);
//
//    for (i = 0; i < NE; i++) {
//        int c2 = getColor(edges[i].n2);
//        if (getColor(edges[i].n1) != c2) {
//            nodes[last_n] = edges[i].n2;
//            printf("%d %d %d\n", edges[i].n1, edges[i].n2, edges[i].w);
//        }
//    }
//    return 0;
//}