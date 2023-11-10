using SWADNETGAAP;
using System;
using System.Collections.Generic;
using System.ServiceModel;

[ServiceContract]
public interface ISWLNGAAP
{
    #region GUsuarioRol
    [OperationContract]
    void Insertar_GUsuarioRol_I(int codigoUsuarioRol, string codigoRol, string codigoUsuario);
    [OperationContract]
    int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
    [OperationContract]
    List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol);
    [OperationContract]
    List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario);
    [OperationContract]
    EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol);
    [OperationContract]
    void Actualizar_GUsuarioRol_A(string codigoUsuario, string codigoRol, int codigoUsuarioRol);
    [OperationContract]
    void Eliminar_GUsuarioRol_E(int codigoUsuario);
    #endregion
    #region GUsuarioProyecto
    [OperationContract]
    void Insertar_GUsuarioProyecto_I(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto);
    [OperationContract]
    int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    [OperationContract]
    List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto);
    [OperationContract]
    List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario);
    [OperationContract]
    void Actualizar_GUsuarioProyecto_A(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto);
    [OperationContract]
    void Eliminar_GUsuarioProyecto_E(int codigoUsuarioProyecto);
    #endregion
    #region GProyecto
    [OperationContract]
    void Insertar_GProyecto_I(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string enlaceDocumentoProyecto, char estadoProyecto);
    [OperationContract]
    List<EGProyecto> Obtener_GProyecto_O(DateTime fechaInicio, DateTime fechaFin);
    [OperationContract]
    EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto);
    [OperationContract]
    void Actualizar_GProyecto_A(EGProyecto eGProyecto);
    #endregion
    #region GEtapa
    [OperationContract]
    void Insertar_GEtapa_I(int codigoEtapa, byte numeroEtapa, DateTime fechaInicioEtapa, DateTime fechaDefinidaEtapa, DateTime fechaFinEtapa, string codigoProyecto, char estadoEtapa);
    [OperationContract]
    int Obtener_GEtapa_O_SiguienteCodigoEtapa();
    [OperationContract]
    EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoEtapa);
    [OperationContract]
    EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroSubEtapa);
    [OperationContract]
    void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa);
    #endregion
    #region GFormularioAceptacion
    [OperationContract]
    void Insertar_GFormularioAceptacion_I(EGFormularioAceptacion eGFormularioAceptacion);
    [OperationContract]
    List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto);
    #endregion
    #region GSubEtapa
    [OperationContract]
    void Insertar_GSubEtapa_I(int codigoSubEtapa, byte numeroSubEtapa, DateTime fechaInicioSubEtapa, DateTime fechaDefinidaSubEtapa, DateTime fechaFinSubEtapa, string codigoUsuarioFirma, int codigoEtapa, char estadoSubEtapa);
    [OperationContract]
    int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    [OperationContract]
    EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoEtapa, char estadoSubEtapa);
    [OperationContract]
    EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa);
    [OperationContract]
    void Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa);
    #endregion
    #region GObservacion
    [OperationContract]
    void Insertar_GObservacion_I(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion);
    [OperationContract]
    List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto);    
    [OperationContract]
    EGObservacion Obtener_GObservacion_O_CodigoObservacion(int codigoObservacion);
    [OperationContract]
    void Actualizar_GObservacion_A(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion);
    [OperationContract]
    void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion);
    [OperationContract]
    int Obtener_GObsevacion_O_SiguienteCodigoObservacion();
    #endregion
    #region GUsuario
    [OperationContract]
    void Insertar_GUsuario_I(string codigoUsuario, string nombreCompletoUsuario, string sede);
    [OperationContract]
    EGUsuario Obtener_GUsuario_O_CodigoUsuario(string codigoUsuario);
    [OperationContract]
    List<EGUsuario> Obtener_GUsuarios_O_CodigoProyecto(string codigoProyecto);
    [OperationContract]
    EGUsuario Obtener_GUsuario_O_NombreCompletoUsuario(string nombreCompletoUsuario);
    [OperationContract]
    List<EGUsuario> Buscar_GUsuario_B_NombreCompletoUsuario(string nombreCompletoUsuario);
    [OperationContract]
    void Actualizar_GUsuario_A(string codigoUsuario, string nombreCompletoUsuario, string sede);
    
    #endregion
    #region GRol
    [OperationContract]
    List<EGRol> Obtener_GRol_O();
    [OperationContract]
    EGRol Obtener_GRol_O_CodigoRol(string codigoRol);
    #endregion
    #region UsuarioNetvalle
    [OperationContract]
    EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario);
    #endregion
    #region GCelular
    [OperationContract]
    int Obtener_GCelular_O_SiguienteCodigoCelular();
    [OperationContract]
    void Insertar_GCelular_I(string codigoUsuario, string codigoAreaCelular, int numeroCelular);
    [OperationContract]
    EGCelular Obtener_GCelular_O_CodigoUsuario(string codigoUsuario);
    [OperationContract]
    void Actualizar_GCelular_A(int codigoCelular, string codigoUsuario, string codigoAreaCelular, int numeroCelular);
    [OperationContract]
    void Eliminar_GCelular_E(int codigoCelular);
    #endregion
    #region GTutorExterno

    [OperationContract]
    void Insertar_GTutorExterno_I(int codigoTutorExterno, string nombresTutorExterno, string apellidosTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno);

    [OperationContract]
    void Actualizar_GTutorExterno_A(int codigoTutorExterno, string nombresTutorExterno, string apellidosTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno);

    [OperationContract]
    List<EGTutorExterno> Obtener_GTutorExterno_O();

    [OperationContract]
    EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(int codigoTutorExterno);

    [OperationContract]
    void Eliminar_GTutorExterno_E(int codigoTutorExterno);

    #endregion
    #region GProyectoComplejo
    [OperationContract]
    List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string CodigoUsuario);
    [OperationContract]
    List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string codigoUsuario);
    #region Opciones Proyecto
    [OperationContract]
    bool Verificar_GProyecto_CorrespondeRevision(string codigoRol, byte numeroEtapa, byte numeroSubEtapa);
    [OperationContract]
    void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string codigoProyecto);
    #endregion
    #endregion
    #region EProgresoEtapaSubEtapa
    [OperationContract]
    List<EProgresoEtapaSubEtapa> Obtener_EProgresoEtapaSubEtapa_O(string codigoProyecto);
    [OperationContract]
    void Insertar_ProyectoCompleto(string codigoProyecto, string codigoUsuario, string codigoDirector, int diasEtapa, int diasSubEtapa);
    #endregion

    #region EUsuarioCompleto
    [OperationContract]
    EUsuarioCompleto Obtener_EUsuarioCompleto_O(string codigoUsuario, string codigoProyecto);
    #endregion

    #region TiemposEntrega
    [OperationContract]
    List<EProyectoTiempoEntrega> Obtener_EProyectoTiempoEntrega_O(string codigoUsuario);
    #endregion

    //Añadidas
    [OperationContract]
    string Descifrado(string texto, string tipo);
    [OperationContract]
    string Cifrar_Cadena(string textoACifrar);
    [OperationContract]
    Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string IdEmp, string Sede);
    [OperationContract]
    Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string IdEmp, string Sede);
}


