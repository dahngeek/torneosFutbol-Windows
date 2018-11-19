using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TP4_TORNEOS.Controladores;
using TP4_TORNEOS.Entidades;
using System.Media;

namespace TP4_TORNEOS
{
	public partial class fmListar : MetroFramework.Forms.MetroForm
	{
		public fmListar()
		{
			InitializeComponent();
			jugadorBindingSource.DataSource = pJugador.GetAll();
			SoundPlayer audioBoton = new SoundPlayer("sonidoBt.wav");

            // Transparencia para las imagenes.
            tarjetaJugador.BackColor = Color.Transparent;

            // Transparencia para label sobre imagen. (vuelve la imagen el padre del label)
            var pos = this.PointToScreen(lbNombre.Location);
            pos = tarjetaJugador.PointToClient(pos);
            lbNombre.Parent = tarjetaJugador;
            lbNombre.Location = pos;
            lbNombre.BackColor = Color.Transparent;

			var pos2 = this.PointToScreen(lbGol.Location);
			pos2 = tarjetaJugador.PointToClient(pos2);
			lbGol.Parent = tarjetaJugador;
			lbGol.Location = pos2;
			lbGol.BackColor = Color.Transparent;

			var pos3 = this.PointToScreen(lbPosicion.Location);
			pos3 = tarjetaJugador.PointToClient(pos3);
			lbPosicion.Parent = tarjetaJugador;
			lbPosicion.Location = pos3;
			lbPosicion.BackColor = Color.Transparent;

			var pos4 = this.PointToScreen(label4.Location);
			pos4 = tarjetaJugador.PointToClient(pos4);
			label4.Parent = tarjetaJugador;
			label4.Location = pos4;
			label4.BackColor = Color.Transparent;

			var pos5 = this.PointToScreen(lbTarjeta.Location);
			pos5 = tarjetaJugador.PointToClient(pos5);
			lbTarjeta.Parent = tarjetaJugador;
			lbTarjeta.Location = pos5;
			lbTarjeta.BackColor = Color.Transparent;

			var pos6 = this.PointToScreen(lbdataTarjeta.Location);
			pos6 = tarjetaJugador.PointToClient(pos6);
			lbdataTarjeta.Parent = tarjetaJugador;
			lbdataTarjeta.Location = pos6;
			lbdataTarjeta.BackColor = Color.Transparent;


			var pos8 = this.PointToScreen(lbdataPosicion.Location);
			pos8 = tarjetaJugador.PointToClient(pos8);
			lbdataPosicion.Parent = tarjetaJugador;
			lbdataPosicion.Location = pos8;
			lbdataPosicion.BackColor = Color.Transparent;

			var pos9 = this.PointToScreen(lbdataGol.Location);
			pos9 = tarjetaJugador.PointToClient(pos9);
			lbdataGol.Parent = tarjetaJugador;
			lbdataGol.Location = pos9;
			lbdataGol.BackColor = Color.Transparent;

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
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void labelNombre_Click(object sender, EventArgs e)
		{

		}

        private void label7_Click(object sender, EventArgs e)
        {

        }

		private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
