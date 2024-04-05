using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GestionVentas.DAL
{
	public class conexion
	{
		public static string CONECTAR
		{
			get { return @"Data Source=DESKTOP-EROEUF5; Initial Catalog=GESTIONVENTABD; Integrated Security=True; TrustServerCertificate=true;"; }
			//get { return ConfigurationManager.ConnectionStrings["cadena"].ToString(); }
		}
		public static DataSet EjecutarDataSet(string consulta)
		{
			string p = conexion.CONECTAR;
			SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
			conectar.Open();
			SqlCommand cmd = new SqlCommand(consulta, conectar);
			SqlDataAdapter da = new SqlDataAdapter();
			da.SelectCommand = cmd;
			DataSet ds = new DataSet();
			da.Fill(ds, "TABLA");
			return ds;
		}

		public static void Ejecutar(string consulta)
		{
			SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
			conectar.Open();
			SqlCommand cmd = new SqlCommand(consulta, conectar);
			cmd.CommandTimeout = 5000;
			cmd.ExecuteNonQuery();
		}

		public static int EjecutarEscalar(string consulta)
		{
			SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
			conectar.Open();

			SqlCommand cmd = new SqlCommand(consulta, conectar);
			cmd.CommandTimeout = 5000;
			int dev = Convert.ToInt32(cmd.ExecuteScalar());
			return dev;
		}
		public static DataTable EjecutarDataTabla(string consulta, string tabla)
		{
			string p = conexion.CONECTAR;
			SqlConnection conectar = new SqlConnection(conexion.CONECTAR);
			SqlCommand cmd = new SqlCommand(consulta, conectar);
			cmd.CommandTimeout = 5000;
			SqlDataAdapter da = new SqlDataAdapter();
			da.SelectCommand = cmd;
			DataTable dt = new DataTable(tabla);
			da.Fill(dt);
			return dt;
		}

		public static DataTable EjecutarDataTabla(string consulta, string nombreTabla, Dictionary<string, object> parametros = null)
		{
			using (SqlConnection conexion = new SqlConnection(CONECTAR))
			{
				SqlCommand comando = new SqlCommand(consulta, conexion);
				if (parametros != null)
				{
					foreach (var kvp in parametros)
					{
						comando.Parameters.AddWithValue(kvp.Key, kvp.Value);
					}
				}

				SqlDataAdapter adaptador = new SqlDataAdapter(comando);
				DataTable tabla = new DataTable(nombreTabla);
				adaptador.Fill(tabla);
				return tabla;
			}
		}

		public static void Ejecutar(string consulta, Dictionary<string, object> parametros = null)
		{
			using (SqlConnection conexion = new SqlConnection(CONECTAR))
			{
				conexion.Open();
				SqlCommand comando = new SqlCommand(consulta, conexion);
				if (parametros != null)
				{
					foreach (var kvp in parametros)
					{
						if (kvp.Value is int)
							comando.Parameters.AddWithValue(kvp.Key, SqlDbType.Int).Value = kvp.Value;
						else if (kvp.Value is decimal)
							comando.Parameters.AddWithValue(kvp.Key, SqlDbType.Decimal).Value = kvp.Value;
						else
							comando.Parameters.AddWithValue(kvp.Key, kvp.Value);
					}
				}
				comando.ExecuteNonQuery();
			}
		}
	}
}
