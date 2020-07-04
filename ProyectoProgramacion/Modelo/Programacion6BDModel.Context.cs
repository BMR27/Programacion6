﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class programacion6Entities : DbContext
    {
        public programacion6Entities()
            : base("name=programacion6Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Canton> Canton { get; set; }
        public DbSet<Distrito> Distrito { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TBL_APERTURA_CIERRE_CAJA> TBL_APERTURA_CIERRE_CAJA { get; set; }
        public DbSet<TBL_BITACORA_ERRORES> TBL_BITACORA_ERRORES { get; set; }
        public DbSet<TBL_CLIENTE> TBL_CLIENTE { get; set; }
        public DbSet<TBL_DETALLE_ENCABEZADO_FACTURA> TBL_DETALLE_ENCABEZADO_FACTURA { get; set; }
        public DbSet<TBL_ENCABEZADO_FACTURA> TBL_ENCABEZADO_FACTURA { get; set; }
        public DbSet<TBL_FABRICANTES> TBL_FABRICANTES { get; set; }
        public DbSet<TBL_INGRESOS_USUARIOS> TBL_INGRESOS_USUARIOS { get; set; }
        public DbSet<TBL_MARCA> TBL_MARCA { get; set; }
        public DbSet<TBL_MODELO> TBL_MODELO { get; set; }
        public DbSet<TBL_PAIS> TBL_PAIS { get; set; }
        public DbSet<TBL_PARAMETROS> TBL_PARAMETROS { get; set; }
        public DbSet<TBL_SERVICIOS> TBL_SERVICIOS { get; set; }
        public DbSet<TBL_TIPO_MOVIMIENTO_CAJA> TBL_TIPO_MOVIMIENTO_CAJA { get; set; }
        public DbSet<TBL_TIPO_USUARIO> TBL_TIPO_USUARIO { get; set; }
        public DbSet<TBL_TIPO_VEHICULO> TBL_TIPO_VEHICULO { get; set; }
        public DbSet<TBL_USUARIOS> TBL_USUARIOS { get; set; }
        public DbSet<TBL_VEHICULO> TBL_VEHICULO { get; set; }
        public DbSet<TBL_VEHICULO_CLIENTE> TBL_VEHICULO_CLIENTE { get; set; }
    
        public virtual ObjectResult<RetornaCantones_Result> RetornaCantones(string nombre, Nullable<int> id_Provincia)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var id_ProvinciaParameter = id_Provincia.HasValue ?
                new ObjectParameter("id_Provincia", id_Provincia) :
                new ObjectParameter("id_Provincia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaCantones_Result>("RetornaCantones", nombreParameter, id_ProvinciaParameter);
        }
    
        public virtual ObjectResult<RetornaCantonesID_Result> RetornaCantonesID(Nullable<int> id_Canton)
        {
            var id_CantonParameter = id_Canton.HasValue ?
                new ObjectParameter("id_Canton", id_Canton) :
                new ObjectParameter("id_Canton", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaCantonesID_Result>("RetornaCantonesID", id_CantonParameter);
        }
    
        public virtual ObjectResult<RetornaDistrito_Result> RetornaDistrito(string nombre, Nullable<int> id_Canton)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var id_CantonParameter = id_Canton.HasValue ?
                new ObjectParameter("id_Canton", id_Canton) :
                new ObjectParameter("id_Canton", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaDistrito_Result>("RetornaDistrito", nombreParameter, id_CantonParameter);
        }
    
        public virtual ObjectResult<RetornaProvincias_Result> RetornaProvincias(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaProvincias_Result>("RetornaProvincias", nombreParameter);
        }
    
        public virtual int sp_Actualizar_Cliente(Nullable<int> iD_CLIENTE, string cEDULA, string nOMBRE, string aPELLIDO1, string aPELLIDO2, string tELEFONO, string cORREO, string dIRECCION)
        {
            var iD_CLIENTEParameter = iD_CLIENTE.HasValue ?
                new ObjectParameter("ID_CLIENTE", iD_CLIENTE) :
                new ObjectParameter("ID_CLIENTE", typeof(int));
    
            var cEDULAParameter = cEDULA != null ?
                new ObjectParameter("CEDULA", cEDULA) :
                new ObjectParameter("CEDULA", typeof(string));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPELLIDO1Parameter = aPELLIDO1 != null ?
                new ObjectParameter("APELLIDO1", aPELLIDO1) :
                new ObjectParameter("APELLIDO1", typeof(string));
    
            var aPELLIDO2Parameter = aPELLIDO2 != null ?
                new ObjectParameter("APELLIDO2", aPELLIDO2) :
                new ObjectParameter("APELLIDO2", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Actualizar_Cliente", iD_CLIENTEParameter, cEDULAParameter, nOMBREParameter, aPELLIDO1Parameter, aPELLIDO2Parameter, tELEFONOParameter, cORREOParameter, dIRECCIONParameter);
        }
    
        public virtual int sp_Actualizar_Vehiculo(Nullable<int> iD_VEHICULO, string pLACA, Nullable<int> iD_MARCA, Nullable<int> iD_TIPO, Nullable<int> iD_MODELO, Nullable<short> cANTIDAD_PUERTAS, Nullable<short> cANTIDAD_RUEDAS, string aÑO)
        {
            var iD_VEHICULOParameter = iD_VEHICULO.HasValue ?
                new ObjectParameter("ID_VEHICULO", iD_VEHICULO) :
                new ObjectParameter("ID_VEHICULO", typeof(int));
    
            var pLACAParameter = pLACA != null ?
                new ObjectParameter("PLACA", pLACA) :
                new ObjectParameter("PLACA", typeof(string));
    
            var iD_MARCAParameter = iD_MARCA.HasValue ?
                new ObjectParameter("ID_MARCA", iD_MARCA) :
                new ObjectParameter("ID_MARCA", typeof(int));
    
            var iD_TIPOParameter = iD_TIPO.HasValue ?
                new ObjectParameter("ID_TIPO", iD_TIPO) :
                new ObjectParameter("ID_TIPO", typeof(int));
    
            var iD_MODELOParameter = iD_MODELO.HasValue ?
                new ObjectParameter("ID_MODELO", iD_MODELO) :
                new ObjectParameter("ID_MODELO", typeof(int));
    
            var cANTIDAD_PUERTASParameter = cANTIDAD_PUERTAS.HasValue ?
                new ObjectParameter("CANTIDAD_PUERTAS", cANTIDAD_PUERTAS) :
                new ObjectParameter("CANTIDAD_PUERTAS", typeof(short));
    
            var cANTIDAD_RUEDASParameter = cANTIDAD_RUEDAS.HasValue ?
                new ObjectParameter("CANTIDAD_RUEDAS", cANTIDAD_RUEDAS) :
                new ObjectParameter("CANTIDAD_RUEDAS", typeof(short));
    
            var aÑOParameter = aÑO != null ?
                new ObjectParameter("AÑO", aÑO) :
                new ObjectParameter("AÑO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Actualizar_Vehiculo", iD_VEHICULOParameter, pLACAParameter, iD_MARCAParameter, iD_TIPOParameter, iD_MODELOParameter, cANTIDAD_PUERTASParameter, cANTIDAD_RUEDASParameter, aÑOParameter);
        }
    
        public virtual int sp_Agregar_Cliente_x_Vehiculo(string cEDULA, Nullable<int> iD_VEHICULO)
        {
            var cEDULAParameter = cEDULA != null ?
                new ObjectParameter("CEDULA", cEDULA) :
                new ObjectParameter("CEDULA", typeof(string));
    
            var iD_VEHICULOParameter = iD_VEHICULO.HasValue ?
                new ObjectParameter("ID_VEHICULO", iD_VEHICULO) :
                new ObjectParameter("ID_VEHICULO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Agregar_Cliente_x_Vehiculo", cEDULAParameter, iD_VEHICULOParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual ObjectResult<SP_CONSULTAR_VEHICULOS_Result> SP_CONSULTAR_VEHICULOS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CONSULTAR_VEHICULOS_Result>("SP_CONSULTAR_VEHICULOS");
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_EliminaCanton(Nullable<int> id_Canton)
        {
            var id_CantonParameter = id_Canton.HasValue ?
                new ObjectParameter("id_Canton", id_Canton) :
                new ObjectParameter("id_Canton", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaCanton", id_CantonParameter);
        }
    
        public virtual int sp_Eliminar_Cliente(Nullable<int> iD_CLIENTE)
        {
            var iD_CLIENTEParameter = iD_CLIENTE.HasValue ?
                new ObjectParameter("ID_CLIENTE", iD_CLIENTE) :
                new ObjectParameter("ID_CLIENTE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Eliminar_Cliente", iD_CLIENTEParameter);
        }
    
        public virtual int sp_Eliminar_Vehiculo(Nullable<int> iD_VEHICULO)
        {
            var iD_VEHICULOParameter = iD_VEHICULO.HasValue ?
                new ObjectParameter("ID_VEHICULO", iD_VEHICULO) :
                new ObjectParameter("ID_VEHICULO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Eliminar_Vehiculo", iD_VEHICULOParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_InsertaCanton(Nullable<int> id_Provincia, string nombre, Nullable<int> id_CantonInec)
        {
            var id_ProvinciaParameter = id_Provincia.HasValue ?
                new ObjectParameter("id_Provincia", id_Provincia) :
                new ObjectParameter("id_Provincia", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var id_CantonInecParameter = id_CantonInec.HasValue ?
                new ObjectParameter("id_CantonInec", id_CantonInec) :
                new ObjectParameter("id_CantonInec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaCanton", id_ProvinciaParameter, nombreParameter, id_CantonInecParameter);
        }
    
        public virtual int sp_ModificaCanton(Nullable<int> id_Canton, Nullable<int> id_Provincia, string nombre, Nullable<int> id_CantonInec)
        {
            var id_CantonParameter = id_Canton.HasValue ?
                new ObjectParameter("id_Canton", id_Canton) :
                new ObjectParameter("id_Canton", typeof(int));
    
            var id_ProvinciaParameter = id_Provincia.HasValue ?
                new ObjectParameter("id_Provincia", id_Provincia) :
                new ObjectParameter("id_Provincia", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var id_CantonInecParameter = id_CantonInec.HasValue ?
                new ObjectParameter("id_CantonInec", id_CantonInec) :
                new ObjectParameter("id_CantonInec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaCanton", id_CantonParameter, id_ProvinciaParameter, nombreParameter, id_CantonInecParameter);
        }
    
        public virtual int sp_Registrar_Cliente(string cEDULA, string nOMBRE, string aPELLIDO1, string aPELLIDO2, string tELEFONO, string cORREO, Nullable<int> iD_PROVINCIA, Nullable<int> iD_CANTON, Nullable<int> iD_DISTRITO, string dIRECCION)
        {
            var cEDULAParameter = cEDULA != null ?
                new ObjectParameter("CEDULA", cEDULA) :
                new ObjectParameter("CEDULA", typeof(string));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPELLIDO1Parameter = aPELLIDO1 != null ?
                new ObjectParameter("APELLIDO1", aPELLIDO1) :
                new ObjectParameter("APELLIDO1", typeof(string));
    
            var aPELLIDO2Parameter = aPELLIDO2 != null ?
                new ObjectParameter("APELLIDO2", aPELLIDO2) :
                new ObjectParameter("APELLIDO2", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var iD_PROVINCIAParameter = iD_PROVINCIA.HasValue ?
                new ObjectParameter("ID_PROVINCIA", iD_PROVINCIA) :
                new ObjectParameter("ID_PROVINCIA", typeof(int));
    
            var iD_CANTONParameter = iD_CANTON.HasValue ?
                new ObjectParameter("ID_CANTON", iD_CANTON) :
                new ObjectParameter("ID_CANTON", typeof(int));
    
            var iD_DISTRITOParameter = iD_DISTRITO.HasValue ?
                new ObjectParameter("ID_DISTRITO", iD_DISTRITO) :
                new ObjectParameter("ID_DISTRITO", typeof(int));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Registrar_Cliente", cEDULAParameter, nOMBREParameter, aPELLIDO1Parameter, aPELLIDO2Parameter, tELEFONOParameter, cORREOParameter, iD_PROVINCIAParameter, iD_CANTONParameter, iD_DISTRITOParameter, dIRECCIONParameter);
        }
    
        public virtual int sp_Registrar_Vehiculo(string pLACA, Nullable<int> iD_MARCA, Nullable<int> iD_TIPO, Nullable<int> iD_MODELO, Nullable<short> cANTIDAD_PUERTAS, Nullable<short> cANTIDAD_RUEDAS, string aÑO)
        {
            var pLACAParameter = pLACA != null ?
                new ObjectParameter("PLACA", pLACA) :
                new ObjectParameter("PLACA", typeof(string));
    
            var iD_MARCAParameter = iD_MARCA.HasValue ?
                new ObjectParameter("ID_MARCA", iD_MARCA) :
                new ObjectParameter("ID_MARCA", typeof(int));
    
            var iD_TIPOParameter = iD_TIPO.HasValue ?
                new ObjectParameter("ID_TIPO", iD_TIPO) :
                new ObjectParameter("ID_TIPO", typeof(int));
    
            var iD_MODELOParameter = iD_MODELO.HasValue ?
                new ObjectParameter("ID_MODELO", iD_MODELO) :
                new ObjectParameter("ID_MODELO", typeof(int));
    
            var cANTIDAD_PUERTASParameter = cANTIDAD_PUERTAS.HasValue ?
                new ObjectParameter("CANTIDAD_PUERTAS", cANTIDAD_PUERTAS) :
                new ObjectParameter("CANTIDAD_PUERTAS", typeof(short));
    
            var cANTIDAD_RUEDASParameter = cANTIDAD_RUEDAS.HasValue ?
                new ObjectParameter("CANTIDAD_RUEDAS", cANTIDAD_RUEDAS) :
                new ObjectParameter("CANTIDAD_RUEDAS", typeof(short));
    
            var aÑOParameter = aÑO != null ?
                new ObjectParameter("AÑO", aÑO) :
                new ObjectParameter("AÑO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Registrar_Vehiculo", pLACAParameter, iD_MARCAParameter, iD_TIPOParameter, iD_MODELOParameter, cANTIDAD_PUERTASParameter, cANTIDAD_RUEDASParameter, aÑOParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<sp_Validar_Inicio_Sesion_Result> sp_Validar_Inicio_Sesion(string uSUARIO, string pASS)
        {
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var pASSParameter = pASS != null ?
                new ObjectParameter("PASS", pASS) :
                new ObjectParameter("PASS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Validar_Inicio_Sesion_Result>("sp_Validar_Inicio_Sesion", uSUARIOParameter, pASSParameter);
        }
    }
}
