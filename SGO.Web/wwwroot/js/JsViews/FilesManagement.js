$(document).ready(function () {
    $('#btnUpload').on('click', function () {
        var files = $('#fUpload').prop("files");
        var fdata = new FormData();
        
        var txtdesc = document.getElementById("txtfiledesc").value;
        console.log(txtdesc);
        for (var i = 0; i < files.length; i++) {
            fdata.append("files", files[i]);
        }
        fdata.append("desc", txtdesc);
        if (files.length > 0) {
            $('#tblfile > tr >td').remove();
            $.ajax({
                type: "POST",
                url: "/FileUpload/OnPostUpload?handler=Upload",
                beforeSend: function (xhr) {
                    xhr.setRequestHeader("XSRF-TOKEN",
                        $('input:hidden[name="__RequestVerificationToken"]').val());
                },
                data: fdata,
                contentType: false,
                processData: false,
                success: function (response) {
                    var Result = response;
                    console.log(Result);
                    var tr;
                    for (var i = 0; i < Result.length; i++) {
                        tr = $('<tr/>');
                        tr.append("<td><input type='submit' id='delfile' class='btn btn-danger' value='Delete'/></td>");
                        tr.append("<td>" + Result[i].fileName + "</td>");
                        tr.append("<td>" + Result[i].description +"</td>");
                        tr.append("<td></td>");
                        $('#tblfile').append(tr);
                    }
                }
            });
            $("#fUpload").val('');
            $("#txtfiledesc").val('');
        }
        else {
            alert('Please select a file.');
        }
    });
});

function DeleteFile() {

}