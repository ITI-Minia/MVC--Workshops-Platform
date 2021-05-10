$(function () {
    $('[data-toggle="tooltip"]').tooltip();

    var role = $('#UserRole')[0]
    if (role == null || role.value != "1") {
        console.log('notifications');
        setInterval(NotificationCount, 3000);
    }
})

function UserNotifications() {
    $.ajax({
        type: "GET",
        url: `/Home/UserNotifications`,
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: function (response) {
            $('#Notifications-center').html(response);
        }
    });
}

function NotificationCount() {
    $.ajax({
        type: "GET",
        url: `/Home/UnreadNotifications`,
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: function (response) {
            if (response == "0") {
                $('#notification-count').html("");
            }
            else
                $('#notification-count').html(response);
        }
    });
}

function ReadNotification(id) {
    $.ajax({
        type: "GET",
        url: `/Home/ReadNotification/${id}`,
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: function (response) {
        }
    });
}