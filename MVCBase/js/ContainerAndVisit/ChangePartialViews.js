$(document)
    .ready(function() {
        
        $(".changeView").click(function () {
          
         
            if (!$("#contact2").is(":visible")) {
                $("#contact2").show();
                $("#contact1").hide();
            
            } else {
                $("#contact2").hide();
                $("#contact1").show();
            }
        
        });
    });