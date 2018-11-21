namespace XLight.Forms
{
	partial class Splash
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.progressBarBorde = new Bunifu.Framework.UI.BunifuProgressBar();
			this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.lblVersion = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.lblSeguimiento = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.Temporizador = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 20;
			this.bunifuElipse1.TargetControl = this;
			// 
			// progressBarBorde
			// 
			this.progressBarBorde.BackColor = System.Drawing.Color.White;
			this.progressBarBorde.BorderRadius = 25;
			this.progressBarBorde.Location = new System.Drawing.Point(4, 133);
			this.progressBarBorde.MaximumValue = 100;
			this.progressBarBorde.Name = "progressBarBorde";
			this.progressBarBorde.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
			this.progressBarBorde.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
			this.progressBarBorde.Size = new System.Drawing.Size(730, 47);
			this.progressBarBorde.TabIndex = 1;
			this.progressBarBorde.Value = 0;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50.25F);
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(60, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(237, 77);
			this.lblTitulo.TabIndex = 2;
			this.lblTitulo.Text = "XLight";
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
			this.lblVersion.ForeColor = System.Drawing.Color.White;
			this.lblVersion.Location = new System.Drawing.Point(292, 38);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(97, 24);
			this.lblVersion.TabIndex = 3;
			this.lblVersion.Text = "ver 1.0.0";
			// 
			// lblSeguimiento
			// 
			this.lblSeguimiento.AutoSize = true;
			this.lblSeguimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
			this.lblSeguimiento.ForeColor = System.Drawing.Color.White;
			this.lblSeguimiento.Location = new System.Drawing.Point(69, 86);
			this.lblSeguimiento.Name = "lblSeguimiento";
			this.lblSeguimiento.Size = new System.Drawing.Size(249, 24);
			this.lblSeguimiento.TabIndex = 4;
			this.lblSeguimiento.Text = "Inicializando sistema ...";
			// 
			// Temporizador
			// 
			this.Temporizador.Enabled = true;
			this.Temporizador.Interval = 3;
			this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::XLight.Properties.Resources.Kodi_100px;
			this.pictureBox1.Location = new System.Drawing.Point(508, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(218, 118);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// Splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(738, 192);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblSeguimiento);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.progressBarBorde);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Splash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuCustomLabel lblSeguimiento;
		private Bunifu.Framework.UI.BunifuCustomLabel lblVersion;
		private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
		private Bunifu.Framework.UI.BunifuProgressBar progressBarBorde;
		private System.Windows.Forms.Timer Temporizador;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}