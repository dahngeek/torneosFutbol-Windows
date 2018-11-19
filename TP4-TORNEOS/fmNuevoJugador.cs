using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4_TORNEOS.Entidades;
using TP4_TORNEOS.Controladores;

namespace TP4_TORNEOS
{
	public partial class fmNuevoJugador : MetroFramework.Forms.MetroForm
	{
		public fmNuevoJugador()
		{
			InitializeComponent();
			posicionBindingSource.DataSource = pPosicion.GetAll();
			equipoBindingSource.DataSource = pEquipo.GetAll();
			

		}

		private void fmNuevoJugador_Load(object sender, EventArgs e)
		{

		}

		private void metroTextBox4_Click(object sender, EventArgs e)
		{

		}

		private void metroTextBox3_Click(object sender, EventArgs e)
		{

		}

		private void metroTextBox5_Click(object sender, EventArgs e)
		{

		}

		private void metroTextBox1_Click(object sender, EventArgs e)
		{

		}

		private void tablaJugador_SelectionChanged(object sender, EventArgs e)
		{
		
		}

		private void mBtAceptar_Click(object sender, EventArgs e)
		{
			Jugador j = new Jugador();
			j.Nombre = nombreTextBox.Text;
			j.Apellido = apellidoTextBox.Text;
			j.Apodo = apodoTextBox.Text;
			j.NumeroCamiseta = int.Parse(numeroCamisetaTextBox.Text);
			j.UrlImagen = urlImagenTextBox.Text;
			j.Equipo = pEquipo.GetById(Convert.ToInt32(equipoComboBox.SelectedValue));
			j.Posicion = pPosicion.GetById(Convert.ToInt32(posicionComboBox.SelectedValue));
			pJugador.Save(j);
			Close();

		}

		private void metroLabel1_Click(object sender, EventArgs e)
		{

		}

		private void metroTextBox4_Click_1(object sender, EventArgs e)
		{

		}

		private void mBtCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void equipoComboBox_SelectionChangeCommitted(object sender, EventArgs e)
		{

		}
	}
}
