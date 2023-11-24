window.onload = function () {
    const barraLateral = document.querySelector(".barraLateral");
    const cerarBarra = document.querySelector("#boton");
    cerarBarra.addEventListener("click", function () {
        barraLateral.classList.toggle("open")
        //menuBtnChange()
    });



}