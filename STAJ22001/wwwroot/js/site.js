// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//table making

var tableData = [];

function createTable() {
    var table = document.getElementById("myTable");
    //var columnsInput = document.getElementById("columns");
    var rowsInput = document.getElementById("rows").value;
    var columns = 3;

    // Clear existing table
   
   
    // Loop through the rows and remove each one
    //dont remove the first one as its the header
 

    for (var i = 1; i < table.rows.length; i++) {
        table.deleteRow(i);
    }

    for (var i = 0; i < rowsInput; i++)
    {
        var row = table.insertRow(i+1);
        var cell1 = row.insertCell(0);
        var cell2 = row.insertCell(1);
        var cell3 = row.insertCell(2);
        var cell4 = row.insertCell(3);
        var cell5 = row.insertCell(4);

        cell1.innerHTML = table.rows.length -1;
        cell2.innerHTML = "a slightly longer text";
        cell3.innerHTML = "A VERY LONG DESCRIPTION A VERY LONG DESCRIPTIONA VERY LONG DESCRIPTIONA VERY LONG DESCRIPTION";
        cell4.innerHTML = '<button class="remove-btn">modify</button>';
        cell5.innerHTML = '<button class="remove-btn">Remove</button>';
       
    }

    // Create table rows
    //for (var i = 0; i < rows; i++) {
    //    var rowData = [];
    //    var row = document.createElement("tr");
    //    for (var j = 0; j < columns; j++) {
    //        var cell = document.createElement("td");
    //        cell.setAttribute("contenteditable", "true");
    //        cell.setAttribute("class", "editable-cell");
    //        cell.addEventListener("input", updateCell);
    //        rowData.push("");
    //        row.appendChild(cell);
    //    }
    //    table.appendChild(row);
    //    tableData.push(rowData);
    //}
    
}

function updateCell(event) {
    var rowIndex = event.target.parentNode.rowIndex - 1;
    var columnIndex = event.target.cellIndex;
    var value = event.target.textContent.trim();
    updateData(rowIndex, columnIndex, value);
}

function updateData(row, col, value) {
    tableData[row][col] = value;
}

function deleteRow(row) {
    var table = document.getElementById("myTable");
    table.deleteRow(row);
    tableData.splice(row, 1);
}

function updateRow(row) {
    var table = document.getElementById("myTable");
    var rowData = tableData[row];
    var cells = table.rows[row + 1].cells;
    for (var i = 0; i < rowData.length; i++) {
        var value = cells[i].textContent.trim();
        rowData[i] = value;
    }
}

function displayData() {
    console.log(tableData);
}