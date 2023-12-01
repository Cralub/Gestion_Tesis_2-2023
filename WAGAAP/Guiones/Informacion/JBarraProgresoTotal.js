
function actualizarBarraProgreso(valor) {
  
    const barra = document.getElementById('barra-progreso');
    const porcentaje = document.getElementById('porcentaje');
    barra.style.width = valor + '%';
    porcentaje.textContent = valor + '%';
}
//function actualizarProgreso(valor) {
//    const barraProgreso = document.getElementById("graficaEtapaActiva");
//    const lblValor = document.getElementById("lblValorActivo");
//    valor = Math.min(Math.max(valor, 0), 100);
//    const angulo = (valor / 100) * 360;
//    barraProgreso.style.background = `conic-gradient(#3fe03f ${angulo}deg, #f0f0f0 ${angulo}deg)`;
//    lblValor.textContent = valor + "%";
//}

//actualizarBarraProgreso(90);



