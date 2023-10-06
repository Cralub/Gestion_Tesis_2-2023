using System.Collections.Generic;
using System.ServiceModel;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNETGAAP
{
    #region Tabla: GUsuarioRol
    [OperationContract]
    void Insertar_GUsuarioRol_I(EGUsuarioRol usuarioRol);
    [OperationContract]
    int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
    [OperationContract]
    List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol);
    [OperationContract]
    List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario);
    [OperationContract]
    EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol);
    [OperationContract]
    void Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol);
    #endregion
    #region Tabla: GUsuarioProyecto
    [OperationContract]
    void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto);
    [OperationContract]
    int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    [OperationContract]
    List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto);
    [OperationContract]
    List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario);
    [OperationContract]
    EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string CodigoUsuario, string CodigoProyecto);
    [OperationContract]
    void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGUsuarioProyecto);
    #endregion
    #region Tabla: GProyecto
    [OperationContract]
    void Insertar_GProyecto_I(EGProyecto eGProyecto);
    [OperationContract]
    List<EGProyecto> Obtener_GProyecto_O_Todo();
    [OperationContract]
    EGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto);

    [OperationContract]
    void Actualizar_GProyecto_A(EGProyecto egProyecto);

    #endregion
    #region Tabla: GEtapa
    [OperationContract]
    void Insertar_GEtapa_I(EGEtapa etapa);
    [OperationContract]
    List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string CodigoProyecto);
    [OperationContract]
    int Obtener_GEtapa_O_SiguienteCodigoEtapa();
    [OperationContract]
    EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto);
    [OperationContract]
    EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroSubEtapa);

    [OperationContract]
    void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa);
    #endregion
    #region Tabla: GSubEtapa
    [OperationContract]
    void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa);
    [OperationContract]
    List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int CodigoEtapa);
    [OperationContract]
    int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    [OperationContract]
    EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa);
    [OperationContract]
    EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa);
    [OperationContract]
    void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa);
    #endregion
    #region Tabla: GObservacion
    [OperationContract]
    void Insertar_GObservacion_I(EGObservacion eGObservacion);
    [OperationContract]
    List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto);
    [OperationContract]
    EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion);
    [OperationContract]
    void Actualizar_GObservacion_A(EGObservacion eGObservacion);
    [OperationContract]
    void Actualizar_GObservacion_A_EstadoObservacion(int CodigoObservacion, char EstadoObservacion);
    [OperationContract]
    int Obtener_GObsevacion_O_SiguienteCodigoObservacion();
    #endregion
    #region Tabla: GUsuario
    [OperationContract]
    void Insertar_GUsuario_I(EGUsuario eGUsuario);
    [OperationContract]
    EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario);
    [OperationContract]
    void Actualizar_GUsuario_A(EGUsuario eGUsuario);
    #endregion
    #region Tabla: GRol
    [OperationContract]
    List<EGRol> Obtener_GRol_O_Todo();
    [OperationContract]
    EGRol Obtener_GRol_O_CodigoRol(string CodigoRol);
    #endregion
    #region Tabla : UsuarioNetvalle
    [OperationContract]
    EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string CodigoUsuario);
    #endregion

}


