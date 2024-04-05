using GestionVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.DAL
{
	public class VentaDal
	{
		public DataTable ListarVentaDal()
		{
			string consulta = "select * from VENTA";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "venta");
			return lista;
		}

		public void InsertarVentaDal(Venta venta)
		{
			string consulta = "INSERT INTO VENTA (FECHAVENTA, TOTALVENTA) VALUES ('" + venta.FechaVenta + "', " + venta.TotalVenta + ")";
			conexion.Ejecutar(consulta);
		}

		public Venta ObtenerVentaIdDal(int id)
		{
			Venta venta = new Venta();
			string consulta = "SELECT * FROM VENTA WHERE IDVENTA = " + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "venta");

			if (tabla.Rows.Count > 0)
			{
				venta.IdVenta = Convert.ToInt32(tabla.Rows[0]["IDVENTA"]);
				venta.FechaVenta = Convert.ToDateTime(tabla.Rows[0]["FECHAVENTA"]);
				venta.TotalVenta = Convert.ToDecimal(tabla.Rows[0]["TOTALVENTA"]);
			}

			return venta;
		}

		public void EditarVentaDal(Venta venta)
		{
			string consulta = "UPDATE VENTA SET FECHAVENTA = '" + venta.FechaVenta + "', " +
												"TOTALVENTA = " + venta.TotalVenta + " " +
							  "WHERE IDVENTA = " + venta.IdVenta;
			conexion.Ejecutar(consulta);
		}

		public void EliminarVentaDal(int id)
		{
			string consulta = "DELETE FROM VENTA WHERE IDVENTA = " + id;
			conexion.Ejecutar(consulta);
		}
	}
}
