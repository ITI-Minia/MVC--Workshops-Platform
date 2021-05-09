$(function () {
    services();
    reviews();
    gallery();

    //user orders services
    var orders = $('.ordered');
    for (var order of orders) {
        $(`#${order.value} .left`).hide(500);
        $(`#${order.value} .right`).removeClass("d-none");
    }

    //last active tab
    $('a[data-toggle="tab"]').on('show.bs.tab', function (e) {
        localStorage.setItem('activeTab', $(e.target).attr('href'));
    });
    var activeTab = localStorage.getItem('activeTab');
    if (activeTab) {
        $('#workshopTab a[href="' + activeTab + '"]').tab('show');
    }

    $(".custom-file-input").on("change", function () {
        var fileName = $(this).val().split("\\").pop();
        $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
    });
});

$('#galleryLink').click(function () {
    $('#gallery-tab').addClass('active');
    $('#services-tab').removeClass('active');
    $('#reviews-tab').removeClass('active');

    $('#services').removeClass(['show', 'active']);
    $('#reviews').removeClass(['show', 'active']);
    $('#gallery').addClass(['show', 'active']);
});

function services(next = 0) {
    var index = eval($('#service-index').val());
    var count = eval($('#services .service-row').length);
    var services = $('#services .service-row');

    if (next == -1) index -= 4;
    else if (next == 0) index = 0;

    if (count > 2) {
        for (i = index + 2; i < count; i++) {
            $(services[i]).addClass('d-none');
        }
        for (i = 0; i < index; i++) {
            $(services[i]).addClass('d-none');
        }
        for (i = index; i < index + 2; i++) {
            $(services[i]).removeClass('d-none');
        }
    }

    index += 2;
    $('#service-index').val(index);

    if (index == 2)
        $('#prev').prop('disabled', true);
    else
        $('#prev').prop('disabled', false);

    if (index >= count)
        $('#next').prop('disabled', true);
    else
        $('#next').prop('disabled', false);
}

function reviews(next = 0) {
    var index = eval($('#review-index').val());
    var count = eval($('#reviews .reviews-row').length);
    var reviews = $('#reviews .reviews-row');

    if (next == -1) index -= 4;
    else if (next == 0) index = 0;

    if (count > 2) {
        for (i = index + 2; i < count; i++) {
            $(reviews[i]).addClass('d-none');
        }
        for (i = 0; i < index; i++) {
            $(reviews[i]).addClass('d-none');
        }
        for (i = index; i < index + 2; i++) {
            $(reviews[i]).removeClass('d-none');
        }
    }

    index += 2;
    $('#review-index').val(index);

    if (index == 2)
        $('#prev2').prop('disabled', true);
    else
        $('#prev2').prop('disabled', false);

    if (index >= count)
        $('#next2').prop('disabled', true);
    else
        $('#next2').prop('disabled', false);
}

function gallery(next = 0) {
    var index = eval($('#image-index').val());
    var count = eval($('#gallery .images-row').length);
    var images = $('#gallery .images-row');

    if (next == -1) index -= 6;
    else if (next == 0) index = 0;

    if (count > 3) {
        for (i = index + 3; i < count; i++) {
            $(images[i]).addClass('d-none');
        }
        for (i = 0; i < index; i++) {
            $(images[i]).addClass('d-none');
        }
        for (i = index; i < index + 3; i++) {
            $(images[i]).removeClass('d-none');
        }
    }

    index += 3;
    $('#image-index').val(index);

    if (index == 3)
        $('#prev3').prop('disabled', true);
    else
        $('#prev3').prop('disabled', false);

    if (index >= count)
        $('#next3').prop('disabled', true);
    else
        $('#next3').prop('disabled', false);
}

function buyClicked(id) {
    $.ajax({
        type: "GET",
        url: `/WorkShops/AddUserService/${id}`,
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: function (response) {
            $(`#${id} .left`).hide(500);
            $(`#${id} .right`).removeClass("d-none");

            var count = Number($('#service-count').html())
            $('#service-count').html(count + 1);

            $('#cart-dropdown').html(response);
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}

function removeClicked(id) {
    $.ajax({
        type: "GET",
        url: `/WorkShops/RemoveUserService/${id}`,
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: function (response) {
            $(`#${id} .left`).slideDown();
            $(`#${id} .right`).addClass("d-none");

            var count = Number($('#service-count').html())
            $('#service-count').html(count - 1);

            $('#cart-dropdown').html(response);
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}

function imageModal(button) {
    var img = $(button).children()[0];
    $('#modal-img').attr('src', $(img).attr('src'));
}

function removeImage(id) {
    $.ajax({
        type: "GET",
        url: `/WorkShops/RemoveImage/${id}`,
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: function (response) {
            document.getElementById('imge-header').style.backgroundImage = "";
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}

function removeLogo(id) {
    $.ajax({
        type: "GET",
        url: `/WorkShops/RemoveLogo/${id}`,
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: function (response) {
            $('#logo').attr('src', '/imgs/Workshop-logo-default.png');
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
}