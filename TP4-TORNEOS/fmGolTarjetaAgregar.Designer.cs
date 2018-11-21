namespace TP4_TORNEOS
{
    partial class fmGolTarjetaAgregar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btAceptar = new MetroFramework.Controls.MetroButton();
            this.btCancelar = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCamisetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlImagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minuteBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.boxTarjeta = new MetroFramework.Controls.MetroComboBox();
            this.labelTarjeta = new MetroFramework.Controls.MetroLabel();
            this.tipoTarjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTarjetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.equipoBindingSource;
            this.metroComboBox1.DisplayMember = "Nombre";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(23, 66);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(191, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "GolesContra";
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Equipo);
            this.equipoBindingSource.CurrentChanged += new System.EventHandler(this.equipoBindingSource_CurrentChanged);
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAceptar.Location = new System.Drawing.Point(82, 410);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btAceptar.UseSelectable = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(181, 411);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btCancelar.UseSelectable = true;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.apodoDataGridViewTextBoxColumn,
            this.numeroCamisetaDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.posicionDataGridViewTextBoxColumn,
            this.urlImagenDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.jugadorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(21, 116);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(293, 244);
            this.metroGrid1.TabIndex = 3;
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
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            this.equipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.equipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // posicionDataGridViewTextBoxColumn
            // 
            this.posicionDataGridViewTextBoxColumn.DataPropertyName = "Posicion";
            this.posicionDataGridViewTextBoxColumn.HeaderText = "Posicion";
            this.posicionDataGridViewTextBoxColumn.Name = "posicionDataGridViewTextBoxColumn";
            this.posicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlImagenDataGridViewTextBoxColumn
            // 
            this.urlImagenDataGridViewTextBoxColumn.DataPropertyName = "UrlImagen";
            this.urlImagenDataGridViewTextBoxColumn.HeaderText = "UrlImagen";
            this.urlImagenDataGridViewTextBoxColumn.Name = "urlImagenDataGridViewTextBoxColumn";
            this.urlImagenDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlImagenDataGridViewTextBoxColumn.Visible = false;
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Jugador);
            // 
            // minuteBox
            // 
            this.minuteBox.Lines = new string[] {
        "0"};
            this.minuteBox.Location = new System.Drawing.Point(239, 69);
            this.minuteBox.MaxLength = 32767;
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.PasswordChar = '\0';
            this.minuteBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.minuteBox.SelectedText = "";
            this.minuteBox.Size = new System.Drawing.Size(75, 23);
            this.minuteBox.TabIndex = 5;
            this.minuteBox.Text = "0";
            this.minuteBox.UseSelectable = true;
            this.minuteBox.TextChanged += new System.EventHandler(this.minuteBox_TextChanged);
            this.minuteBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minuteBox_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Equipo:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(239, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Minuto:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // boxTarjeta
            // 
            this.boxTarjeta.DataSource = this.tipoTarjetaBindingSource;
            this.boxTarjeta.DisplayMember = "Nombre";
            this.boxTarjeta.FormattingEnabled = true;
            this.boxTarjeta.ItemHeight = 23;
            this.boxTarjeta.Location = new System.Drawing.Point(150, 372);
            this.boxTarjeta.Name = "boxTarjeta";
            this.boxTarjeta.Size = new System.Drawing.Size(164, 29);
            this.boxTarjeta.TabIndex = 8;
            this.boxTarjeta.UseSelectable = true;
            this.boxTarjeta.ValueMember = "Id";
            this.boxTarjeta.Visible = false;
            // 
            // labelTarjeta
            // 
            this.labelTarjeta.AutoSize = true;
            this.labelTarjeta.Location = new System.Drawing.Point(53, 377);
            this.labelTarjeta.Name = "labelTarjeta";
            this.labelTarjeta.Size = new System.Drawing.Size(80, 19);
            this.labelTarjeta.TabIndex = 9;
            this.labelTarjeta.Text = "Tipo Tarjeta:";
            this.labelTarjeta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelTarjeta.Visible = false;
            // 
            // tipoTarjetaBindingSource
            // 
            this.tipoTarjetaBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.TipoTarjeta);
            // 
            // fmGolTarjetaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.labelTarjeta);
            this.Controls.Add(this.boxTarjeta);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.metroComboBox1);
            this.MaximizeBox = false;
            this.Name = "fmGolTarjetaAgregar";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Agregar Gol";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.fmGolTarjetaAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTarjetaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton btAceptar;
        private MetroFramework.Controls.MetroButton btCancelar;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCamisetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlImagenDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox minuteBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox boxTarjeta;
        private System.Windows.Forms.BindingSource tipoTarjetaBindingSource;
        private MetroFramework.Controls.MetroLabel labelTarjeta;
    }
}