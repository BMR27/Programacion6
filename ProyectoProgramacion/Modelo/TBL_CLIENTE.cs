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
    using System.Collections.Generic;
    
    public partial class TBL_CLIENTE
    {
        public TBL_CLIENTE()
        {
            this.TBL_ENCABEZADO_FACTURA = new HashSet<TBL_ENCABEZADO_FACTURA>();
            this.TBL_VEHICULO_CLIENTE = new HashSet<TBL_VEHICULO_CLIENTE>();
        }
    
        public int C_ID_CLIENTE { get; set; }
        public string C_NOMBRE_CLIENTE { get; set; }
        public string C_CEDULA { get; set; }
        public int C_FK_PROVINCIA { get; set; }
        public int C_FK_CANTON { get; set; }
        public int C_FK_DISTRITO { get; set; }
        public string C_DIRECCION { get; set; }
        public string C_APELLIDO1 { get; set; }
        public string C_APELLIDO2 { get; set; }
        public string C_CORREO { get; set; }
        public string C_TELEFONO { get; set; }
    
        public virtual ICollection<TBL_ENCABEZADO_FACTURA> TBL_ENCABEZADO_FACTURA { get; set; }
        public virtual ICollection<TBL_VEHICULO_CLIENTE> TBL_VEHICULO_CLIENTE { get; set; }
    }
}