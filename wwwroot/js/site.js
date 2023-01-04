// Loding spinner
$(function () {
    $("#loaderbody").addClass('hide');

    $(document).bind('ajaxStart', function () {
        $("#loaderbody").removeClass('hide');
    }).bind('ajaxStop', function () {
        $("#loaderbody").addClass('hide');
    });
});

// Open modal for creating/editting subscription
showInSubscriptionPopUp = (url, title) => {

    $.ajax({
        type: 'GET',
        url: url,
        success: function (res) {
            $('#form-modal .modal-body');
            $('#form-modal .modal-body').html(res);
            $('#form-modal .modal-title').html(title);
            $('#form-modal').modal('show');
        }
    });
}

// POST: new subscription
jQueryAjaxPost = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $("#view-all").html(res.html);
                    $("#form-modal .modal-body").html('');
                    $("#form-modal .modal-title").html('');
                    $("#form-modal").modal('hide');
                    Swal.fire({
                        title: 'Abonnement lagret',
                        icon: 'success',
                        timer: 1500
                    });

                } else
                    Swal.fire({
                        title: 'Noe gikk galt',
                        text: 'Abonnement er ikke lagret. Prøv igjen',
                        icon: 'error',
                        timer: 3000
                    });
                $("#form-modal").modal('hide');;
            },
            error: function (err) {
                console.log(err);
            }
        });

    } catch (e) {
        console.log(e);
    }

    // to prevent default form submit event
    return false;
}