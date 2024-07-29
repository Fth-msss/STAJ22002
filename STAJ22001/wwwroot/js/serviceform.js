// Example JavaScript to handle form submission

function SubmitButtonClick() {


    var formData = new FormData(this);
    var data = {};
    formData.forEach((value, key) => {
        data[key] = value;
    });

    // Do something with the data (e.g., log it, send it to a server)
    console.log(data);

    // For demonstration purposes
    alert('Form submitted! Check the console for the data.');
}
