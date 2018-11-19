namespace TP4_TORNEOS
{
	partial class fmEliminarJugador
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
			this.mBtCancelar = new MetroFramework.Controls.MetroButton();
			this.mBtAceptar = new MetroFramework.Controls.MetroButton();
			this.mTbConfirmar = new MetroFramework.Controls.MetroTextBox();
			this.SuspendLayout();
			// 
			// mBtCancelar
			// 
			this.mBtCancelar.Location = new System.Drawing.Point(341, 183);
			this.mBtCancelar.Name = "mBtCancelar";
			this.mBtCancelar.Size = new System.Drawing.Size(114, 32);
			this.mBtCancelar.TabIndex = 19;
			this.mBtCancelar.Text = "Cancelar";
			this.mBtCancelar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mBtCancelar.UseSelectable = true;
			// 
			// mBtAceptar
			// 
			this.mBtAceptar.Location = new System.Drawing.Point(135, 183);
			this.mBtAceptar.Name = "mBtAceptar";
			this.mBtAceptar.Size = new System.Drawing.Size(114, 32);
			this.mBtAceptar.TabIndex = 18;
			this.mBtAceptar.Text = "Aceptar";
			this.mBtAceptar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mBtAceptar.UseSelectable = true;
			// 
			// mTbConfirmar
			// 
			this.mTbConfirmar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mTbConfirmar.Lines = new string[] {
        "¿Está seguro que desea borrar el jugador?"};
			this.mTbConfirmar.Location = new System.Drawing.Point(100, 80);
			this.mTbConfirmar.MaxLength = 32767;
			this.mTbConfirmar.Multiline = true;
			this.mTbConfirmar.Name = "mTbConfirmar";
			this.mTbConfirmar.PasswordChar = '\0';
			this.mTbConfirmar.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mTbConfirmar.SelectedText = "";
			this.mTbConfirmar.Size = new System.Drawing.Size(376, 38);
			this.mTbConfirmar.TabIndex = 20;
			this.mTbConfirmar.Text = "¿Está seguro que desea borrar el jugador?";
			this.mTbConfirmar.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.mTbConfirmar.UseSelectable = true;
			// 
			// fmEliminarJugador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 281);
			this.Controls.Add(this.mTbConfirmar);
			this.Controls.Add(this.mBtCancelar);
			this.Controls.Add(this.mBtAceptar);
			this.Name = "fmEliminarJugador";
			this.Style = MetroFramework.MetroColorStyle.Teal;
			this.Text = "fmEliminarJugador";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton mBtCancelar;
		private MetroFramework.Controls.MetroButton mBtAceptar;
		private MetroFramework.Controls.MetroTextBox mTbConfirmar;
	}
}