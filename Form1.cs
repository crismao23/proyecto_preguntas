using System.Data;

namespace proyecto_preguntas
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			if (FormRegistro.dTableUsers.Columns.Count < 4)
			{
				FormRegistro.dTableUsers.Columns.Add("User", typeof(string));
				FormRegistro.dTableUsers.Columns.Add("Pass", typeof(string));
				FormRegistro.dTableUsers.Columns.Add("Email", typeof(string));
				FormRegistro.dTableUsers.Columns.Add("Nombre", typeof(string));
			}
			FormRegistro.dTableUsers.Rows.Add("pepe", "1234", "pepe@gmail.com", "Pepe Perez");
			InitializeComponent();
			
		}
		

		private void txtUser_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			if (FormRegistro.validateUser(txtUser.Text, txtPassword.Text))
			{
				formPreguntas();
			}
			else
			{
				MessageBox.Show("Datos incorrectos");
			}
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void formPreguntas()
		{
			FormPreguntas fp = new FormPreguntas();
			this.Hide();
			fp.Show();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			limpiar();
		}
		private void limpiar() {
			txtUser.Clear();
			txtPassword.Clear();
		}

		private void btnRegistro_Click(object sender, EventArgs e)
		{
			FormRegistro fr = new FormRegistro();
			this.Hide();
			fr.Show();
		}
	}
}