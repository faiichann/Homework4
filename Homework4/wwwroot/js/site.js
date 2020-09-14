var loadFile = function (event) {
    var show = document.getElementById('show');
    show.src = URL.createObjectURL(event.target.files[0]);
    show.onload = function () {
        URL.revokeObjectURL(show.src)
    }
};

function submitForm() {
    return confirm('Are You Sure to Apply this Form!!');
}