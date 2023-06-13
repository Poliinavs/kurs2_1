 // // 1.	Хранилище всего имеющегося товара в интернет-магазине представляет собой объект products. 
// //  Весь товар разделен на категории, одна из них «Обувь», которая в свою очередь делится на виды «Ботинки»,
// //   «Кроссовки», «Сандалии». О каждой паре обуви хранится следующая информация: уникальный номер товара, размер обуви, цвет, цена. 

class Product
{
  price=""
  constructor(id,number, name, price, size, color, sale = 0) {
    this.sale = 0;
    this.id = id;
    this.type = number;
    this.name = name;
    this.size = size;
    this.color = color;
    this.sale = sale;
    this.startPrice = price;
    this.finalCost=0;
  }
}

let products = [
  new Product(1,"Кроссовки", "Nike Air Forse", 150, 42, "black"),
  new Product(2,"Кроссовки", "Addidas 32", 200, 40, "black", 20),
  new Product(3,"Кроссовки", "Boot Sicker", 50, 42, "Бежевый"),
  new Product(2,"Ботинки", "Vance", 900, 36, "black",  30),
  new Product(3,"Сандали", "New Balance", 500, 38, "Бежевый",  10),
];
// // 4.	Каждый товар (пара обуви) из предыдущей задачи представляет собой однотипные объекты. Учитывая это, создайте объект товара с
//// помощью new, при этом свойства «id», «цвет» и «размер» 
////должны быть доступны только для чтения, свойство «id» не может быть удалено. 

Object.defineProperty(products, "name", { 
  writable: false,
  enumerable: true,
  configurable: true
});
Object.defineProperty(products, "size", { 
  writable: false,
  enumerable: true,
  configurable: true
});
Object.defineProperty(products, "id", {
  writable: false,
  enumerable: true,
  configurable: false
});


class ProductIterator {
  constructor(products) {
      this.index = -1;
      this.products = products.length
  }
  next() {
      if (this.index < products.length) {
          return { done: false, value: products[++this.index] };
      }
      else {
          return { done: true, value: null };
      }
  }
}
let iterator = new ProductIterator(products);
let prod=iterator.next();
console.log('---------------------------------------------------');
while(prod.done==false){
  console.log(prod.value);
  prod=iterator.next();
}

// // 3.	Реализуйте фильтр обуви по цене в заданном диапазоне, по заданному размеру, по заданному цвету. Выведите номера товаров, соответствующих заданному условию (фильтру).

function filtreByPrice() {
  var priceFrom= Number(100);
  var priceTo= Number(210);
  let arr = products.filter((value) => value.price >= priceFrom && value.price <= priceTo);
      console.log('Sorted by price: ');

  arr.forEach(element => {
    console.log('id: '+ element.id);
    console.log('Mark: '+ element.name);
    console.log('Price: '+ element.price);
  }); 
}

function filtreByColor() {
  let color = "black";
  let arr = products.filter((value) => value.color == color);
  console.log('Sorted by color: ');

  arr.forEach(element => {
    console.log('id: '+ element.id);
    console.log('Mark: '+ element.name);
    console.log('Color: '+ element.color);
  }); 
}

function filtreBySize() {
  let size = Number(42);
  let arr = products.filter((value) => value.size = size);
  console.log('Sorted by size: ');

  arr.forEach(element => {
    console.log('id: '+ element.id);
    console.log('Mark: '+ element.name);
    console.log('Size: '+ element.size);
  }); 
}

filtreBySize();
filtreByColor();
filtreByPrice();  

// // 5.	Добавьте в описание товара новые свойства: «скидка» и «конечная стоимость» (стоимость с учетом скидки). Добавьте геттер и сеттер для свойства «конечная стоимость», учитывая то, что свойства «скидка» и «конечная стоимость» взаимозависимые.
let shoes7 = new Product(2,"Кроссовки", "Addidas 32", 200, 40, "black", 20);
Object.defineProperty(shoes7, "finalCost", {

  get: function() {
    return Number(this.startPrice - (this.startPrice * this.sale / 100))
  },

  set: function(value) {
    }
});

alert(shoes7.finalCost);






// // 4.	Каждый товар (пара обуви) из предыдущей задачи представляет собой однотипные объекты. Учитывая это, создайте объект товара с помощью new, при этом свойства «id», «цвет» и «размер» должны быть доступны только для чтения, свойство «id» не может быть удалено. 

