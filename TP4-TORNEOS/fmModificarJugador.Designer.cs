namespace TP4_TORNEOS
{
	partial class fmModificarJugador
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
			System.Windows.Forms.Label apellidoLabel;
			System.Windows.Forms.Label apodoLabel;
			System.Windows.Forms.Label nombreLabel;
			System.Windows.Forms.Label numeroCamisetaLabel;
			System.Windows.Forms.Label urlImagenLabel;
			this.mBtCancelar = new MetroFramework.Controls.MetroButton();
			this.mBtAceptar = new MetroFramework.Controls.MetroButton();
			this.apellidoTextBox = new System.Windows.Forms.TextBox();
			this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.apodoTextBox = new System.Windows.Forms.TextBox();
			this.nombreTextBox = new System.Windows.Forms.TextBox();
			this.numeroCamisetaTextBox = new System.Windows.Forms.TextBox();
			this.urlImagenTextBox = new System.Windows.Forms.TextBox();
			this.posicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.posicionComboBox = new System.Windows.Forms.ComboBox();
			this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.equipoComboBox = new System.Windows.Forms.ComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			apellidoLabel = new System.Windows.Forms.Label();
			apodoLabel = new System.Windows.Forms.Label();
			nombreLabel = new System.Windows.Forms.Label();
			numeroCamisetaLabel = new System.Windows.Forms.Label();
			urlImagenLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.posicionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// apellidoLabel
			// 
			apellidoLabel.AutoSize = true;
			apellidoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			apellidoLabel.Location = new System.Drawing.Point(306, 112);
			apellidoLabel.Name = "apellidoLabel";
			apellidoLabel.Size = new System.Drawing.Size(62, 17);
			apellidoLabel.TabIndex = 32;
			apellidoLabel.Text = "Apellido:";
			// 
			// apodoLabel
			// 
			apodoLabel.AutoSize = true;
			apodoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			apodoLabel.Location = new System.Drawing.Point(306, 140);
			apodoLabel.Name = "apodoLabel";
			apodoLabel.Size = new System.Drawing.Size(53, 17);
			apodoLabel.TabIndex = 34;
			apodoLabel.Text = "Apodo:";
			// 
			// nombreLabel
			// 
			nombreLabel.AutoSize = true;
			nombreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			nombreLabel.Location = new System.Drawing.Point(306, 85);
			nombreLabel.Name = "nombreLabel";
			nombreLabel.Size = new System.Drawing.Size(62, 17);
			nombreLabel.TabIndex = 38;
			nombreLabel.Text = "Nombre:";
			// 
			// numeroCamisetaLabel
			// 
			numeroCamisetaLabel.AutoSize = true;
			numeroCamisetaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			numeroCamisetaLabel.Location = new System.Drawing.Point(306, 169);
			numeroCamisetaLabel.Name = "numeroCamisetaLabel";
			numeroCamisetaLabel.Size = new System.Drawing.Size(124, 17);
			numeroCamisetaLabel.TabIndex = 40;
			numeroCamisetaLabel.Text = "Numero Camiseta:";
			// 
			// urlImagenLabel
			// 
			urlImagenLabel.AutoSize = true;
			urlImagenLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			urlImagenLabel.Location = new System.Drawing.Point(306, 197);
			urlImagenLabel.Name = "urlImagenLabel";
			urlImagenLabel.Size = new System.Drawing.Size(80, 17);
			urlImagenLabel.TabIndex = 42;
			urlImagenLabel.Text = "Url Imagen:";
			// 
			// mBtCancelar
			// 
			this.mBtCancelar.Location = new System.Drawing.Point(490, 452);
			this.mBtCancelar.Name = "mBtCancelar";
			this.mBtCancelar.Size = new System.Drawing.Size(114, 32);
			this.mBtCancelar.TabIndex = 31;
			this.mBtCancelar.Text = "Cancelar";
			this.mBtCancelar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mBtCancelar.UseSelectable = true;
			this.mBtCancelar.Click += new System.EventHandler(this.mBtCancelar_Click);
			// 
			// mBtAceptar
			// 
			this.mBtAceptar.Location = new System.Drawing.Point(175, 452);
			this.mBtAceptar.Name = "mBtAceptar";
			this.mBtAceptar.Size = new System.Drawing.Size(114, 32);
			this.mBtAceptar.TabIndex = 30;
			this.mBtAceptar.Text = "Aceptar";
			this.mBtAceptar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mBtAceptar.UseSelectable = true;
			this.mBtAceptar.Click += new System.EventHandler(this.mBtAceptar_Click);
			// 
			// apellidoTextBox
			// 
			this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "Apellido", true));
			this.apellidoTextBox.Location = new System.Drawing.Point(436, 109);
			this.apellidoTextBox.Name = "apellidoTextBox";
			this.apellidoTextBox.Size = new System.Drawing.Size(100, 22);
			this.apellidoTextBox.TabIndex = 33;
			// 
			// jugadorBindingSource
			// 
			this.jugadorBindingSource.DataSource = typeof(TP4_TORNEOS.Entidades.Jugador);
			// 
			// apodoTextBox
			// 
			this.apodoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "Apodo", true));
			this.apodoTextBox.Location = new System.Drawing.Point(436, 137);
			this.apodoTextBox.Name = "apodoTextBox";
			this.apodoTextBox.Size = new System.Drawing.Size(100, 22);
			this.apodoTextBox.TabIndex = 35;
			// 
			// nombreTextBox
			// 
			this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "Nombre", true));
			this.nombreTextBox.Location = new System.Drawing.Point(436, 82);
			this.nombreTextBox.Name = "nombreTextBox";
			this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
			this.nombreTextBox.TabIndex = 39;
			// 
			// numeroCamisetaTextBox
			// 
			this.numeroCamisetaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "NumeroCamiseta", true));
			this.numeroCamisetaTextBox.Location = new System.Drawing.Point(436, 166);
			this.numeroCamisetaTextBox.Name = "numeroCamisetaTextBox";
			this.numeroCamisetaTextBox.Size = new System.Drawing.Size(100, 22);
			this.numeroCamisetaTextBox.TabIndex = 41;
			// 
			// urlImagenTextBox
			// 
			this.urlImagenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "UrlImagen", true));
			this.urlImagenTextBox.Location = new System.Drawing.Point(436, 194);
			this.urlImagenTextBox.Name = "urlImagenTextBox";
			this.urlImagenTextBox.Size = new System.Drawing.Size(100, 22);
			this.urlImagenTextBox.TabIndex = 43;
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
			this.posicionComboBox.Location = new System.Drawing.Point(309, 352);
			this.posicionComboBox.Name = "posicionComboBox";
			this.posicionComboBox.Size = new System.Drawing.Size(300, 24);
			this.posicionComboBox.TabIndex = 43;
			this.posicionComboBox.ValueMember = "Id";
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
			this.equipoComboBox.Location = new System.Drawing.Point(309, 278);
			this.equipoComboBox.Name = "equipoComboBox";
			this.equipoComboBox.Size = new System.Drawing.Size(300, 24);
			this.equipoComboBox.TabIndex = 43;
			this.equipoComboBox.ValueMember = "GolesContra";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(309, 242);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(59, 20);
			this.metroLabel1.TabIndex = 44;
			this.metroLabel1.Text = "Equipo: ";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(309, 317);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(66, 20);
			this.metroLabel2.TabIndex = 45;
			this.metroLabel2.Text = "Posicion: ";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// fmModificarJugador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 555);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.equipoComboBox);
			this.Controls.Add(this.posicionComboBox);
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
			this.Name = "fmModificarJugador";
			this.Style = MetroFramework.MetroColorStyle.Teal;
			this.Text = "Modificar Jugador";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.posicionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroButton mBtCancelar;
		private MetroFramework.Controls.MetroButton mBtAceptar;
		private System.Windows.Forms.BindingSource jugadorBindingSource;
		private System.Windows.Forms.TextBox apellidoTextBox;
		private System.Windows.Forms.TextBox apodoTextBox;
		private System.Windows.Forms.TextBox nombreTextBox;
		private System.Windows.Forms.TextBox numeroCamisetaTextBox;
		private System.Windows.Forms.TextBox urlImagenTextBox;
		private System.Windows.Forms.BindingSource posicionBindingSource;
		private System.Windows.Forms.ComboBox posicionComboBox;
		private System.Windows.Forms.BindingSource equipoBindingSource;
		private System.Windows.Forms.ComboBox equipoComboBox;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
	}
}