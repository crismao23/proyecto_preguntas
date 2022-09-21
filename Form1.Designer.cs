namespace proyecto_preguntas
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.btnRegistro = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(254, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 25);
			this.label3.TabIndex = 13;
			this.label3.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(246, 183);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Contraseña";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtPassword.Location = new System.Drawing.Point(203, 201);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(150, 27);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			// 
			// txtUser
			// 
			this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtUser.Location = new System.Drawing.Point(203, 139);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(150, 27);
			this.txtUser.TabIndex = 10;
			this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(257, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 15);
			this.label1.TabIndex = 9;
			this.label1.Text = "Usuario";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(203, 314);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(150, 49);
			this.btnLimpiar.TabIndex = 8;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnIngresar
			// 
			this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnIngresar.Location = new System.Drawing.Point(203, 252);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(150, 49);
			this.btnIngresar.TabIndex = 7;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = false;
			this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
			// 
			// btnRegistro
			// 
			this.btnRegistro.Location = new System.Drawing.Point(203, 386);
			this.btnRegistro.Name = "btnRegistro";
			this.btnRegistro.Size = new System.Drawing.Size(150, 47);
			this.btnRegistro.TabIndex = 14;
			this.btnRegistro.Text = "Registro";
			this.btnRegistro.UseVisualStyleBackColor = true;
			this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 479);
			this.Controls.Add(this.btnRegistro);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnIngresar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label3;
		private Label label2;
		private TextBox txtPassword;
		private TextBox txtUser;
		private Label label1;
		private Button btnLimpiar;
		private Button btnIngresar;
		private Button btnRegistro;
	}
}