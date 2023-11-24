const archivoInput = document.getElementById('archivo-input');

cargarBtn.addEventListener('click', () => {
    archivoInput.click();
});

archivoInput.addEventListener('change', () => {
    const archivoSeleccionado = archivoInput.files[0];
    if (archivoSeleccionado) {
        if (archivoSeleccionado.name.endsWith('.docx')) {
            alert('Has seleccionado un documento Word válido: ' + archivoSeleccionado.name);
            // Aquí puedes realizar acciones adicionales con el archivo seleccionado.
        } else {
            alert('Por favor, selecciona un archivo Word válido (.docx).');
        }
    }
});
