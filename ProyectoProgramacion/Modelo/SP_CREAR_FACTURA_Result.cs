//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoProgramacion.Modelo
{
    using System;
    
    public partial class SP_CREAR_FACTURA_Result
    {
        public int C_ID_ENCABEZADO_FACTURA { get; set; }
        public int C_FK_CLIENTE { get; set; }
        public int C_FK_VEHICULO { get; set; }
        public System.DateTime C_FECHA { get; set; }
        public decimal C_SUBTOTAL { get; set; }
        public decimal C_TOTAL { get; set; }
        public decimal C_TOTAL_IMPUESTO { get; set; }
        public bool C_ESTADO { get; set; }
    }
}
