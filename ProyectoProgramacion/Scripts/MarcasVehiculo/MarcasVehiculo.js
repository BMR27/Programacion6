﻿//Document ready
$(function () {
    ValidarRegistroVehiculo();
    EventoChange();
    ConsultarListaMarcas();
    ConsultarListaPais();
    ConsultarListaFabricante();
    CapturarDatosFormulario();
});

//VALIDAR FORMULARIO
function ValidarRegistroVehiculo() {
    $("#frmRegistroMarca").validate(
        {
            rules: {
                C_NOMBRE_MARCA: {
                    required: true,
                    maxlength: 60,
                    minlength: 1
                },
                Pais: {
                    required: true
                },
                Fabricantes: {
                    required: true
                }

            }

        }
    );
}
//CAPTURAMOS LOS DATOS DEL FORMULARIO
function CapturarDatosFormulario() {
    $("#btnRegistrar").click(function () {
        //CAPTURMAOS LOS DATOS SELECCIONADOS
        var Fabricante = $("#Pais").val()
        var Nombre = $("#C_NOMBRE_MARCA").val()
        /////construir la dirección del método del servidor
        var urlMetodo = '/MarcaVehiculo/RegistrarMarca'
        var parametros = {
            C_NOMBRE_MARCA: Nombre,
            C_FK_FABRICANTE: Fabricante
        };
        var funcion = MostrarResultadoRegistro;
        ///ejecuta la función $.ajax utilizando un método genérico
        //para no declarar toda la instrucción siempre
        ejecutaAjax(urlMetodo, parametros, funcion);
    });
}
function MostrarResultadoRegistro(data) {
    alert(data.resultado);
}


/*Eventos change*/
function EventoChange() {
    $("#Pais").change(function () {
        var pais = $("#Pais").val();
        ConsultarListaFabricante(pais);
    });
}

/*consulta la lista de marcas*/
function ConsultarListaMarcas() {
    /////construir la dirección del método del servidor
    var urlMetodo = '/MarcaVehiculo/ListaMarcas'
    var parametros = {};
    var funcion = creaGrid;
    ///ejecuta la función $.ajax utilizando un método genérico
    //para no declarar toda la instrucción siempre
    ejecutaAjax(urlMetodo, parametros, funcion);
}
//Funcion para cargar el grid
function creaGrid(data) {
    $("#divListaMarcas").kendoGrid({
        dataSource: {
            data: data.resultado,    
            pageSize: 3
        },
        pageable: true,
        columnMenu: true,
        sortable: true,
        toolbar: ["search"],
        columns: [
            {
                field: 'C_ID_MARCA',
                title: 'Id Marca'
            },
            {
                field: 'C_NOMBRE_MARCA',
                title:'Nombre'
            },
            {
                title: 'Acciones',
                template: function (dataItem) {
                    return "<a href='/Vehiculo/ModificarVehiculo?C_PLACA=" + dataItem.C_PLACA + "'>Modificar</a>"
                }
            }
        ]


    });
}

//Funcion que carga los fabricantes
function ConsultarListaPais() {
    /////construir la dirección del método del servidor
    var urlMetodo = '/MarcaVehiculo/ListaPais'
    var parametros = {};
    var funcion = procesarResultadoPais;
    ///ejecuta la función $.ajax utilizando un método genérico
    //para no declarar toda la instrucción siempre
    ejecutaAjax(urlMetodo, parametros, funcion);
}

function procesarResultadoPais(data) {
    ///mediante un selector nos posicionamos sobre la lista de provincias
    var ddlPais = $("#Pais");
    ///"limpiamos" todas las opciones de la lista de provincias
    ddlPais.empty();

    ///empezamos a trabajar con los datos que nos retorna el servidor
    ///creamos la primera opción de la lista, con un valor vacío y el texto de "Seleecione un valor"
    var nuevaOpción = "<option value=''>Seleccione una Pais</option>";
    ///agregamos la opción al dropdownlist
    ddlPais.append(nuevaOpción);
    ///empezamos a recorerrer cada uno de los registros obtenidos
    $(data).each(function () {
        ///obtenemos el objeto de tipo Provincia haciendo uso de la claúsula "this"                        
        //ahora podemos acceder a todas las propiedades
        ///por ejemplo provinciaActual.nombre nos retorna el nombre de la provincia
        var paisActual = this;
        ///creamos la opción de la lista, con el valor del id de provioncia y el texto con el nomnbre
        nuevaOpción = "<option value='" + paisActual.C_ID_PAIS + "'>" + paisActual.C_NOMBRE_PAIS + "</option>";
        ///agregamos la opción al dropdownlist
        ddlPais.append(nuevaOpción);
    });
}
//FUNCION QUE CONSULTA LOS FABRICANTES
//Funcion que carga los fabricantes
function ConsultarListaFabricante(pais) {
    /////construir la dirección del método del servidor
    var urlMetodo = '/Vehiculo/RetornaFabricantes'
    var parametros = {
        C_ID_PAIS : pais
    };
    var funcion = ProcesaResultadoFabricantes;
    ///ejecuta la función $.ajax utilizando un método genérico
    //para no declarar toda la instrucción siempre
    ejecutaAjax(urlMetodo, parametros, funcion);
}
function ProcesaResultadoFabricantes(data) {
    var ddlFabricantes = $("#Fabricante");
    ddlFabricantes.empty();
    var nuevaAccion = "<option value=''>Seleccione un Fabricante</option>";
    ddlFabricantes.append(nuevaAccion);
    $(data).each(function () {
        var FabricanteActual = this;
        nuevaAccion = "<option value='" + FabricanteActual.C_ID_FABRICANTE + "'>" + FabricanteActual.C_NOMBRE_FABRICANTE + "</option>";
        ddlFabricantes.append(nuevaAccion);
    });
}