// lab1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#include <iostream>

using namespace std;

void hanoi_towers(int quantity, int from, int to, int buf_peg)   
{                                                 
    if (quantity != 0)
    {
        hanoi_towers(quantity - 1, from, buf_peg, to);
        cout << from << " -> " << to << endl;
        hanoi_towers(quantity - 1, buf_peg, to, from);
    }
}

int main()
{
    setlocale( LC_ALL, "rus");
    int start_peg, end_peg, buffer_peg, amount;
    cout << "Номер первого столбика(от 1-3):" << endl;
    cin >> start_peg;
    cout << "Номер конечного столбика(от 1-3):" << endl;
    cin >> end_peg;
    buffer_peg = 6 - end_peg - start_peg;
    cout << "Количество дисков:" << endl;
    cin >> amount;
    if (start_peg > 3 || start_peg <= 0 || end_peg > 3 || end_peg < 0) {
        cout << "Данные введены с ошибкой" << endl;
        return 0;
    }
    if (start_peg == end_peg) {
        cout << "Башня остается на месте" << endl;
        return 0;
    }
    hanoi_towers(amount, start_peg, end_peg, buffer_peg);
    return 0;
}
