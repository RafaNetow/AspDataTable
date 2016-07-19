$(document).ready(function () {

    var table = $("#TableVisit")
           .DataTable({
               
               "language":
       {
           "sProcessing":     "Procesando...",
           "sLengthMenu":     "Mostrar _MENU_ registros",
           "sZeroRecords":    "No se encontraron resultados",
           "sEmptyTable":     "Ningún dato disponible en esta tabla",
           "sInfo":           "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
           "sInfoEmpty":      "Mostrando registros del 0 al 0 de un total de 0 registros",
           "sInfoFiltered":   "(filtrado de un total de _MAX_ registros)",
           "sInfoPostFix":    "",
           "sSearch":         "Buscar:",
           "sUrl":            "",
           "sInfoThousands":  ",",
           "sLoadingRecords": "Cargando...",
           "oPaginate": {
               "sFirst":    "Primero",
               "sLast":     "Último",
               "sNext":     "Siguiente",
               "sPrevious": "Anterior"
     
           }
       }, 
               dom: 'Bfrtip',
               buttons: [
                    'excel', 'pdf'
               ]

             
           
           });
    var data = table
  .rows()
  .data();
   
    

 
    $("#impButton")
        .on("click",
            function() {

               var count = 0;
                var array = [];
             //  $('#TableVisit').find('tr').each(function () {
                $('#TableVisit').eq(0).find('tr').each(function () {
                    var row = $(this);
                    if (row.find('input[type="checkbox"]').is
                        (':checked')) {
                            console.log("estas cheked");
                            console.log(count);
                            array.push(count);
                       
                        }
                        count++;
                 
               });

               console.log(array);
                $.ajax({
                    url: "/VesselVisit/MigrateData",
                    data: JSON.stringify(array),
                    type: "POST",
                    contentType: "application/json",
                    success: function(data) {
                        alert("todo bien ");    
                        console.log("todo bien");
                    }
               });
                /*
                  var count = 0;
                  var objectsJson = [];
                  table.rows().every(function () {
                     if( this.data().find('input:checkbox'))
                      console.log(this.data());
  
  
                      */

                //  var val = this.$("input:").val();
                //      console.log(('#item_Id').attr('id'));
                //   var data =this.data.column[0];


            });

               
                /*
                ('#example tfoot th').each(function () {
                    var title = $(this).text();
                    $(this).html('<input type="text" placeholder="Search ' + title + '" />');
                });
                */
                //alert(data.);
         
});
  
    

$(function () {

    var specialElementHandlers = {
        '#editor': function (element, renderer) {
            return true;
        }
    };
    $('#cmd').click(function () {
        var doc = new jsPDF();
        doc.fromHTML($('#target').html(), 15, 15, {
            'width': 170, 'elementHandlers': specialElementHandlers
        });
        doc.save('sample-file.pdf');
    });
});

       
