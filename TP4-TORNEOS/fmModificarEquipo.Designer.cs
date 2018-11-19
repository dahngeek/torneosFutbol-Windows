namespace TP4_TORNEOS
{
    partial class fmModificarEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmModificarEquipo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btCrear = new MetroFramework.Controls.MetroButton();
            this.cbEquipos = new MetroFramework.Controls.MetroComboBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btVenderJugador = new MetroFramework.Controls.MetroButton();
            this.btComprarJugador = new MetroFramework.Controls.MetroButton();
            this.btModificar = new MetroFramework.Controls.MetroButton();
            this.lbNombreEquipo = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPuntos = new MetroFramework.Controls.MetroLabel();
            this.lbGolesFavor = new MetroFramework.Controls.MetroLabel();
            this.lbGolesContra = new MetroFramework.Controls.MetroLabel();
            this.lbPuntosEq = new MetroFramework.Controls.MetroLabel();
            this.lbGFEq = new MetroFramework.Controls.MetroLabel();
            this.lbGCEq = new MetroFramework.Controls.MetroLabel();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCamisetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlImagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txNombreEquipo = new MetroFramework.Controls.MetroTextBox();
            this.cbConfiguracion = new MetroFramework.Controls.MetroComboBox();
            this.configuracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btAnadir = new MetroFramework.Controls.MetroButton();
            this.btCancelarAnadir = new MetroFramework.Controls.MetroButton();
            this.btModificarEquipo = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(653, 96);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(105, 29);
            this.btCrear.TabIndex = 1;
            this.btCrear.Text = "Crear";
            this.btCrear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btCrear.UseSelectable = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // cbEquipos
            // 
            this.cbEquipos.DataSource = this.equipoBindingSource;
            this.cbEquipos.DisplayMember = "Nombre";
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.ItemHeight = 23;
            this.cbEquipos.Location = new System.Drawing.Point(502, 96);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.PromptText = "(Seleccione Equipo)";
            this.cbEquipos.Size = new System.Drawing.Size(145, 29);
            this.cbEquipos.TabIndex = 2;
            this.cbEquipos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbEquipos.UseSelectable = true;
            this.cbEquipos.SelectedIndexChanged += new System.EventHandler(this.cbEquipos_SelectedIndexChanged);
            this.cbEquipos.DisplayMemberChanged += new System.EventHandler(this.cbEquipos_DisplayMemberChanged);
            this.cbEquipos.SelectedValueChanged += new System.EventHandler(this.cbEquipos_SelectedValueChanged);
            this.cbEquipos.Click += new System.EventHandler(this.cbEquipos_Click);
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Equipo);
            // 
            // btVenderJugador
            // 
            this.btVenderJugador.Location = new System.Drawing.Point(653, 409);
            this.btVenderJugador.Name = "btVenderJugador";
            this.btVenderJugador.Size = new System.Drawing.Size(104, 23);
            this.btVenderJugador.TabIndex = 3;
            this.btVenderJugador.Text = "Vender Jugador";
            this.btVenderJugador.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btVenderJugador.UseSelectable = true;
            this.btVenderJugador.Click += new System.EventHandler(this.btVenderJugador_Click);
            // 
            // btComprarJugador
            // 
            this.btComprarJugador.Location = new System.Drawing.Point(533, 409);
            this.btComprarJugador.Name = "btComprarJugador";
            this.btComprarJugador.Size = new System.Drawing.Size(103, 23);
            this.btComprarJugador.TabIndex = 4;
            this.btComprarJugador.Text = "Comprar Jugador";
            this.btComprarJugador.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btComprarJugador.UseSelectable = true;
            this.btComprarJugador.Click += new System.EventHandler(this.btComprarJugador_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(196, 187);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(121, 23);
            this.btModificar.TabIndex = 5;
            this.btModificar.Text = "Modificar";
            this.btModificar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btModificar.UseSelectable = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // lbNombreEquipo
            // 
            this.lbNombreEquipo.AutoSize = true;
            this.lbNombreEquipo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNombreEquipo.Location = new System.Drawing.Point(29, 66);
            this.lbNombreEquipo.Name = "lbNombreEquipo";
            this.lbNombreEquipo.Size = new System.Drawing.Size(65, 25);
            this.lbNombreEquipo.TabIndex = 6;
            this.lbNombreEquipo.Text = "Equipo";
            this.lbNombreEquipo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::TP4_TORNEOS.Properties.Resources.Equipos;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 110);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.Location = new System.Drawing.Point(29, 235);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(27, 19);
            this.lbPuntos.TabIndex = 8;
            this.lbPuntos.Text = "PT:";
            this.lbPuntos.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbGolesFavor
            // 
            this.lbGolesFavor.AutoSize = true;
            this.lbGolesFavor.Location = new System.Drawing.Point(29, 277);
            this.lbGolesFavor.Name = "lbGolesFavor";
            this.lbGolesFavor.Size = new System.Drawing.Size(28, 19);
            this.lbGolesFavor.TabIndex = 9;
            this.lbGolesFavor.Text = "GF:";
            this.lbGolesFavor.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbGolesContra
            // 
            this.lbGolesContra.AutoSize = true;
            this.lbGolesContra.Location = new System.Drawing.Point(29, 321);
            this.lbGolesContra.Name = "lbGolesContra";
            this.lbGolesContra.Size = new System.Drawing.Size(30, 19);
            this.lbGolesContra.TabIndex = 10;
            this.lbGolesContra.Text = "GC:";
            this.lbGolesContra.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbPuntosEq
            // 
            this.lbPuntosEq.AutoSize = true;
            this.lbPuntosEq.Location = new System.Drawing.Point(98, 235);
            this.lbPuntosEq.Name = "lbPuntosEq";
            this.lbPuntosEq.Size = new System.Drawing.Size(18, 19);
            this.lbPuntosEq.TabIndex = 11;
            this.lbPuntosEq.Text = "...";
            this.lbPuntosEq.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbGFEq
            // 
            this.lbGFEq.AutoSize = true;
            this.lbGFEq.Location = new System.Drawing.Point(98, 277);
            this.lbGFEq.Name = "lbGFEq";
            this.lbGFEq.Size = new System.Drawing.Size(18, 19);
            this.lbGFEq.TabIndex = 12;
            this.lbGFEq.Text = "...";
            this.lbGFEq.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbGCEq
            // 
            this.lbGCEq.AutoSize = true;
            this.lbGCEq.Location = new System.Drawing.Point(98, 321);
            this.lbGCEq.Name = "lbGCEq";
            this.lbGCEq.Size = new System.Drawing.Size(18, 19);
            this.lbGCEq.TabIndex = 13;
            this.lbGCEq.Text = "...";
            this.lbGCEq.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Jugador);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.apodoDataGridViewTextBoxColumn,
            this.numeroCamisetaDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.urlImagenDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.jugadorBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(401, 146);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(356, 194);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGrid1.TabIndex = 14;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apodoDataGridViewTextBoxColumn
            // 
            this.apodoDataGridViewTextBoxColumn.DataPropertyName = "Apodo";
            this.apodoDataGridViewTextBoxColumn.HeaderText = "Apodo";
            this.apodoDataGridViewTextBoxColumn.Name = "apodoDataGridViewTextBoxColumn";
            this.apodoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroCamisetaDataGridViewTextBoxColumn
            // 
            this.numeroCamisetaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCamiseta";
            this.numeroCamisetaDataGridViewTextBoxColumn.HeaderText = "NumeroCamiseta";
            this.numeroCamisetaDataGridViewTextBoxColumn.Name = "numeroCamisetaDataGridViewTextBoxColumn";
            this.numeroCamisetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCamisetaDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Posicion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Posicion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // urlImagenDataGridViewTextBoxColumn
            // 
            this.urlImagenDataGridViewTextBoxColumn.DataPropertyName = "UrlImagen";
            this.urlImagenDataGridViewTextBoxColumn.HeaderText = "UrlImagen";
            this.urlImagenDataGridViewTextBoxColumn.Name = "urlImagenDataGridViewTextBoxColumn";
            this.urlImagenDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlImagenDataGridViewTextBoxColumn.Visible = false;
            // 
            // txNombreEquipo
            // 
            this.txNombreEquipo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txNombreEquipo.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txNombreEquipo.Lines = new string[] {
        "Nombre:"};
            this.txNombreEquipo.Location = new System.Drawing.Point(29, 67);
            this.txNombreEquipo.MaxLength = 32767;
            this.txNombreEquipo.Name = "txNombreEquipo";
            this.txNombreEquipo.PasswordChar = '\0';
            this.txNombreEquipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNombreEquipo.SelectedText = "";
            this.txNombreEquipo.Size = new System.Drawing.Size(150, 29);
            this.txNombreEquipo.TabIndex = 15;
            this.txNombreEquipo.Text = "Nombre:";
            this.txNombreEquipo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txNombreEquipo.UseSelectable = true;
            this.txNombreEquipo.Visible = false;
            this.txNombreEquipo.Click += new System.EventHandler(this.txNombreEquipo_Click);
            // 
            // cbConfiguracion
            // 
            this.cbConfiguracion.DataSource = this.configuracionBindingSource;
            this.cbConfiguracion.DisplayMember = "Nombre";
            this.cbConfiguracion.FormattingEnabled = true;
            this.cbConfiguracion.ItemHeight = 23;
            this.cbConfiguracion.Location = new System.Drawing.Point(196, 68);
            this.cbConfiguracion.Name = "cbConfiguracion";
            this.cbConfiguracion.PromptText = "Configuracion";
            this.cbConfiguracion.Size = new System.Drawing.Size(121, 29);
            this.cbConfiguracion.TabIndex = 16;
            this.cbConfiguracion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbConfiguracion.UseSelectable = true;
            this.cbConfiguracion.Visible = false;
            // 
            // configuracionBindingSource
            // 
            this.configuracionBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Configuracion);
            // 
            // posicionBindingSource
            // 
            this.posicionBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Posicion);
            // 
            // btAnadir
            // 
            this.btAnadir.Location = new System.Drawing.Point(196, 110);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(121, 23);
            this.btAnadir.TabIndex = 17;
            this.btAnadir.Text = "Añadir Equipo";
            this.btAnadir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btAnadir.UseSelectable = true;
            this.btAnadir.Visible = false;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // btCancelarAnadir
            // 
            this.btCancelarAnadir.Location = new System.Drawing.Point(196, 146);
            this.btCancelarAnadir.Name = "btCancelarAnadir";
            this.btCancelarAnadir.Size = new System.Drawing.Size(121, 23);
            this.btCancelarAnadir.TabIndex = 18;
            this.btCancelarAnadir.Text = "Cancelar";
            this.btCancelarAnadir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btCancelarAnadir.UseSelectable = true;
            this.btCancelarAnadir.Visible = false;
            this.btCancelarAnadir.Click += new System.EventHandler(this.btCancelarAnadir_Click);
            // 
            // btModificarEquipo
            // 
            this.btModificarEquipo.Location = new System.Drawing.Point(196, 109);
            this.btModificarEquipo.Name = "btModificarEquipo";
            this.btModificarEquipo.Size = new System.Drawing.Size(121, 23);
            this.btModificarEquipo.TabIndex = 19;
            this.btModificarEquipo.Text = "Modificar Equipo";
            this.btModificarEquipo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btModificarEquipo.UseSelectable = true;
            this.btModificarEquipo.Visible = false;
            this.btModificarEquipo.Click += new System.EventHandler(this.btModificarEquipo_Click);
            // 
            // fmModificarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btModificarEquipo);
            this.Controls.Add(this.btCancelarAnadir);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.cbConfiguracion);
            this.Controls.Add(this.txNombreEquipo);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lbGCEq);
            this.Controls.Add(this.lbGFEq);
            this.Controls.Add(this.lbPuntosEq);
            this.Controls.Add(this.lbGolesContra);
            this.Controls.Add(this.lbGolesFavor);
            this.Controls.Add(this.lbPuntos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNombreEquipo);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btComprarJugador);
            this.Controls.Add(this.btVenderJugador);
            this.Controls.Add(this.cbEquipos);
            this.Controls.Add(this.btCrear);
            this.Name = "fmModificarEquipo";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "fmModificarEquipo";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btCrear;
        private MetroFramework.Controls.MetroComboBox cbEquipos;
        private MetroFramework.Controls.MetroButton btVenderJugador;
        private MetroFramework.Controls.MetroButton btComprarJugador;
        private MetroFramework.Controls.MetroButton btModificar;
        private MetroFramework.Controls.MetroLabel lbNombreEquipo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lbPuntos;
        private MetroFramework.Controls.MetroLabel lbGolesFavor;
        private MetroFramework.Controls.MetroLabel lbGolesContra;
        private MetroFramework.Controls.MetroLabel lbPuntosEq;
        private MetroFramework.Controls.MetroLabel lbGFEq;
        private MetroFramework.Controls.MetroLabel lbGCEq;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicionDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCamisetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlImagenDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox txNombreEquipo;
        private MetroFramework.Controls.MetroComboBox cbConfiguracion;
        private System.Windows.Forms.BindingSource posicionBindingSource;
        private MetroFramework.Controls.MetroButton btAnadir;
        private System.Windows.Forms.BindingSource configuracionBindingSource;
        private MetroFramework.Controls.MetroButton btCancelarAnadir;
        private MetroFramework.Controls.MetroButton btModificarEquipo;
    }
}