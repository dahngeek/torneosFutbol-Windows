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
    public partial class fmModificarEquipo : MetroFramework.Forms.MetroForm
    {
        public fmModificarEquipo()
        {
            InitializeComponent();
            equipoBindingSource.DataSource = pEquipo.GetAll();

            configuracionBindingSource.DataSource = pConfiguracion.GetAll();
            //jugadorBindingSource.DataSource = pJugador.GetAll();



        }

        private void cbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //LKpo
                List<Jugador> todosjugadores = new List<Jugador>();
                todosjugadores = pJugador.GetAll();

                List<Jugador> jugadoresEquipo = new List<Jugador>();

                for (int i = 0; i < todosjugadores.Count; i++)
                {
                    if (todosjugadores[i].Equipo.Id == cbEquipos.SelectedIndex + 1)
                    {
                        jugadoresEquipo.Add(todosjugadores[i]);

                    }
                }

                jugadorBindingSource.DataSource = null;
                jugadorBindingSource.DataSource = jugadoresEquipo;

                Equipo equipo = pEquipo.GetById(cbEquipos.SelectedIndex + 1);

                lbPuntosEq.Text = equipo.Puntos.ToString();
                lbGCEq.Text = equipo.GolesContra.ToString();
                lbGFEq.Text = equipo.GolesFavor.ToString();
                lbNombreEquipo.Text = equipo.Nombre;


            }
            catch { }


        }

        private void cbEquipos_Click(object sender, EventArgs e)
        {
            

        }

        private void cbEquipos_DisplayMemberChanged(object sender, EventArgs e)
        {
           

        }

        private void cbEquipos_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            txNombreEquipo.Visible = true;
            txNombreEquipo.Text = "Nombre: ";
            cbConfiguracion.Visible = true;
            btAnadir.Visible = true;
            lbNombreEquipo.Visible = false;
            cbEquipos.Visible = false;
            btCrear.Visible = false;
            btCancelarAnadir.Visible = true;
            lbGCEq.Text = 0.ToString();
            lbGFEq.Text = 0.ToString();
            lbPuntosEq.Text = 0.ToString();
        }

        private void txNombreEquipo_Click(object sender, EventArgs e)
        {
            txNombreEquipo.Text = "";
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.Nombre = txNombreEquipo.Text;
            equipo.Configuracion = pConfiguracion.GetById(cbConfiguracion.SelectedIndex + 1);
            equipo.Puntos = int.Parse(lbPuntosEq.Text);
            equipo.GolesContra = int.Parse(lbGCEq.Text);
            equipo.GolesFavor = int.Parse(lbGFEq.Text);
            pEquipo.Save(equipo);

            //Equipo equipoGuardado = pEquipo.GetById(equipo.Id);
            txNombreEquipo.Visible = false;
            cbConfiguracion.Visible = false;
            btAnadir.Visible = false;
            btCancelarAnadir.Visible = false;
            lbNombreEquipo.Visible = true;
            cbEquipos.Visible = true;
            btCrear.Visible = true;

            equipoBindingSource.DataSource = pEquipo.GetAll();
            
            cbEquipos.SelectedIndex = (pEquipo.GetAll()).Count - 1;
        }

        private void btCancelarAnadir_Click(object sender, EventArgs e)
        {
            txNombreEquipo.Visible = false;
            cbConfiguracion.Visible = false;
            btAnadir.Visible = false;
            btCancelarAnadir.Visible = false;
            lbNombreEquipo.Visible = true;
            cbEquipos.Visible = true;
            btCrear.Visible = true;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Equipo equipo = pEquipo.GetById(cbEquipos.SelectedIndex + 1);

            txNombreEquipo.Visible = true;
            txNombreEquipo.Text = equipo.Nombre;
            cbConfiguracion.Visible = true;
            btAnadir.Visible = false;
            lbNombreEquipo.Visible = false;
            cbEquipos.Visible = false;
            btCrear.Visible = false;
            btCancelarAnadir.Visible = true;
            btModificarEquipo.Visible = true;
            btModificar.Visible = false;
            //lbGCEq.Text = 0.ToString();
            //lbGFEq.Text = 0.ToString();
            //lbPuntosEq.Text = 0.ToString();
            // if (equipo.Id == )
        }

        private void btModificarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipo = pEquipo.GetById(cbEquipos.SelectedIndex+1);
            equipo.Nombre = txNombreEquipo.Text;
            equipo.Configuracion = pConfiguracion.GetById(cbConfiguracion.SelectedIndex + 1);
            equipo.Puntos = int.Parse(lbPuntosEq.Text);
            equipo.GolesContra = int.Parse(lbGCEq.Text);
            equipo.GolesFavor = int.Parse(lbGFEq.Text);
            pEquipo.Update(equipo);

            //Equipo equipoGuardado = pEquipo.GetById(equipo.Id);
            txNombreEquipo.Visible = false;
            cbConfiguracion.Visible = false;
            btAnadir.Visible = false;
            btModificarEquipo.Visible = false;
            btCancelarAnadir.Visible = false;
            lbNombreEquipo.Visible = true;
            lbNombreEquipo.Text = equipo.Nombre;
            cbEquipos.Visible = true;
            btCrear.Visible = true;
            btModificar.Visible = true;

            equipoBindingSource.DataSource = pEquipo.GetAll();

            //cbEquipos.SelectedIndex = (pEquipo.GetAll()).Count - 1;
        }

        private void btComprarJugador_Click(object sender, EventArgs e)
        {
            



        }

        private void btVenderJugador_Click(object sender, EventArgs e)
        {

            Jugador jugadorSeleccionado = (Jugador)jugadorBindingSource.Current;
            fmVenderJugador Vender = new fmVenderJugador(jugadorSeleccionado.Id);

            Vender.ShowDialog();
            jugadorSeleccionado = pJugador.GetById(jugadorSeleccionado.Id);
            equipoBindingSource.Position = jugadorSeleccionado.Equipo.Id - 1;
                // SelectedIndex = jugadorSeleccionado.Equipo.Id - 1;
            //cbEquipoDestino.Visible = true;
            //btComprarJugador.Visible = false;
            //btVenderJugador.Visible = false;
            //btCrear.Visible = false;
            //btModificar.Visible = false;
            //btVender.Visible = true;
            //cbEquipos.Visible = true;
            //metroGrid1.Visible = true;
            //lbNombreJugador.Visible = true;
            //lbNombreJugador.Text = (((Jugador)jugadorBindingSource.Current).Nombre + " " + ((Jugador)jugadorBindingSource.Current).Apellido).ToString();

        }

        private void btVender_Click(object sender, EventArgs e)
        {
            //Jugador jugadorSeleccionado = (Jugador)jugadorBindingSource.Current;
            //cbEquipos.BindingContext = new BindingContext();
            //cbEquipoDestino.BindingContext = new BindingContext();
            //cbEquipoDestino.DataSource = pEquipo.GetAll();
            //Equipo equipoDestino = pEquipo.GetById(cbEquipoDestino.SelectedIndex - 1);
            //jugadorSeleccionado.Equipo = equipoDestino;

            //pJugador.Update(jugadorSeleccionado);

            //cbEquipoDestino.Visible = false;
            //btComprarJugador.Visible = true;
            //btVenderJugador.Visible = true;
            //btCrear.Visible = true;
            //btModificar.Visible = true;
            //btVender.Visible = false;
            //cbEquipos.Visible = true;
            //metroGrid1.Visible = true;
            //lbNombreJugador.Visible = false;

            //equipoBindingSource.DataSource = pEquipo.GetAll();



        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
