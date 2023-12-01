const filter1Select = document.getElementById('filter1');
const filter2Select = document.getElementById('filter2');
const filter3Select = document.getElementById('filter3');
const searchInput = document.getElementById('searchInput');
const dataTable = document.getElementById('dataTable');

filter1Select.addEventListener('change', applyFilters);
filter2Select.addEventListener('change', applyFilters);
filter3Select.addEventListener('change', applyFilters);
searchInput.addEventListener('input', applyFilters);

function applyFilters() {
    const filter1Value = filter1Select.value;
    const filter2Value = filter2Select.value.toLowerCase();
    const filter3Value = filter3Select.value.toLowerCase();
    const searchText = searchInput.value.toLowerCase();

    const rows = dataTable.getElementsByTagName('tr');

    for (let i = 1; i < rows.length; i++) {
        const row = rows[i];
        const dataCells = row.getElementsByTagName('td');
        const value1 = dataCells[4].textContent.toLowerCase();
        const value2 = dataCells[3].textContent.toLowerCase();
        const value3 = dataCells[2].textContent.toLowerCase();

        const filter1Match = filter1Value === 'activo' || value1 === filter1Value;
        const filter2Match = filter2Value === 'etapa' || value2 === filter2Value;
        const filter3Match = filter3Value === 'tipo' || value3 === filter3Value;
        const searchMatch = value1.includes(searchText) || value2.includes(searchText) || value3.includes(searchText);

        if (filter1Match || filter2Match || filter3Match || searchMatch) {
            row.style.display = '';
            applyFilters();
        }
        else {
            row.style.display = 'none';
            applyFilters();
        }
    }
}