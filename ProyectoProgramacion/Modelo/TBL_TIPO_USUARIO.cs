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
    
    public partial class TBL_TIPO_USUARIO
    {
        public TBL_TIPO_USUARIO()
        {
            this.TBL_USUARIOS = new HashSet<TBL_USUARIOS>();
        }
    
        public int C_ID_TIPO_USUARIO { get; set; }
        public string C_NOMBRE_TIPO_USUARIO { get; set; }
    
        public virtual ICollection<TBL_USUARIOS> TBL_USUARIOS { get; set; }
    }
}
