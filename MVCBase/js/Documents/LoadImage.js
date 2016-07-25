$(document)
    .ready(function() {
        $.fn.MessageBox = function(msg) {
            alert(msg);
        };
       

               
        $("#LoadImage").change(
                          function() {
                              console.log("Called");
                              
                          });
    });

function saveId(id) {
    console.log(id);
    $.ajax({
        url: "/Documents/ShowDocuments",
        data: JSON.stringify([id]),
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            alert("todo bien ");
            console.log("todo bien");
        }
    });



    /*
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


    */
    
}
