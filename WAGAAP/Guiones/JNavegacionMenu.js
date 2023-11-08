window.onload = function () {
    const barraLateral = document.querySelector(".barraLateral");
    const cerarBarra = document.querySelector("#boton");
    //const logo = document.querySelector(".logo");
    cerarBarra.addEventListener("click", function () {
        barraLateral.classList.toggle("open")
        menuBtnChange()

        // Verificar si la barra lateral está abierta o cerrada
        //if (barraLateral.classList.contains("open")) {
        //    logo.style.width = "10%"; // Habilitar interacción con la imagen
        //} else {
        //    logo.style.width = "10%"; // Deshabilitar interacción con la imagen
        //}

    })
   


}