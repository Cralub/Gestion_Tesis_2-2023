using SWLNGAAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web.UI.WebControls;

/// <summary>
/// Descripción breve de LNServicio
/// </summary>
public class LNServicio
{
    #region Propiedades
    public string NombreClase
    {
        get { return GetType().Name; }
    }
    #endregion

    #region Constructor
    public LNServicio()
    {

    }
    private EDefecto ConstruirDefecto(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje, string stackTrace)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = tipoDefecto,
            Servicio = SDatosGlobales.NOMBRE_APLICACION,
            Clase = NombreClase,
            Metodo = metodo,
            Mensaje = mensaje,
            Excepcion = excepcion,
        };

        return eDefecto;
    }

    private EDefecto ConstruirDefecto(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = tipoDefecto,
            Servicio = SDatosGlobales.NOMBRE_APLICACION,
            Clase = NombreClase,
            Metodo = metodo,
            Mensaje = mensaje,
            Excepcion = excepcion
        };

        return eDefecto;
    }

    private EDefecto ConstruirDefecto(FaultException<EDefecto> ex)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = ex.Detail.TipoDefecto,
            Servicio = ex.Detail.Servicio,
            Clase = ex.Detail.Clase,
            Metodo = ex.Detail.Metodo,
            Excepcion = ex.Detail.Excepcion,
            Mensaje = ex.Detail.Mensaje,
        };
        return eDefecto;
    }
    #endregion

    #region Metodos Publicos

    #region GUsuarioRol
    public void Insertar_GUsuarioRol_I(int codigoUsuarioRol, string codigoRol, string codigoUsuario)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GUsuarioRol_I(codigoUsuarioRol, codigoRol, codigoUsuario);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GUsuarioRol_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Insertar_GUsuarioRol_I(codigoUsuarioRol, codigoRol, codigoUsuario);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GUsuarioRol_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_GUsuarioRol_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GUsuarioRol_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public int Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol()
    {
        int siguienteCodigo = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                siguienteCodigo = clienteSWLNGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    siguienteCodigo = clienteSWLNGAAP.Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_SiguienteCodigoUsuarioRol", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return siguienteCodigo;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoRol(string codigoRol)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoRol(codigoRol).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoRol", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoRol(codigoRol).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoRol", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuarioRol_O_CodigoRol", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoRol", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGUsuarioRol;
    }
    public List<EGUsuarioRol> Obtener_GUsuarioRol_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioRol> lstEGUsuarioRol = new List<EGUsuarioRol>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoUsuario(codigoUsuario).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoUsuario", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuarioRol_O_CodigoUsuario", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGUsuarioRol;
    }
    public EGUsuarioRol Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(string codigoUsuario, string codigoRol)
    {
        EGUsuarioRol eGUsuarioRol = new EGUsuarioRol();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGUsuarioRol = clienteSWLNGAAP.Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol(codigoUsuario, codigoRol);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioRol_O_CodigoUsuario_CodigoRol", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGUsuarioRol;
    }
    public void Actualizar_GUsuarioRol_A(string codigoUsuario, string codigoRol, int codigoUsuarioRol)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GUsuarioRol_A(codigoUsuario, codigoRol, codigoUsuarioRol);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GUsuarioRol_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_GUsuarioRol_A(codigoUsuario, codigoRol, codigoUsuarioRol);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GUsuarioRol_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GUsuarioRol_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GUsuarioRol_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public void Eliminar_GUsuarioRol_E(int codigoUsuarioRol)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GUsuarioRol_E", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Eliminar_GUsuarioRol_E(codigoUsuarioRol);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GUsuarioRol_E", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Eliminar_GUsuarioRol_E", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GUsuarioRol_E", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion
    #region GUsuarioProyecto
    public void Insertar_GUsuarioProyecto_I(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GUsuarioProyecto_I(codigoUsuarioProyecto, codigoProyecto, codigoUsuario, codigoRol, estadoUsuarioProyecto);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GUsuarioProyecto_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Insertar_GUsuarioProyecto_I(codigoUsuarioProyecto, codigoProyecto, codigoUsuario, codigoRol, estadoUsuarioProyecto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GUsuarioProyecto_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_GUsuarioProyecto_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GUsuarioProyecto_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public int Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto()
    {
        int siguienteCodigo = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                siguienteCodigo = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    siguienteCodigo = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_SiguienteCodigoUsuarioProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return siguienteCodigo;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioProyecto = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGUsuarioProyecto = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_CodigoProyecto(codigoProyecto).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoProyecto", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuarioProyecto_O_CodigoProyecto", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGUsuarioProyecto;
    }
    public List<EGUsuarioProyecto> Obtener_GUsuarioProyecto_O_CodigoUsuario(string codigoUsuario)
    {
        List<EGUsuarioProyecto> lstEGUsuarioProyecto = new List<EGUsuarioProyecto>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarioProyecto = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGUsuarioProyecto = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario(codigoUsuario).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoUsuario", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuarioProyecto_O_CodigoUsuario", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGUsuarioProyecto;
    }
    public EGUsuarioProyecto Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(string codigoUsuario, string codigoProyecto)
    {
        EGUsuarioProyecto eGUsuarioProyecto = new EGUsuarioProyecto();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGUsuarioProyecto = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGUsuarioProyecto = clienteSWLNGAAP.Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto(codigoUsuario, codigoProyecto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarioProyecto_O_CodigoUsuario_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGUsuarioProyecto;
    }
    public void Actualizar_GUsuarioProyecto_A(int codigoUsuarioProyecto, string codigoProyecto, string codigoUsuario, string codigoRol, char estadoUsuarioProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GUsuarioProyecto_A(codigoUsuarioProyecto, codigoProyecto, codigoUsuario, codigoRol, estadoUsuarioProyecto);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GUsuarioProyecto_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_GUsuarioProyecto_A(codigoUsuarioProyecto, codigoProyecto, codigoUsuario, codigoRol, estadoUsuarioProyecto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GUsuarioProyecto_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GUsuarioProyecto_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GUsuarioProyecto_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public void Eliminar_GUsuarioProyecto_E(int codigoUsuarioProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GUsuarioProyecto_E", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Eliminar_GUsuarioProyecto_E(codigoUsuarioProyecto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GUsuarioProyecto_E", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Eliminar_GUsuarioProyecto_E", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GUsuarioProyecto_E", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion
    #region GProyecto
    public void Insertar_GProyecto_I(string codigoProyecto, char modalidadProyecto, string tituloProyecto, string objetivoGeneralProyecto, string objetivosEspecificosProyecto, string alcanceProyecto, string enlaceDocumentoProyecto, char estadoProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GProyecto_I(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, objetivosEspecificosProyecto, alcanceProyecto, enlaceDocumentoProyecto, estadoProyecto);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GProyecto_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Insertar_GProyecto_I(codigoProyecto, modalidadProyecto, tituloProyecto, objetivoGeneralProyecto, objetivosEspecificosProyecto, alcanceProyecto, enlaceDocumentoProyecto, estadoProyecto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GProyecto_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_GProyecto_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GProyecto_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
  
    public EGProyecto Obtener_GProyecto_O_CodigoProyecto(string codigoProyecto)
    {
        EGProyecto eGProyecto = new EGProyecto();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGProyecto = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGProyecto = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoProyecto(codigoProyecto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoProyecto", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GProyecto_O_CodigoProyecto", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGProyecto;
    }
    public void Actualizar_GProyecto_A(EGProyecto eGProyecto)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GProyecto_A(eGProyecto);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GProyecto_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_GProyecto_A(eGProyecto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GProyecto_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GProyecto_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GProyecto_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion
    #region GEtapa
    public void Insertar_GEtapa_I(int codigoEtapa, byte numeroEtapa, DateTime fechaInicioEtapa, DateTime fechaDefinidaEtapa, DateTime fechaFinEtapa, string codigoProyecto, char estadoEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GEtapa_I(codigoEtapa, numeroEtapa, fechaInicioEtapa, fechaDefinidaEtapa, fechaFinEtapa, codigoProyecto, estadoEtapa);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GEtapa_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Insertar_GEtapa_I(codigoEtapa, numeroEtapa, fechaInicioEtapa, fechaDefinidaEtapa, fechaFinEtapa, codigoProyecto, estadoEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GEtapa_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_GEtapa_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GEtapa_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public int Obtener_GEtapa_O_SiguienteCodigoEtapa()
    {
        int siguienteCodigo = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                siguienteCodigo = clienteSWLNGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_SiguienteCodigoEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    siguienteCodigo = clienteSWLNGAAP.Obtener_GEtapa_O_SiguienteCodigoEtapa();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_SiguienteCodigoEtapa", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GEtapa_O_SiguienteCodigoEtapa", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_SiguienteCodigoEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return siguienteCodigo;
    }

    public List<EGEtapa> Obtener_GEtapa_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGEtapa> lstEGEtapa = new List<EGEtapa>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGEtapa = clienteSWLNGAAP.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGEtapa = clienteSWLNGAAP.Obtener_GEtapa_O_CodigoProyecto(codigoProyecto).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GEtapa_O_CodigoProyecto", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(string codigoProyecto, char estadoEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGEtapa = clienteSWLNGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, estadoEtapa);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGEtapa = clienteSWLNGAAP.Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa(codigoProyecto, estadoEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto_EstadoEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGEtapa;
    }
    public EGEtapa Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(string codigoProyecto, byte numeroSubEtapa)
    {
        EGEtapa eGEtapa = new EGEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGEtapa = clienteSWLNGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto, numeroSubEtapa);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGEtapa = clienteSWLNGAAP.Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa(codigoProyecto, numeroSubEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GEtapa_O_CodigoProyecto_NumeroEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGEtapa;
    }

    public void Actualizar_GEtapa_A_EstadoEtapa(int codigoEtapa, char estadoEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GEtapa_A_EstadoEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_GEtapa_A_EstadoEtapa(codigoEtapa, estadoEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GEtapa_A_EstadoEtapa", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GEtapa_A_EstadoEtapa", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GEtapa_A_EstadoEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion
    #region GSubEtapa
    public void Insertar_GSubEtapa_I(int codigoSubEtapa, int codigoEtapa, string codigoUsuarioFirmaSubEtapa, string codigoRolDesignadoSubEtapa, byte numeroSubEtapa, DateTime fechaInicioSubEtapa, DateTime fechaDefinidaSubEtapa, DateTime fechaFinSubEtapa, char estadoSubEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GSubEtapa_I(codigoSubEtapa, codigoEtapa, codigoUsuarioFirmaSubEtapa, codigoRolDesignadoSubEtapa, numeroSubEtapa, fechaInicioSubEtapa, fechaDefinidaSubEtapa, fechaFinSubEtapa, estadoSubEtapa);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GSubEtapa_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Insertar_GSubEtapa_I(codigoSubEtapa, codigoEtapa, codigoUsuarioFirmaSubEtapa, codigoRolDesignadoSubEtapa, numeroSubEtapa, fechaInicioSubEtapa, fechaDefinidaSubEtapa, fechaFinSubEtapa, estadoSubEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GSubEtapa_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_GSubEtapa_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GSubEtapa_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public int Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa()
    {
        int siguienteCodigo = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                siguienteCodigo = clienteSWLNGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    siguienteCodigo = clienteSWLNGAAP.Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_SiguienteCodigoSubEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return siguienteCodigo;
    }
    public List<EGSubEtapa> Obtener_GSubEtapa_O_CodigoEtapa(int codigoEtapa)
    {
        List<EGSubEtapa> lstEGSubEtapa = new List<EGSubEtapa>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGSubEtapa = clienteSWLNGAAP.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGSubEtapa = clienteSWLNGAAP.Obtener_GSubEtapa_O_CodigoEtapa(codigoEtapa).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GSubEtapa_O_CodigoEtapa", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(int codigoEtapa, char estadoSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGSubEtapa = clienteSWLNGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGSubEtapa = clienteSWLNGAAP.Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa(codigoEtapa, estadoSubEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa_EstadoSubEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGSubEtapa;
    }
    public EGSubEtapa Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(int codigoEtapa, byte numeroSubEtapa)
    {
        EGSubEtapa eGSubEtapa = new EGSubEtapa();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGSubEtapa = clienteSWLNGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGSubEtapa = clienteSWLNGAAP.Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa(codigoEtapa, numeroSubEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GSubEtapa_O_CodigoEtapa_NumeroSubEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGSubEtapa;
    }
    public void Actualizar_GSubEtapa_A_EstadoSubEtapa(int codigoSubEtapa, char estadoSubEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GSubEtapa_A_EstadoSubEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_GSubEtapa_A_EstadoSubEtapa(codigoSubEtapa, estadoSubEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GSubEtapa_A_EstadoSubEtapa", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GSubEtapa_A_EstadoSubEtapa", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GSubEtapa_A_EstadoSubEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public void Actualizar_Etapa_SubEtapa_SaltarASubEtapa(string codigoProyecto, string codigoUsuario, string codigoRol, byte numeroSubEtapaASaltar)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_Etapa_SubEtapa_SaltarASubEtapa(codigoProyecto, codigoUsuario, codigoRol, numeroSubEtapaASaltar);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_Etapa_SubEtapa_SaltarASubEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_Etapa_SubEtapa_SaltarASubEtapa(codigoProyecto, codigoUsuario, codigoRol, numeroSubEtapaASaltar);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_Etapa_SubEtapa_SaltarASubEtapa", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_Etapa_SubEtapa_SaltarASubEtapa", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_Etapa_SubEtapa_SaltarASubEtapa", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion
    #region GFormularioAceptacion
    public void Insertar_GFormularioAceptacion_I(EGFormularioAceptacion eGFormularioAceptacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GFormularioAceptacion_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Insertar_GFormularioAceptacion_I(eGFormularioAceptacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GFormularioAceptacion_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_GFormularioAceptacion_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GFormularioAceptacion_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public void Actualizar_GFormularioAceptacion_A(EGFormularioAceptacion eGFormularioAceptacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GFormularioAceptacion_A(eGFormularioAceptacion);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GFormularioAceptacion_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_GFormularioAceptacion_A(eGFormularioAceptacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GFormularioAceptacion_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GFormularioAceptacion_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GFormularioAceptacion_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public List<EGFormularioAceptacion> Obtener_GFormularioAceptacion_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGFormularioAceptacion> lstFormularioAceptacion = new List<EGFormularioAceptacion>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstFormularioAceptacion = clienteSWLNGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GFormularioAceptacion_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstFormularioAceptacion = clienteSWLNGAAP.Obtener_GFormularioAceptacion_O_CodigoProyecto(codigoProyecto).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GFormularioAceptacion_O_CodigoProyecto", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GFormularioAceptacion_O_CodigoProyecto", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GFormularioAceptacion_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstFormularioAceptacion;
    }
    public int Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion()
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                return clienteSWLNGAAP.Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    return clienteSWLNGAAP.Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GFormularioAceptacion_O_SiguienteCodigoFormularioAceptacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion
    #region GObservacion
    public void Insertar_GObservacion_I(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GObservacion_I(codigoObservacion, codigoProyecto, codigoSubEtapa, codigoUsuarioObservacion, comentarioObservacion, tipoObservacion, estadoObservacion);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GObservacion_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Insertar_GObservacion_I(codigoObservacion, codigoProyecto, codigoSubEtapa, codigoUsuarioObservacion, comentarioObservacion, tipoObservacion, estadoObservacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GObservacion_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_GObservacion_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GObservacion_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public int Obtener_GObsevacion_O_SiguienteCodigoObservacion()
    {
        int siguienteCodigo = 0;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                siguienteCodigo = clienteSWLNGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GObsevacion_O_SiguienteCodigoObservacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    siguienteCodigo = clienteSWLNGAAP.Obtener_GObsevacion_O_SiguienteCodigoObservacion();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GObsevacion_O_SiguienteCodigoObservacion", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GObsevacion_O_SiguienteCodigoObservacion", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GObsevacion_O_SiguienteCodigoObservacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return siguienteCodigo;
    }
    public List<EGObservacion> Obtener_GObservacion_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGObservacion> lstObservacion = new List<EGObservacion>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstObservacion = clienteSWLNGAAP.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GObservacion_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstObservacion = clienteSWLNGAAP.Obtener_GObservacion_O_CodigoProyecto(codigoProyecto).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GObservacion_O_CodigoProyecto", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GObservacion_O_CodigoProyecto", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GObservacion_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstObservacion;
    }

    public EGObservacion Obtener_GObservacion_O_CodigoObservacion(int CodigoObservacion)
    {
        EGObservacion eGObservacion = new EGObservacion();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGObservacion = clienteSWLNGAAP.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GObservacion_O_CodigoObservacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGObservacion = clienteSWLNGAAP.Obtener_GObservacion_O_CodigoObservacion(CodigoObservacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GObservacion_O_CodigoObservacion", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GObservacion_O_CodigoObservacion", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GObservacion_O_CodigoObservacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGObservacion;
    }
    public void Actualizar_GObservacion_A(int codigoObservacion, string codigoProyecto, int codigoSubEtapa, string codigoUsuarioObservacion, string comentarioObservacion, char tipoObservacion, char estadoObservacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GObservacion_A(codigoObservacion, codigoProyecto, codigoSubEtapa, codigoUsuarioObservacion, comentarioObservacion, tipoObservacion, estadoObservacion);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GObservacion_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_GObservacion_A(codigoObservacion, codigoProyecto, codigoSubEtapa, codigoUsuarioObservacion, comentarioObservacion, tipoObservacion, estadoObservacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GObservacion_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GObservacion_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GObservacion_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public void Actualizar_GObservacion_A_EstadoObservacion(int codigoObservacion, char estadoObservacion)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GObservacion_A_EstadoObservacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_GObservacion_A_EstadoObservacion(codigoObservacion, estadoObservacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GObservacion_A_EstadoObservacion", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GObservacion_A_EstadoObservacion", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GObservacion_A_EstadoObservacion", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion
    #region GUsuario
    public void Insertar_GUsuario_I(string CodigoUsuario, string nombreCompletoUsuario, string SedeUsuario)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GUsuario_I(CodigoUsuario, nombreCompletoUsuario, SedeUsuario);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GUsuario_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Insertar_GUsuario_I(CodigoUsuario, nombreCompletoUsuario, SedeUsuario);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GUsuario_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_GUsuario_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GUsuario_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public EGUsuario Obtener_GUsuario_O_CodigoUsuario(string codigoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGUsuario = clienteSWLNGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuario_O_CodigoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGUsuario = clienteSWLNGAAP.Obtener_GUsuario_O_CodigoUsuario(codigoUsuario);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuario_O_CodigoUsuario", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuario_O_CodigoUsuario", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuario_O_CodigoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGUsuario;
    }
    public List<EGUsuario> Obtener_GUsuarios_O_CodigoProyecto(string codigoProyecto)
    {
        List<EGUsuario> lstEGUsuarios = new List<EGUsuario>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarios = clienteSWLNGAAP.Obtener_GUsuarios_O_CodigoProyecto(codigoProyecto).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarios_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGUsuarios = clienteSWLNGAAP.Obtener_GUsuarios_O_CodigoProyecto(codigoProyecto).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarios_O_CodigoProyecto", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuarios_O_CodigoProyecto", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuarios_O_CodigoProyecto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGUsuarios;
    }
    public EGUsuario Obtener_GUsuario_O_NombreCompletoUsuario(string nombreCompletoUsuario)
    {
        EGUsuario eGUsuario = new EGUsuario();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGUsuario = clienteSWLNGAAP.Obtener_GUsuario_O_NombreCompletoUsuario(nombreCompletoUsuario);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuario_O_NombreCompletoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGUsuario = clienteSWLNGAAP.Obtener_GUsuario_O_NombreCompletoUsuario(nombreCompletoUsuario);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuario_O_NombreCompletoUsuario", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GUsuario_O_NombreCompletoUsuario", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GUsuario_O_NombreCompletoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGUsuario;
    }
    public List<EGUsuario> Buscar_GUsuario_B_NombreCompletoUsuario(string nombreCompletoUsuario)
    {
        List<EGUsuario> lstEGUsuarios = new List<EGUsuario>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGUsuarios = clienteSWLNGAAP.Buscar_GUsuario_B_NombreCompletoUsuario(nombreCompletoUsuario).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Buscar_GUsuario_B_NombreCompletoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGUsuarios = clienteSWLNGAAP.Buscar_GUsuario_B_NombreCompletoUsuario(nombreCompletoUsuario).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Buscar_GUsuario_B_NombreCompletoUsuario", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Buscar_GUsuario_B_NombreCompletoUsuario", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Buscar_GUsuario_B_NombreCompletoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGUsuarios;
    }
    public void Actualizar_GUsuario_A(string codigoUsuario, string nombreCompletoUsuario, string sedeUsuario)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GUsuario_A(codigoUsuario, nombreCompletoUsuario, sedeUsuario);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GUsuario_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_GUsuario_A(codigoUsuario, nombreCompletoUsuario, sedeUsuario);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GUsuario_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GUsuario_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GUsuario_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    #endregion
    #region GRol
    public List<EGRol> Obtener_GRol_O()
    {
        List<EGRol> lstEGRol = new List<EGRol>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGRol = clienteSWLNGAAP.Obtener_GRol_O().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEGRol;
    }
    public EGRol Obtener_GRol_O_CodigoRol(string codigoRol)
    {
        EGRol eGRol = new EGRol();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGRol = clienteSWLNGAAP.Obtener_GRol_O_CodigoRol(codigoRol);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eGRol;
    }
    #endregion
    #region UsuarioNetvalle
    public EUsuarioNetvalle Obtener_UsuarioNetvalle_O_CodigoUsuario(string codigoUsuario)
    {
        EUsuarioNetvalle eUsuarioNetvalle = new EUsuarioNetvalle();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eUsuarioNetvalle = clienteSWLNGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_UsuarioNetvalle_O_CodigoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eUsuarioNetvalle = clienteSWLNGAAP.Obtener_UsuarioNetvalle_O_CodigoUsuario(codigoUsuario);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_UsuarioNetvalle_O_CodigoUsuario", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_UsuarioNetvalle_O_CodigoUsuario", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_UsuarioNetvalle_O_CodigoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eUsuarioNetvalle;
    }
    #endregion
    #region Metodos Complejos

    #region GProyectoCompleja
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(string codigoUsuario)
    {
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGProyectos = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGProyectos = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja(codigoUsuario).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGProyectos;
    }
    public List<EProyectoCompleja> Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(string codigoUsuario)
    {
        List<EProyectoCompleja> lstEGProyectos = new List<EProyectoCompleja>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGProyectos = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(codigoUsuario).ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGProyectos = clienteSWLNGAAP.Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos(codigoUsuario).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GProyecto_O_CodigoUsuario_ProyectoCompleja_Todos", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGProyectos;
    }
    public bool Verificar_GProyecto_CorrespondeRevision(string codigoRol, EGSubEtapa eGSubEtapa)
    {
        bool esValido;
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                esValido = clienteSWLNGAAP.Verificar_GProyecto_CorrespondeRevision(codigoRol, eGSubEtapa);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Verificar_GProyecto_CorrespondeRevision", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    esValido = clienteSWLNGAAP.Verificar_GProyecto_CorrespondeRevision(codigoRol, eGSubEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Verificar_GProyecto_CorrespondeRevision", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Verificar_GProyecto_CorrespondeRevision", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Verificar_GProyecto_CorrespondeRevision", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return esValido;
    }
    public void Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(string codigoProyecto, string codigoUsuario, string codigoRol)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(codigoProyecto, codigoUsuario, codigoRol);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_Etapa_SubEtapa_AvanzarEnFlujo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_Etapa_SubEtapa_AvanzarEnFlujo(codigoProyecto, codigoUsuario, codigoRol);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_Etapa_SubEtapa_AvanzarEnFlujo", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_Etapa_SubEtapa_AvanzarEnFlujo", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_Etapa_SubEtapa_AvanzarEnFlujo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public void Insertar_ProyectoCompleto(string codigoProyecto, string codigoUsuarioEstudiante, string codigoUsuarioDirector, string codigoUsuarioDAAP, int diasEtapa, int diasSubEtapa)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_ProyectoCompleto(codigoProyecto, codigoUsuarioEstudiante, codigoUsuarioDirector, codigoUsuarioDAAP, diasEtapa, diasSubEtapa);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_ProyectoCompleto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Insertar_ProyectoCompleto(codigoProyecto, codigoUsuarioEstudiante, codigoUsuarioDirector, codigoUsuarioDAAP, diasEtapa, diasSubEtapa);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_ProyectoCompleto", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_ProyectoCompleto", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_ProyectoCompleto", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion

    #region EUsuarioCompleto
    public EUsuarioCompleto Obtener_EUsuarioCompleto_O(string codigoUsuario, string codigoProyecto)
    {
        EUsuarioCompleto eEUsuarioCompleto = new EUsuarioCompleto();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eEUsuarioCompleto = clienteSWLNGAAP.Obtener_EUsuarioCompleto_O(codigoUsuario, codigoProyecto);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EUsuarioCompleto_O", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eEUsuarioCompleto = clienteSWLNGAAP.Obtener_EUsuarioCompleto_O(codigoUsuario, codigoProyecto);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EUsuarioCompleto_O", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_EUsuarioCompleto_O", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EUsuarioCompleto_O", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eEUsuarioCompleto;
    }
    #endregion

    #endregion

    #region Cifrado y descifrado
    public string Descifrar_Cadena(string Texto, string Tipo)
    {
        string textoDescifrado = string.Empty;
        try
        {
            using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
            {
                textoDescifrado = sWLNGAAPClient.Descifrado(Texto, Tipo);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient sWLNServicioClient = new SWLNGAAPClient())
                {
                    textoDescifrado = sWLNServicioClient.Descifrado(Texto, Tipo);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", communicationException.ToString(), communicationException.Message, communicationException.StackTrace);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return textoDescifrado;
    }

    public string Cifrar_Cadena(string TextoACifrar)
    {
        string textoCifrado = string.Empty;

        try
        {
            using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
            {
                textoCifrado = sWLNGAAPClient.Cifrar_Cadena(TextoACifrar);
                //textoCifrado = sWLNServicioClient.Adicionar_VSolicitud()
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
                {
                    textoCifrado = sWLNGAAPClient.Cifrar_Cadena(TextoACifrar);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", communicationException.ToString(), communicationException.Message, communicationException.StackTrace);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return textoCifrado;
    }
    #endregion

    #region EEmpleado
    public Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string Id_Emp, string SedeAcademica)
    {
        Tuple<EEmpleado, EMensajeError> result;
        try
        {
            using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
            {
                result = sWLNGAAPClient.Obtener_Empleado_Id_Emp_SedeAcademica(Id_Emp, SedeAcademica);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
                {
                    result = sWLNGAAPClient.Obtener_Empleado_Id_Emp_SedeAcademica(Id_Emp, SedeAcademica);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_Empleado_Id_Emp_SedeAcademica", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return result;
    }

    public Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string Id_Emp, string SedeAcademica)
    {
        Tuple<byte[], EMensajeError> result;
        try
        {
            using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
            {
                result = sWLNGAAPClient.Obtener_EmpleadoFotografia(Id_Emp, SedeAcademica);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient sWLNGAAPClient = new SWLNGAAPClient())
                {
                    result = sWLNGAAPClient.Obtener_EmpleadoFotografia(Id_Emp, SedeAcademica);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_EmpleadoFotografia", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return result;
    }

    #endregion

    #region GCelular
    public void Insertar_GCelular_I(string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        try
        {
            using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
            {
                swlnGAAP.Insertar_GCelular_I(codigoUsuario, codigoAreaCelular, numeroCelular);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GCelular_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
                {
                    swlnGAAP.Insertar_GCelular_I(codigoUsuario, codigoAreaCelular, numeroCelular);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GCelular_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_GCelular_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GCelular_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public EGCelular Obtener_GCelular_O_CodigoUsuario(string codigoUsuario)
    {
        EGCelular celular = new EGCelular();
        try
        {
            using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
            {
                celular = swlnGAAP.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GCelular_O_CodigoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
                {
                    celular = swlnGAAP.Obtener_GCelular_O_CodigoUsuario(codigoUsuario);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GCelular_O_CodigoUsuario", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GCelular_O_CodigoUsuario", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GCelular_O_CodigoUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return celular;
    }
    public void Actualizar_GCelular_A(int codigoCelular, string codigoUsuario, string codigoAreaCelular, int numeroCelular)
    {
        try
        {
            using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
            {
                swlnGAAP.Actualizar_GCelular_A(codigoCelular, codigoUsuario, codigoAreaCelular, numeroCelular);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GCelular_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
                {
                    swlnGAAP.Actualizar_GCelular_A(codigoCelular, codigoUsuario, codigoAreaCelular, numeroCelular);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GCelular_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GCelular_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GCelular_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    public void Eliminar_GCelular_E(int codigoCelular)
    {
        try
        {
            using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
            {
                swlnGAAP.Eliminar_GCelular_E(codigoCelular);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GCelular_E", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient swlnGAAP = new SWLNGAAPClient())
                {
                    swlnGAAP.Eliminar_GCelular_E(codigoCelular);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GCelular_E", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Eliminar_GCelular_E", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GCelular_E", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion

    #region GTutorExterno

    public List<EGTutorExterno> Obtener_GTutorExterno_O()
    {
        List<EGTutorExterno> lstEGTutorExterno = new List<EGTutorExterno>();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                lstEGTutorExterno = clienteSWLNGAAP.Obtener_GTutorExterno_O().ToList();
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GTutorExterno_O", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    lstEGTutorExterno = clienteSWLNGAAP.Obtener_GTutorExterno_O().ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GTutorExterno_O", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GTutorExterno_O", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GTutorExterno_O", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEGTutorExterno;
    }

    public EGTutorExterno Obtener_GTutorExterno_O_CodigoTutorExterno(string codigoTutorExterno)
    {
        EGTutorExterno eGTutorExterno = new EGTutorExterno();
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                eGTutorExterno = clienteSWLNGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GTutorExterno_O_CodigoTutorExterno", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    eGTutorExterno = clienteSWLNGAAP.Obtener_GTutorExterno_O_CodigoTutorExterno(codigoTutorExterno);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GTutorExterno_O_CodigoTutorExterno", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_GTutorExterno_O_CodigoTutorExterno", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_GTutorExterno_O_CodigoTutorExterno", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eGTutorExterno;
    }

    public void Insertar_GTutorExterno_I(string codigoTutorExterno, string nombreCompletoTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Insertar_GTutorExterno_I(codigoTutorExterno, nombreCompletoTutorExterno, carreraTutorExterno, direccionTrabajoTutorExterno, descripcionTutorExterno, sedeTutorExterno);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GTutorExterno_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Insertar_GTutorExterno_I(codigoTutorExterno, nombreCompletoTutorExterno, carreraTutorExterno, direccionTrabajoTutorExterno, descripcionTutorExterno, sedeTutorExterno);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GTutorExterno_I", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_GTutorExterno_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_GTutorExterno_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Actualizar_GTutorExterno_A(string codigoTutorExterno, string nombreCompletoTutorExterno, string carreraTutorExterno, string direccionTrabajoTutorExterno, string descripcionTutorExterno, string sedeTutorExterno)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Actualizar_GTutorExterno_A(codigoTutorExterno, nombreCompletoTutorExterno, carreraTutorExterno, direccionTrabajoTutorExterno, descripcionTutorExterno, sedeTutorExterno);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GTutorExterno_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Actualizar_GTutorExterno_A(codigoTutorExterno, nombreCompletoTutorExterno, carreraTutorExterno, direccionTrabajoTutorExterno, descripcionTutorExterno, sedeTutorExterno);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GTutorExterno_A", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_GTutorExterno_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_GTutorExterno_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Eliminar_GTutorExterno_E(string codigoTutorExterno)
    {
        try
        {
            using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
            {
                clienteSWLNGAAP.Eliminar_GTutorExterno_E(codigoTutorExterno);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GTutorExterno_E", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNGAAPClient clienteSWLNGAAP = new SWLNGAAPClient())
                {
                    clienteSWLNGAAP.Eliminar_GTutorExterno_E(codigoTutorExterno);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GTutorExterno_E", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Eliminar_GTutorExterno_E", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Eliminar_GTutorExterno_E", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion




    #endregion
}