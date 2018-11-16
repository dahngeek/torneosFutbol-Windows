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
    }
}
