
function searchButtonClick() {

}

function searchInputChange(input) {

}

function handleInputChange() {

    var input = document.getElementById("userInput").value.toLowerCase();
    // Get the table rows
    var rows = document.querySelectorAll("#DataTable tr");

    // Loop through the rows (starting from index 1 to skip the header row)
    for (var i = 1; i < rows.length; i++) {
        var row = rows[i];
        var serviceName = row.cells[0].textContent.toLowerCase(); // Get the Service name from the first cell
        var type = row.cells[1].textContent.toLowerCase(); // Get the Service name from the first cell
        var path = row.cells[2].textContent.toLowerCase(); // Get the Service name from the first cell

        // Check if the input matches the service name, show or hide the row
        if (serviceName.includes(input) || type.includes(input) || path.includes(input)) {
            row.style.display = ""; // Show row
        } else {
            row.style.display = "none"; // Hide row
        }


    }
}