#include <iostream>
#include <vector>
#include <random>
#include <string>

using namespace std;

#define MAX_DIST 100

typedef vector<vector<int>> Matrix;
typedef vector<int> Path;

struct Way
{
	Path way;
	int dist;

	int length()
	{
		return way.size();
	}

	void clear()
	{
		way.clear();
	}

	void push_back(int value)
	{
		way.push_back(value);
	}

	Way()
	{
		this->dist = 0;
	}

	string to_string()
	{
		string text = "Путь: ";

		for (auto i : way)
		{
			text += std::to_string(i) + " ";
		}

		text += "\nДлина пути : " + std::to_string(this->dist) + "\n";

		return text;
	}
};

Matrix createMatrix(int N, int spread = 100);

void fillPheramons(Matrix& matrix);

void outputMatrix(Matrix matrix);

Way antAlgorithm(
	Matrix& way_matr,
	Matrix& pheramons,
	int amount_iter = 100,
	int alpha = 1,
	int beta = 1
);

///////////////////////////////////////

void main()
{
	setlocale(LC_ALL, "Ru");
	int amount_iter = 100;
	int N;
	cout << "Введите количество городов: ";
	cin >> N;
	Matrix cities = createMatrix(N);
	outputMatrix(cities);

	Matrix pheromons = cities;
	fillPheramons(pheromons);

	int alpha;
	int betta;
	cout << "Введите alpha: ";
	cin >> alpha;
	cout << "Введите betta(чем больше alpha и betta, тем больше влияние феромона и длины пути): "; 
	cin >> betta;
	Way way = antAlgorithm(cities, pheromons, amount_iter, alpha, betta);

	cout << way.to_string();
}

///////////////////////////////////////

void fillAll(vector<bool>& path, int N)
{
	for (int i = 0; i < N; i++)
	{
		path.push_back(true);
	}
}

void fillchoose_prop( 
	Matrix& way_matr,
	Matrix& pheramons,
	vector<double>& choose_prop,
	vector<bool> notv,
	int alpha,
	int beta,
	int current)
{
	double sum = 0.0;
	choose_prop.resize(way_matr.size()); 
	for (int i = 0; i < notv.size(); i++)  
	{
		if (notv[i] && i != current) 
		{
			sum += pow(1.1 / (double)way_matr[current][i], alpha) * pow((double)pheramons[current][i], beta); 
		}
	}

	for (int i = 0; i < choose_prop.size(); i++) 
	{
		if (notv[i])
		{
			choose_prop[i] = 100.0 * pow(1.1 / (double)way_matr[current][i], alpha) * pow((double)pheramons[current][i], beta) / sum;
		}
		else
		{
			choose_prop[i] = 0;
		}
	}
}

int makeChoise(vector<double> choose_prop)
{
	srand(time(NULL));
	int answer = 0;
	int random = rand() % 100 + 1;
	double sum = 0.0;
	
	for (int i = 0; i < choose_prop.size(); i++)
	{
		if (choose_prop[i] == 0) continue;

		sum += choose_prop[i];
		if (sum >= random)
		{
			answer = i;
			break;
		}
	}

	return answer;
}

Way antAlgorithm(
	Matrix& way_matr,
	Matrix& pheramons,
	int amount_iter,
	int alpha,
	int beta
)
{
	Way way;
	Way best;
	best.dist = INT_MAX;

	vector<bool> notv;
	vector<double> choose_prop;

	int current=0;
	int to;
	int i = 0;

	fillAll(notv, way_matr.size());

	way.push_back(current); 

	while (i < amount_iter) 
	{
		choose_prop.clear(); 
		notv[current] = false; 
		fillchoose_prop(way_matr, pheramons, choose_prop, notv, alpha, beta, current);  

		if (find(notv.begin(), notv.end(), true) == notv.end())
		{
			if (way.dist < best.dist)
			{
				best = way;
			}

			way.clear();
			way.dist = 0;
			

			way.push_back(current);
			notv.clear();
			fillAll(notv, way_matr.size());
			i++;
		}
		else
		{
			to = makeChoise(choose_prop); 
			way.dist += way_matr[current][to];
			current = to;
			way.push_back(current);
		}
	}
	return best;
}

Matrix createMatrix(int N, int spread)
{
	Matrix matrix;
	matrix.resize(N);

	for (auto& i : matrix)
	{
		i.resize(N);
	}

	for (int i = 0; i < N; i++)
	{
		matrix[i][i] = 0;

		for (int j = i + 1; j < N; j++)
		{
			matrix[i][j] = matrix[j][i] = rand() % MAX_DIST + 1;
		}
	}

	return matrix;
}

void fillPheramons(Matrix& matrix)
{
	for (auto& i : matrix)
	{
		for (auto& el : i)
		{
			if (el < (double)MAX_DIST * 0.25)
			{
				el = (double)MAX_DIST * 0.25;
			}
			else if (el < (double)MAX_DIST * 0.5)
			{
				el = (double)MAX_DIST * 0.5;
			}
			else if (el < (double)MAX_DIST * 0.75)
			{
				el = (double)MAX_DIST * 0.75;
			}
			else
			{
				el = (double)MAX_DIST;
			}
		}
	}
}

void outputMatrix(Matrix matrix)
{
	for (auto i : matrix)
	{
		for (auto el : i)
		{
			cout << el << "\t";
		}
		cout << endl;
	}
}