namespace GestionVentas.VISTA.ProductoVistas
{
	partial class ProductoEditarVista
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
			textBox2 = new TextBox();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			textBox1 = new TextBox();
			label4 = new Label();
			label3 = new Label();
			button2 = new Button();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// textBox2
			// 
			textBox2.Location = new Point(35, 332);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(335, 27);
			textBox2.TabIndex = 83;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(108, -1);
			label1.Name = "label1";
			label1.Size = new Size(181, 28);
			label1.TabIndex = 82;
			label1.Text = "Ingresar Producto";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_producto_50;
			pictureBox1.Location = new Point(129, 47);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(141, 138);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 81;
			pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(35, 236);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(335, 27);
			textBox1.TabIndex = 80;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(9, 198);
			label4.Name = "label4";
			label4.Size = new Size(64, 20);
			label4.TabIndex = 79;
			label4.Text = "Nombre";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(9, 297);
			label3.Name = "label3";
			label3.Size = new Size(103, 20);
			label3.TabIndex = 78;
			label3.Text = "PrecioUnitario";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(224, 392);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 77;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(78, 392);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 76;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// ProductoEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(409, 450);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Controls.Add(textBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "ProductoEditarVista";
			Text = "ProductoEditarVista";
			Load += ProductoEditarVista_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox2;
		private Label label1;
		private PictureBox pictureBox1;
		private TextBox textBox1;
		private Label label4;
		private Label label3;
		private Button button2;
		private Button button1;
	}
}