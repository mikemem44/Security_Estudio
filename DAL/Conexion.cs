using System.Data.SqlClient;
namespace DAL
{
	 public static class Conexion
	{
		private static string NombreAplicacion = "GeneradorCapas";
		private static string Servidor = @"DESKTOP-I3CJ3Q1\SQL2022";
		private static string Usuario = "";
		private static string Password = "";
		private static string BaseDatos = "InformaticSecuriy";

		public static string ConexionString(bool SqlAutentication = true)
		{
			 SqlConnectionStringBuilder Constructor = new SqlConnectionStringBuilder()
			{
				  ApplicationName = NombreAplicacion,
				 IntegratedSecurity = SqlAutentication,
				 DataSource = Servidor,
				  InitialCatalog = BaseDatos
			};
			 if (SqlAutentication)
			{
				  Constructor.UserID = Usuario;
				  Constructor.Password = Password;
			}
			 return Constructor.ConnectionString;
		}
	}
}
