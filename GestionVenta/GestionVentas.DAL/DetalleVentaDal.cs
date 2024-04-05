using GestionVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.DAL
{
	public class DetalleVentaDal
	{
		public DataTable ListarDetalleVentaDal()
		{
			string consulta = "SELECT * FROM DETALLEVENTA";

			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}

		public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
		{
			string consulta = "insert into detalleventa values (" + detalleVenta.IdVenta + ", "
														 + detalleVenta.IdProducto + ", "
														 + detalleVenta.Cantidad + ","
														  + detalleVenta.PrecioUnitario + ", "
														  + detalleVenta.TotalDetalle + ")";
			conexion.Ejecutar(consulta);
		}
		DetalleVenta p = new DetalleVenta();
		public DetalleVenta ObtenerDetalleVentaIdDal(int id)
		{
			string consulta = "select * from detalleventa where iddetalleventa=" + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			if (tabla.Rows.Count > 0)
			{
				p.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
				p.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
				p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
				p.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
				p.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["preciounitario"]);
				p.TotalDetalle = Convert.ToDecimal(tabla.Rows[0]["totaldetalle"]);

			}
			return p;
		}

		public void EditarDetalleVentaDal(DetalleVenta detalleVenta)
		{
			string consulta = "update detalleventa set idventa=" + p.IdVenta + "," +
														"idproducto=" + p.IdProducto + "," +
														"cantidad=" + p.Cantidad + "," +
														"preciounitario=" + p.PrecioUnitario + "," +
														"totaldetalle=" + p.TotalDetalle + " " +
												"where iddetalleventa=" + p.IdDetalleVenta;
			conexion.Ejecutar(consulta);
		}

		public void EliminarDetalleVentaDal(int id)
		{
			string consulta = "delete from detalleventa where iddetalleventa=" + id;
			conexion.Ejecutar(consulta);
		}
		


	}
}
