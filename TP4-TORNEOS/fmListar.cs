using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

namespace TP4_TORNEOS
{
	public partial class fmListar : Form
	{
		public fmListar()
		{
			InitializeComponent();

			SoundPlayer audioBoton = new SoundPlayer("sonidoBt.wav");

            // Transparencia para las imagenes.
            tarjetaJugador.BackColor = Color.Transparent;

            // Transparencia para label sobre imagen. (vuelve la imagen el padre del label)
            var pos = this.PointToScreen(labelNombre.Location);
            pos = tarjetaJugador.PointToClient(pos);
            labelNombre.Parent = tarjetaJugador;
            labelNombre.Location = pos;
            labelNombre.BackColor = Color.Transparent;

			var pos2 = this.PointToScreen(label2.Location);
			pos2 = tarjetaJugador.PointToClient(pos2);
			label2.Parent = tarjetaJugador;
			label2.Location = pos2;
			label2.BackColor = Color.Transparent;

			var pos3 = this.PointToScreen(label3.Location);
			pos3 = tarjetaJugador.PointToClient(pos3);
			label3.Parent = tarjetaJugador;
			label3.Location = pos3;
			label3.BackColor = Color.Transparent;

			var pos4 = this.PointToScreen(label4.Location);
			pos4 = tarjetaJugador.PointToClient(pos4);
			label4.Parent = tarjetaJugador;
			label4.Location = pos4;
			label4.BackColor = Color.Transparent;

			var pos5 = this.PointToScreen(label5.Location);
			pos5 = tarjetaJugador.PointToClient(pos5);
			label5.Parent = tarjetaJugador;
			label5.Location = pos5;
			label5.BackColor = Color.Transparent;

			var pos6 = this.PointToScreen(label6.Location);
			pos6 = tarjetaJugador.PointToClient(pos6);
			label6.Parent = tarjetaJugador;
			label6.Location = pos6;
			label6.BackColor = Color.Transparent;


			var pos8 = this.PointToScreen(label8.Location);
			pos8 = tarjetaJugador.PointToClient(pos8);
			label8.Parent = tarjetaJugador;
			label8.Location = pos8;
			label8.BackColor = Color.Transparent;

			var pos9 = this.PointToScreen(label9.Location);
			pos9 = tarjetaJugador.PointToClient(pos9);
			label9.Parent = tarjetaJugador;
			label9.Location = pos9;
			label9.BackColor = Color.Transparent;

			//Cargar imagen de jugador
			pictureBox1.Load("https://cdn.sofifa.org/players/10/19/158023.png");
            pos = this.PointToScreen(pictureBox1.Location);
            pos = tarjetaJugador.PointToClient(pos);
            pictureBox1.Parent = tarjetaJugador;
            pictureBox1.Location = pos;
            pictureBox1.BackColor = Color.Transparent;
        }

		private void fmListar_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void fmListar_Load(object sender, EventArgs e)
		{
            
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
		{

		}

		private void label1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			label1.Text = "hola";
		}

		private void axWindowsMediaPlayer1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			
		}

		private void axWindowsMediaPlayer1_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
		{
			Close();

        }

        private void fmListar_Leave(object sender, EventArgs e)
        {

        }

        private void fmListar_FormClosed(object sender, FormClosedEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

		private void labelNombre_Click(object sender, EventArgs e)
		{

		}

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
