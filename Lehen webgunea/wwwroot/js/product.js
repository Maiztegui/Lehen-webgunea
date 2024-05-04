var dataTable;

$(document).ready(function () {
    loadDataTable();
});

//para que la informacion aparezca en el datable
function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url : '/admin/product/getall' },
        "columns": [
        { data: 'title' , "width": "25%" },
            { data: 'isbn', "width": "15%" },
            { data: 'listPrice', "width": "10%" },
            { data: 'author', "width": "20%" },
            { data: 'category.name', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    //botones de editar y borrar
                    return `<div class="w-75 btn-group" role="group">
                   <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2">  <i class="bi bi-pencil-square"></i> Edit </a>
                   <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash3"></i> Delete </a>
                    </div>`
                }

               
            }

    ]

   });
}

//para que al darle a borrar salgo un aviso de confirmacion para borrar 
function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload(); // que al borrar la pagina se refreque
                    toastr.success(data.message);
                }
            })
        }
    });
}

