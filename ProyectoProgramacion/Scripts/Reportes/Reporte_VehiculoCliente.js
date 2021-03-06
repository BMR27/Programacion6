﻿//Document ready
$(function () {
    //ConsultarListaServicios();
    //OcultarAlertasBotones();
    //CapturarDatosFormulario();
    MostrarClientes();
    //ObetenerDatoGrid();
    EventoClick();
});

function EventoClick() {
    $("#btnConsultar").on("click", function () {
        ConsultarListaVehiculos();
    });
}


//FUNCION MUESTRA LOS CLIENTES
function MostrarClientes() {
    var urlMetodo = '/Factura/MostrarClientes'
    var parametros = {};
    var funcion = procesarResultadoCliente;
    ejecutaAjax(urlMetodo, parametros, funcion);
}

function procesarResultadoCliente(data) {
    var ddlCliente = $("#cliente");
    ddlCliente.empty();
    var nuevaOpción = "<option value=''>Seleccione una Cliente</option>";
    ddlCliente.append(nuevaOpción);
    $(data).each(function () {
        var ClienteActual = this;
        nuevaOpción = "<option value='" + ClienteActual.C_ID_CLIENTE + "'>" + ClienteActual.C_NOMBRE_CLIENTE + " " + ClienteActual.C_APELLIDO1 + " " + ClienteActual.C_APELLIDO2 + "</option>";
        ddlCliente.append(nuevaOpción);
    });
}
//OCULTAR ALERTAS Y BOTONES
function OcultarAlertasBotones() {
    $("#AlertaExito").hide();
    $("#divIdServicio").hide();
    $("#divAlertaElimina").hide();
}


//VALIDAR FORMULARIO
function ValidarRegistroCliente() {
    $("#frmReportes_Servicios").validate(
        {
            rules: {
                C_NOMBRE_CLIENTE: {
                    required: true,
                    maxlength: 60,
                    minlength: 1
                }

            }



        }
    );
}


/*consulta la lista de paises*/
function ConsultarListaVehiculos() {
    /////construir la dirección del método del servidor
    var urlMetodo = '/Reporte_VehiculoCliente_/MostrarVehiculos'
    var parametros = {
        C_ID_CLIENTE: $("#cliente").val()
    };
    var funcion = creaGrid;
    ///ejecuta la función $.ajax utilizando un método genérico
    //para no declarar toda la instrucción siempre
    ejecutaAjax(urlMetodo, parametros, funcion);
}
//Funcion para cargar el grid
function creaGrid(data) {
    $("#divListaVehiculos").kendoGrid({
        dataSource: {
            data: data.resultado,
            pageSize: 15
        },
        pageable: true,
        columnMenu: true,
        sortable: true,
        selectable: "multiple",
        toolbar: ["search"],
        columns: [
            {
                field: 'C_NOMBRE_MODELO',
                title: 'Nombre Modelo'
            },
            {
                field: 'C_NOMBRE_MARCA',
                title: 'Nombre Marca'
            },
            {
                field: 'C_PLACA',
                title: 'Placa'
            },
            {
                field: 'C_CANT_PUERTAS',
                title: 'Cantidad de Puertas'
            },
            {
                field: 'C_YEAR',
                title: 'Año'
            }

        ]


    });
}

