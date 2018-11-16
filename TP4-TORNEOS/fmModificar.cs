using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_TORNEOS
{
	public partial class fmModificar : Form
	{
		public fmModificar()
		{
			InitializeComponent();
		}

		private void fmModificar_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Escape))
			{
				Close();

			}
		}
	}
}
