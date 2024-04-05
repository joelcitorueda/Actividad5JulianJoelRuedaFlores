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

namespace GestionVentas.VISTA.ProductoVistas
{
	public partial class ProductoInsertarVista : Form
	{
		public ProductoInsertarVista()
		{
			InitializeComponent();
		}
		ProductoBss bss = new ProductoBss();

		private void button1_Click(object sender, EventArgs e)
		{
			Producto p = new Producto();

			p.NombreProducto = textBox1.Text;
			p.PrecioUnitario = Convert.ToDecimal(textBox2.Text);


			bss.InsertarProductoBss(p);
			MessageBox.Show("Se guardó correctamente a Venta");
		}
	}
}
