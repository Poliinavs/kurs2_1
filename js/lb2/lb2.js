const calculateArrow = (radius) =>  3.14 * radius ** 2;
    
function calculateDeclaration(radius) {
    return radius * 2
}
    
const calculateExpression = function (radius) {
   return 3.14 * radius * 2
};
    alert(calculateExpression(10));
    alert(calculateExpression);
  let radius = Number(prompt("Введите радиус: "));
  alert(`Площадь круга: ${calculateArrow(radius)} Диаметр круга: ${calculateDeclaration(radius)} длина окружности круга: ${calculateExpression(radius)} `);
 
// //task2
const three_param = (first = 'default', second, third) => {
    alert(first + second + third)
    }
    
    const thirdParameter = prompt('Enter third parameter')
    three_param( undefined,'second', thirdParameter)
//task3
const students = prompt('Введите имена студентов через ;').split(';') 
alert(students.length)
// //task4
// 4.

const amount_var=(26**5)*(10**3);
const time=amount_var*3;
const sec_in_year=60*60*24*365;
const sec_in_month=60*60*24*30;
const sec_in_day=60*60*24;
const year=Math.floor(time/sec_in_year);
const month=Math.floor((time-year*sec_in_year)/sec_in_month)
const day =Math.floor((time-year*sec_in_year-month*sec_in_month)/sec_in_day)
const hour =Math.floor((time-year*sec_in_year-month*sec_in_month-day*sec_in_day)/3600)
const min =Math.floor((time-year*sec_in_year-month*sec_in_month-day*sec_in_day -hour*3600)/60)
const sec =(time-year*sec_in_year-month*sec_in_month-day*sec_in_day -hour*3600-min*60)
alert(` ${year} лет ${month} месяцев ${day} дней ${hour} часов ${min} минут ${sec} секунд  `);

//5	Пользователь вводит данные. Если он ввел число, то преобразуйте его в 16-ричную систему счисления (вывод в верхнем регистре). 
//Если число дробное – округлите его до наибольшего, наименьшего и ближайшего целого. 
//Если пользователь ввел текст, то преобразуйте его к верхнему и нижнему регистру.

let inform = prompt('Введите данные');

if ( /[0-9/.]/.test(inform )){

    if ( Number.isInteger(+inform)==false){

        alert(`Округление до наибольшего: ${Math.ceil(inform)}, наименьшего: ${Math.floor(inform)}, ближайшего целого ${Math.round(inform)}`);
        
    } else {

        function decimalToHexString(number)
        {

        if (number < 0)
        {
            number = 0xFFFFFFFF + number + 1;
        }

        return number.toString(16).toUpperCase();
        }

        alert(`В 16-ричной системе:${decimalToHexString(+inform)}`);

    }
} else {
    alert(`Ваш текст в верхенем регистре ${ inform.toUpperCase()}`);
    alert(`Ваш текст в нижнем регистре ${ inform.toLowerCase()}`);
}
// 6.	Выпускник сдает ЦТ по русскому языку. Ему дано словарное слово, необходимо ввести в текстовое поле правильный вариант ответа. 
// Проверьте его ответ и сообщите в каком символе он допустил ошибку, если она есть.
let correct_answer= "облако";
let incorrect_position= [];
let amount=0;
let question = prompt(`Как пишется слово обл*ко`, `введите ваш ответ`);
question=question.toLowerCase();

for(var i=0; i<correct_answer.length; i++){
    if(correct_answer[i]!=question[i]){
        incorrect_position[amount]=i+1;
        amount+=1;
    }
}
if(incorrect_position.length==0){
    alert(`Вы правильно ввели слово`)
} else {
    alert(`Вы допустили ошибку в слове в позициях: ${incorrect_position}`)
}
// 7.	Разработайте геометрический калькулятор для расчета параметров треугольника: 
// площадь, периметр, высота, cos, sin, tg, ctg. Пользователь указывает длину катетов.
function Square(lg1, lg2) {
    return lg1*lg2 / 2
}
function Perimeter(lg1, lg2){
    return lg1 + lg2 + Math.sqrt(lg1**2 + lg2**2)
}
function cos(lg1, lg2){

  return lg2/(Math.sqrt(lg1**2 + lg2**2))

}
function sin(lg1, lg2){

  return lg1/(Math.sqrt(lg1**2 + lg2**2))

}
function height(lg1, lg2){

  let sn =sin(lg1,lg2);
  return sn*lg2

}
function tg(lg1, lg2){

  return lg1/lg2

}
function ctg(lg1, lg2){

  return lg2/lg1

}
let leg1 = prompt('Введите первый катет: ');
let leg2 = prompt('Введите второй катет: ');
let choise=1;

while(+choise !=0){

     choise =  prompt(`1.Площадь:\n2.Периметр\n3.высота\n4.cos\n5.sin\n6.tg\n7.ctg\n0.выйти`);

    switch (+choise) {
        case 1:
          alert(`Площадь: ${Square(leg1, leg2)}` );
          break;
        case 2:
            alert(`Периметр: ${Perimeter(leg1, leg2)}` );
          break;
        case 3:
          alert( `Высота: ${height(leg1, leg2)}` );
          break;
        case 4:
          alert( `cos : ${cos(leg1, leg2)} ` );
          break;
        case 5:
          alert( `sin : ${sin(leg1, leg2)} ` );
          break;
        case 6:
          alert( `tg : ${tg(leg1, leg2)} ` );
          break;
        case 7:
            alert( `ctg : ${ctg(leg1, leg2)} ` );
            break;
         case 0:
          break;
        default:
          alert( "Введено некорректное значение" );
    }
}