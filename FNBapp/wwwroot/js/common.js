// Bootstrap modal functions
window.ShowConfirmationModal = function () {
    var modalElement = document.getElementById('bsConfirmationModal');
    if (modalElement) {
        var modal = new bootstrap.Modal(modalElement);
        modal.show();
    } else {
        console.error("Modal element not found");
    }
};

window.HideConfirmationModal = function () {
    var modalElement = document.getElementById('bsConfirmationModal');
    if (modalElement) {
        var modal = bootstrap.Modal.getInstance(modalElement);
        if (modal) {
            modal.hide();
        } else {
            console.error("Modal instance not found");
        }
    } else {
        console.error("Modal element not found");
    }
};