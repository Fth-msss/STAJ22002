function searchButtonClick() {


    alert('search buttonjaja');
}

async function deleteTableRowButton(param)
{

    console.log("delete", param);


}

function edittableRowButton(param)
{
    console.log("update",param);
}

function createTable() {


    var table = document.getElementById("DataTable");
    //var columnsInput = document.getElementById("columns");
    var rowsInput = document.getElementById("rows").value;

    for (var i = 0; i < rowsInput; i++) {
        var row = table.insertRow(i + 1);
        var cell1 = row.insertCell(0);
        var cell2 = row.insertCell(1);
        var cell3 = row.insertCell(2);
        var cell4 = row.insertCell(3);

        cell1.innerHTML = table.rows.length - 1;
        cell2.innerHTML = "123";
        cell3.innerHTML = "456";
        cell4.innerHTML = '<button class="remove-btn">modify</button> < button class="remove-btn" > Remove</button >';

    }

}