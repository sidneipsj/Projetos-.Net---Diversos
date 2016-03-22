var xml_string = "<CONSULTAR_CARTOES_PARAM><CREDENCIADO><CODACESSO>17</CODACESSO><SENHA>1111</SENHA></CREDENCIADO><NOME_CARTAO>6064213004465078</NOME_CARTAO></CONSULTAR_CARTOES_PARAM>" 

$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "http://localhost:12454/wsconvenio.asmx/MConsultarCartoes",
        data: xml_string,
        crossDomain: true,
        cache: false,
        dataType: XMLHttpRequest,
        success: function (data) {
            console.log(data);
            alert(data);
        },
        error: function (data) {
            console.log(data);
            alert("Unable to process your resquest at this time.");
        }
    });
});/**
 * Created by sidnei on 21/01/2016.
 */
