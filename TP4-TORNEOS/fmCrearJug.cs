using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4_TORNEOS;


namespace TP4_TORNEOS
{
	public partial class fmCrearJug : Form
	{
		public fmCrearJug()
		{
			InitializeComponent();
			
		}

		private void fmCrearJug_Load(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			// aca guardar en la base de datos
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
			{
				tbNombre.Text = "Apellido: ";
			}

			if (e.KeyChar == Convert.ToChar(Keys.Escape))
			{
				Close();
				
			}
		}

		private void tbNombre_Enter(object sender, EventArgs e)
		{

			
			
		}
	}
}
