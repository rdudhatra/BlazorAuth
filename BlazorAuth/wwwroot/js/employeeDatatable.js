
//function initializeDataTable() {

//    $(document).ready(function () {
//        $('#Employees').dataTable({
//            "processing": true,
//            "serverSide": true,
//            "filter": true,
//            "ajax": {
//                "url": "/api/Employees",
//                "type": "POST",
//                "datatype": "json"
//            },
//            //visible property
//            "columnDefs": [{
//                //"targets": [0],
//                //"visible": false,
//                //"searchable": false,
//            },
//            {
//                "targets": [6],
//                "sorting": false,
//            },
//            {
//                "targets": [5],
//                "sorting": false,
//            }],

//            "columns": [
//                { "data": "id", "name": "Id", "autowidth": true },
//                { "data": "firstName", "name": "FirstName", "autowidth": true },
//                { "data": "lastName", "name": "LastName", "autowidth": true },
//                { "data": "contact", "name": "Contact", "autowidth": true },
//                { "data": "email", "name": "Email", "autowidth": true },

//                { "data": "dateOfBirth", "name": "Date Of Birth", "autowidth": true },
//                {
//                    "render": function (data, row) { return "<a href='#' class='btn btn-danger' onclick=DeleteCustomer('" + row.id + "'); >Delete</a>"; }
//                },

//            ]
//        });
//    });
//}

