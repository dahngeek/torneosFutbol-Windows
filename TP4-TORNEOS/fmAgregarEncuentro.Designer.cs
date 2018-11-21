namespace TP4_TORNEOS
{
    partial class fmAgregarEncuentro
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
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.equipoBindingSourceLocal = new System.Windows.Forms.BindingSource(this.components);
            this.equipoBindingSourceVisita = new System.Windows.Forms.BindingSource(this.components);
            this.cbEquipoLocal = new MetroFramework.Controls.MetroComboBox();
            this.cbEquipoVisitante = new MetroFramework.Controls.MetroComboBox();
            this.encuentroDate = new MetroFramework.Controls.MetroDateTime();
            this.tblArbitro = new MetroFramework.Controls.MetroGrid();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arbitroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSourceLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSourceVisita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArbitro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(148, 386);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(234, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // equipoBindingSourceLocal
            // 
            this.equipoBindingSourceLocal.DataSource = typeof(TP4_TORNEOS.Entidades.Equipo);
            // 
            // equipoBindingSourceVisita
            // 
            this.equipoBindingSourceVisita.DataSource = typeof(TP4_TORNEOS.Entidades.Equipo);
            // 
            // cbEquipoLocal
            // 
            this.cbEquipoLocal.DataSource = this.equipoBindingSourceLocal;
            this.cbEquipoLocal.DisplayMember = "Nombre";
            this.cbEquipoLocal.FormattingEnabled = true;
            this.cbEquipoLocal.ItemHeight = 23;
            this.cbEquipoLocal.Location = new System.Drawing.Point(27, 81);
            this.cbEquipoLocal.Name = "cbEquipoLocal";
            this.cbEquipoLocal.Size = new System.Drawing.Size(190, 29);
            this.cbEquipoLocal.TabIndex = 2;
            this.cbEquipoLocal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbEquipoLocal.UseSelectable = true;
            this.cbEquipoLocal.ValueMember = "Id";
            this.cbEquipoLocal.SelectedIndexChanged += new System.EventHandler(this.cbEquipoLocal_SelectedIndexChanged);
            // 
            // cbEquipoVisitante
            // 
            this.cbEquipoVisitante.DataSource = this.equipoBindingSourceVisita;
            this.cbEquipoVisitante.DisplayMember = "Nombre";
            this.cbEquipoVisitante.FormattingEnabled = true;
            this.cbEquipoVisitante.ItemHeight = 23;
            this.cbEquipoVisitante.Location = new System.Drawing.Point(256, 81);
            this.cbEquipoVisitante.Name = "cbEquipoVisitante";
            this.cbEquipoVisitante.Size = new System.Drawing.Size(207, 29);
            this.cbEquipoVisitante.TabIndex = 3;
            this.cbEquipoVisitante.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbEquipoVisitante.UseSelectable = true;
            this.cbEquipoVisitante.ValueMember = "Id";
            // 
            // encuentroDate
            // 
            this.encuentroDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.encuentroDate.Location = new System.Drawing.Point(132, 144);
            this.encuentroDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.encuentroDate.Name = "encuentroDate";
            this.encuentroDate.Size = new System.Drawing.Size(219, 29);
            this.encuentroDate.TabIndex = 4;
            this.encuentroDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tblArbitro
            // 
            this.tblArbitro.AllowUserToAddRows = false;
            this.tblArbitro.AllowUserToDeleteRows = false;
            this.tblArbitro.AllowUserToResizeRows = false;
            this.tblArbitro.AutoGenerateColumns = false;
            this.tblArbitro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tblArbitro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblArbitro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblArbitro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblArbitro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblArbitro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblArbitro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.tblArbitro.DataSource = this.arbitroBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblArbitro.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblArbitro.EnableHeadersVisualStyles = false;
            this.tblArbitro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tblArbitro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tblArbitro.Location = new System.Drawing.Point(121, 212);
            this.tblArbitro.MultiSelect = false;
            this.tblArbitro.Name = "tblArbitro";
            this.tblArbitro.ReadOnly = true;
            this.tblArbitro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblArbitro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblArbitro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tblArbitro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblArbitro.Size = new System.Drawing.Size(240, 150);
            this.tblArbitro.TabIndex = 5;
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
            // arbitroBindingSource
            // 
            this.arbitroBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Arbitro);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Equipo Local:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(256, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Equipo Visitante:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(128, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Fecha y Hora:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(121, 187);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Arbitro:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // fmAgregarEncuentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(486, 425);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tblArbitro);
            this.Controls.Add(this.encuentroDate);
            this.Controls.Add(this.cbEquipoVisitante);
            this.Controls.Add(this.cbEquipoLocal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "fmAgregarEncuentro";
            this.Text = "Crear nuevo Encuentro";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSourceLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSourceVisita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArbitro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.BindingSource equipoBindingSourceLocal;
        private System.Windows.Forms.BindingSource equipoBindingSourceVisita;
        private MetroFramework.Controls.MetroComboBox cbEquipoLocal;
        private MetroFramework.Controls.MetroComboBox cbEquipoVisitante;
        private MetroFramework.Controls.MetroDateTime encuentroDate;
        private MetroFramework.Controls.MetroGrid tblArbitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource arbitroBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}