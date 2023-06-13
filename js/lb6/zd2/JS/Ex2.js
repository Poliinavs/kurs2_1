
let buttonAdd = document.querySelector(".Add");
let buttonRemove = document.querySelector(".Remove");
let buttonAddReady = document.querySelector(".AddReady");

let products = new Map();
var buttonsAddToBasket = document.querySelectorAll(".product-btn");
    buttonAdd.onclick = () => {
        let name = prompt("Введите название товара:");
        let price = Number(prompt("Введите цену товара:"));
        let pathToImg = prompt("Введите путь к изображению товара:");
        if (pathToImg == "") {
            pathToImg="C://instit//kurs2//js//lb6//zd2//image//comp1.jpg";
        }

        let product = new Product(name, price, pathToImg);
        product.Wrapper = document.querySelector(".products");
        products.set(product.ID, product);
        product.toHTML();
        buttonChangeBack();
    };

    buttonRemove.onclick = () => {
        let answer;
        answer = prompt("Введите id:")
        let product = products.get(Number(answer));
        if (product == undefined) {
            alert("Введено не существующее id")
        } else{
            alert("Товар успешно удален")
            product.Remove();
        }
       
    };

    buttonAddReady.onclick = () => {
        let name = "Comp"+id1;
        let price = 1499;
        let pathToImg = "C://instit//kurs2//js//lb6//zd2//image//comp1.jpg";
        let product = new Product(name, price, pathToImg);
        product.Name += " " + product.ID;
        product.Wrapper = document.querySelector(".products");
        products.set(product.ID, product);
        product.toHTML();
        buttonChangeBack () ;
    };
    
    function  buttonChangeBack () {
        let prods = Array.from(document.querySelectorAll(".product"));
        for (let i = 0; i < prods.length; i++) {
            if ((i + 1) % 2 != 0) {
                prods[i].style.backgroundColor = "grey";
            }
        }
    };

