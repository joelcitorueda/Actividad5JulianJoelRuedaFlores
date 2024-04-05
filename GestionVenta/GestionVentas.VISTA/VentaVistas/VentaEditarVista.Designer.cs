namespace GestionVentas.VISTA.VentaVistas
{
	partial class VentaEditarVista
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaEditarVista));
			label1 = new Label();
			pictureBox1 = new PictureBox();
			dateTimePicker1 = new DateTimePicker();
			textBox1 = new TextBox();
			label4 = new Label();
			label3 = new Label();
			button2 = new Button();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(147, 15);
			label1.Name = "label1";
			label1.Size = new Size(149, 28);
			label1.TabIndex = 74;
			label1.Text = "Ingresar Venta";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(167, 61);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(117, 114);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 73;
			pictureBox1.TabStop = false;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(66, 249);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(335, 27);
			dateTimePicker1.TabIndex = 72;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(66, 344);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(335, 27);
			textBox1.TabIndex = 71;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(27, 206);
			label4.Name = "label4";
			label4.Size = new Size(54, 20);
			label4.TabIndex = 70;
			label4.Text = "FECHA";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(27, 300);
			label3.Name = "label3";
			label3.Size = new Size(50, 20);
			label3.TabIndex = 69;
			label3.Text = "TOTAL";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(268, 414);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 68;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(138, 414);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 67;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// VentaEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(462, 488);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Controls.Add(dateTimePicker1);
			Controls.Add(textBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "VentaEditarVista";
			Text = "VentaEditarVista";
			Load += VentaEditarVista_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private PictureBox pictureBox1;
		private DateTimePicker dateTimePicker1;
		private TextBox textBox1;
		private Label label4;
		private Label label3;
		private Button button2;
		private Button button1;
	}
}