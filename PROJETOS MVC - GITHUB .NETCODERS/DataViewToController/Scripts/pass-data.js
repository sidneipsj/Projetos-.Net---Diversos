$(function () {
    $('#ajax_method').click(function (e) {
        e.preventDefault();

		$.ajax({
			type: "POST",   
			url: "test/Ajax",                            //Your Action name in the DropDownListConstroller.cs
		    data: "{'AJAXParameter1':'" + $('#selectedLanguange').val() + "','AJAXParameter2':'" + $('#selectedLanguange').val() + "'}",  //Parameter in this function, Is case sensitive and also type must be string
			contentType: "application/json; charset=utf-8",
			dataType: "json"

		}).done(function (data) {
			//Successfully pass to server and get response
			if (data.result="OK") { 
			    alert("submit successfully."); 
			}
		}).fail(function (response) {
			if (response.status != 0) {
				alert(response.status + " " + response.statusText);
			}
		});
	});

});