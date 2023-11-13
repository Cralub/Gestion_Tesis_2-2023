using SWADNETGAAP;
using System;
using System.Collections.Generic;
using System.ServiceModel;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWLNGAAP : ISWLNGAAP
{
    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(int codigoUsuarioRol, string codigoRol, string codigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GUsuarioRol_I(codigoUsuarioRol, codigoRol, codigoUsuario);
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGUsuarioRol> lstEgUsuarioRol = new List<EGUsuarioRol>();
        lstEgUsuarioRol = cGAAP.Obtener_GUsuarioRol_O_CodigoRol(codigoRol);
        return lstEgUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGUsuarioRol> lstEgUsuarioRol = new List<EGUsuarioRol>();
        lstEgUsuarioRol = cGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario);
        return lstEgUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
    }
    public void Actualizar_GUsuarioRol_A(string codigoUsuario, string codigoRol, int codigoUsuarioRol)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GUsuarioRol_A(codigoUsuario, codigoRol, codigoUsuarioRol);
    }
    public void Eliminar_GUsuarioRol_E(int codigoUsuarioRol)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Eliminar_GusuarioRol_E(codigoUsuarioRol);
    }
    #endregion
    #region GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GUsuarioProyecto_I(codigoUsuarioProyecto, codigoProyecto, codigoUsuario, codigoRol, estadoUsuarioProyecto);
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto> ();
        lstEGUsuarioProyecto = cGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto (codigoProyecto);
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        lstEGUsuarioProyecto = cGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario);
        return lstEGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GUsuarioProyecto_A(codigoUsuarioProyecto, codigoProyecto, codigoUsuario, codigoRol,estadoUsuarioProyecto);
    }
    public void Eliminar_GUsuarioProyecto_E(int codigoUsuarioProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
    }
    #endregion
    #region GProyecto
    public void Insertar_GProyecto_I(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string enlaceDocumentoProyecto, char estadoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GProyecto_I(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, enlaceDocumentoProyecto,  estadoProyecto);
    }
    public List<EGProyecto> Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GProyecto_O(fechaInicio, fechaFin);
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        EGProyecto eGProyecto = new EGProyecto();
        eGProyecto = cGAAP.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto eGProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GProyecto_A(eGProyecto);
    }
    #endregion
    #region GEtapa
    public void Insertar_GEtapa_I(int codigoEtapa, byte numeroEtapa, DateTime fechaInicioEtapa, DateTime fechaDefinidaEtapa, DateTime fechaFinEtapa, string codigoProyecto, char estadoEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GEtapa_I(codigoEtapa, numeroEtapa, fechaInicioEtapa, fechaDefinidaEtapa, fechaFinEtapa, codigoProyecto, estadoEtapa);
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
    }

    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        EGEtapa eGEtapa = new EGEtapa();
        eGEtapa = cGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, estadoEtapa);
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        EGEtapa eGEtapa = new EGEtapa();
        eGEtapa = cGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto, numeroSubEtapa);
        return eGEtapa;
    }
    public void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
    }
    public void Actualizar_Etapa_SubEtapa_SaltarASubEtapa(string codigoProyecto, byte numeroSubEtapaASaltar)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_Etapa_SubEtapa_SaltarASubEtapa(codigoProyecto, numeroSubEtapaASaltar);
    }
    #endregion
    #region GFormularioAceptacion
    public void Insertar_GFormularioAceptacion_I(EGFormularioAceptacion eGFormularioAceptacion)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
    }

    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGFormularioAceptacion> lstEGFormularioAceptacion = new List<EGFormularioAceptacion>();
        lstEGFormularioAceptacion = cGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto);
        return lstEGFormularioAceptacion;
    }
    #endregion
    #region GSubEtapa
    public void Insertar_GSubEtapa_I(int codigoSubEtapa, byte numeroSubEtapa, DateTime fechaInicioSubEtapa, DateTime fechaDefinidaSubEtapa, DateTime fechaFinSubEtapa, string codigoUsuarioFirma, int codigoEtapa, char estadoSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GSubEtapa_I(codigoSubEtapa, numeroSubEtapa, fechaInicioSubEtapa, fechaDefinidaSubEtapa, fechaFinSubEtapa, codigoUsuarioFirma, codigoEtapa, estadoSubEtapa);
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoEtapa, char estadoSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        eGSubEtapa = cGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa); 
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        eGSubEtapa = cGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
    }

    #endregion
    #region GObservacion
    public void Insertar_GObservacion_I(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GObservacion_I(CodigoObservacion, CodigoProyecto, CodigoSubEtapa, CodigoUsuarioObservacion, ComentarioObservacion, TipoObservacion, EstadoObservacion);

    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        lstObservacion = cGAAP.Obtener_GObservacion_O_CodigoProyecto(CodigoProyecto);
        return lstObservacion;

    }
    
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
    }
    public void Actualizar_GObservacion_A(int CodigoObservacion, string CodigoProyecto, int CodigoSubEtapa, string CodigoUsuarioObservacion, string ComentarioObservacion, char TipoObservacion, char EstadoObservacion)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GObservacion_A(CodigoObservacion, CodigoProyecto, CodigoSubEtapa, CodigoUsuarioObservacion, ComentarioObservacion, TipoObservacion, EstadoObservacion);
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int CodigoObservacion, char EstadoObservacion)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GObservacion_A_EstadoObservacion(CodigoObservacion, EstadoObservacion);
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
    }

    #endregion
    #region GUsuario
    public void Insertar_GUsuario_I(string CodigoUsuario,string nombreCompletoUsuario, string sede)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GUsuario_I(CodigoUsuario, nombreCompletoUsuario, sede);
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
    }
    public List<EGUsuario> Obtener_GUsuarios_O_CodigoProyecto(string CodigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GUsuarios_O_CodigoProyecto(CodigoProyecto);
    }
    public EGUsuario Obtener_GUsuario_O_NombreCompletoUsuario(string nombreCompletoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GUsuario_O_NombreCompletoUsuario(nombreCompletoUsuario);
    }
    public List<EGUsuario> Buscar_GUsuario_B_NombreCompletoUsuario(string nombreCompletoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Buscar_GUsuario_B_NombreCompletoUsuario(nombreCompletoUsuario);
    }
    public void Actualizar_GUsuario_A(string codigoUsuario, string nombreCompletoUsuario, string sede)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GUsuario_A(codigoUsuario, nombreCompletoUsuario, sede);
    }
    
    #endregion
    #region GRol
    public List<EGRol> Obtener_GRol_O()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GRol_O();
    }
    public EGRol Obtener_GRol_O_CodigoRol(string codigoRol)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GRol_O_CodigoRol(codigoRol);
    }
    #endregion
    #region UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
    }
    #endregion
    #region GCelular
    public int Obtener_GCelular_O_SiguienteCodigoCelular()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GCelular_O_SiguienteCodigoCelular();
    }
    public void Insertar_GCelular_I(string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GCelular_I(codigoUsuario, codigoAreaCelular, numeroCelular);
    }
    public EGCelular Obtener_GCelular_O_CodigoUsuario(string codigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
    }
    public void Actualizar_GCelular_A(int codigoCelular, string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GCelular_A(codigoCelular, codigoUsuario, codigoAreaCelular, numeroCelular);
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Eliminar_GCelular_E(codigoCelular);
    }
    #endregion
    #region GTutorExterno
    public List<EGTutorExterno> Obtener_GTutorExterno_O()
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GTutorExterno_O();
    }

    public EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(int codigoTutorExterno)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
    }


    public void Insertar_GTutorExterno_I(int codigoTutorExterno, string nombresTutorExterno, string apellidosTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_GTutorExterno_I(codigoTutorExterno, nombresTutorExterno, apellidosTutorExterno, carreraTutorExterno, direccionTrabajoTutorExterno, descripcionTutorExterno, sedeTutorExterno);
    }

    public void Actualizar_GTutorExterno_A(int codigoTutorExterno, string nombresTutorExterno, string apellidosTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_GTutorExterno_A(codigoTutorExterno, nombresTutorExterno, apellidosTutorExterno, carreraTutorExterno, direccionTrabajoTutorExterno, descripcionTutorExterno, sedeTutorExterno);
    }


    public void Eliminar_GTutorExterno_E(int codigoTutorExterno)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Eliminar_GTutorExterno_E(codigoTutorExterno);
    }


    #endregion

    #region GProyectoCompleja
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string codigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        lstEGProyectos = cGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario);
        return lstEGProyectos;
    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string codigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        lstEGProyectos = cGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(codigoUsuario);
        return lstEGProyectos;
    }
    #region Opciones
    public bool Verificar_GProyecto_CorrespondeRevision(string codigoRol, byte numeroEtapa, byte numeroSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Verificar_GProyecto_CorrespondeRevision(codigoRol, numeroEtapa, numeroSubEtapa);
    }
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string codigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(codigoProyecto);
    }
    public void Insertar_ProyectoCompleto(string codigoProyecto, string codigoUsuario, string codigoDirector, int diasEtapa, int diasSubEtapa)
    {
        CGAAP cGAAP = new CGAAP();
        cGAAP.Insertar_ProyectoCompleto(codigoProyecto, codigoUsuario, codigoDirector, diasEtapa, diasSubEtapa);
    }
    #endregion
    #endregion

    #region EProgresoEtapaSubEtapa
    public List<EProgresoEtapaSubEtapa> Obtener_EProgresoEtapaSubEtapa_O(string codigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_EProgresoEtapaSubEtapa_O(codigoProyecto);
    }
    #endregion

    #region EUsuarioCompleto
    public EUsuarioCompleto Obtener_EUsuarioCompleto_O(string codigoUsuario, string codigoProyecto)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_EUsuarioCompleto_O_CodigoUsuario(codigoUsuario, codigoProyecto);
    }
    #endregion

    #region EProyectoTiempoEntrega
    public List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string codigoUsuario)
    {
        CGAAP cGAAP = new CGAAP();
        return cGAAP.Obtener_EProyectoTiempoEntrega_O(codigoUsuario);
    }
    #endregion

    //Añadidas
    public string Descifrado(string texto, string tipo)
    {
        return "";
    }
    public string Cifrar_Cadena(string textoACifrar)
    {
        return "";
    }
    public Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string Id_Emp, string sedeAcademica)
    {
        Tuple<EEmpleado, EMensajeError> result;
        result = null;
        return result;
    }
    public Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string Id_Emp, string sedeAcademica)
    {
        Tuple<byte[], EMensajeError> result;
        result = null;
        return result;
    }

}
