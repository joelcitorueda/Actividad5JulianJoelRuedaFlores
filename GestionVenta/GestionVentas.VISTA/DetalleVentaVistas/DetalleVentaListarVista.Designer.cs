namespace GestionVentas.VISTA.DetalleVentaVistas
{
	partial class DetalleVentaListarVista
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleVentaListarVista));
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			dataGridView1 = new DataGridView();
			button5 = new Button();
			pServicios = new Panel();
			button7 = new Button();
			button6 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			pServicios.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Image = Properties.Resources.icons8_marque_todas_las_27;
			button1.ImageAlign = ContentAlignment.BottomRight;
			button1.Location = new Point(591, 52);
			button1.Name = "button1";
			button1.Size = new Size(163, 34);
			button1.TabIndex = 49;
			button1.Text = "SELECCIONAR";
			button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(47, 106);
			label1.Name = "label1";
			label1.Size = new Size(278, 25);
			label1.TabIndex = 48;
			label1.Text = "LISTADO DE DETALLES VENTAS";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(230, 9);
			label2.Name = "label2";
			label2.Size = new Size(353, 25);
			label2.TabIndex = 47;
			label2.Text = "ADMINISTRACION DE DETALLE VENTAS";
			// 
			// button4
			// 
			button4.Image = Properties.Resources.icons8_eliminar_27;
			button4.ImageAlign = ContentAlignment.MiddleRight;
			button4.Location = new Point(401, 52);
			button4.Name = "button4";
			button4.Size = new Size(163, 34);
			button4.TabIndex = 46;
			button4.Text = "ELIMINAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Image = Properties.Resources.icons8_editar_27;
			button3.ImageAlign = ContentAlignment.MiddleRight;
			button3.Location = new Point(199, 52);
			button3.Name = "button3";
			button3.Size = new Size(168, 34);
			button3.TabIndex = 45;
			button3.Text = "EDITAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.ImageAlign = ContentAlignment.BottomRight;
			button2.Location = new Point(20, 52);
			button2.Name = "button2";
			button2.Size = new Size(163, 34);
			button2.TabIndex = 44;
			button2.Text = "AGREGAR";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(89, 150);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(607, 312);
			dataGridView1.TabIndex = 43;
			// 
			// button5
			// 
			button5.Image = (Image)resources.GetObject("button5.Image");
			button5.Location = new Point(694, 0);
			button5.Name = "button5";
			button5.Size = new Size(60, 47);
			button5.TabIndex = 50;
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// pServicios
			// 
			pServicios.BackColor = SystemColors.HotTrack;
			pServicios.Controls.Add(button7);
			pServicios.Controls.Add(button6);
			pServicios.Location = new Point(596, 52);
			pServicios.Name = "pServicios";
			pServicios.Size = new Size(158, 108);
			pServicios.TabIndex = 51;
			pServicios.Visible = false;
			// 
			// button7
			// 
			button7.FlatAppearance.MouseOverBackColor = Color.Lime;
			button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button7.Location = new Point(0, 57);
			button7.Name = "button7";
			button7.Size = new Size(158, 43);
			button7.TabIndex = 8;
			button7.Text = "Productos";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button6
			// 
			button6.FlatAppearance.MouseOverBackColor = Color.Lime;
			button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button6.Location = new Point(0, 15);
			button6.Name = "button6";
			button6.Size = new Size(158, 43);
			button6.TabIndex = 7;
			button6.Text = "Ventas";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// DetalleVentaListarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 514);
			Controls.Add(pServicios);
			Controls.Add(button5);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(dataGridView1);
			Name = "DetalleVentaListarVista";
			Text = "DetalleVentaListarVista";
			Load += DetalleVentaListarVista_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			pServicios.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private Label label2;
		private Button button4;
		private Button button3;
		private Button button2;
		private DataGridView dataGridView1;
		private Button button5;
		private Panel pServicios;
		private Button button7;
		private Button button6;
	}
}