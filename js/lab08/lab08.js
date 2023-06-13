$(document).ready(function(){
    // когда нажим ищменяется белый фон
    $(".dws-form").on("click",".tab",function(){
        //удаление класса active
        $(".dws-form ").find(".active").removeClass("active");
        //добавляем active белым становится то, к чему обратились 

        $(this).addClass("active");

        $(".tab-form").eq($(this).index()).addClass("active"); //eq добавляем к текущему индексу

    })
});


// var form = document.querySelectorAll(".tab2 ");
// //var email_valid=form.querySelector('.tab2')

// // form.addEventListener('submit', function (){
// //     console.log('clicked on validate')
// // })

// form.addEventListener('email', function (){
//     // event.preventDefault()
//      console.log('ddd')

// });

