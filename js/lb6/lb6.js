//Выведите: свойства, которые отличают фигуру «зеленый круг»; 
//свойства, которые описывают фигуру «треугольник с тремя линиями»;
//есть ли у фигуры «маленький квадрат» собственное свойство, которое определяет цвет фигуры.

let circle  = {
    name: "Белый круг",
    radius: 15,
    color: "white",
    
}
let cyrcle2 =
{
    countLinesIn: 3
}
let cyrcle1  = 
{
    border: "1px solid black"
};

cyrcle1.__proto__ = circle;
cyrcle2.__proto__ = circle;

let triangle1  =
{
    name: "Белый треугольник с одной полосой посередине",
    base: 10,
    height: 5,
    color: "red",
    border: "1px solid black",
    countLinesIn: 1
};

let square2  = {
    name: "Желтый маленький квадрат",
    edge: 5,
    color: "yellow",
    border: "1px solid black"
};



let triangle2  =
{
    name: "Белый треугольник с тремя полосами посередине",
    base: 10,
    height: 5,
    color: "red",
    border: "1px solid black",
    countLinesIn: 1
};

let figures  = 
[
    cyrcle1, 
    triangle1, 
    square2, 
    cyrcle2,
    triangle2
];
console.log("\\\\\\\\\\\\\\\\");
let propsOfGreenCyrcle = Object.keys(triangle2);
for(let prop of propsOfGreenCyrcle)
{
  let Unick  = square2.hasOwnProperty(prop); 
    if (!Unick) {
      console.log(prop); 
    } 
}
console.log("\n");
//let propsOfGreenCyrcle = Object.keys(cyrcle2);

for(let i = 0; i < figures.length; i++)
{
    console.log("Зеленый круг отличается свойствами от " + figures[i].name + ":\n");
    for(let prop of propsOfGreenCyrcle)
    {
      let Unick  = figures[i].hasOwnProperty(prop); 
        if (!Unick) {
          console.log(prop); 
        } 
    }
    console.log("\n");
}

// свойства, которые описывают фигуру «треугольник с тремя линиями»

console.log("свойства, которые описывают фигуру «треугольник с тремя линиями»");
Object.keys(triangle2).forEach((prop) => {
    console.log(prop);
});

// есть ли у фигуры «маленький квадрат» собственное свойство, которое определяет цвет фигуры.

console.log("есть ли у фигуры «маленький квадрат» собственное свойство, которое определяет цвет фигуры?");
Object.keys(square2).forEach(prop => {
    if(prop === "color")
    {
        console.log("Есть");
    }
});