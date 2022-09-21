using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_preguntas
{
	public partial class FormPreguntas : Form
	{
		private static DataTable dTablePreguntas = new DataTable("dTablePreguntas");

		private static Random rand = new Random();
		private static List<int> listaPreguntas = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
		private static List<int> listaPreguntasAleatorias = listaPreguntas.OrderBy(_ => rand.Next()).ToList();
		private static List<int> listaCuatroRespuestas = new List<int>() { 1, 2, 3, 4 };
		private static List<int> listaDosRespuestas = new List<int>() { 1, 2 };
		private static int contador = 0;
		private static int contadorPr = 0;
		private static int cMitad = 0;
		private static int cCambio = 0;
		private static int cLlamada = 0;
		private double totalAcumulado = 0;


		public FormPreguntas()
		{
			generarPreguntas();
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void lblPreguntas_Click(object sender, EventArgs e)
		{

		}

		public static int generarNumeroDePregunta() {
			int valor;
			valor = listaPreguntasAleatorias[contador];
			return valor;
		}

		public void generarPreguntas() {
			dTablePreguntas.Columns.Add("Pregunta", typeof(string));
			dTablePreguntas.Columns.Add("r1", typeof(string));
			dTablePreguntas.Columns.Add("r2", typeof(string));
			dTablePreguntas.Columns.Add("r3", typeof(string));
			dTablePreguntas.Columns.Add("r4", typeof(string));

			dTablePreguntas.Rows.Add("¿Cuál es la capital de Amazonas?", "Leticia", "Tunja", "Riohacha", "Mocoa");
			dTablePreguntas.Rows.Add("¿Cuál es la capital de Vaupés?", "Mitú", "Puerto Carreño", "Inírida", "Florencia");
			dTablePreguntas.Rows.Add("¿Cuál es el río más largo de Colombia?", "Río Magdalena", "Río Putumayo", "Río Orinoco", "Río Negro");
			dTablePreguntas.Rows.Add("¿Cuál es la montaña más alta de Colombia?", "Sierra Nevada de Santa Marta", "Nevado del Ruiz", "Nevado Santa Isabel", "Pico Simón Bolivar");
			dTablePreguntas.Rows.Add("¿Cuál es la ciudad más pequeña de Colombia?", "Providencia", "Itagüi", "Palmar", "Busbanzá");
			dTablePreguntas.Rows.Add("¿Cuales fueron los primeros habitantes de Colombia?", "Muiscas", "Consotás", "Taironas", "Quimbayas");
			dTablePreguntas.Rows.Add("¿Cómo se llama el gorro del escudo de Colombia?", "Frigio", "Cachucha", "Sombrero", "Pasamontañas");
			dTablePreguntas.Rows.Add("¿Cómo se llama la flor del escudo de Colombia?", "Catleya", "Girasol", "Rosa", "Clavel");
		}

		private void checkedListBox12_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = chlbPreguntas.SelectedIndex;
			int count = chlbPreguntas.Items.Count;
			for (int x = 0; x<count; x++) {
				if (index != x) {
					chlbPreguntas.SetItemCheckState(x, CheckState.Unchecked);
				}
			}
		}

		private void FormPreguntas_Load(object sender, EventArgs e)
		{
			generarPregunta(listaCuatroRespuestas);
			
		}

		private void generarPregunta(List<int>listaRp) {
			int nroPregunta = generarNumeroDePregunta();
			List<int> respuestas = generarListaOrdenAleatorio(listaRp);

			lblPreguntas.Text = dTablePreguntas.Rows[nroPregunta]["Pregunta"].ToString();
			foreach (var i in respuestas){
				chlbPreguntas.Items.Add(dTablePreguntas.Rows[nroPregunta][i].ToString());
			}
		}



		private void btnContinuar_Click(object sender, EventArgs e)
		{
			string seleccion = chlbPreguntas.Text;
			if (seleccion.Equals(""))
			{
				MessageBox.Show("Debes seleccionar una opción!!");
			}
			else {
				if (contadorPr < 4)
				{
					if (validateResponse(seleccion))
					{
						MessageBox.Show("Correcto!!");
						totalAcumulado += 500000;
						lblAcumulado.Text = totalAcumulado.ToString();
					}
					else
					{
						MessageBox.Show("Perdiste!!");
						lblAcumulado.Text = "0";
						this.Close();
					}
					contador += 1;
					limpiar();
					generarPregunta(listaCuatroRespuestas);
				}
				else
				{
					MessageBox.Show("Felicitaciones, te acabas de ganar " + totalAcumulado + " de pesos");
					this.Close();
				}
				contadorPr++;
			}
		}

		private List<int> generarListaOrdenAleatorio(List<int> resps) {
			return resps.OrderBy(_ => rand.Next()).ToList();
		}

		private void limpiar() {
			chlbPreguntas.Items.Clear();
		}

		public static bool validateResponse(String response)
		{
			bool isCorrect = false;

			for (int i = 0; i < dTablePreguntas.Rows.Count; i++)
			{
				string? resp = dTablePreguntas.Rows[i]["r1"].ToString();
				if (resp == response)
				{
					isCorrect = true;
				}
			}
			return isCorrect;
		}

		private void btnMitad_Click(object sender, EventArgs e)
		{
			limpiar();
			generarPregunta(listaDosRespuestas);

			cMitad += 1;
			if (cMitad == 1) {
				btnMitad.Enabled = false;
			}
		}

		private void btnCambio_Click(object sender, EventArgs e)
		{
			contador += 1;
			limpiar();
			generarPregunta(listaCuatroRespuestas);
			
			cCambio += 1;
			if (cCambio == 1)
			{
				btnCambio.Enabled = false;
			}
		}

		private void btnLlamar_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Mijit@ para mi es la primera");

			cLlamada += 1;
			if (cLlamada == 1)
			{
				btnLlamar.Enabled = false;
			}
		}

		private void btnRetirarse_Click(object sender, EventArgs e)
		{
			MessageBox.Show("OK, te vas con " + totalAcumulado + " de pesos");
			this.Close();
		}

		private void lblTotal_Click(object sender, EventArgs e)
		{

		}
	}
}
