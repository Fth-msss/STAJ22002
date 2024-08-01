

function SubmitButtonClick() {

  

    var form = document.getElementById('myForm');

    // Check if form exists
    if (!form) {
        console.error('Form not found');
        return;
    }

    // Create a FormData object from the form element
    var formData = new FormData(form);

    var rawdata = {}
    for (var pair of formData.entries()) {
        rawdata[pair[0]]=pair[1];
        console.log(pair[0] + ': ' + pair[1]);
    }

    console.log(rawdata);

    // Log the form data for demonstration purposes
    //for (var pair of formData.entries()) {
    //    console.log(pair[0] + ': ' + pair[1]);
    //}

    // Add your logic here to handle form submission, e.g., using fetch or XMLHttpRequest
    alert("Form data processed!");
}
