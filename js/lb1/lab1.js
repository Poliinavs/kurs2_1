function checkAge(age){
   const mes=age;
    return mes;
}


console.log(checkAge(21));



// function exponent(x, n) {
//     let result = 1;

//     for (var i = 0; i < n; i++)
//         result *= x;

//     return result;
// }

// let x = prompt("x?", '');
// let n = prompt("n?", '');

// if (n < 0) {
//     alert(`Степень ${n} не поддерживается, введите целую степень, большую 0`);
// } else {
//     alert(exponent(x, n));
// }

    
//     // 2
//     let username = 'Polina';
//     let city = 'Minsk';
//     let year = 2004;
//     let color = 'blue';
//     let ans = 'yes';
//     let inf = Infinity;
//     let s = 532;
//     let p ='Периметр прямоугольника 120 мм';
//     alert('Введенные данные неверны');
    
//     //3
//     let a = 5;
//     alert(typeof a);
    
//     let name = "Name";
//     alert(typeof name);
    
//     let ii = 0;
//     alert(typeof ii);
    
//     let double = 0.23;
//     alert(typeof double);
    
//     let result = 1 / 0;
//     alert(typeof result);
    
//     let answer = true;
//     alert(typeof answer);
    
//     let no = null;
//     alert(typeof no);
    
//     //4
//     function Square(a, b) {
//         let Sq = a*b;
//         return Sq;
//       }
//     let lenght = 45;
//     let width = 21;
//     alert(`Площадь: ${Square(lenght, width)}`);
//     //5
//     let rectangle=5;
//     let amount =Square(lenght, width)/ Square(rectangle, rectangle);
//     alert(`Количество квадратов: ${amount}`);
//     //6 
//     let i = 2;
//     let a1 = ++i;
//     let b = i++;
//     alert(`a1>a2: ${a1 > b}`);
//     //7

//     alert(`Привет > привет: ${`Привет` < `привет`}`); 
//     alert(`Привет > Пока: ${`Привет` > `Пока`}`);
//     alert(`45 < 53: ${45 < 53}`);
//     alert(`false > 3: ${false > 3}`);
//     alert(`true < 3: ${true < 3}`);
//     alert(`3 == 5mm: ${3 == `5mm`}`);
//     alert(`null > undefined: ${null > undefined}`);
//     //8
//     alert(`Введённые данные неверные`);
//     //9
//     let answer_2;
//     let qestion = prompt(`Ответ на секретный вопрос`, `Секретный ответ`);
//     //10
//     var login = "11";
//     var password = "kat";
//     var answer_login = prompt(`Введите логин`);
//     var answer_password = prompt(`Введите пароль`);
    
//     if (answer_login == login && answer_password == password) {
//         alert(`Вход успешно выполнен!`)
//     } else
//         alert(`Вход не выполнен!`);
//     //11
//     let rus= prompt(`Сдал ли студент экзамен по математике? (если ДА введите "+", НЕТ "-")`);
//     let math = prompt(`Сдал ли студент экзамен по русскому? (если ДА введите "+", НЕТ "-")`);
//     let engl = prompt(`Сдал ли студент экзамен по английскому? (если ДА введите "+", НЕТ "-")`);
    
//     if (rus== '+' && math == '+' && engl == '+') {
//         alert(`Студент переведён на второй курс`);
//     } else if (rus== '-' && math == '-' && engl == '-') {
//         alert(`Студент отчислен`);
//     } else if (rus== '-' || math == '-' || engl == '-') {
//         alert(`Студента ожидает пересдача`);
//     }
//    //12
//     let number_a = Number(prompt("Введите a: "));
//     let number_b = Number(prompt("Введите b: "));
//     sum = +number_a + +number_b;
//     alert(`Сумма: ${sum}`);
//     //13
//     let number13_1 = true + true; //2
//     let number13_2 = 0 + "5"; 
//     let number13_3 = 5 + "mm"; 
//     let number13_4 = 8 / Infinity; 
//     let number13_5 = 9 * "\n9"; 
//     let number13_6 = null - 1; 
//     let number13_7 = "5" - 2; 
//     let number13_8 = "5px" - 3; 
//     let number13_9 = true - 3; 
//     let number13_10 = 7 || 0; 
//     //14
//     let Arr = [10];
//     for (let count = 0; count < 10; count++) {
//         Arr[count] = count + 1;

//         if (Arr[count] % 2 == 0)
//             Arr[count] += 2;

//         if (Arr[count] % 2 != 0)
//             Arr[count] = `${Arr[count]}mm`;

//         alert(`${Arr[count]}`);
//     }
//    // 15
//     let user_number;
//     while (true) {

//     user_number = prompt(`Введите число: `);

//         if (user_number > 100) {
//             break;
//         }
//     }
//     //16
//     let week = ["понедельнику", "вторнику", "среде", "четвергу", "пятнице", "субботе", "воскресенью"];
//     let day_number = prompt(`Введите номер дня:`) - 1;
//     alert(`Данный номер соответствует ${week[day_number]}`);
    