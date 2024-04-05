using GestionVentas.BSS;
using GestionVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVentas.VISTA.VentaVistas
{
	public partial class VentaInsertarVista : Form
	{
		public VentaInsertarVista()
		{
			InitializeComponent();
		}
		VentaBss bss = new VentaBss();

		private void button1_Click(object sender, EventArgs e)
		{
			Venta p = new Venta();

			p.FechaVenta = dateTimePicker1.Value;
			p.TotalVenta = Convert.ToDecimal(textBox1.Text);


			bss.InsertarVentaBss(p);
			MessageBox.Show("Se guardó correctamente a Venta");
		}

		private void VentaInsertarVista_Load(object sender, EventArgs e)
		{

		}
	}
}
