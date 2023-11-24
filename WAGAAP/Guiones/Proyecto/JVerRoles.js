const searchInput = document.getElementById('txtBusqueda');

searchInput.addEventListener('input', applyFilters);

function applyFilters() {
    const searchText = searchInput.value.toLowerCase();

    const rows = document.querySelectorAll('.tabla-split2 table tr');

    rows.forEach((row) => {
        const dataCells = row.getElementsByTagName('td');
        const value1 = dataCells[0].textContent.toLowerCase();
        const value2 = dataCells[1].textContent.toLowerCase();

        const searchMatch = value1.includes(searchText) || value2.includes(searchText);

        if (searchMatch) {
            row.style.display = '';
        } else {
            row.style.display = 'none';
        }
    });
}