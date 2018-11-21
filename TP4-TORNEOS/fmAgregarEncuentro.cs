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

namespace TP4_TORNEOS
{
    public partial class fmAgregarEncuentro : MetroFramework.Forms.MetroForm
    {
        public fmAgregarEncuentro()
        {
            InitializeComponent();
            encuentroDate.Format = DateTimePickerFormat.Custom;
            encuentroDate.CustomFormat = "dd/MM/yyyy hh:mm tt";

            //Llenar los select y evitar que se cruzen los datos o que juege el equipo consigo mismo
            equipoBindingSourceLocal.DataSource = Controladores.pEquipo.GetAll();
            List<Equipo> equiposrestantes = Controladores.pEquipo.GetAll();
            equiposrestantes.RemoveAt(cbEquipoLocal.SelectedIndex);
            equipoBindingSourceVisita.DataSource = equiposrestantes;

            //Cargar Arbitros
            arbitroBindingSource.DataSource = Controladores.pArbitro.GetAll();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Equipo local = (Equipo)equipoBindingSourceLocal.Current;
            Equipo visitante = (Equipo)equipoBindingSourceVisita.Current;
            DateTime fecha = encuentroDate.Value;
            Arbitro arbitro = (Arbitro)arbitroBindingSource.Current;
            Encuentro guardar = new Encuentro(0,local,visitante,fecha,arbitro);
            Controladores.pEncuentro.Save(guardar);
            Close();
        }

        private void cbEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Equipo> equiposrestantes = Controladores.pEquipo.GetAll();
            equiposrestantes.RemoveAt(cbEquipoLocal.SelectedIndex);
            equipoBindingSourceVisita.DataSource = equiposrestantes;
        }
    }
}
