// Configure Toastr options
toastr.options = {
    "closeButton": true,
    "progressBar": true,
    "positionClass": "toast-top-right",
    "timeOut": "3000"
};

// Define the ShowToastr object that matches your C# extension method
window.ShowToastr = {
    success: function (message) {
        toastr.success(message, 'Success');
    },
    error: function (message) {
        toastr.error(message, 'Error');
    },
    warning: function (message) {
        toastr.warning(message, 'Warning');
    },
    info: function (message) {
        toastr.info(message, 'Information');
    }
};

// Keep the existing ShowToast function for backward compatibility
window.ShowToast = function (type, message) {
    if (type === "success") {
        toastr.success(message);
    }
    if (type === "error") {
        toastr.error(message);
    }
};

    //// Display a warning toast, with no title
    //toastr.warning('My name is Inigo Montoya. You killed my father, prepare to die!')

    //// Display a success toast, with a title
    //toastr.success('Have fun storming the castle!', 'Miracle Max Says')

    //// Display an error toast, with a title
    //toastr.error('I do not think that word means what you think it means.', 'Inconceivable!')

    //// Immediately remove current toasts without using animation
    //toastr.remove()

    //// Remove current toasts using animation
    //toastr.clear()

    //// Override global options
    //toastr.success('We do have the Kapua suite available.', 'Turtle Bay Resort', { timeOut: 5000 })