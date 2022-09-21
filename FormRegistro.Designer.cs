namespace proyecto_preguntas
{
	partial class FormRegistro
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPass1 = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.txtPass2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(207, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 25);
			this.label3.TabIndex = 18;
			this.label3.Text = "Registro";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(207, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 15);
			this.label2.TabIndex = 17;
			this.label2.Text = "Contraseña";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtPass1
			// 
			this.txtPass1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPass1.Location = new System.Drawing.Point(164, 156);
			this.txtPass1.Name = "txtPass1";
			this.txtPass1.Size = new System.Drawing.Size(150, 27);
			this.txtPass1.TabIndex = 16;
			this.txtPass1.UseSystemPasswordChar = true;
			this.txtPass1.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// txtUser
			// 
			this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtUser.Location = new System.Drawing.Point(164, 94);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(150, 27);
			this.txtUser.TabIndex = 15;
			this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(218, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 15);
			this.label1.TabIndex = 14;
			this.label1.Text = "Usuario";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnRegistrar.Location = new System.Drawing.Point(164, 387);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(150, 49);
			this.btnRegistrar.TabIndex = 19;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(164, 442);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(150, 49);
			this.btnLimpiar.TabIndex = 20;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// txtPass2
			// 
			this.txtPass2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPass2.Location = new System.Drawing.Point(164, 222);
			this.txtPass2.Name = "txtPass2";
			this.txtPass2.Size = new System.Drawing.Size(150, 27);
			this.txtPass2.TabIndex = 21;
			this.txtPass2.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(187, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 15);
			this.label4.TabIndex = 22;
			this.label4.Text = "Repetir contraseña";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(164, 497);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(150, 49);
			this.btnRegresar.TabIndex = 23;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(218, 261);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 15);
			this.label5.TabIndex = 24;
			this.label5.Text = "E-mail";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(187, 321);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 15);
			this.label6.TabIndex = 25;
			this.label6.Text = "Nombre completo";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtEmail.Location = new System.Drawing.Point(134, 279);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(218, 27);
			this.txtEmail.TabIndex = 26;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtNombre.Location = new System.Drawing.Point(134, 339);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(218, 27);
			this.txtNombre.TabIndex = 27;
			// 
			// FormRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 573);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPass2);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPass1);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label1);
			this.Name = "FormRegistro";
			this.Text = "FormRegistro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label3;
		private Label label2;
		private TextBox txtPass1;
		private TextBox txtUser;
		private Label label1;
		private Button btnRegistrar;
		private Button btnLimpiar;
		private TextBox txtPass2;
		private Label label4;
		private Button btnRegresar;
		private Label label5;
		private Label label6;
		private TextBox txtEmail;
		private TextBox txtNombre;
	}
}