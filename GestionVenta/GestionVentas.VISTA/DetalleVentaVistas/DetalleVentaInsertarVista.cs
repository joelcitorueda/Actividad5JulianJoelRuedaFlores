using GestionVentas.BSS;
using GestionVentas.Modelos;
using GestionVentas.VISTA.ProductoVistas;
using GestionVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentas.VISTA.DetalleVentaVistas
{
	public partial class DetalleVentaInsertarVista : Form
	{
		public DetalleVentaInsertarVista()
		{
			InitializeComponent();
		}
		DetalleVentaBss bss = new DetalleVentaBss();

		private void button1_Click(object sender, EventArgs e)
		{
			DetalleVenta p = new DetalleVenta();
			p.IdVenta = IdVentaSeleccionada;
			p.IdProducto = IdProductoSeleccionada;
			p.Cantidad = Convert.ToInt32(textBox3.Text);
			p.PrecioUnitario = Convert.ToDecimal(textBox4.Text);
			p.TotalDetalle = Convert.ToDecimal(textBox5.Text);
			bss.InsertarDetalleVentaBss(p);
			MessageBox.Show("Se guardó correctamente a Detalle Venta");
		}
		public static int IdVentaSeleccionada = 0;
		VentaBss bssven = new VentaBss();

		private void button3_Click(object sender, EventArgs e)
		{
			VentaListarVista fr = new VentaListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Venta venta = bssven.ObtenerVentaIdBss(IdVentaSeleccionada);
				textBox1.Text = venta.IdVenta.ToString();
			}
		}
		public static int IdProductoSeleccionada = 0;
		ProductoBss bsspro = new ProductoBss();

		private void button4_Click(object sender, EventArgs e)
		{
			ProductoListarVista fr = new ProductoListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Producto producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
				textBox2.Text = producto.NombreProducto;
			}
		}
	}
}
