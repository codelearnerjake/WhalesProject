var whaleId = 0;

function AddOrUpdate(id) {
    $("#addEditModal").show(); 

    if (id != null) {
        whaleId = id;
        var dietNum = 0;
        var diet = $(`#${whaleId} .diet`).html();

        if (diet == "Squid") {
            dietNum = 1;
        }
        else if (diet == "Other") {
            dietNum = 2;
        }

        $("#name").val($(`#${whaleId} .name`).html());
        $("#size").val($(`#${whaleId} .size`).html());
        $("#description").val($(`#${whaleId} .description`).html());
        $("#diet").val(dietNum);
    }
}

function Delete(id) {
    var data = {};
    data.id = id;

    $.ajax({
        type: "DELETE",
        url: "/WhaleController/Delete",
        data: JSON.stringify(data),
        contentType: "application/json",
        dataType: 'json',
        success: function (result) {
            window.location.reload(true);
        },
        error: function (req, status, error) {
            alert("Error Deleting Whale");
        }
    });
}

function Save() {
    var data = {};
    if (whaleId != 0) {
        data.id = whaleId;
    }
    data.name = $("#name").val();
    data.averageSize = $("#size").val();
    data.description = $("#description").val();
    data.diet = parseInt($("#diet").val());

    $.ajax({
        type: "POST",
        url: "/WhaleController/Save",
        data: JSON.stringify(data),
        contentType: "application/json",
        dataType: 'json',
        success: function (result) {
            window.location.reload(true);
        },
        error: function (req, status, error) {
            alert("Error Deleting Whale");
        }
    });
}

function Cancel() {
    $("#addEditModal").hide(); 

    $("#name").val("");
    $("#size").val("");
    $("#description").val("");
    $("#diet").val(0);
}