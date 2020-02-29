
$(document).ready(function () {
    document.getElementById('1').style.display = "block";
    $('#btnUpload').on('click', function () {
        var fdata = new FormData();
        var files = $('#fUpload').prop("files");
        var txtdesc = document.getElementById("txtfiledesc").value;
        
        for (var i = 0; i < files.length; i++) {
            fdata.append("files", files[i]);
        }
        fdata.append("desc", txtdesc);
        if (files.length > 0) {
            $('#tblfile > tbody > tr > td').remove();
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
                        tr.append("<td>" + Result[i].id + "</td>");
                        tr.append("<td>" + Result[i].fileName + "</td>");
                        tr.append("<td>" + Result[i].description + "</td>");
                        tr.append("<td>_</td>");
                        tr.append("<td><input type='button' id='delfile' onClick='DeleteFile(" + Result[i].id + ")' class='btn btn-danger' value='Delete'/></td>");
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

function DeleteFile(id) {

    var fdata = new FormData();
    fdata.append("id", id);
    $('#tblfile > tbody > tr > td').remove();
    $.ajax({
        type: "POST",
        url: "/FileUpload/OnPostDelete?handler=Delete",
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
                tr.append("<td>" + Result[i].id + "</td>");
                tr.append("<td>" + Result[i].fileName + "</td>");
                tr.append("<td>" + Result[i].description + "</td>");
                tr.append("<td></td>");
                tr.append("<td><input type='button' id='delfile' onClick='DeleteFile(" + Result[i].id + ")' class='btn btn-danger' value='Delete'/></td>");
                $('#tblfile').append(tr);
            }
        }
    });
    $("#fUpload").val('');
    $("#txtfiledesc").val('');
}

function openTab(evt, tabname) {
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
    document.getElementById(tabname).style.display = "block";
    evt.currentTarget.className += " active";
}

/*------------------------------------------*/
new Vue({
    el: '#DivMember',
    methods: {
        showAlert(a) {
            if (event.target.classList.contains('btn__content')) return;
            this.teams.push(a);
            this.$refs.formDialog.close();
        }
    },
    data() {
        return {
         //   selected: [],
            teams: [],
            search: '',
            headers: [
                {
                    text: 'Employee Id',
                    align: 'left',
                    sortable: false,
                    value: 'emp_id'
                },
                { text: 'Employee Name', value: 'emp_name' },
                { text: 'Position', value: 'job' },
                { text: 'Department', value: 'dep' }
            ],
            employees: []
        }
    },
    mounted() {
        let vm = this;
        $.ajax({
            url: 'http://localhost:3000/data/',
            success(res) {
                console.log(res);
                vm.employees = res;
            }
        });
    }
})
/*-----------------------------------------*/

