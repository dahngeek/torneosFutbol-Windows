namespace TP4_TORNEOS
{
    partial class PantallaPrincipal
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btJugador = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
			this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
			this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.mtpJugadores = new MetroFramework.Controls.MetroTabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.btJugador.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			this.metroPanel2.SuspendLayout();
			this.metroPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			this.metroTabPage2.SuspendLayout();
			this.mtpJugadores.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackgroundImage = global::TP4_TORNEOS.Properties.Resources.FONDO;
			this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Controls.Add(this.btJugador, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1800, 942);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// btJugador
			// 
			this.btJugador.AccessibleDescription = "";
			this.btJugador.AccessibleName = "";
			this.btJugador.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.btJugador.Controls.Add(this.metroTabPage1);
			this.btJugador.Controls.Add(this.metroTabPage2);
			this.btJugador.Controls.Add(this.mtpJugadores);
			this.btJugador.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btJugador.Dock = System.Windows.Forms.DockStyle.Right;
			this.btJugador.FontSize = MetroFramework.MetroTabControlSize.Tall;
			this.btJugador.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
			this.btJugador.HotTrack = true;
			this.btJugador.ItemSize = new System.Drawing.Size(460, 45);
			this.btJugador.Location = new System.Drawing.Point(180, 188);
			this.btJugador.Margin = new System.Windows.Forms.Padding(0);
			this.btJugador.Name = "btJugador";
			this.btJugador.SelectedIndex = 2;
			this.btJugador.Size = new System.Drawing.Size(1440, 659);
			this.btJugador.Style = MetroFramework.MetroColorStyle.Orange;
			this.btJugador.TabIndex = 0;
			this.btJugador.TabStop = false;
			this.btJugador.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btJugador.UseSelectable = true;
			this.btJugador.Resize += new System.EventHandler(this.x);
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.BackgroundImage = global::TP4_TORNEOS.Properties.Resources.blurred;
			this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.metroTabPage1.Controls.Add(this.metroPanel2);
			this.metroTabPage1.Controls.Add(this.metroPanel1);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 12;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 49);
			this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(1432, 606);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "INICIO";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 13;
			this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
			// 
			// metroPanel2
			// 
			this.metroPanel2.Controls.Add(this.metroLabel4);
			this.metroPanel2.Controls.Add(this.metroLabel3);
			this.metroPanel2.Controls.Add(this.metroLabel2);
			this.metroPanel2.Controls.Add(this.metroProgressBar1);
			this.metroPanel2.Controls.Add(this.metroProgressSpinner1);
			this.metroPanel2.Controls.Add(this.metroProgressBar2);
			this.metroPanel2.HorizontalScrollbarBarColor = true;
			this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel2.HorizontalScrollbarSize = 12;
			this.metroPanel2.Location = new System.Drawing.Point(671, 183);
			this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
			this.metroPanel2.Name = "metroPanel2";
			this.metroPanel2.Size = new System.Drawing.Size(365, 375);
			this.metroPanel2.TabIndex = 6;
			this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroPanel2.VerticalScrollbarBarColor = true;
			this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel2.VerticalScrollbarSize = 13;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(11, 5);
			this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(144, 20);
			this.metroLabel4.TabIndex = 8;
			this.metroLabel4.Text = "PUNTOS OBTENIDOS";
			this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(11, 71);
			this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(173, 20);
			this.metroLabel3.TabIndex = 7;
			this.metroLabel3.Text = "PARTIDOS COMPLETADOS";
			this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(11, 153);
			this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(188, 20);
			this.metroLabel2.TabIndex = 6;
			this.metroLabel2.Text = "PORCENTAJE COMPLETADO";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroProgressBar1
			// 
			this.metroProgressBar1.Location = new System.Drawing.Point(11, 36);
			this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(4);
			this.metroProgressBar1.Name = "metroProgressBar1";
			this.metroProgressBar1.Size = new System.Drawing.Size(344, 28);
			this.metroProgressBar1.TabIndex = 4;
			this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroProgressBar1.Value = 5;
			// 
			// metroProgressSpinner1
			// 
			this.metroProgressSpinner1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.metroProgressSpinner1.Location = new System.Drawing.Point(92, 187);
			this.metroProgressSpinner1.Margin = new System.Windows.Forms.Padding(4);
			this.metroProgressSpinner1.Maximum = 100;
			this.metroProgressSpinner1.Name = "metroProgressSpinner1";
			this.metroProgressSpinner1.Size = new System.Drawing.Size(196, 172);
			this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroProgressSpinner1.TabIndex = 5;
			this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroProgressSpinner1.UseSelectable = true;
			this.metroProgressSpinner1.Value = 35;
			// 
			// metroProgressBar2
			// 
			this.metroProgressBar2.Location = new System.Drawing.Point(11, 102);
			this.metroProgressBar2.Margin = new System.Windows.Forms.Padding(4);
			this.metroProgressBar2.Name = "metroProgressBar2";
			this.metroProgressBar2.Size = new System.Drawing.Size(344, 28);
			this.metroProgressBar2.Style = MetroFramework.MetroColorStyle.Green;
			this.metroProgressBar2.TabIndex = 4;
			this.metroProgressBar2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroProgressBar2.Value = 57;
			// 
			// metroPanel1
			// 
			this.metroPanel1.Controls.Add(this.metroGrid1);
			this.metroPanel1.Controls.Add(this.metroLabel1);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 12;
			this.metroPanel1.Location = new System.Drawing.Point(1044, 183);
			this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(381, 375);
			this.metroPanel1.TabIndex = 2;
			this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 13;
			// 
			// metroGrid1
			// 
			this.metroGrid1.AllowUserToResizeRows = false;
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
			this.metroGrid1.Location = new System.Drawing.Point(4, 39);
			this.metroGrid1.Margin = new System.Windows.Forms.Padding(4);
			this.metroGrid1.Name = "metroGrid1";
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
			this.metroGrid1.Size = new System.Drawing.Size(373, 332);
			this.metroGrid1.TabIndex = 3;
			this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(4, 12);
			this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(153, 20);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "TABLA DE POSICIONES";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.BackgroundImage = global::TP4_TORNEOS.Properties.Resources.blurred;
			this.metroTabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.metroTabPage2.Controls.Add(this.metroTile1);
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 12;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 49);
			this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.metroTabPage2.Size = new System.Drawing.Size(1432, 606);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "EQUIPOS";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 13;
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.Location = new System.Drawing.Point(4, 4);
			this.metroTile1.Margin = new System.Windows.Forms.Padding(4);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(680, 175);
			this.metroTile1.TabIndex = 2;
			this.metroTile1.Text = "metroTile1";
			this.metroTile1.UseSelectable = true;
			this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
			// 
			// mtpJugadores
			// 
			this.mtpJugadores.BackgroundImage = global::TP4_TORNEOS.Properties.Resources.blurred;
			this.mtpJugadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.mtpJugadores.Controls.Add(this.label4);
			this.mtpJugadores.Controls.Add(this.label3);
			this.mtpJugadores.Controls.Add(this.label2);
			this.mtpJugadores.Controls.Add(this.label1);
			this.mtpJugadores.HorizontalScrollbarBarColor = true;
			this.mtpJugadores.HorizontalScrollbarHighlightOnWheel = false;
			this.mtpJugadores.HorizontalScrollbarSize = 10;
			this.mtpJugadores.Location = new System.Drawing.Point(4, 49);
			this.mtpJugadores.Name = "mtpJugadores";
			this.mtpJugadores.Size = new System.Drawing.Size(1432, 606);
			this.mtpJugadores.TabIndex = 2;
			this.mtpJugadores.Text = "JUGADORES";
			this.mtpJugadores.VerticalScrollbarBarColor = true;
			this.mtpJugadores.VerticalScrollbarHighlightOnWheel = false;
			this.mtpJugadores.VerticalScrollbarSize = 10;
			this.mtpJugadores.Click += new System.EventHandler(this.mtpJugadores_Click);
			// 
			// label4
			// 
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.label4.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label4.Location = new System.Drawing.Point(376, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 52);
			this.label4.TabIndex = 7;
			this.label4.Text = "BORRAR";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.label3.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label3.Location = new System.Drawing.Point(248, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 52);
			this.label3.TabIndex = 6;
			this.label3.Text = "LISTAR";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.label2.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label2.Location = new System.Drawing.Point(108, 0);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(145, 52);
			this.label2.TabIndex = 5;
			this.label2.Text = "MODIFICAR";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.UseCompatibleTextRendering = true;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			this.label2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.label1_PreviewKeyDown);
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.Image = global::TP4_TORNEOS.Properties.Resources.bgbutton_normal;
			this.label1.Location = new System.Drawing.Point(-9, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(131, 52);
			this.label1.TabIndex = 4;
			this.label1.Text = "CREAR";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.UseCompatibleTextRendering = true;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.label1_PreviewKeyDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::TP4_TORNEOS.Properties.Resources.banner;
			this.pictureBox1.Location = new System.Drawing.Point(989, 65);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(631, 123);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// PantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1800, 942);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PantallaPrincipal";
			this.Text = "PantallaPrincipal";
			this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.btJugador.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			this.metroPanel2.ResumeLayout(false);
			this.metroPanel2.PerformLayout();
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			this.metroTabPage2.ResumeLayout(false);
			this.mtpJugadores.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTabControl btJugador;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTabPage mtpJugadores;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}