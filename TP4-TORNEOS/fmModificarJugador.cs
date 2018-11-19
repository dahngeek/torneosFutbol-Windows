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

namespace TP4_TORNEOS
{
	public partial class fmModificarJugador : MetroFramework.Forms.MetroForm
	{
		
		public fmModificarJugador(int id)
		{
			InitializeComponent();

			if (id > 0)
			{
				jugadorBindingSource.Add(pJugador.GetById(id));
			}
			else
			{
				Jugador p = new Jugador();
				p.Id = 0;
				jugadorBindingSource.Add(p);
			}

		}


		private void mBtCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mBtAceptar_Click(object sender, EventArgs e)
		{
			Jugador j = (Jugador)jugadorBindingSource.Current;
			if (j.Id > 0)
			{
				pJugador.Update(j);
			}
			else
			{
				pJugador.Save(j);
			}

			this.Close();
		}
	}
}
