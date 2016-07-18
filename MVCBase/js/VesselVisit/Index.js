$(document).ready(function() {
        $("#TableVisit")
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
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
             
           
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
       
});