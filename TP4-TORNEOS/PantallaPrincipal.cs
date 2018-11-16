using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using MetroFramework;
using System.Media;

namespace TP4_TORNEOS
{
	public partial class PantallaPrincipal : Form
	{
		SoundPlayer variable1 = new SoundPlayer("SonidoMenu.wav");
		SoundPlayer variable = new SoundPlayer("sonidoBt.wav");
		SoundPlayer MusicCrear = new SoundPlayer("musicaCrear.wav");
		public PantallaPrincipal()
		{

			InitializeComponent();
			pictureBox1.BackColor = Color.Transparent;
			//variable1.Play();
		}

		//PANTALLA COMPLETA / FULLSCREEN
		private void PantallaPrincipal_Load(object sender, EventArgs e)
		{
			//this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			MetroMessageBox.Show(this, "This is a sample MetroMessagebox `Yes` and `No` button", "MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{

		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			
		}

		private void metroTile1_Click_1(object sender, EventArgs e)
		{

		}

		private void metroTabPage3_Click(object sender, EventArgs e)
		{

		}

		private void metroTabPage3_Click_1(object sender, EventArgs e)
		{
			//variable.Play();
		}

		private void x(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{

		//	button1.FlatAppearance.BorderColor = Color.White;
			new fmCrearJug().ShowDialog();
		}

		private void mtpJugadores_Click(object sender, EventArgs e)
		{
			//variable.Play();
		}

		private void metroTabPage1_Click(object sender, EventArgs e)
		{
			//variable.Play();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			//variable.Play();
			new fmListar().ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			new fmModificar().ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//variable.Play();
			new fmEliminar().ShowDialog();
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btjugador(object sender, KeyEventArgs e)
		{
		}

		private void button1_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

			//activar boton
			this.label1.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_activo;

			//desactivar boton
			this.label2.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label3.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label4.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			//abre la ventana
			new fmCrearJug().ShowDialog();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			//activar boton
			this.label2.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_activo;

			//desactivar boton
			this.label1.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label3.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label4.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			//abre la ventana
			new fmModificar().ShowDialog();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			// sonido
			MusicCrear.Play();
			//activar boton
			this.label3.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_activo;

			//desactivar boton
			this.label1.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label2.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label4.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			//abre la ventana
			new fmListar().ShowDialog();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			variable.Play();
			//activar boton
			this.label4.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_activo;

			//desactivar boton
			this.label2.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label3.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label3.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;

			//abre la ventana
			new fmEliminar().ShowDialog();
		}

		private void label1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
		
		}
	}
}
