namespace TP4_TORNEOS
{
    partial class frmEncuentro
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
            this.encuentrosTable = new MetroFramework.Controls.MetroGrid();
            this.btnNuevoEncuentro = new MetroFramework.Controls.MetroButton();
            this.btnModificarEncuentro = new MetroFramework.Controls.MetroButton();
            this.btnEliminarEncuentro = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.encuentroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.encuentrosTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encuentroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // encuentrosTable
            // 
            this.encuentrosTable.AllowUserToAddRows = false;
            this.encuentrosTable.AllowUserToDeleteRows = false;
            this.encuentrosTable.AllowUserToResizeRows = false;
            this.encuentrosTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.encuentrosTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encuentrosTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.encuentrosTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.encuentrosTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.encuentrosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.encuentrosTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.encuentrosTable.EnableHeadersVisualStyles = false;
            this.encuentrosTable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.encuentrosTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.encuentrosTable.Location = new System.Drawing.Point(215, 97);
            this.encuentrosTable.Name = "encuentrosTable";
            this.encuentrosTable.ReadOnly = true;
            this.encuentrosTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.encuentrosTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.encuentrosTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.encuentrosTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.encuentrosTable.Size = new System.Drawing.Size(542, 322);
            this.encuentrosTable.TabIndex = 0;
            this.encuentrosTable.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnNuevoEncuentro
            // 
            this.btnNuevoEncuentro.Location = new System.Drawing.Point(46, 57);
            this.btnNuevoEncuentro.Name = "btnNuevoEncuentro";
            this.btnNuevoEncuentro.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoEncuentro.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnNuevoEncuentro.TabIndex = 1;
            this.btnNuevoEncuentro.Text = "Nuevo";
            this.btnNuevoEncuentro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNuevoEncuentro.UseSelectable = true;
            this.btnNuevoEncuentro.Click += new System.EventHandler(this.btnNuevoEncuentro_Click);
            // 
            // btnModificarEncuentro
            // 
            this.btnModificarEncuentro.Location = new System.Drawing.Point(128, 57);
            this.btnModificarEncuentro.Name = "btnModificarEncuentro";
            this.btnModificarEncuentro.Size = new System.Drawing.Size(99, 23);
            this.btnModificarEncuentro.TabIndex = 2;
            this.btnModificarEncuentro.Text = "Ver/Modificar";
            this.btnModificarEncuentro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnModificarEncuentro.UseSelectable = true;
            this.btnModificarEncuentro.Click += new System.EventHandler(this.btnModificarEncuentro_Click);
            // 
            // btnEliminarEncuentro
            // 
            this.btnEliminarEncuentro.Location = new System.Drawing.Point(682, 57);
            this.btnEliminarEncuentro.Name = "btnEliminarEncuentro";
            this.btnEliminarEncuentro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEncuentro.TabIndex = 3;
            this.btnEliminarEncuentro.Text = "Eliminar";
            this.btnEliminarEncuentro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEliminarEncuentro.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP4_TORNEOS.Properties.Resources.cheto;
            this.pictureBox1.Location = new System.Drawing.Point(34, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // encuentroBindingSource
            // 
            this.encuentroBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Encuentro);
            // 
            // frmEncuentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarEncuentro);
            this.Controls.Add(this.btnModificarEncuentro);
            this.Controls.Add(this.btnNuevoEncuentro);
            this.Controls.Add(this.encuentrosTable);
            this.Name = "frmEncuentro";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Encuentros";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.encuentrosTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encuentroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource encuentroBindingSource;
        private MetroFramework.Controls.MetroGrid encuentrosTable;
        private MetroFramework.Controls.MetroButton btnNuevoEncuentro;
        private MetroFramework.Controls.MetroButton btnModificarEncuentro;
        private MetroFramework.Controls.MetroButton btnEliminarEncuentro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}