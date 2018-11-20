namespace TP4_TORNEOS
{
    partial class fmVenderJugador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btCancelar = new MetroFramework.Controls.MetroButton();
            this.txNombreJugador = new MetroFramework.Controls.MetroTextBox();
            this.cbEquipoSeleccionado = new MetroFramework.Controls.MetroComboBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btVender = new MetroFramework.Controls.MetroButton();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbVenderJugador = new MetroFramework.Controls.MetroLabel();
            this.lbAEquipo = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(264, 143);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(121, 23);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btCancelar.UseSelectable = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txNombreJugador
            // 
            this.txNombreJugador.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txNombreJugador.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txNombreJugador.Lines = new string[] {
        "Nombre:"};
            this.txNombreJugador.Location = new System.Drawing.Point(25, 84);
            this.txNombreJugador.MaxLength = 32767;
            this.txNombreJugador.Name = "txNombreJugador";
            this.txNombreJugador.PasswordChar = '\0';
            this.txNombreJugador.ReadOnly = true;
            this.txNombreJugador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNombreJugador.SelectedText = "";
            this.txNombreJugador.Size = new System.Drawing.Size(219, 29);
            this.txNombreJugador.TabIndex = 1;
            this.txNombreJugador.Text = "Nombre:";
            this.txNombreJugador.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txNombreJugador.UseSelectable = true;
            this.txNombreJugador.Click += new System.EventHandler(this.txNombreJugador_Click);
            // 
            // cbEquipoSeleccionado
            // 
            this.cbEquipoSeleccionado.DataSource = this.equipoBindingSource;
            this.cbEquipoSeleccionado.DisplayMember = "Nombre";
            this.cbEquipoSeleccionado.FormattingEnabled = true;
            this.cbEquipoSeleccionado.ItemHeight = 23;
            this.cbEquipoSeleccionado.Location = new System.Drawing.Point(264, 84);
            this.cbEquipoSeleccionado.Name = "cbEquipoSeleccionado";
            this.cbEquipoSeleccionado.PromptText = "(Seleccione Nuevo Equipo)";
            this.cbEquipoSeleccionado.Size = new System.Drawing.Size(212, 29);
            this.cbEquipoSeleccionado.TabIndex = 2;
            this.cbEquipoSeleccionado.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbEquipoSeleccionado.UseSelectable = true;
            this.cbEquipoSeleccionado.ValueMember = "Id";
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Equipo);
            // 
            // btVender
            // 
            this.btVender.Location = new System.Drawing.Point(123, 143);
            this.btVender.Name = "btVender";
            this.btVender.Size = new System.Drawing.Size(121, 23);
            this.btVender.TabIndex = 3;
            this.btVender.Text = "Transferir";
            this.btVender.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btVender.UseSelectable = true;
            this.btVender.Click += new System.EventHandler(this.btVender_Click);
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Jugador);
            // 
            // lbVenderJugador
            // 
            this.lbVenderJugador.AutoSize = true;
            this.lbVenderJugador.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbVenderJugador.Location = new System.Drawing.Point(25, 61);
            this.lbVenderJugador.Name = "lbVenderJugador";
            this.lbVenderJugador.Size = new System.Drawing.Size(137, 19);
            this.lbVenderJugador.TabIndex = 4;
            this.lbVenderJugador.Text = "Transferir Jugador:";
            this.lbVenderJugador.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbAEquipo
            // 
            this.lbAEquipo.AutoSize = true;
            this.lbAEquipo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbAEquipo.Location = new System.Drawing.Point(264, 61);
            this.lbAEquipo.Name = "lbAEquipo";
            this.lbAEquipo.Size = new System.Drawing.Size(77, 19);
            this.lbAEquipo.TabIndex = 5;
            this.lbAEquipo.Text = "Al Equipo:";
            this.lbAEquipo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // fmVenderJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 202);
            this.Controls.Add(this.lbAEquipo);
            this.Controls.Add(this.lbVenderJugador);
            this.Controls.Add(this.btVender);
            this.Controls.Add(this.cbEquipoSeleccionado);
            this.Controls.Add(this.txNombreJugador);
            this.Controls.Add(this.btCancelar);
            this.Name = "fmVenderJugador";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Transferencia de Jugador";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btCancelar;
        private MetroFramework.Controls.MetroTextBox txNombreJugador;
        private MetroFramework.Controls.MetroComboBox cbEquipoSeleccionado;
        private MetroFramework.Controls.MetroButton btVender;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private MetroFramework.Controls.MetroLabel lbVenderJugador;
        private MetroFramework.Controls.MetroLabel lbAEquipo;
    }
}