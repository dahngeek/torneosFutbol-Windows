namespace TP4_TORNEOS
{
    partial class fmArbitro
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
            this.newArbitroBtn = new MetroFramework.Controls.MetroButton();
            this.modifyArbitroBtn = new MetroFramework.Controls.MetroButton();
            this.deleteArbitroBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablaArbitros = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arbitroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.apellidoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArbitros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newArbitroBtn
            // 
            this.newArbitroBtn.Location = new System.Drawing.Point(16, 46);
            this.newArbitroBtn.Name = "newArbitroBtn";
            this.newArbitroBtn.Size = new System.Drawing.Size(75, 23);
            this.newArbitroBtn.TabIndex = 0;
            this.newArbitroBtn.Text = "Nuevo";
            this.newArbitroBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.newArbitroBtn.UseSelectable = true;
            this.newArbitroBtn.Click += new System.EventHandler(this.newArbitroBtn_Click);
            // 
            // modifyArbitroBtn
            // 
            this.modifyArbitroBtn.Location = new System.Drawing.Point(397, 46);
            this.modifyArbitroBtn.Name = "modifyArbitroBtn";
            this.modifyArbitroBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyArbitroBtn.TabIndex = 1;
            this.modifyArbitroBtn.Text = "Modificar";
            this.modifyArbitroBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.modifyArbitroBtn.UseSelectable = true;
            this.modifyArbitroBtn.Click += new System.EventHandler(this.modifyArbitroBtn_Click);
            // 
            // deleteArbitroBtn
            // 
            this.deleteArbitroBtn.Location = new System.Drawing.Point(478, 46);
            this.deleteArbitroBtn.Name = "deleteArbitroBtn";
            this.deleteArbitroBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteArbitroBtn.Style = MetroFramework.MetroColorStyle.Orange;
            this.deleteArbitroBtn.TabIndex = 2;
            this.deleteArbitroBtn.Text = "Eliminar";
            this.deleteArbitroBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deleteArbitroBtn.UseSelectable = true;
            this.deleteArbitroBtn.Click += new System.EventHandler(this.deleteArbitroBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP4_TORNEOS.Properties.Resources.firefox_2018_11_18_20_24_25;
            this.pictureBox1.Location = new System.Drawing.Point(16, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tablaArbitros
            // 
            this.tablaArbitros.AllowUserToAddRows = false;
            this.tablaArbitros.AllowUserToDeleteRows = false;
            this.tablaArbitros.AllowUserToResizeRows = false;
            this.tablaArbitros.AutoGenerateColumns = false;
            this.tablaArbitros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tablaArbitros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaArbitros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tablaArbitros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaArbitros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaArbitros.ColumnHeadersHeight = 30;
            this.tablaArbitros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.tablaArbitros.DataSource = this.arbitroBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaArbitros.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaArbitros.EnableHeadersVisualStyles = false;
            this.tablaArbitros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tablaArbitros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tablaArbitros.Location = new System.Drawing.Point(212, 83);
            this.tablaArbitros.MultiSelect = false;
            this.tablaArbitros.Name = "tablaArbitros";
            this.tablaArbitros.ReadOnly = true;
            this.tablaArbitros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaArbitros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaArbitros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablaArbitros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaArbitros.Size = new System.Drawing.Size(341, 345);
            this.tablaArbitros.Style = MetroFramework.MetroColorStyle.Teal;
            this.tablaArbitros.TabIndex = 5;
            this.tablaArbitros.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tablaArbitros.SelectionChanged += new System.EventHandler(this.tablaArbitros_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // nombreTextBox
            // 
            this.nombreTextBox.Lines = new string[] {
        "John"};
            this.nombreTextBox.Location = new System.Drawing.Point(91, 101);
            this.nombreTextBox.MaxLength = 32767;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.PasswordChar = '\0';
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombreTextBox.SelectedText = "";
            this.nombreTextBox.Size = new System.Drawing.Size(98, 23);
            this.nombreTextBox.TabIndex = 6;
            this.nombreTextBox.Text = "John";
            this.nombreTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nombreTextBox.UseSelectable = true;
            this.nombreTextBox.Click += new System.EventHandler(this.nombreTextBox_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Nombre:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Lines = new string[] {
        "Doe"};
            this.apellidoTextBox.Location = new System.Drawing.Point(91, 133);
            this.apellidoTextBox.MaxLength = 32767;
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.PasswordChar = '\0';
            this.apellidoTextBox.ReadOnly = true;
            this.apellidoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.apellidoTextBox.SelectedText = "";
            this.apellidoTextBox.Size = new System.Drawing.Size(97, 23);
            this.apellidoTextBox.TabIndex = 8;
            this.apellidoTextBox.Text = "Doe";
            this.apellidoTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.apellidoTextBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Apellido:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(113, 165);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // fmArbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.tablaArbitros);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteArbitroBtn);
            this.Controls.Add(this.modifyArbitroBtn);
            this.Controls.Add(this.newArbitroBtn);
            this.MaximizeBox = false;
            this.Name = "fmArbitro";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Administrar Arbitros";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArbitros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton newArbitroBtn;
        private MetroFramework.Controls.MetroButton modifyArbitroBtn;
        private MetroFramework.Controls.MetroButton deleteArbitroBtn;
        private System.Windows.Forms.BindingSource arbitroBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid tablaArbitros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox nombreTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox apellidoTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton saveBtn;
    }
}