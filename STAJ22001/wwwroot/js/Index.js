
function searchButtonClick() {

}


function handleInputChange() {

    var input = document.getElementById("userInput").value.toLowerCase();
    // Get the table rows
    var rows = document.querySelectorAll("#DataTable tr");
    var noResultsRow = document.getElementById("noResultsRow"); // The placeholder row
    var visibleRowCount = 0;

    // Loop through the rows (starting from index 1 to skip the header row)
    for (var i = 1; i < rows.length; i++) {
        var row = rows[i];
        if (row.id === "noResultsRow") {
            continue;
        }

        var serviceName = row.cells[0].textContent.toLowerCase();
        var type        = row.cells[1].textContent.toLowerCase(); 
        var path        = row.cells[2].textContent.toLowerCase(); 

        // Check if the input matches the service name, show or hide the row
        if (serviceName.includes(input) || type.includes(input) || path.includes(input)) {
            row.style.display = ""; // Show row
            visibleRowCount++;
        } else {
            row.style.display = "none"; // Hide row
        }


    }

    if (visibleRowCount === 0) {
        noResultsRow.style.display = ""; // Show the "No results" row
    } else {
        noResultsRow.style.display = "none"; // Hide the "No results" row
    }
}