using System.Collections.Generic;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWADNETGAAP : ISWADNETGAAP
{
    #region Tabla: GUsuarioRol
    public void Insertar_GUsuarioRol_I(EGUsuarioRol eGUsuarioRol)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        cGUsuarioRol.Insertar_GUsuarioRol_I(eGUsuarioRol);
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        return cGUsuarioRol.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string CodigoRol)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        lstEGUsuarioRol = cGUsuarioRol.Obtener_GUsuarioRol_O_CodigoRol(CodigoRol);
        return lstEGUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string CodigoUsuario)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        lstEGUsuarioRol = cGUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario(CodigoUsuario);
        return lstEGUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string CodigoUsuario, string CodigoRol)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        return cGUsuarioRol.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(CodigoUsuario, CodigoRol);
    }
    public void Actualizar_GUsuarioRol_A(EGUsuarioRol eGUsuarioRol)
    {
        CGUsuarioRol cGUsuarioRol = new CGUsuarioRol();
        cGUsuarioRol.Actualizar_GUsuarioRol_A(eGUsuarioRol);
    }
    #endregion
    #region Tabla: GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(EGUsuarioProyecto eGUsuarioProyecto)
    {
        CGUsuarioProyecto cGUsuarioProyecto = new CGUsuarioProyecto();
        cGUsuarioProyecto.Insertar_GUsuarioProyecto_I(eGUsuarioProyecto);
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        CGUsuarioProyecto cGProyectoUsuario = new CGUsuarioProyecto();
        return cGProyectoUsuario.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        CGUsuarioProyecto cGUsuarioProyecto = new CGUsuarioProyecto();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        lstEGUsuarioProyecto = cGUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoProyecto(CodigoProyecto);
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string CodigoUsuario)
    {
        CGUsuarioProyecto cGUsuarioProyecto = new CGUsuarioProyecto();
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        lstEGUsuarioProyecto = cGUsuarioProyecto.Obtener_GUsuarioProyecto_O_CodigoUsuario(CodigoUsuario);
        return lstEGUsuarioProyecto;
    }
    public EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string CodigoUsuario, string CodigoProyecto)
    {
        CGUsuarioProyecto cGProyectoUsuario = new CGUsuarioProyecto();
        return cGProyectoUsuario.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(CodigoUsuario, CodigoProyecto);
    }
    public void Actualizar_GUsuarioProyecto_A(EGUsuarioProyecto eGUsuarioProyecto)
    {
        CGUsuarioProyecto cGUsuarioProyecto = new CGUsuarioProyecto();
        cGUsuarioProyecto.Actualizar_GUsuarioProyecto_A(eGUsuarioProyecto);
    }
    #endregion
    #region Tabla: GProyecto
    public void Insertar_GProyecto_I(EGProyecto eGProyecto)
    {
        CGProyecto cGProyecto = new CGProyecto();
        cGProyecto.Insertar_GProyecto_I(eGProyecto);
    }
    public List<EGProyecto> Obtener_GProyecto_O_Todo()
    {
        CGProyecto cGProyecto = new CGProyecto();
        return cGProyecto.Obtener_GProyecto_O_Todo();
    }
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string CodigoProyecto)
    {
        CGProyecto cGProyecto = new CGProyecto();
        EGProyecto eGProyecto = new EGProyecto();
        eGProyecto = cGProyecto.Obtener_GProyecto_O_CodigoProyecto(CodigoProyecto);
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto egProyecto)
    {
        CGProyecto cGProyecto = new CGProyecto();
        cGProyecto.Actualizar_GProyecto_A(egProyecto);
    }
    #endregion
    #region Tabla: GEtapa
    public void Insertar_GEtapa_I(EGEtapa etapa)
    {
        CGEtapa cGEtapa = new CGEtapa();
        cGEtapa.Insertar_GEtapa_I(etapa);
    }
    public List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string CodigoProyecto)
    {
        CGEtapa cGEtapa = new CGEtapa();
        return cGEtapa.Obtener_GEtapa_O_CodigoProyecto(CodigoProyecto);
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        CGEtapa cGEtapa = new CGEtapa();
        return cGEtapa.Obtener_GEtapa_O_SiguienteCodigoEtapa();
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(string CodigoProyecto)
    {
        CGEtapa cGEtapa = new CGEtapa();
        EGEtapa eGEtapa = new EGEtapa();
        eGEtapa = cGEtapa.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapaActivo(CodigoProyecto);
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string CodigoProyecto, byte NumeroEtapa)
    {
        CGEtapa cGEtapa = new CGEtapa();
        EGEtapa eGEtapa = new EGEtapa();
        eGEtapa = cGEtapa.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(CodigoProyecto, NumeroEtapa);
        return eGEtapa;
    }
    public void Actualizar_GEtapa_A_EstadoEtapa(int CodigoEtapa, char EstadoEtapa)
    {
        CGEtapa cGEtapa = new CGEtapa();
        cGEtapa.Actualizar_GEtapa_A_EstadoEtapa(CodigoEtapa, EstadoEtapa);
    }

    #endregion
    #region Tabla: GSubEtapa
    public void Insertar_GSubEtapa_I(EGSubEtapa eGSubEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        cGSubEtapa.Insertar_GSubEtapa_I(eGSubEtapa);
    }
    public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int CodigoEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        return cGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa(CodigoEtapa);
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        return cGSubEtapa.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(int CodigoEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        eGSubEtapa = cGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapaActivo(CodigoEtapa);
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int CodigoSubEtapa, char EstadoSubEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        cGSubEtapa.Actualizar_GSubEtapa_A_EstadoSubEtapa(CodigoSubEtapa, EstadoSubEtapa);
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int CodigoEtapa, byte NumeroSubEtapa)
    {
        CGSubEtapa cGSubEtapa = new CGSubEtapa();
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        eGSubEtapa = cGSubEtapa.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(CodigoEtapa, NumeroSubEtapa);
        return eGSubEtapa;
    }
    #endregion
    #region Tabla: GObservacion
    public void Insertar_GObservacion_I(EGObservacion eGObservacion)
    {
        CGObservacion cGObservacion = new CGObservacion();
        cGObservacion.Insertar_GObservacion_I(eGObservacion);
    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string CodigoProyecto)
    {
        CGObservacion cGObservacion = new CGObservacion();
        List<EGObservacion> lstEGObservaciones = new List<EGObservacion>();
        lstEGObservaciones = cGObservacion.Obtener_GObservacion_O_CodigoProyecto(CodigoProyecto);
        return lstEGObservaciones;
    }
    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        CGObservacion cGObservacion = new CGObservacion();
        return cGObservacion.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
    }

    public void Actualizar_GObservacion_A(EGObservacion eGObservacion)
    {
        CGObservacion cGObservacion = new CGObservacion();
        cGObservacion.Actualizar_GObservacion_A(eGObservacion);
    }

    public void Actualizar_GObservacion_A_EstadoObservacion(int CodigoObservacion, char EstadoObservacion)
    {
        CGObservacion cGObservacion = new CGObservacion();
        cGObservacion.Actualizar_GObservacion_A_EstadoObservacion(CodigoObservacion, EstadoObservacion);
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        CGObservacion cGObservacion = new CGObservacion();
        return cGObservacion.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
    }
    #endregion
    #region Tabla: GUsuario
    public void Insertar_GUsuario_I(EGUsuario eGUsuario)
    {
        CGUsuario cGUsuario = new CGUsuario();
        cGUsuario.Insertar_GUsuario_I(eGUsuario);
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string CodigoUsuario)
    {
        CGUsuario cGUsuario = new CGUsuario();
        return cGUsuario.Obtener_GUsuario_O_CodigoUsuario(CodigoUsuario);
    }
    public void Actualizar_GUsuario_A(EGUsuario eGUsuario)
    {
        CGUsuario cGUsuario = new CGUsuario();
        cGUsuario.Actualizar_GUsuario_A(eGUsuario);
    }
    #endregion
    #region Tabla: GRol
    public List<EGRol> Obtener_GRol_O_Todo()
    {
        CGRol cGRol = new CGRol();
        return cGRol.Obtener_GRol_O_Todo();
    }
    public EGRol Obtener_GRol_O_CodigoRol(string CodigoRol)
    {
        CGRol cGRol = new CGRol();
        return cGRol.Obtener_GRol_O_CodigoRol(CodigoRol);
    }
    #endregion
    #region Tabla : UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string CodigoUsuario)
    {
        CUsuarioNetvalle cUsuarioNetvalle = new CUsuarioNetvalle();
        return cUsuarioNetvalle.Obtener_UsuarioNetvalle_O_CodigoUsuario(CodigoUsuario);
    }
    #endregion
}
