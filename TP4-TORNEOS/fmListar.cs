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
			tarjetaJugadorBindingSource.DataSource = pTarjetaJugador.GetAll();
			SoundPlayer audioBoton = new SoundPlayer("sonidoBt.wav");

            // Transparencia para las imagenes.
            tarjetaJugador.BackColor = Color.Transparent;
			generarTabla();
			// Transparencia para label sobre imagen. (vuelve la imagen el padre del label)






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

			var pos4 = this.PointToScreen(lbCamiseta.Location);
			pos4 = tarjetaJugador.PointToClient(pos4);
			lbCamiseta.Parent = tarjetaJugador;
			lbCamiseta.Location = pos4;
			lbCamiseta.BackColor = Color.Transparent;

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
             var pos = this.PointToScreen(pictureBox1.Location);
            pos = tarjetaJugador.PointToClient(pos);
            pictureBox1.Parent = tarjetaJugador;
            pictureBox1.Location = pos;
            pictureBox1.BackColor = Color.Transparent;
        }

		public void generarTabla()
		{
			
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

		

		private void mBtNuevo_Click(object sender, EventArgs e)
		{
			new fmNuevoJugador().ShowDialog();
			jugadorBindingSource.DataSource = null;
			jugadorBindingSource.DataSource = pJugador.GetAll();

			
		}

		private void mBtBorrar_Click(object sender, EventArgs e)
		{
			Jugador jugadoreliminar = (Jugador)jugadorBindingSource.Current;
			pJugador.Delete(jugadoreliminar);
			actualizar();
		}

		private void actualizar()
		{
			jugadorBindingSource.DataSource = null;
			jugadorBindingSource.DataSource = pJugador.GetAll();
		}

		private void mBtModificar_Click(object sender, EventArgs e)
		{
			int id = ((Jugador)jugadorBindingSource.Current).Id;
			new fmModificarJugador(id).ShowDialog();

			//show dialogo me muestra el formulario

			jugadorBindingSource.DataSource = null; //la lista la pongo nula para volver a cargar todo
			jugadorBindingSource.DataSource = pJugador.GetAll();

		}

		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
		}

	
		private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			try
			{
				if (metroComboBox1.SelectedIndex + 1 == 1)
				{
					jugadorBindingSource.DataSource = null;
					jugadorBindingSource.DataSource = pJugador.GetAll();
				}

					if (metroComboBox1.SelectedIndex == 1)
				{
					List<Jugador> todoslosjugadores = new List<Jugador>();
					todoslosjugadores = pJugador.GetAll();

					List<Goles> gols = new List<Goles>();
					gols = pGoles.GetAll();

					Jugador SelecionarJugador = (Jugador)jugadorBindingSource.Current;
					int goles = pGoles.GetByJugador(SelecionarJugador.Id).Count();

					List<Jugador> jugadoresordenados = new List<Jugador>();

					for (int i = 0; i < todoslosjugadores.Count; i++)
					{
						for (int ii = 0; ii < gols.Count; ii++)
						{
							if (todoslosjugadores[i].Id == gols[ii].Jugador.Id)
							{

								jugadoresordenados.Add(todoslosjugadores[i]);


							}

						}
					}

					jugadorBindingSource.DataSource = null;
					jugadorBindingSource.DataSource = jugadoresordenados;

				}

				if (metroComboBox1.SelectedIndex == 2)
				{
					List<Jugador> todoslosjugadores = new List<Jugador>();
					todoslosjugadores = pJugador.GetAll();

					List<TarjetaJugador> tarjetaJugadors = new List<TarjetaJugador>();
					tarjetaJugadors = pTarjetaJugador.GetAll();
					
					List<Jugador> jugadoresordenadostarjeta = new List<Jugador>();

					for (int i = 0; i < todoslosjugadores.Count; i++)
					{
						for (int ii = 0; ii < tarjetaJugadors.Count; ii++)
						{
							if (todoslosjugadores[i].Id == tarjetaJugadors[ii].Jugador.Id)
							{

								jugadoresordenadostarjeta.Add(todoslosjugadores[i]);


							}

						}
					}

					jugadorBindingSource.DataSource = null;
					jugadorBindingSource.DataSource = jugadoresordenadostarjeta;

				}


			}
			catch { }


		}

		private void metroGrid1_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				Jugador SelecionarJugador = (Jugador)jugadorBindingSource.Current;
				tarjetaJugadorBindingSource.DataSource = pTarjetaJugador.GetByJugador(SelecionarJugador.Id);

				int goles = pGoles.GetByJugador(SelecionarJugador.Id).Count();
				int tarjeta = pTarjetaJugador.GetByJugador(SelecionarJugador.Id).Count();
				// obtener todos los goles
				// recorrerlos y comparar a ver si son de ese jugador
				// llevar un contador
				lbGol.Text = goles.ToString();
				lbTarjeta.Text = tarjeta.ToString();
				lbPosicion.Text = SelecionarJugador.Posicion.Nombre;
				lbCamiseta.Text = SelecionarJugador.NumeroCamiseta.ToString();
				pictureBox1.Load(SelecionarJugador.UrlImagen);


			
			
			}
			catch
			{
			}
		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
		
		}

	}
}
