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
	public partial class DetalleVentaEditarVista : Form
	{
		int idx = 0;
		DetalleVenta p = new DetalleVenta();
		DetalleVentaBss bss = new DetalleVentaBss();
		public DetalleVentaEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}

		private void DetalleVentaEditarVista_Load(object sender, EventArgs e)
		{
			p = bss.ObtenerDetalleVentaIdBss(idx);
			textBox1.Text = p.IdVenta.ToString();
			textBox2.Text = p.IdProducto.ToString();
			textBox3.Text = p.Cantidad.ToString();
			textBox4.Text = p.PrecioUnitario.ToString();
			textBox5.Text = p.TotalDetalle.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			p.IdVenta = IdVentaSeleccionada;
			p.IdProducto = IdProductoSeleccionada;
			p.Cantidad = Convert.ToInt32(textBox3.Text);
			p.PrecioUnitario = Convert.ToDecimal(textBox4.Text);
			p.TotalDetalle = Convert.ToDecimal(textBox5.Text);

			bss.EditarDetalleVentaBss(p);
			MessageBox.Show("Datos Actualizados");
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
