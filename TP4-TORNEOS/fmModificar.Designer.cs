namespace TP4_TORNEOS
{
	partial class fmModificar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmModificar));
			this.SuspendLayout();
			// 
			// fmModificar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 45F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImage = global::TP4_TORNEOS.Properties.Resources.blurred;
			this.ClientSize = new System.Drawing.Size(622, 187);
			this.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
			this.Name = "fmModificar";
			this.Opacity = 0.5D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "fmModificar";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fmModificar_KeyPress);
			this.ResumeLayout(false);

		}

		#endregion
	}
}