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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionVentas.VISTA.VentaVistas
{
	public partial class VentaEditarVista : Form
	{
		int idx = 0;
		Venta p = new Venta();
		VentaBss bss = new VentaBss();
		public VentaEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
		
			p.FechaVenta = dateTimePicker1.Value;
			p.TotalVenta = Convert.ToDecimal(textBox1.Text);
			
			bss.EditarVentaBss(p);
			MessageBox.Show("Datos Actualizados");
		}

		private void VentaEditarVista_Load(object sender, EventArgs e)
		{
			p = bss.ObtenerVentaIdBss(idx);
			dateTimePicker1.Value = p.FechaVenta;
			textBox1.Text = p.TotalVenta.ToString();
			
		}
	}
}
