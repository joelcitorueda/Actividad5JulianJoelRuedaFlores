using GestionVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.DAL
{
	public class ProductoDal
	{
		public DataTable ListarProductoDal()
		{
			string consulta = "select * from PRODUCTO";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "producto");
			return lista;
		}

		public void InsertarProductoDal(Producto producto)
		{
			string consulta = "INSERT INTO PRODUCTO (NOMBREPRODUCTO, PRECIOUNITARIO) VALUES ('" + producto.NombreProducto + "', " + producto.PrecioUnitario + ")";
			conexion.Ejecutar(consulta);
		}

		public Producto ObtenerProductoIdDal(int id)
		{
			Producto producto = new Producto();
			string consulta = "SELECT * FROM PRODUCTO WHERE IDPRODUCTO = " + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "producto");

			if (tabla.Rows.Count > 0)
			{
				producto.IdProducto = Convert.ToInt32(tabla.Rows[0]["IDPRODUCTO"]);
				producto.NombreProducto = tabla.Rows[0]["NOMBREPRODUCTO"].ToString();
				producto.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["PRECIOUNITARIO"]);
			}

			return producto;
		}

		public void EditarProductoDal(Producto producto)
		{
			string consulta = "UPDATE PRODUCTO SET NOMBREPRODUCTO = '" + producto.NombreProducto + "', " +
													 "PRECIOUNITARIO = " + producto.PrecioUnitario + " " +
							  "WHERE IDPRODUCTO = " + producto.IdProducto;
			conexion.Ejecutar(consulta);
		}

		public void EliminarProductoDal(int id)
		{
			string consulta = "DELETE FROM PRODUCTO WHERE IDPRODUCTO = " + id;
			conexion.Ejecutar(consulta);
		}

	}
}
