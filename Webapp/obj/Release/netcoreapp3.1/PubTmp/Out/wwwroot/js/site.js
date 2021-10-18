var myVar;
var myVar1;

function myFunction() {
    myVar = setTimeout(showPage, 2000);
    myVar = setTimeout(aos, 3000);

}

function showPage() {
    var at = document.getElementById("atomo");
    if (at != null && at != undefined) {
        at.style.display = "none"
    }
    var div = document.getElementById("myDiv");
    if (div != null && div != undefined) {
        div.style.display = "block";
    }

}


$('.owl-carousel').owlCarousel({
    rtl: true,
    loop: false,
    margin: 40,

    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 3
        },
        1000: {
            items: 5
        }
    }
})

function aos() {

    AOS.init({
        easing: "ease-in-out-sine",
        once: true
    });
}