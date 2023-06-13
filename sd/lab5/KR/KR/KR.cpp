// KR.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

#define edge pair<int,int>

vector<pair<int, edge>> G; // graph
vector<pair<int, edge>> T; // mst
int* parent;
int V; // number of vertices/nodes in graph
void Graph(int V);
void add(int u, int v, int w);
int find_set(int i);
void kruskal();
void print();

int find_set(int i) {
    /*If i is the parent of itself*/
    if (i == parent[i])
        return i;
    else
        /*  Else if i is not the parent of itself
          Then i is not the representative of his set,
          so we recursively call Find on its parent*/
        return find_set(parent[i]);
}

void add(int u, int v, int w) {
    G.push_back(make_pair(w, edge(u, v)));
}
void kruskal() {
    parent = new int[8];
    for (int i = 0; i < 8; i++)
        parent[i] = i;

    int i, uRep, vRep;
    sort(G.begin(), G.end()); // сортируем по весу 
    for (i = 0; i < G.size(); i++) {
        uRep = find_set(G[i].second.first);//во второй паре 1 элемент(1(6.3)) =6 это вершина 6-3 
        vRep = find_set(G[i].second.second);//вершина 3
        if (uRep != vRep) {
            T.push_back(G[i]); // add to tree
            parent[uRep] = parent[vRep];

        }
    }
}
void print() {
    cout << "Edge :" << " Weight" << endl;
    for (int i = 0; i < T.size(); i++) {
        cout << T[i].second.first + 1 << " - " << T[i].second.second + 1 << " : "
            << T[i].first;
        cout << endl;
    }
}

int main()
{
     add(0, 1, 2);
     add(0, 4, 2);
     add(0, 3, 8);
     add(1, 0, 2);
     add(1, 4, 5);
     add(1, 2, 3);
     add(2, 1, 3);
     add(2, 4, 12);
     add(2, 7, 7);
     add(3, 0, 8);

     add(3, 1, 10 );
     add(3, 4, 14 );
     add(3, 5, 3 );
     add(4, 0, 2 );
     add(4, 1, 5 );
     add(4, 2, 12 );
     add(4, 7, 8 );
     add(4, 6, 4 );
     add(4, 5, 11 );
     add(4, 3, 14 );
     add(5, 3, 3 );
     add(5, 4, 11 );
     add(5, 6, 6 );
     add(6, 5, 6 );
     add(6, 3, 1 );
     add(6, 4, 4 );
     add(6, 7, 9 );
     add(7, 6, 9 );
     add(7, 4, 8 );
     add(7, 2, 7 );
     kruskal();
     print();
}
