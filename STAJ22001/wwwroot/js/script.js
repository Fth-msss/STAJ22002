//anasayfa kodu

function newPageButtonClick() {
    alert('yeni sayfa  button');
}

function searchButtonClick() {
    alert('search button');
}

function modifyRowButtonClick() {
    alert('modify row button');
}

function deleteRowButtonClick() {
    alert('delete row button');
}

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
        console.log(table.rows());
        

    }

    for (var i = 0; i < rowsInput; i++) {
        var row = table.insertRow(i + 1);
        var cell1 = row.insertCell(0);
        var cell2 = row.insertCell(1);
        var cell3 = row.insertCell(2);
        var cell4 = row.insertCell(3);
        var cell5 = row.insertCell(4);

        cell1.innerHTML = table.rows.length - 1;
        cell2.innerHTML = "a slightly longer text";
        cell3.innerHTML = "A VERY LONG DESCRIPTION A VERY LONG DESCRIPTIONA VERY LONG DESCRIPTIONA VERY LONG DESCRIPTION";
        cell4.innerHTML = '<button class="remove-btn">modify</button>';
        cell5.innerHTML = '<button class="remove-btn">Remove</button>';

    }

}

function modifyRow(button) {
    var row = button.parentNode.parentNode;
    alert('Modify row: ' + row.rowIndex);
}

function removeRow(button) {
    var row = button.parentNode.parentNode;
    row.parentNode.removeChild(row);
}