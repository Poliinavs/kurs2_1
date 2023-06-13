// C++ implementation of the above approach
#include <iostream>
#include<vector>
#include<algorithm>
#include <limits.h>
#include <Windows.h>
using namespace std;


#define V 5


#define GENES ABCDE
#define START 0


int child = 0;
int populationSize = 0;
int evoCount = 0;


int map[V][V] = { { INT_MAX, 25, 40, 31, 27},
				{ 5, INT_MAX, 17, 30, 25},
				{ 19, 15, INT_MAX, 6, 1},
				{ 9, 50, 24, INT_MAX, 6 },
				{ 22, 8, 7, 10, INT_MAX } };
struct individual {
	string gnome;
	int weight;
};


int rand_num(int start, int end)
{
	int r = end - start;
	int rnum = start + rand() % r;
	return rnum;
}


bool repeat(string s, char ch)
{
	for (int i = 0; i < s.size(); i++) {
		if (s[i] == ch)
			return true;
	}
	return false;
}


string mutatedGene(string gnome) 
{
	while (true) {
		int r = rand_num(1, V);
		int r1 = rand_num(1, V);
		if (r1 != r) {
			char temp = gnome[r];
			gnome[r] = gnome[r1];
			gnome[r1] = temp;
			break;
		}
	}
	return gnome;
}

string create_gnome() 
{
	string gnome = "0";
	while (true) {
		if (gnome.size() == V) {
			gnome += gnome[0];
			break;
		}
		int temp = rand_num(1, V);
		if (!repeat(gnome, (char)(temp + 48)))
			gnome += (char)(temp + 48);
	}
	return gnome;
}

int cal_weight(string gnome)
{

	int f = 0;
	for (int i = 0; i < gnome.size() - 1; i++) {
		if (map[gnome[i] - 48][gnome[i + 1] - 48] == INT_MAX)
			return INT_MAX;
		f += map[gnome[i] - 48][gnome[i + 1] - 48];
	}
	return f;
}

int cooldown(int temp)
{
	return (90 * temp) / 100;
}

bool lessthan(struct individual t1,
	struct individual t2)
{
	return t1.weight < t2.weight;
}

void TSPUtil()
{
	int numb_gen = 1;

	vector<struct individual> population;
	struct individual temp;

	for (int i = 0; i < populationSize; i++) { 
		temp.gnome = create_gnome(); 
		temp.weight = cal_weight(temp.gnome); 
		population.push_back(temp); 
	}

	cout << "\nСтартовая популяция: " << endl;
	cout << "Геном популяци \tвес генома\n";
	for (int i = 0; i < populationSize; i++)
		cout << population[i].gnome << "\t\t"
		<< population[i].weight << endl;
	cout << "\n";

	int mutation_proc = 10000; 

	sort(population.begin(), population.end(), lessthan); 

	while (mutation_proc > 100 && numb_gen <= evoCount) {
		cout << endl << "Лучший геном: " << population[0].gnome;
		cout << " его вес: " << population[0].weight << "\n\n";

		vector<struct individual> new_population;

 		for (int i = 0; i < child; i++) {

			struct individual p1 = population[i];

			while (true)
			{
				string mautat_g = mutatedGene(p1.gnome);
				struct individual mautat;
				mautat.gnome = mautat_g;
				mautat.weight = cal_weight(mautat.gnome);

				if (mautat.weight <= population[i].weight) {
					new_population.push_back(mautat);
					break;
				}
				else {
					mautat.weight = INT_MAX;
					new_population.push_back(mautat);
					break;
				}
			}
		}

		mutation_proc = cooldown(mutation_proc);
		for (int i = 0; i < child; i++)
		{
			population.push_back(new_population[i]);
		}
		sort(population.begin(), population.end(), lessthan);

		for (int i = 0; i < child; i++) 
		{
			population.pop_back();
		}

		cout << "Поколение " << numb_gen << " \n";
		cout << "Геном популяци \tвес генома\n";

		for (int i = 0; i < populationSize; i++)
			cout << population[i].gnome << "\t\t"
			<< population[i].weight << endl;
		numb_gen++;
	}
	cout << "\n\nнаиболее оптимальный маршрут, найденный генетическим алгоритмом: ";
	cout << population[0].gnome;
	cout << "\nВес: " << population[0].weight << endl;
	cout << "\n\n";
}
bool prov(string st) {
	if (st.length() >= 1 && st[0] != '0') {
		for (int i = 0; i < st.length(); i++) {
			if (st[i] < 47 || st[i]>58)
				return false;
		}
	}
	else {
		return false;
	}
	
	return true;
}
int main()
{
	setlocale(LC_ALL, "ru");
	string st;
	cout << "Введите размер популяций: ";
	cin >> st;
	if (!prov(st)) {
		return main();
	}
	populationSize = atoi(st.c_str());  //сеолько строк
	cout << "Введите количество потомков в одной популяции: ";
	cin >> st;
	if (!prov(st)) {
		return main();
	}
	child = atoi(st.c_str()); //сколько детей будет
	cout << "Введите количество эволюционных циклов: ";//сколько раз повторять будем
	cin >> st;
	if (!prov(st)) {
		return main();
	}
	evoCount = atoi(st.c_str());
	
	TSPUtil();
}
