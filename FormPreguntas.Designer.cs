namespace proyecto_preguntas
{
	partial class FormPreguntas
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
			this.label1 = new System.Windows.Forms.Label();
			this.chlbPreguntas = new System.Windows.Forms.CheckedListBox();
			this.lblPreguntas = new System.Windows.Forms.Label();
			this.btnContinuar = new System.Windows.Forms.Button();
			this.btnMitad = new System.Windows.Forms.Button();
			this.btnCambio = new System.Windows.Forms.Button();
			this.btnLlamar = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnRetirarse = new System.Windows.Forms.Button();
			this.acum = new System.Windows.Forms.GroupBox();
			this.lblAcumulado = new System.Windows.Forms.Label();
			this.lblPesos = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.acum.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(250, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(311, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bienvenido al juego de preguntas";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// chlbPreguntas
			// 
			this.chlbPreguntas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.chlbPreguntas.CheckOnClick = true;
			this.chlbPreguntas.FormattingEnabled = true;
			this.chlbPreguntas.Location = new System.Drawing.Point(250, 158);
			this.chlbPreguntas.Name = "chlbPreguntas";
			this.chlbPreguntas.Size = new System.Drawing.Size(311, 126);
			this.chlbPreguntas.TabIndex = 5;
			this.chlbPreguntas.SelectedIndexChanged += new System.EventHandler(this.checkedListBox12_SelectedIndexChanged);
			// 
			// lblPreguntas
			// 
			this.lblPreguntas.AutoSize = true;
			this.lblPreguntas.Location = new System.Drawing.Point(250, 116);
			this.lblPreguntas.Name = "lblPreguntas";
			this.lblPreguntas.Size = new System.Drawing.Size(60, 15);
			this.lblPreguntas.TabIndex = 6;
			this.lblPreguntas.Text = "preguntas";
			this.lblPreguntas.Click += new System.EventHandler(this.lblPreguntas_Click);
			// 
			// btnContinuar
			// 
			this.btnContinuar.BackColor = System.Drawing.Color.GreenYellow;
			this.btnContinuar.Location = new System.Drawing.Point(419, 343);
			this.btnContinuar.Name = "btnContinuar";
			this.btnContinuar.Size = new System.Drawing.Size(142, 58);
			this.btnContinuar.TabIndex = 7;
			this.btnContinuar.Text = "Ultima palabra";
			this.btnContinuar.UseVisualStyleBackColor = false;
			this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
			// 
			// btnMitad
			// 
			this.btnMitad.BackColor = System.Drawing.Color.Gold;
			this.btnMitad.Location = new System.Drawing.Point(34, 37);
			this.btnMitad.Name = "btnMitad";
			this.btnMitad.Size = new System.Drawing.Size(122, 33);
			this.btnMitad.TabIndex = 8;
			this.btnMitad.Text = "50 / 50";
			this.btnMitad.UseVisualStyleBackColor = false;
			this.btnMitad.Click += new System.EventHandler(this.btnMitad_Click);
			// 
			// btnCambio
			// 
			this.btnCambio.BackColor = System.Drawing.Color.Gold;
			this.btnCambio.Location = new System.Drawing.Point(34, 164);
			this.btnCambio.Name = "btnCambio";
			this.btnCambio.Size = new System.Drawing.Size(122, 33);
			this.btnCambio.TabIndex = 9;
			this.btnCambio.Text = "Cambio pregunta";
			this.btnCambio.UseVisualStyleBackColor = false;
			this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
			// 
			// btnLlamar
			// 
			this.btnLlamar.BackColor = System.Drawing.Color.Gold;
			this.btnLlamar.Location = new System.Drawing.Point(34, 298);
			this.btnLlamar.Name = "btnLlamar";
			this.btnLlamar.Size = new System.Drawing.Size(122, 33);
			this.btnLlamar.TabIndex = 10;
			this.btnLlamar.Text = "Llamar a mamá";
			this.btnLlamar.UseVisualStyleBackColor = false;
			this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnMitad);
			this.groupBox1.Controls.Add(this.btnLlamar);
			this.groupBox1.Controls.Add(this.btnCambio);
			this.groupBox1.Location = new System.Drawing.Point(596, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(182, 354);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ayudas";
			// 
			// btnRetirarse
			// 
			this.btnRetirarse.BackColor = System.Drawing.Color.DarkOrange;
			this.btnRetirarse.Location = new System.Drawing.Point(250, 343);
			this.btnRetirarse.Name = "btnRetirarse";
			this.btnRetirarse.Size = new System.Drawing.Size(143, 58);
			this.btnRetirarse.TabIndex = 13;
			this.btnRetirarse.Text = "Retirarse";
			this.btnRetirarse.UseVisualStyleBackColor = false;
			this.btnRetirarse.Click += new System.EventHandler(this.btnRetirarse_Click);
			// 
			// acum
			// 
			this.acum.Controls.Add(this.lblAcumulado);
			this.acum.Controls.Add(this.lblPesos);
			this.acum.Location = new System.Drawing.Point(23, 158);
			this.acum.Name = "acum";
			this.acum.Size = new System.Drawing.Size(206, 126);
			this.acum.TabIndex = 14;
			this.acum.TabStop = false;
			this.acum.Text = "Acumulado";
			// 
			// lblAcumulado
			// 
			this.lblAcumulado.AutoSize = true;
			this.lblAcumulado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lblAcumulado.Location = new System.Drawing.Point(66, 48);
			this.lblAcumulado.Name = "lblAcumulado";
			this.lblAcumulado.Size = new System.Drawing.Size(19, 21);
			this.lblAcumulado.TabIndex = 2;
			this.lblAcumulado.Text = "0";
			// 
			// lblPesos
			// 
			this.lblPesos.AutoSize = true;
			this.lblPesos.Location = new System.Drawing.Point(66, 102);
			this.lblPesos.Name = "lblPesos";
			this.lblPesos.Size = new System.Drawing.Size(72, 15);
			this.lblPesos.TabIndex = 1;
			this.lblPesos.Text = "Pesos (COP)";
			// 
			// FormPreguntas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.acum);
			this.Controls.Add(this.btnRetirarse);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnContinuar);
			this.Controls.Add(this.lblPreguntas);
			this.Controls.Add(this.chlbPreguntas);
			this.Controls.Add(this.label1);
			this.Name = "FormPreguntas";
			this.Text = "FormPreguntas";
			this.Load += new System.EventHandler(this.FormPreguntas_Load);
			this.groupBox1.ResumeLayout(false);
			this.acum.ResumeLayout(false);
			this.acum.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private CheckedListBox chlbPreguntas;
		private Label lblPreguntas;
		private Button btnContinuar;
		private Button btnMitad;
		private Button btnCambio;
		private Button btnLlamar;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private GroupBox groupBox1;
		private Button btnRetirarse;
		private GroupBox acum;
		private Label lblPesos;
		private Label lblAcumulado;
	}
}