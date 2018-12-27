var confirmacion = function (x) {
    var boton = x.name;
    if (Page_ClientValidate("Proyecto")) {
        event.preventDefault();
        bootbox.confirm("Seguro?", function (result) {
            if (result)
            { __doPostBack('ctl00$ContentPlaceHolder1$btnGuardar', '__EVENTARGUMENT'); }
        });
    }
};