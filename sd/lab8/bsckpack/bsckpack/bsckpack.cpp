//// bsckpack.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
////

#include <Windows.h>
#include <iostream>
#include <vector>
#include <limits>
#include <math.h>
using namespace std;


void BackPack(const vector<int>& wts, const vector<int>& cost, const vector<string> name, int W);

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    const vector<int> weight = { 6,3, 4, 2, 1 };
    const vector<int> cost = { 30, 14, 16, 9, 22 };
    const vector<string> name = { "Гиря", "дверь", "Куртка", "Конфета", "Телефон" };
    string st;
    cout << "Введите максимальную емкость рюкзака: "; cin >> st;


    if (st.length() >= 1 && st[0] != '0') {
        for (int i = 0; i < st.length(); i++) {
            if (st[i] < 47 || st[i]>58)
                return main();
        }
    }
    else {
        return main();
    }


    int N = atoi(st.c_str());
  
    BackPack(weight, cost, name, N);

}


void BackPack(const vector<int>& weight, const vector<int>& cost, const vector<string> name, int size)
{
    int n = weight.size();
    vector<vector<int> > dp(size + 1, vector<int>(n + 1, 0));
    vector<string> names;
    for (size_t i = 1; i <= n; i++)
    {
        for (int j = 1; j <= size; j++)
        {
            if (weight[i - 1] <= j)
            {
                if (dp[j][i - 1] > dp[j - weight[i - 1]][i - 1] + cost[i - 1]) 
                {
                    dp[j][i] = dp[j][i - 1];
                }
                else
                {
                    dp[j][i] = dp[j - weight[i - 1]][i - 1] + cost[i - 1]; 
                }
            }
            else
            {
                dp[j][i] = dp[j][i - 1];
            }
        }
    }
    for (int i = 0; i <= n; i++)
    {
        for (int j = 0; j < size + 1; j++)
        {
            cout << dp[j][i] << "\t";
        }
        cout << "\n";
    }

    bool* need = new bool[n];
    for (int i = 0; i < n; i++)
    {
        need[i] = true;
    }

    int i = n, j = size;
    while (true)
    {
        if (i == 0)
        {
            break;
        }
        if (dp[j][i] == dp[j][i - 1]) 
        {
            need[i - 1] = false;
            i--;
        }
        else
        {
            j = size - weight[i - 1];
            i--;
        }
    }
    for (int i = 0; i < n; i++)
    {
        if (need[i] == true)
        {
            cout << name[i] << " ";
        }
    }

    cout << "\nМаксимальная стоимость: " << dp[size][n];
}





////wts - массив весов, cost - массив стоимостей предметов, W - вместимость рюкзака
////функция возвращает максимальную стоимость, которую можно набрать(решение задачи о рюкзаке
////с повторениями)
////массив dp собственно реализует динамическое программирование, описанное в статье, как K_w
//#include <iostream>
//#include <vector>
//#include <limits>
//using namespace   std;
//
//int knapsack2(const std::vector<int>& wts, const std::vector<int>& cost, int W)
//{
//    size_t n = wts.size();
//    std::vector<std::vector<int> > dp(W + 1, std::vector<int>(n + 1, 0));
//    for (size_t j = 1; j <= n; j++)
//    {
//        for (int w = 1; w <= W; w++)
//        {
//            if (wts[j - 1] <= w)
//            {
//                dp[w][j] = std::max(dp[w][j - 1], dp[w - wts[j - 1]][j - 1] + cost[j - 1]);
//            }
//            else
//            {
//                dp[w][j] = dp[w][j - 1];
//            }
//        }
//    }
//    for (int i = 0; i < W+1; i++) {
//        for (int j = 0; j < n+1; j++)
//            std::cout << dp[i][j] << " ";
//        cout << endl;
//    }
//    return dp[W][n];
//}
//
//int main()
//{
//    std::vector<int> weights = { 6, 3, 4, 2 };
//    std::vector<int> values = { 30, 14, 16, 9 };
//    knapsack2(weights, values,10 );
//	
//}
//
//// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
//// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"
//
//// Советы по началу работы 
////   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
////   2. В окне Team Explorer можно подключиться к системе управления версиями.
////   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
////   4. В окне "Список ошибок" можно просматривать ошибки.
////   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
////   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
