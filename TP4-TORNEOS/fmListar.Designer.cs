﻿namespace TP4_TORNEOS
{
	partial class fmListar
	{
		/// <summary>
		/// Required designer audioBoton.
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmListar));
			this.tarjetaJugador = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbGol = new System.Windows.Forms.Label();
			this.lbPosicion = new System.Windows.Forms.Label();
			this.lbTarjeta = new System.Windows.Forms.Label();
			this.lbdataTarjeta = new System.Windows.Forms.Label();
			this.lbdataPosicion = new System.Windows.Forms.Label();
			this.lbdataGol = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.lbCamiseta = new System.Windows.Forms.Label();
			this.mBtNuevo = new MetroFramework.Controls.MetroButton();
			this.mBtModificar = new MetroFramework.Controls.MetroButton();
			this.mBtBorrar = new MetroFramework.Controls.MetroButton();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
			this.lbequipo = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.minutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tarjetaJugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numeroCamisetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.tarjetaJugador)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tarjetaJugadorBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tarjetaJugador
			// 
			this.tarjetaJugador.Image = global::TP4_TORNEOS.Properties.Resources.cardsbg_large;
			this.tarjetaJugador.Location = new System.Drawing.Point(56, 162);
			this.tarjetaJugador.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.tarjetaJugador.Name = "tarjetaJugador";
			this.tarjetaJugador.Size = new System.Drawing.Size(268, 303);
			this.tarjetaJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tarjetaJugador.TabIndex = 0;
			this.tarjetaJugador.TabStop = false;
			this.tarjetaJugador.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(84, 205);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 90);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
			// 
			// lbGol
			// 
			this.lbGol.AutoSize = true;
			this.lbGol.BackColor = System.Drawing.Color.Transparent;
			this.lbGol.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGol.Location = new System.Drawing.Point(174, 379);
			this.lbGol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbGol.Name = "lbGol";
			this.lbGol.Size = new System.Drawing.Size(45, 25);
			this.lbGol.TabIndex = 8;
			this.lbGol.Text = "204";
			// 
			// lbPosicion
			// 
			this.lbPosicion.AutoSize = true;
			this.lbPosicion.BackColor = System.Drawing.Color.Transparent;
			this.lbPosicion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPosicion.Location = new System.Drawing.Point(93, 379);
			this.lbPosicion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbPosicion.Name = "lbPosicion";
			this.lbPosicion.Size = new System.Drawing.Size(41, 25);
			this.lbPosicion.TabIndex = 9;
			this.lbPosicion.Text = "Del";
			// 
			// lbTarjeta
			// 
			this.lbTarjeta.AutoSize = true;
			this.lbTarjeta.BackColor = System.Drawing.Color.Transparent;
			this.lbTarjeta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTarjeta.Location = new System.Drawing.Point(246, 379);
			this.lbTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbTarjeta.Name = "lbTarjeta";
			this.lbTarjeta.Size = new System.Drawing.Size(34, 25);
			this.lbTarjeta.TabIndex = 11;
			this.lbTarjeta.Text = "12";
			// 
			// lbdataTarjeta
			// 
			this.lbdataTarjeta.AutoSize = true;
			this.lbdataTarjeta.BackColor = System.Drawing.Color.Transparent;
			this.lbdataTarjeta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbdataTarjeta.Location = new System.Drawing.Point(238, 351);
			this.lbdataTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbdataTarjeta.Name = "lbdataTarjeta";
			this.lbdataTarjeta.Size = new System.Drawing.Size(55, 25);
			this.lbdataTarjeta.TabIndex = 15;
			this.lbdataTarjeta.Text = "TARJ";
			// 
			// lbdataPosicion
			// 
			this.lbdataPosicion.AutoSize = true;
			this.lbdataPosicion.BackColor = System.Drawing.Color.Transparent;
			this.lbdataPosicion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbdataPosicion.Location = new System.Drawing.Point(98, 351);
			this.lbdataPosicion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbdataPosicion.Name = "lbdataPosicion";
			this.lbdataPosicion.Size = new System.Drawing.Size(61, 25);
			this.lbdataPosicion.TabIndex = 13;
			this.lbdataPosicion.Text = "POSC";
			// 
			// lbdataGol
			// 
			this.lbdataGol.AutoSize = true;
			this.lbdataGol.BackColor = System.Drawing.Color.Transparent;
			this.lbdataGol.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbdataGol.Location = new System.Drawing.Point(170, 351);
			this.lbdataGol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbdataGol.Name = "lbdataGol";
			this.lbdataGol.Size = new System.Drawing.Size(61, 25);
			this.lbdataGol.TabIndex = 12;
			this.lbdataGol.Text = "GOLS";
			// 
			// lbCamiseta
			// 
			this.lbCamiseta.AutoSize = true;
			this.lbCamiseta.BackColor = System.Drawing.Color.Transparent;
			this.lbCamiseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCamiseta.Location = new System.Drawing.Point(206, 222);
			this.lbCamiseta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbCamiseta.Name = "lbCamiseta";
			this.lbCamiseta.Size = new System.Drawing.Size(129, 91);
			this.lbCamiseta.TabIndex = 10;
			this.lbCamiseta.Text = "10";
			// 
			// mBtNuevo
			// 
			this.mBtNuevo.Location = new System.Drawing.Point(23, 53);
			this.mBtNuevo.Margin = new System.Windows.Forms.Padding(4);
			this.mBtNuevo.Name = "mBtNuevo";
			this.mBtNuevo.Size = new System.Drawing.Size(120, 23);
			this.mBtNuevo.TabIndex = 16;
			this.mBtNuevo.Text = "Nuevo";
			this.mBtNuevo.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mBtNuevo.UseSelectable = true;
			this.mBtNuevo.Click += new System.EventHandler(this.mBtNuevo_Click);
			// 
			// mBtModificar
			// 
			this.mBtModificar.Location = new System.Drawing.Point(151, 53);
			this.mBtModificar.Margin = new System.Windows.Forms.Padding(4);
			this.mBtModificar.Name = "mBtModificar";
			this.mBtModificar.Size = new System.Drawing.Size(120, 23);
			this.mBtModificar.TabIndex = 17;
			this.mBtModificar.Text = "Modificar";
			this.mBtModificar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mBtModificar.UseSelectable = true;
			this.mBtModificar.Click += new System.EventHandler(this.mBtModificar_Click);
			// 
			// mBtBorrar
			// 
			this.mBtBorrar.Location = new System.Drawing.Point(279, 53);
			this.mBtBorrar.Margin = new System.Windows.Forms.Padding(4);
			this.mBtBorrar.Name = "mBtBorrar";
			this.mBtBorrar.Size = new System.Drawing.Size(120, 23);
			this.mBtBorrar.TabIndex = 18;
			this.mBtBorrar.Text = "Borrar";
			this.mBtBorrar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mBtBorrar.UseSelectable = true;
			this.mBtBorrar.Click += new System.EventHandler(this.mBtBorrar_Click);
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.apodoDataGridViewTextBoxColumn,
            this.numeroCamisetaDataGridViewTextBoxColumn});
			this.metroGrid1.DataSource = this.jugadorBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
			this.metroGrid1.EnableHeadersVisualStyles = false;
			this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.metroGrid1.Location = new System.Drawing.Point(399, 182);
			this.metroGrid1.Name = "metroGrid1";
			this.metroGrid1.ReadOnly = true;
			this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGrid1.RowTemplate.Height = 24;
			this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid1.Size = new System.Drawing.Size(448, 151);
			this.metroGrid1.Style = MetroFramework.MetroColorStyle.Teal;
			this.metroGrid1.TabIndex = 21;
			this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
			this.metroGrid1.SelectionChanged += new System.EventHandler(this.metroGrid1_SelectionChanged);
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.ForeColor = System.Drawing.Color.White;
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 24;
			this.metroComboBox1.Items.AddRange(new object[] {
            "Listar todos Los Jugadores",
            "Ordenar por Goles",
            "Ordenar por Tarjetas"});
			this.metroComboBox1.Location = new System.Drawing.Point(633, 53);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(484, 30);
			this.metroComboBox1.Style = MetroFramework.MetroColorStyle.White;
			this.metroComboBox1.TabIndex = 23;
			this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroComboBox1.UseSelectable = true;
			this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
			// 
			// metroGrid2
			// 
			this.metroGrid2.AllowUserToAddRows = false;
			this.metroGrid2.AllowUserToDeleteRows = false;
			this.metroGrid2.AllowUserToResizeRows = false;
			this.metroGrid2.AutoGenerateColumns = false;
			this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.minutoDataGridViewTextBoxColumn});
			this.metroGrid2.DataSource = this.tarjetaJugadorBindingSource;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle5;
			this.metroGrid2.EnableHeadersVisualStyles = false;
			this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.metroGrid2.Location = new System.Drawing.Point(864, 182);
			this.metroGrid2.Name = "metroGrid2";
			this.metroGrid2.ReadOnly = true;
			this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGrid2.RowTemplate.Height = 24;
			this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid2.Size = new System.Drawing.Size(343, 150);
			this.metroGrid2.Style = MetroFramework.MetroColorStyle.Teal;
			this.metroGrid2.TabIndex = 25;
			this.metroGrid2.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// lbequipo
			// 
			this.lbequipo.AutoSize = true;
			this.lbequipo.Location = new System.Drawing.Point(151, 123);
			this.lbequipo.Name = "lbequipo";
			this.lbequipo.Size = new System.Drawing.Size(37, 20);
			this.lbequipo.TabIndex = 26;
			this.lbequipo.Text = "Club";
			this.lbequipo.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(875, 144);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(114, 20);
			this.metroLabel1.TabIndex = 27;
			this.metroLabel1.Text = "Min de La Tarjeta";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// minutoDataGridViewTextBoxColumn
			// 
			this.minutoDataGridViewTextBoxColumn.DataPropertyName = "Minuto";
			this.minutoDataGridViewTextBoxColumn.HeaderText = "Minuto";
			this.minutoDataGridViewTextBoxColumn.Name = "minutoDataGridViewTextBoxColumn";
			this.minutoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tarjetaJugadorBindingSource
			// 
			this.tarjetaJugadorBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.TarjetaJugador);
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
			// 
			// jugadorBindingSource
			// 
			this.jugadorBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Jugador);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(542, 144);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(127, 20);
			this.metroLabel2.TabIndex = 28;
			this.metroLabel2.Text = "Tabla de Jugadores";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// fmListar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 45F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImage = global::TP4_TORNEOS.Properties.Resources.FONDO;
			this.ClientSize = new System.Drawing.Size(1185, 512);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.lbequipo);
			this.Controls.Add(this.metroGrid2);
			this.Controls.Add(this.metroComboBox1);
			this.Controls.Add(this.metroGrid1);
			this.Controls.Add(this.mBtBorrar);
			this.Controls.Add(this.mBtModificar);
			this.Controls.Add(this.mBtNuevo);
			this.Controls.Add(this.lbdataTarjeta);
			this.Controls.Add(this.lbdataPosicion);
			this.Controls.Add(this.lbdataGol);
			this.Controls.Add(this.lbTarjeta);
			this.Controls.Add(this.lbCamiseta);
			this.Controls.Add(this.lbPosicion);
			this.Controls.Add(this.lbGol);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tarjetaJugador);
			this.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(1000, 1000);
			this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
			this.Name = "fmListar";
			this.Padding = new System.Windows.Forms.Padding(0, 59, 0, 2);
			this.Style = MetroFramework.MetroColorStyle.Teal;
			this.Text = "Jugadores";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.Blue;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmListar_FormClosed);
			this.Load += new System.EventHandler(this.fmListar_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fmListar_KeyPress);
			this.Leave += new System.EventHandler(this.fmListar_Leave);
			((System.ComponentModel.ISupportInitialize)(this.tarjetaJugador)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tarjetaJugadorBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox tarjetaJugador;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbGol;
		private System.Windows.Forms.Label lbPosicion;
		private System.Windows.Forms.Label lbTarjeta;
		private System.Windows.Forms.Label lbdataTarjeta;
		private System.Windows.Forms.Label lbdataPosicion;
		private System.Windows.Forms.Label lbdataGol;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbCamiseta;
		private MetroFramework.Controls.MetroButton mBtNuevo;
		private MetroFramework.Controls.MetroButton mBtModificar;
		private MetroFramework.Controls.MetroButton mBtBorrar;
		private System.Windows.Forms.BindingSource jugadorBindingSource;
		private MetroFramework.Controls.MetroGrid metroGrid1;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private MetroFramework.Controls.MetroGrid metroGrid2;
		private System.Windows.Forms.BindingSource tarjetaJugadorBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn apodoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeroCamisetaDataGridViewTextBoxColumn;
		private MetroFramework.Controls.MetroLabel lbequipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn minutoDataGridViewTextBoxColumn;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
	}
}