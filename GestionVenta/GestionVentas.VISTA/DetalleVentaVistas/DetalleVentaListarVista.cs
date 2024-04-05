using GestionVentas.BSS;
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
	public partial class DetalleVentaListarVista : Form
	{
		public DetalleVentaListarVista()
		{
			InitializeComponent();
		}
		DetalleVentaBss bss = new DetalleVentaBss();

		private void DetalleVentaListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarDetalleVentaBss();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DetalleVentaInsertarVista fr = new DetalleVentaInsertarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarDetalleVentaBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DetalleVentaEditarVista fr = new DetalleVentaEditarVista(IdSeleccionada);
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarDetalleVentaBss();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este DetalleVenta?", "Eliminando", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarDetalleVentaBss(IdSeleccionada);
				dataGridView1.DataSource = bss.ListarDetalleVentaBss();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!pServicios.Visible)
				pServicios.Visible = true;
			else
				pServicios.Visible = false;
		}
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProductoListarVista detalleingForm = new ProductoListarVista();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			VentaListarVista detalleingForm = new VentaListarVista();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}
	}
}
