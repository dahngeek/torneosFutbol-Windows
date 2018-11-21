namespace TP4_TORNEOS
{
    partial class fmEncuentroDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLocal = new MetroFramework.Controls.MetroLabel();
            this.lblVisitante = new MetroFramework.Controls.MetroLabel();
            this.puntajeLocal = new System.Windows.Forms.Label();
            this.puntajeVisitante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.agregarGol = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.registroTable = new MetroFramework.Controls.MetroGrid();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.registroTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLocal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLocal.Location = new System.Drawing.Point(26, 63);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(86, 25);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "Equipo 1";
            this.lblLocal.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblVisitante
            // 
            this.lblVisitante.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVisitante.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblVisitante.Location = new System.Drawing.Point(459, 63);
            this.lblVisitante.Name = "lblVisitante";
            this.lblVisitante.Size = new System.Drawing.Size(206, 25);
            this.lblVisitante.TabIndex = 1;
            this.lblVisitante.Text = "Equipo 2";
            this.lblVisitante.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblVisitante.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // puntajeLocal
            // 
            this.puntajeLocal.AutoSize = true;
            this.puntajeLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntajeLocal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.puntajeLocal.Location = new System.Drawing.Point(254, 54);
            this.puntajeLocal.Name = "puntajeLocal";
            this.puntajeLocal.Size = new System.Drawing.Size(80, 55);
            this.puntajeLocal.TabIndex = 2;
            this.puntajeLocal.Text = "##";
            this.puntajeLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // puntajeVisitante
            // 
            this.puntajeVisitante.AutoSize = true;
            this.puntajeVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntajeVisitante.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.puntajeVisitante.Location = new System.Drawing.Point(350, 54);
            this.puntajeVisitante.Name = "puntajeVisitante";
            this.puntajeVisitante.Size = new System.Drawing.Size(80, 55);
            this.puntajeVisitante.TabIndex = 3;
            this.puntajeVisitante.Text = "##";
            this.puntajeVisitante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(325, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.metroButton1.Location = new System.Drawing.Point(127, 123);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(101, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Agregar Tarjeta";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // agregarGol
            // 
            this.agregarGol.Location = new System.Drawing.Point(26, 123);
            this.agregarGol.Name = "agregarGol";
            this.agregarGol.Size = new System.Drawing.Size(86, 23);
            this.agregarGol.TabIndex = 5;
            this.agregarGol.Text = "Agregar Gol";
            this.agregarGol.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.agregarGol.UseSelectable = true;
            this.agregarGol.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(244, 123);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(106, 23);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Agregar Cambio";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Local";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(608, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Visitante";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // registroTable
            // 
            this.registroTable.AllowUserToAddRows = false;
            this.registroTable.AllowUserToDeleteRows = false;
            this.registroTable.AllowUserToResizeRows = false;
            this.registroTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.registroTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registroTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.registroTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registroTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.registroTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.registroTable.DefaultCellStyle = dataGridViewCellStyle11;
            this.registroTable.EnableHeadersVisualStyles = false;
            this.registroTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.registroTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.registroTable.Location = new System.Drawing.Point(76, 165);
            this.registroTable.MultiSelect = false;
            this.registroTable.Name = "registroTable";
            this.registroTable.ReadOnly = true;
            this.registroTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registroTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.registroTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.registroTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registroTable.Size = new System.Drawing.Size(572, 212);
            this.registroTable.TabIndex = 10;
            this.registroTable.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(590, 123);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "Eliminar";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // fmEncuentroDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 402);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.registroTable);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.agregarGol);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.puntajeVisitante);
            this.Controls.Add(this.puntajeLocal);
            this.Controls.Add(this.lblVisitante);
            this.Controls.Add(this.lblLocal);
            this.MaximizeBox = false;
            this.Name = "fmEncuentroDetalle";
            this.Text = "Encuentro:";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.registroTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblLocal;
        private MetroFramework.Controls.MetroLabel lblVisitante;
        private System.Windows.Forms.Label puntajeLocal;
        private System.Windows.Forms.Label puntajeVisitante;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton agregarGol;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid registroTable;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}