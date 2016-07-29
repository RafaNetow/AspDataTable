$(document).ready(function () {

    var table = $("#TableMaster")
           .DataTable({

               "language":
       {
           "sProcessing": "Procesando...",
           "sLengthMenu": "Mostrar _MENU_ registros",
           "sZeroRecords": "No se encontraron resultados",
           "sEmptyTable": "Ningún dato disponible en esta tabla",
           "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
           "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
           "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
           "sInfoPostFix": "",
           "sSearch": "Buscar:",
           "sUrl": "",
           "sInfoThousands": ",",
           "sLoadingRecords": "Cargando...",
           "oPaginate": {
               "sFirst": "Primero",
               "sLast": "Último",
               "sNext": "Siguiente",
               "sPrevious": "Anterior"

           }
       },
               dom: 'Bfrtip',
               buttons: [
                    'excel', 'pdf'
               ]



           });





    $("#impButton")
        .on("click",
            function () {


                var array = [];

                var rows = table.rows({ search: 'applied' }).nodes();
                var rows2 = table.rows().nodes();

                console.log(rows);
                console.log(rows2);
                $('input[type="checkbox"]:checked', rows)
                      .each(function () {


                          var val = $(this).data("unidad");


                          console.log(val);
                          array.push(val);
                          console.log("checked");
                          console.log(array);


                      });



                console.log(array);
                $.ajax({
                    url: "/VesselVisit/MigrateData",
                    data: JSON.stringify(array),
                    type: "POST",
                    contentType: "application/json",
                    success: function (data) {
                        alert("todo bien ");
                        console.log("todo bien");
                    }
                });



            });




});





