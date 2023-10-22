using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de SBaseDatos
/// </summary>
public static class SBaseDatos
{
    // Cadena de conexión para la base de datos NETGAAP
    public static Database BDSWADNETGAAP = DatabaseFactory.CreateDatabase("BDGestionDeApoyoYAsesoriaAProyectosConnectionString");

    // Cadena de conexión para la base de datos NETVALLE_USUARIOS
    public static Database DBSWADNETUSR = DatabaseFactory.CreateDatabase("BDNetvalleConnectionString");

}