using System.Data;

namespace proyecto_preguntas
{

	public partial class FormRegistro : Form
	{

		public static DataTable dTableUsers = new DataTable("dTableUsers");
		Form1 f1 = new Form1();

		public FormRegistro()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtUser_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			createUser(txtUser.Text, txtPass1.Text, txtPass2.Text, txtEmail.Text, txtNombre.Text);
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
		private void limpiar()
		{
			txtUser.Clear();
			txtPass1.Clear();
			txtPass2.Clear();
			txtEmail.Clear();
			txtNombre.Clear();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			limpiar();
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			this.Hide();
			f1.Show();
		}
		public void createUser(string user, string pass1, string pass2, string email, string nombre)
		{


			if (pass1 != pass2)
			{
				MessageBox.Show("Las contraseñas no coinciden");
			}
			else if (pass1.Equals("") || pass2.Equals("") || user.Equals("") || email.Equals("") || nombre.Equals(""))
			{
				MessageBox.Show("Debes diligenciar todos los campos");
			}
			else
			{
				if (validateRegister(user))
				{
					MessageBox.Show("El usuario ya existe");
					limpiar();
				}
				else
				{
					dTableUsers.Rows.Add(user, pass1, email, nombre);
					limpiar();
					MessageBox.Show("Usuario añadido exitosamente");
					this.Hide();
					f1.Show();
				}
			}
		}

		public static bool validateRegister(String user)
		{
			bool exist = false;

			for (int i = 0; i < dTableUsers.Rows.Count; i++)
			{
				string? usuario = dTableUsers.Rows[i]["User"].ToString();
				if (user == usuario)
				{
					exist = true;
				}
			}
			return exist;
		}

		public static bool validateUser(String user, String password)
		{
			bool exist = false;
			string? usuario;
			string? pas;
			for (int i = 0; i < dTableUsers.Rows.Count; i++)
			{
				usuario = dTableUsers.Rows[i]["User"].ToString();
				pas = dTableUsers.Rows[i]["Pass"].ToString();
				if (user == usuario && password == pas)
				{
					exist = true;
				}
			}
			return exist;
		}
	}
}
