var task = task || {};

task.remove = function (id, invoker) {
    $.ajax({
        url: "/Task/Remove",
        dataType: "json",
        method: "POST",
        data: { "id": id },
        success: function () {
            invoker.closest('tr').remove();
        }
    });
}

