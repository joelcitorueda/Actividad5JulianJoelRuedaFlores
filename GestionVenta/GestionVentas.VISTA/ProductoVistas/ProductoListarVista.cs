using GestionVentas.BSS;
using GestionVentas.VISTA.DetalleVentaVistas;
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

namespace GestionVentas.VISTA.ProductoVistas
{
	public partial class ProductoListarVista : Form
	{
		public ProductoListarVista()
		{
			InitializeComponent();
		}
		ProductoBss bss = new ProductoBss();

		private void button2_Click(object sender, EventArgs e)
		{
			ProductoInsertarVista fr = new ProductoInsertarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarProductoBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			ProductoEditarVista fr = new ProductoEditarVista(IdSeleccionada);
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarProductoBss();
			}
		}

		private void ProductoListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarProductoBss();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Venta?", "Eliminando", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarProductoBss(IdSeleccionada);
				dataGridView1.DataSource = bss.ListarProductoBss();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DetalleVentaVistas.DetalleVentaInsertarVista.IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DetalleVentaVistas.DetalleVentaEditarVista.IdProductoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!pServicios.Visible)
				pServicios.Visible = true;
			else
				pServicios.Visible = false;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			DetalleVentaListarVista detalleingForm = new DetalleVentaListarVista();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			VentaListarVista detalleingForm = new VentaListarVista();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}
	}
}
