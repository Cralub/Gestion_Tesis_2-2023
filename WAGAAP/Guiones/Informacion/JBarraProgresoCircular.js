
function actualizarProgreso(valor) {
    const barraProgreso = document.getElementById("graficaEtapaActiva");
    const lblValor = document.getElementById("lblValorActivo");
    valor = Math.min(Math.max(valor, 0), 100);
    const angulo = (valor / 100) * 360;
    barraProgreso.style.background = `conic-gradient(#0E7116 ${angulo}deg, #f0f0f0 ${angulo}deg)`;
    lblValor.textContent = valor + "%";
}

//actualizarProgreso(50);
