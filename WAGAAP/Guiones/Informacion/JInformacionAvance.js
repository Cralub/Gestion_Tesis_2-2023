let porcentaje = 0;
const progresoBarra = document.getElementById('barra-progreso');
const porcentajeElemento = document.getElementById('porcentaje');
const divs = [document.getElementById("Div1"), document.getElementById("Div2"), document.getElementById("Div3"), document.getElementById("Div4")]

function actualizarProgresoBarra() {
    progresoBarra.style.width = porcentaje + '%';
    porcentajeElemento.textContent = porcentaje + '%';
}

function incrementoProgreso() {
    if (porcentaje < 100) {
        porcentaje += 10;
        actualizarProgresoBarra();
    }
}

function decrementoProgreso() {
    if (porcentaje > 0) {
        porcentaje -= 10;
        actualizarProgresoBarra();
    }
}

function mostrarDiv(indice) {
    // Ocultar todos los divs
    divs.forEach(div => div.style.display = 'none');

    // Mostrar el div solicitado
    divs[indice].style.display = 'block';
}

