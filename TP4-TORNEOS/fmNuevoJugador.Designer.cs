namespace TP4_TORNEOS
{
	partial class fmNuevoJugador
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
            System.Windows.Forms.Label numeroCamisetaLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label urlImagenLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apodoLabel;
            this.mBtAceptar = new MetroFramework.Controls.MetroButton();
            this.mBtCancelar = new MetroFramework.Controls.MetroButton();
            this.numeroCamisetaTextBox = new System.Windows.Forms.TextBox();
            this.apodoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.urlImagenTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipoComboBox = new System.Windows.Forms.ComboBox();
            this.posicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posicionComboBox = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            numeroCamisetaLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            urlImagenLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apodoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroCamisetaLabel
            // 
            numeroCamisetaLabel.AutoSize = true;
            numeroCamisetaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            numeroCamisetaLabel.Location = new System.Drawing.Point(23, 147);
            numeroCamisetaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numeroCamisetaLabel.Name = "numeroCamisetaLabel";
            numeroCamisetaLabel.Size = new System.Drawing.Size(93, 13);
            numeroCamisetaLabel.TabIndex = 11;
            numeroCamisetaLabel.Text = "Numero Camiseta:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            apellidoLabel.Location = new System.Drawing.Point(23, 98);
            apellidoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Apellido:";
            // 
            // urlImagenLabel
            // 
            urlImagenLabel.AutoSize = true;
            urlImagenLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            urlImagenLabel.Location = new System.Drawing.Point(23, 170);
            urlImagenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            urlImagenLabel.Name = "urlImagenLabel";
            urlImagenLabel.Size = new System.Drawing.Size(61, 13);
            urlImagenLabel.TabIndex = 13;
            urlImagenLabel.Text = "Url Imagen:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nombreLabel.Location = new System.Drawing.Point(23, 75);
            nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // apodoLabel
            // 
            apodoLabel.AutoSize = true;
            apodoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            apodoLabel.Location = new System.Drawing.Point(23, 121);
            apodoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            apodoLabel.Name = "apodoLabel";
            apodoLabel.Size = new System.Drawing.Size(41, 13);
            apodoLabel.TabIndex = 5;
            apodoLabel.Text = "Apodo:";
            // 
            // mBtAceptar
            // 
            this.mBtAceptar.Location = new System.Drawing.Point(16, 371);
            this.mBtAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mBtAceptar.Name = "mBtAceptar";
            this.mBtAceptar.Size = new System.Drawing.Size(86, 26);
            this.mBtAceptar.TabIndex = 0;
            this.mBtAceptar.Text = "Aceptar";
            this.mBtAceptar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtAceptar.UseSelectable = true;
            this.mBtAceptar.Click += new System.EventHandler(this.mBtAceptar_Click);
            // 
            // mBtCancelar
            // 
            this.mBtCancelar.Location = new System.Drawing.Point(179, 371);
            this.mBtCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mBtCancelar.Name = "mBtCancelar";
            this.mBtCancelar.Size = new System.Drawing.Size(86, 26);
            this.mBtCancelar.TabIndex = 1;
            this.mBtCancelar.Text = "Cancelar";
            this.mBtCancelar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mBtCancelar.UseSelectable = true;
            this.mBtCancelar.Click += new System.EventHandler(this.mBtCancelar_Click);
            // 
            // numeroCamisetaTextBox
            // 
            this.numeroCamisetaTextBox.Location = new System.Drawing.Point(121, 144);
            this.numeroCamisetaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeroCamisetaTextBox.Name = "numeroCamisetaTextBox";
            this.numeroCamisetaTextBox.Size = new System.Drawing.Size(130, 20);
            this.numeroCamisetaTextBox.TabIndex = 12;
            // 
            // apodoTextBox
            // 
            this.apodoTextBox.Location = new System.Drawing.Point(121, 118);
            this.apodoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.apodoTextBox.Name = "apodoTextBox";
            this.apodoTextBox.Size = new System.Drawing.Size(130, 20);
            this.apodoTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(121, 71);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(130, 20);
            this.nombreTextBox.TabIndex = 10;
            // 
            // urlImagenTextBox
            // 
            this.urlImagenTextBox.Location = new System.Drawing.Point(121, 167);
            this.urlImagenTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.urlImagenTextBox.Name = "urlImagenTextBox";
            this.urlImagenTextBox.Size = new System.Drawing.Size(130, 20);
            this.urlImagenTextBox.TabIndex = 14;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(121, 96);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(130, 20);
            this.apellidoTextBox.TabIndex = 4;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Equipo);
            // 
            // equipoComboBox
            // 
            this.equipoComboBox.DataSource = this.equipoBindingSource;
            this.equipoComboBox.DisplayMember = "Nombre";
            this.equipoComboBox.FormattingEnabled = true;
            this.equipoComboBox.Location = new System.Drawing.Point(25, 240);
            this.equipoComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.equipoComboBox.Name = "equipoComboBox";
            this.equipoComboBox.Size = new System.Drawing.Size(226, 21);
            this.equipoComboBox.TabIndex = 14;
            this.equipoComboBox.ValueMember = "Id";
            this.equipoComboBox.SelectionChangeCommitted += new System.EventHandler(this.equipoComboBox_SelectionChangeCommitted);
            // 
            // posicionBindingSource
            // 
            this.posicionBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Posicion);
            // 
            // posicionComboBox
            // 
            this.posicionComboBox.DataSource = this.posicionBindingSource;
            this.posicionComboBox.DisplayMember = "Nombre";
            this.posicionComboBox.FormattingEnabled = true;
            this.posicionComboBox.Location = new System.Drawing.Point(25, 302);
            this.posicionComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.posicionComboBox.Name = "posicionComboBox";
            this.posicionComboBox.Size = new System.Drawing.Size(226, 21);
            this.posicionComboBox.TabIndex = 15;
            this.posicionComboBox.ValueMember = "Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 274);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Posicion: ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 210);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "Equipo: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // fmNuevoJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 429);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.posicionComboBox);
            this.Controls.Add(this.equipoComboBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(apodoLabel);
            this.Controls.Add(this.apodoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(numeroCamisetaLabel);
            this.Controls.Add(this.numeroCamisetaTextBox);
            this.Controls.Add(urlImagenLabel);
            this.Controls.Add(this.urlImagenTextBox);
            this.Controls.Add(this.mBtCancelar);
            this.Controls.Add(this.mBtAceptar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fmNuevoJugador";
            this.Padding = new System.Windows.Forms.Padding(1, 24, 1, 1);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Crear Jugador";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fmNuevoJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton mBtAceptar;
		private MetroFramework.Controls.MetroButton mBtCancelar;
		private System.Windows.Forms.TextBox numeroCamisetaTextBox;
		private System.Windows.Forms.TextBox apodoTextBox;
		private System.Windows.Forms.TextBox nombreTextBox;
		private System.Windows.Forms.TextBox urlImagenTextBox;
		private System.Windows.Forms.TextBox apellidoTextBox;
		private System.Windows.Forms.BindingSource equipoBindingSource;
		private System.Windows.Forms.ComboBox equipoComboBox;
		private System.Windows.Forms.BindingSource posicionBindingSource;
		private System.Windows.Forms.ComboBox posicionComboBox;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}