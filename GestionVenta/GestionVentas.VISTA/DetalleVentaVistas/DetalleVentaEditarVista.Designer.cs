﻿namespace GestionVentas.VISTA.DetalleVentaVistas
{
	partial class DetalleVentaEditarVista
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
			label6 = new Label();
			pictureBox1 = new PictureBox();
			button4 = new Button();
			button3 = new Button();
			textBox5 = new TextBox();
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label5 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			button2 = new Button();
			button1 = new Button();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(116, 11);
			label6.Name = "label6";
			label6.Size = new Size(202, 28);
			label6.TabIndex = 92;
			label6.Text = "Editar Detalle Venta";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_la_venta_de_tierras_50;
			pictureBox1.Location = new Point(168, 58);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(117, 114);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 91;
			pictureBox1.TabStop = false;
			// 
			// button4
			// 
			button4.Location = new Point(258, 266);
			button4.Name = "button4";
			button4.Size = new Size(127, 29);
			button4.TabIndex = 90;
			button4.Text = "SELECCIONAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Location = new Point(258, 209);
			button3.Name = "button3";
			button3.Size = new Size(127, 29);
			button3.TabIndex = 89;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(72, 434);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(313, 27);
			textBox5.TabIndex = 88;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(74, 372);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(313, 27);
			textBox4.TabIndex = 87;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(74, 318);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(313, 27);
			textBox3.TabIndex = 86;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(72, 266);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(164, 27);
			textBox2.TabIndex = 85;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(72, 209);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(164, 27);
			textBox1.TabIndex = 84;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(28, 411);
			label5.Name = "label5";
			label5.Size = new Size(76, 20);
			label5.TabIndex = 83;
			label5.Text = "SUBTOTAL";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(27, 295);
			label3.Name = "label3";
			label3.Size = new Size(83, 20);
			label3.TabIndex = 81;
			label3.Text = "CANTIDAD";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(27, 243);
			label2.Name = "label2";
			label2.Size = new Size(104, 20);
			label2.TabIndex = 80;
			label2.Text = "ID PRODUCTO";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(27, 177);
			label1.Name = "label1";
			label1.Size = new Size(73, 20);
			label1.TabIndex = 79;
			label1.Text = "ID VENTA";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(245, 494);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 78;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(116, 494);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 77;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(27, 348);
			label4.Name = "label4";
			label4.Size = new Size(128, 20);
			label4.TabIndex = 93;
			label4.Text = "PRECIO UNITARIO";
			// 
			// DetalleVentaEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(445, 558);
			Controls.Add(label4);
			Controls.Add(label6);
			Controls.Add(pictureBox1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label5);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "DetalleVentaEditarVista";
			Text = "DetalleVentaEditarVista";
			Load += DetalleVentaEditarVista_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label6;
		private PictureBox pictureBox1;
		private Button button4;
		private Button button3;
		private TextBox textBox5;
		private TextBox textBox4;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label5;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button button2;
		private Button button1;
		private Label label4;
	}
}