// 1.	Реализуйте функцию без параметров. Вызовите ее с произвольным количеством аргументов. 
// Если вы передали не более 3-х аргументов, то функция должна возвращать строку,
//  состоящую из значений всех аргументов. Если вы передали более 3-х, но не более 5-ти 
//  аргументов – то типы аргументов. Если более 5-ти и не более 7-ми – то   количество аргументов. 
// Если более 7-ми – то сообщение о том, что количество аргументов очень большое.

function without_param() {

    if(arguments.length<=3){
        let str=""; 
        for (var i = 0; i < arguments.length; i++) {
            str+=arguments[i];
            str+=" ";
        }
        return str;
    }

    if(arguments.length>3 &&arguments.length<=5 ){
        let str=""; 
        for (var i = 0; i < arguments.length; i++) {
            str+=typeof(arguments[i]);
            str+=" ";
        }
        return str;
    }

    if(arguments.length>5 &&arguments.length<=7 ){

        return arguments.length;
    }

    return "количество аргументов очень большое";
  }

console.log( without_param("Винни", "Пятачок"));
console.log( without_param("Hellow", "how",11, "you" ));
console.log( without_param("Hellow", "how","are",11, "you", "?" ));
console.log( without_param("Hellow", "how","are",11, "you", "?", 10, 5, 8 ));
//2 
let WhatEx=1;
while(WhatEx!=0){
    WhatEx= prompt("Для выхода нажмите 0");
    switch (WhatEx) {
        case '1':
        {
            window.a;
            alert(a);
            break;
        }
        case '2':
        {
            alert(b);
            window.b = 2;
            break;
        }
        case '3':
        {
            alert(c);
            window.c = 2;
            let c;
            break;
        }
        case '4':
        {
            alert(d);
            window.d = 2;
            var d;
            break;
        }
        case "5":
        {
            alert(e);
            let e = 2;
            break;
        }
        case "6":
        {
            let f = 2;
            window.f = 3;
            alert(f);
            break;
        }
        case "7":
        {
            var g = 2;
            window.g = 3;
            alert(g);
            break;
        }
    }
}


//3

let s = 5;
function sum(){
    alert(s);
}

sum();

// 4.	Что выведет alert в примерах? Поясните почему так? 
// На что ссылается [[Environment]] функций? Что будет содержать
//  LexicalEnvironment при запуске функций? Что хранится в counter? Когда будет вызвана функция (*)?
//Вариант 1.

// function makeCounter() {
//     let currentCount = 1;

//     return function() {
//         return currentCount++;
//     }
// }

// let counter = makeCounter();
// alert( counter() ); 
// alert( counter() ); 
// alert( counter() ); 

// let counter2 = makeCounter();
// alert( counter2() ); 

//Вариант 2
let currentCount = 1;

function makeCounter() {
    return function() {
    return currentCount++;
    };
}

let counter = makeCounter();
let counter2 = makeCounter();

alert( counter() ); 
alert( counter() ); 

alert( counter2() ); 
alert( counter2() ); 

// 6.	Реализуйте каррированную функцию, которая рассчитывает объем прямоугольного параллелепипеда.
//  Выполните преобразование функции для неоднократного расчёта объема прямоугольных параллелепипедов, 
//  у которых одно ребро одинаковой длины.

function lenght_volume(l) {
    return (w, h) => {
        return l * w * h
    }
}
function volume(l) {
    return (w) => {
        return (h) => {
            return l * w * h
        }
    }
}
console.log('Объем1: '+ volume(1)(2)(3));

console.log('Объем2: '+ lenght_volume(1)(2,3));
console.log('Объем3: '+ lenght_volume(1)(2,5));
const mul1 = lenght_volume(1);
const mul2 = mul1(2, 3);
const mul3 = mul1(4,6);
console.log('Объем4: '+ mul2);
console.log('Объем5: '+ mul3);


//
console.log(lenght_volume.name);
console.log(volume.name);


// 7.	Пользователь управляет движением объекта, вводя в модальное окно  команды left, right, up, down. 
// Объект совершает 10 шагов в заданном направлении (т.е. высчитываются и выводятся в консоль соответствующие координаты) 
// и запрашивает новую команду
// . Разработайте генератор, который возвращает координаты объекта, согласно заданному направлению движения. 
function* move() {
    var _a;
    let x = 0;
    let y = 0;
    for (let i = 0; i < 10; i++) {
        _a = prompt("Enter direction");
        switch (_a.toLowerCase()) {
            case "left":
                x--;
                break;
            case "right":
                x++;
                break;
            case "up":
                y++;
                break;
            case "down":
                y--;
                break;
        }
        yield [x, y];
    }
}
let generator = move();
for (let i = 0; i < 10; i++) {
    console.log(generator.next().value);
}
