namespace TP4_TORNEOS
{
	partial class fmCrearJug
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCrearJug));
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbNombre
			// 
			this.tbNombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbNombre.Location = new System.Drawing.Point(126, 61);
			this.tbNombre.Multiline = true;
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(375, 52);
			this.tbNombre.TabIndex = 0;
			this.tbNombre.Text = "Nombre:";
			this.tbNombre.Enter += new System.EventHandler(this.tbNombre_Enter);
			this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
			// 
			// fmCrearJug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 45F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImage = global::TP4_TORNEOS.Properties.Resources.blurred;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(622, 187);
			this.Controls.Add(this.tbNombre);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
			this.Name = "fmCrearJug";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "fmCrearJug";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.Blue;
			this.Load += new System.EventHandler(this.fmCrearJug_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbNombre;
	}
}