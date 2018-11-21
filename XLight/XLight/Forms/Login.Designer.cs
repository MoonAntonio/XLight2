namespace XLight.Forms
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
			this.BtnLogin = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
			this.InputName = new Bunifu.Framework.UI.BunifuTextbox();
			this.InputPassword = new Bunifu.Framework.UI.BunifuTextbox();
			this.LblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuGradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.bunifuGradientPanel3.SuspendLayout();
			this.bunifuGradientPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 50;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuGradientPanel1
			// 
			this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
			this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
			this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel3);
			this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel2);
			this.bunifuGradientPanel1.Controls.Add(this.InputName);
			this.bunifuGradientPanel1.Controls.Add(this.InputPassword);
			this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(104)))));
			this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(156)))));
			this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(156)))));
			this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(104)))));
			this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
			this.bunifuGradientPanel1.Quality = 10;
			this.bunifuGradientPanel1.Size = new System.Drawing.Size(375, 495);
			this.bunifuGradientPanel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::XLight.Properties.Resources.Icono;
			this.pictureBox1.Location = new System.Drawing.Point(74, 68);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(237, 218);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// bunifuGradientPanel3
			// 
			this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
			this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuGradientPanel3.Controls.Add(this.BtnLogin);
			this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
			this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(166)))), ((int)(((byte)(245)))));
			this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(254)))));
			this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(206)))), ((int)(((byte)(234)))));
			this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 422);
			this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
			this.bunifuGradientPanel3.Quality = 10;
			this.bunifuGradientPanel3.Size = new System.Drawing.Size(375, 73);
			this.bunifuGradientPanel3.TabIndex = 3;
			// 
			// BtnLogin
			// 
			this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
			this.BtnLogin.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnLogin.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.BtnLogin.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.BtnLogin.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(204)))));
			this.BtnLogin.Border.Color = System.Drawing.Color.White;
			this.BtnLogin.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnLogin.Border.HoverVisible = true;
			this.BtnLogin.Border.Rounding = 6;
			this.BtnLogin.Border.Thickness = 1;
			this.BtnLogin.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.BtnLogin.Border.Visible = true;
			this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
			this.BtnLogin.ForeColor = System.Drawing.Color.White;
			this.BtnLogin.Image = global::XLight.Properties.Resources.Login_50px;
			this.BtnLogin.Location = new System.Drawing.Point(74, 7);
			this.BtnLogin.Margin = new System.Windows.Forms.Padding(31);
			this.BtnLogin.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(223, 59);
			this.BtnLogin.TabIndex = 5;
			this.BtnLogin.Text = "          Conectar";
			this.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnLogin.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.BtnLogin.TextStyle.Enabled = System.Drawing.Color.White;
			this.BtnLogin.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnLogin.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnLogin.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.BtnLogin.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.BtnLogin.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// bunifuGradientPanel2
			// 
			this.bunifuGradientPanel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
			this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuGradientPanel2.Controls.Add(this.LblTitulo);
			this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
			this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(166)))), ((int)(((byte)(245)))));
			this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(135)))), ((int)(((byte)(254)))));
			this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(206)))), ((int)(((byte)(234)))));
			this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
			this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
			this.bunifuGradientPanel2.Quality = 10;
			this.bunifuGradientPanel2.Size = new System.Drawing.Size(375, 59);
			this.bunifuGradientPanel2.TabIndex = 2;
			// 
			// InputName
			// 
			this.InputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.InputName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InputName.BackgroundImage")));
			this.InputName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.InputName.ForeColor = System.Drawing.Color.White;
			this.InputName.Icon = ((System.Drawing.Image)(resources.GetObject("InputName.Icon")));
			this.InputName.Location = new System.Drawing.Point(35, 292);
			this.InputName.Name = "InputName";
			this.InputName.Size = new System.Drawing.Size(310, 56);
			this.InputName.TabIndex = 0;
			this.InputName.text = "Nombre";
			this.InputName.Click += new System.EventHandler(this.InputName_Click);
			// 
			// InputPassword
			// 
			this.InputPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.InputPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InputPassword.BackgroundImage")));
			this.InputPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.InputPassword.ForeColor = System.Drawing.Color.White;
			this.InputPassword.Icon = ((System.Drawing.Image)(resources.GetObject("InputPassword.Icon")));
			this.InputPassword.Location = new System.Drawing.Point(35, 354);
			this.InputPassword.Name = "InputPassword";
			this.InputPassword.Size = new System.Drawing.Size(310, 58);
			this.InputPassword.TabIndex = 1;
			this.InputPassword.text = "Password";
			this.InputPassword.Click += new System.EventHandler(this.InputPassword_Click);
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
			this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
			this.LblTitulo.ForeColor = System.Drawing.Color.White;
			this.LblTitulo.Location = new System.Drawing.Point(142, 18);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(100, 30);
			this.LblTitulo.TabIndex = 0;
			this.LblTitulo.Text = "Conectar";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 495);
			this.Controls.Add(this.bunifuGradientPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.bunifuGradientPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.bunifuGradientPanel3.ResumeLayout(false);
			this.bunifuGradientPanel2.ResumeLayout(false);
			this.bunifuGradientPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuTextbox InputName;
		private Bunifu.Framework.UI.BunifuTextbox InputPassword;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
		private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
		private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnLogin;
		private Bunifu.Framework.UI.BunifuCustomLabel LblTitulo;
	}
}