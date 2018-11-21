namespace XLight.Forms
{
	partial class EditarUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.LblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.visualSeparator1 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
			this.TextNombre = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
			this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.visualLabel2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.visualLabel3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.TextDNI = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
			this.TextDireccion = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
			this.visualLabel4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.TextApellidos = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
			this.visualLabel5 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.TextTelefono = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
			this.visualLabel6 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.DataFecha = new Bunifu.Framework.UI.BunifuDatepicker();
			this.visualSeparator2 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.BtnGuardarUsuario = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// LblTitulo
			// 
			this.LblTitulo.AutoSize = true;
			this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.LblTitulo.Location = new System.Drawing.Point(321, 18);
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Size = new System.Drawing.Size(141, 17);
			this.LblTitulo.TabIndex = 0;
			this.LblTitulo.Text = "Editando al usuario X";
			// 
			// visualSeparator1
			// 
			this.visualSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.visualSeparator1.Line = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
			this.visualSeparator1.Location = new System.Drawing.Point(21, 38);
			this.visualSeparator1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualSeparator1.Name = "visualSeparator1";
			this.visualSeparator1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualSeparator1.Shadow = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
			this.visualSeparator1.ShadowVisible = false;
			this.visualSeparator1.Size = new System.Drawing.Size(750, 4);
			this.visualSeparator1.TabIndex = 1;
			this.visualSeparator1.Text = "visualSeparator1";
			this.visualSeparator1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualSeparator1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualSeparator1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualSeparator1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualSeparator1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.visualSeparator1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualSeparator1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// TextNombre
			// 
			this.TextNombre.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.TextNombre.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TextNombre.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextNombre.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextNombre.Border.HoverVisible = true;
			this.TextNombre.Border.Rounding = 6;
			this.TextNombre.Border.Thickness = 1;
			this.TextNombre.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.TextNombre.Border.Visible = true;
			this.TextNombre.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextNombre.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextNombre.ButtonBorder.HoverVisible = true;
			this.TextNombre.ButtonBorder.Rounding = 6;
			this.TextNombre.ButtonBorder.Thickness = 1;
			this.TextNombre.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.TextNombre.ButtonBorder.Visible = true;
			this.TextNombre.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TextNombre.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.TextNombre.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TextNombre.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TextNombre.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextNombre.ButtonIndent = 3;
			this.TextNombre.ButtonText = "visualButton";
			this.TextNombre.ButtonVisible = false;
			this.TextNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextNombre.Image = null;
			this.TextNombre.ImageSize = new System.Drawing.Size(16, 16);
			this.TextNombre.ImageVisible = false;
			this.TextNombre.ImageWidth = 35;
			this.TextNombre.Location = new System.Drawing.Point(91, 49);
			this.TextNombre.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.TextNombre.Name = "TextNombre";
			this.TextNombre.PasswordChar = '\0';
			this.TextNombre.ReadOnly = false;
			this.TextNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TextNombre.Size = new System.Drawing.Size(160, 32);
			this.TextNombre.TabIndex = 3;
			this.TextNombre.TextBoxWidth = 150;
			this.TextNombre.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextNombre.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextNombre.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextNombre.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextNombre.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.TextNombre.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.TextNombre.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TextNombre.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.TextNombre.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextNombre.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.TextNombre.Watermark.Text = "Watermark text";
			this.TextNombre.Watermark.Visible = false;
			this.TextNombre.WordWrap = true;
			// 
			// visualLabel1
			// 
			this.visualLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.visualLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel1.Location = new System.Drawing.Point(10, 49);
			this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel1.Name = "visualLabel1";
			this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel1.Outline = false;
			this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel1.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel1.ReflectionSpacing = 0;
			this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel1.ShadowDirection = 315;
			this.visualLabel1.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel1.ShadowOpacity = 100;
			this.visualLabel1.Size = new System.Drawing.Size(75, 32);
			this.visualLabel1.TabIndex = 4;
			this.visualLabel1.Text = "Nombre";
			this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Near;
			this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// visualLabel2
			// 
			this.visualLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.visualLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel2.Location = new System.Drawing.Point(10, 87);
			this.visualLabel2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel2.Name = "visualLabel2";
			this.visualLabel2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel2.Outline = false;
			this.visualLabel2.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel2.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel2.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel2.ReflectionSpacing = 0;
			this.visualLabel2.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel2.ShadowDirection = 315;
			this.visualLabel2.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel2.ShadowOpacity = 100;
			this.visualLabel2.Size = new System.Drawing.Size(75, 32);
			this.visualLabel2.TabIndex = 5;
			this.visualLabel2.Text = "DNI";
			this.visualLabel2.TextAlignment = System.Drawing.StringAlignment.Near;
			this.visualLabel2.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel2.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel2.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel2.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// visualLabel3
			// 
			this.visualLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.visualLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel3.Location = new System.Drawing.Point(10, 125);
			this.visualLabel3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel3.Name = "visualLabel3";
			this.visualLabel3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel3.Outline = false;
			this.visualLabel3.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel3.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel3.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel3.ReflectionSpacing = 0;
			this.visualLabel3.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel3.ShadowDirection = 315;
			this.visualLabel3.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel3.ShadowOpacity = 100;
			this.visualLabel3.Size = new System.Drawing.Size(75, 32);
			this.visualLabel3.TabIndex = 6;
			this.visualLabel3.Text = "Dirección";
			this.visualLabel3.TextAlignment = System.Drawing.StringAlignment.Near;
			this.visualLabel3.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel3.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel3.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel3.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// TextDNI
			// 
			this.TextDNI.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.TextDNI.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TextDNI.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextDNI.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextDNI.Border.HoverVisible = true;
			this.TextDNI.Border.Rounding = 6;
			this.TextDNI.Border.Thickness = 1;
			this.TextDNI.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.TextDNI.Border.Visible = true;
			this.TextDNI.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextDNI.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextDNI.ButtonBorder.HoverVisible = true;
			this.TextDNI.ButtonBorder.Rounding = 6;
			this.TextDNI.ButtonBorder.Thickness = 1;
			this.TextDNI.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.TextDNI.ButtonBorder.Visible = true;
			this.TextDNI.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TextDNI.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.TextDNI.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TextDNI.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TextDNI.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextDNI.ButtonIndent = 3;
			this.TextDNI.ButtonText = "visualButton";
			this.TextDNI.ButtonVisible = false;
			this.TextDNI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextDNI.Image = null;
			this.TextDNI.ImageSize = new System.Drawing.Size(16, 16);
			this.TextDNI.ImageVisible = false;
			this.TextDNI.ImageWidth = 35;
			this.TextDNI.Location = new System.Drawing.Point(91, 87);
			this.TextDNI.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.TextDNI.Name = "TextDNI";
			this.TextDNI.PasswordChar = '\0';
			this.TextDNI.ReadOnly = false;
			this.TextDNI.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TextDNI.Size = new System.Drawing.Size(128, 32);
			this.TextDNI.TabIndex = 7;
			this.TextDNI.TextBoxWidth = 118;
			this.TextDNI.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextDNI.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextDNI.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextDNI.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextDNI.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.TextDNI.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.TextDNI.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TextDNI.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.TextDNI.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextDNI.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.TextDNI.Watermark.Text = "Watermark text";
			this.TextDNI.Watermark.Visible = false;
			this.TextDNI.WordWrap = true;
			// 
			// TextDireccion
			// 
			this.TextDireccion.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.TextDireccion.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TextDireccion.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextDireccion.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextDireccion.Border.HoverVisible = true;
			this.TextDireccion.Border.Rounding = 6;
			this.TextDireccion.Border.Thickness = 1;
			this.TextDireccion.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.TextDireccion.Border.Visible = true;
			this.TextDireccion.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextDireccion.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextDireccion.ButtonBorder.HoverVisible = true;
			this.TextDireccion.ButtonBorder.Rounding = 6;
			this.TextDireccion.ButtonBorder.Thickness = 1;
			this.TextDireccion.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.TextDireccion.ButtonBorder.Visible = true;
			this.TextDireccion.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TextDireccion.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.TextDireccion.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TextDireccion.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TextDireccion.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextDireccion.ButtonIndent = 3;
			this.TextDireccion.ButtonText = "visualButton";
			this.TextDireccion.ButtonVisible = false;
			this.TextDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextDireccion.Image = null;
			this.TextDireccion.ImageSize = new System.Drawing.Size(16, 16);
			this.TextDireccion.ImageVisible = false;
			this.TextDireccion.ImageWidth = 35;
			this.TextDireccion.Location = new System.Drawing.Point(91, 125);
			this.TextDireccion.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.TextDireccion.Name = "TextDireccion";
			this.TextDireccion.PasswordChar = '\0';
			this.TextDireccion.ReadOnly = false;
			this.TextDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TextDireccion.Size = new System.Drawing.Size(680, 32);
			this.TextDireccion.TabIndex = 8;
			this.TextDireccion.TextBoxWidth = 670;
			this.TextDireccion.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextDireccion.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextDireccion.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextDireccion.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextDireccion.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.TextDireccion.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.TextDireccion.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TextDireccion.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.TextDireccion.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextDireccion.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.TextDireccion.Watermark.Text = "Watermark text";
			this.TextDireccion.Watermark.Visible = false;
			this.TextDireccion.WordWrap = true;
			// 
			// visualLabel4
			// 
			this.visualLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.visualLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel4.Location = new System.Drawing.Point(269, 49);
			this.visualLabel4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel4.Name = "visualLabel4";
			this.visualLabel4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel4.Outline = false;
			this.visualLabel4.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel4.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel4.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel4.ReflectionSpacing = 0;
			this.visualLabel4.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel4.ShadowDirection = 315;
			this.visualLabel4.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel4.ShadowOpacity = 100;
			this.visualLabel4.Size = new System.Drawing.Size(75, 32);
			this.visualLabel4.TabIndex = 9;
			this.visualLabel4.Text = "Apellidos";
			this.visualLabel4.TextAlignment = System.Drawing.StringAlignment.Near;
			this.visualLabel4.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel4.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel4.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel4.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel4.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel4.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel4.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel4.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// TextApellidos
			// 
			this.TextApellidos.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.TextApellidos.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TextApellidos.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextApellidos.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextApellidos.Border.HoverVisible = true;
			this.TextApellidos.Border.Rounding = 6;
			this.TextApellidos.Border.Thickness = 1;
			this.TextApellidos.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.TextApellidos.Border.Visible = true;
			this.TextApellidos.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextApellidos.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextApellidos.ButtonBorder.HoverVisible = true;
			this.TextApellidos.ButtonBorder.Rounding = 6;
			this.TextApellidos.ButtonBorder.Thickness = 1;
			this.TextApellidos.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.TextApellidos.ButtonBorder.Visible = true;
			this.TextApellidos.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TextApellidos.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.TextApellidos.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TextApellidos.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TextApellidos.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextApellidos.ButtonIndent = 3;
			this.TextApellidos.ButtonText = "visualButton";
			this.TextApellidos.ButtonVisible = false;
			this.TextApellidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextApellidos.Image = null;
			this.TextApellidos.ImageSize = new System.Drawing.Size(16, 16);
			this.TextApellidos.ImageVisible = false;
			this.TextApellidos.ImageWidth = 35;
			this.TextApellidos.Location = new System.Drawing.Point(350, 49);
			this.TextApellidos.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.TextApellidos.Name = "TextApellidos";
			this.TextApellidos.PasswordChar = '\0';
			this.TextApellidos.ReadOnly = false;
			this.TextApellidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TextApellidos.Size = new System.Drawing.Size(421, 32);
			this.TextApellidos.TabIndex = 10;
			this.TextApellidos.TextBoxWidth = 411;
			this.TextApellidos.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextApellidos.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextApellidos.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextApellidos.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextApellidos.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.TextApellidos.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.TextApellidos.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TextApellidos.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.TextApellidos.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextApellidos.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.TextApellidos.Watermark.Text = "Watermark text";
			this.TextApellidos.Watermark.Visible = false;
			this.TextApellidos.WordWrap = true;
			// 
			// visualLabel5
			// 
			this.visualLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.visualLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel5.Location = new System.Drawing.Point(225, 87);
			this.visualLabel5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel5.Name = "visualLabel5";
			this.visualLabel5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel5.Outline = false;
			this.visualLabel5.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel5.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel5.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel5.ReflectionSpacing = 0;
			this.visualLabel5.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel5.ShadowDirection = 315;
			this.visualLabel5.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel5.ShadowOpacity = 100;
			this.visualLabel5.Size = new System.Drawing.Size(75, 32);
			this.visualLabel5.TabIndex = 11;
			this.visualLabel5.Text = "Telefono";
			this.visualLabel5.TextAlignment = System.Drawing.StringAlignment.Near;
			this.visualLabel5.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel5.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel5.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel5.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel5.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel5.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel5.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel5.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// TextTelefono
			// 
			this.TextTelefono.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.TextTelefono.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TextTelefono.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextTelefono.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextTelefono.Border.HoverVisible = true;
			this.TextTelefono.Border.Rounding = 6;
			this.TextTelefono.Border.Thickness = 1;
			this.TextTelefono.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.TextTelefono.Border.Visible = true;
			this.TextTelefono.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextTelefono.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextTelefono.ButtonBorder.HoverVisible = true;
			this.TextTelefono.ButtonBorder.Rounding = 6;
			this.TextTelefono.ButtonBorder.Thickness = 1;
			this.TextTelefono.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.TextTelefono.ButtonBorder.Visible = true;
			this.TextTelefono.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TextTelefono.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.TextTelefono.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.TextTelefono.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.TextTelefono.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextTelefono.ButtonIndent = 3;
			this.TextTelefono.ButtonText = "visualButton";
			this.TextTelefono.ButtonVisible = false;
			this.TextTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextTelefono.Image = null;
			this.TextTelefono.ImageSize = new System.Drawing.Size(16, 16);
			this.TextTelefono.ImageVisible = false;
			this.TextTelefono.ImageWidth = 35;
			this.TextTelefono.Location = new System.Drawing.Point(292, 87);
			this.TextTelefono.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.TextTelefono.Name = "TextTelefono";
			this.TextTelefono.PasswordChar = '\0';
			this.TextTelefono.ReadOnly = false;
			this.TextTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TextTelefono.Size = new System.Drawing.Size(170, 32);
			this.TextTelefono.TabIndex = 12;
			this.TextTelefono.TextBoxWidth = 160;
			this.TextTelefono.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextTelefono.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextTelefono.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextTelefono.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.TextTelefono.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.TextTelefono.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.TextTelefono.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TextTelefono.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.TextTelefono.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextTelefono.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.TextTelefono.Watermark.Text = "Watermark text";
			this.TextTelefono.Watermark.Visible = false;
			this.TextTelefono.WordWrap = true;
			// 
			// visualLabel6
			// 
			this.visualLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.visualLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel6.Location = new System.Drawing.Point(468, 87);
			this.visualLabel6.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel6.Name = "visualLabel6";
			this.visualLabel6.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel6.Outline = false;
			this.visualLabel6.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel6.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel6.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel6.ReflectionSpacing = 0;
			this.visualLabel6.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel6.ShadowDirection = 315;
			this.visualLabel6.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel6.ShadowOpacity = 100;
			this.visualLabel6.Size = new System.Drawing.Size(75, 32);
			this.visualLabel6.TabIndex = 13;
			this.visualLabel6.Text = "Fecha";
			this.visualLabel6.TextAlignment = System.Drawing.StringAlignment.Near;
			this.visualLabel6.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel6.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel6.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel6.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel6.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel6.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel6.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualLabel6.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// DataFecha
			// 
			this.DataFecha.BackColor = System.Drawing.SystemColors.Control;
			this.DataFecha.BorderRadius = 0;
			this.DataFecha.ForeColor = System.Drawing.Color.Black;
			this.DataFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.DataFecha.FormatCustom = null;
			this.DataFecha.Location = new System.Drawing.Point(523, 87);
			this.DataFecha.Name = "DataFecha";
			this.DataFecha.Size = new System.Drawing.Size(248, 32);
			this.DataFecha.TabIndex = 14;
			this.DataFecha.Value = new System.DateTime(2018, 11, 21, 14, 36, 28, 123);
			// 
			// visualSeparator2
			// 
			this.visualSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.visualSeparator2.Line = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
			this.visualSeparator2.Location = new System.Drawing.Point(19, 171);
			this.visualSeparator2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualSeparator2.Name = "visualSeparator2";
			this.visualSeparator2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualSeparator2.Shadow = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
			this.visualSeparator2.ShadowVisible = false;
			this.visualSeparator2.Size = new System.Drawing.Size(750, 4);
			this.visualSeparator2.TabIndex = 15;
			this.visualSeparator2.Text = "visualSeparator2";
			this.visualSeparator2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualSeparator2.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualSeparator2.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualSeparator2.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualSeparator2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.visualSeparator2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.visualSeparator2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(789, 35);
			this.panel1.TabIndex = 16;
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			// 
			// BtnGuardarUsuario
			// 
			this.BtnGuardarUsuario.BackColor = System.Drawing.SystemColors.Control;
			this.BtnGuardarUsuario.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnGuardarUsuario.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnGuardarUsuario.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnGuardarUsuario.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BtnGuardarUsuario.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnGuardarUsuario.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnGuardarUsuario.Border.HoverVisible = true;
			this.BtnGuardarUsuario.Border.Rounding = 6;
			this.BtnGuardarUsuario.Border.Thickness = 1;
			this.BtnGuardarUsuario.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.BtnGuardarUsuario.Border.Visible = true;
			this.BtnGuardarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.BtnGuardarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnGuardarUsuario.Image = null;
			this.BtnGuardarUsuario.Location = new System.Drawing.Point(310, 191);
			this.BtnGuardarUsuario.Margin = new System.Windows.Forms.Padding(0);
			this.BtnGuardarUsuario.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnGuardarUsuario.Name = "BtnGuardarUsuario";
			this.BtnGuardarUsuario.Size = new System.Drawing.Size(140, 45);
			this.BtnGuardarUsuario.TabIndex = 17;
			this.BtnGuardarUsuario.Text = "Guardar";
			this.BtnGuardarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnGuardarUsuario.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.BtnGuardarUsuario.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnGuardarUsuario.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnGuardarUsuario.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnGuardarUsuario.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.BtnGuardarUsuario.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.BtnGuardarUsuario.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnGuardarUsuario.Click += new System.EventHandler(this.BtnGuardarUsuario_Click);
			// 
			// EditarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 258);
			this.Controls.Add(this.BtnGuardarUsuario);
			this.Controls.Add(this.visualSeparator2);
			this.Controls.Add(this.DataFecha);
			this.Controls.Add(this.visualLabel6);
			this.Controls.Add(this.TextTelefono);
			this.Controls.Add(this.visualLabel5);
			this.Controls.Add(this.TextApellidos);
			this.Controls.Add(this.visualLabel4);
			this.Controls.Add(this.TextDireccion);
			this.Controls.Add(this.TextDNI);
			this.Controls.Add(this.visualLabel3);
			this.Controls.Add(this.visualLabel2);
			this.Controls.Add(this.visualLabel1);
			this.Controls.Add(this.TextNombre);
			this.Controls.Add(this.visualSeparator1);
			this.Controls.Add(this.LblTitulo);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditarUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EditarUsuario";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuCustomLabel LblTitulo;
		private VisualPlus.Toolkit.Controls.Layout.VisualSeparator visualSeparator1;
		private VisualPlus.Toolkit.Controls.Layout.VisualSeparator visualSeparator2;
		private Bunifu.Framework.UI.BunifuDatepicker DataFecha;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel6;
		private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TextTelefono;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel5;
		private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TextApellidos;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel4;
		private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TextDireccion;
		private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TextDNI;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel3;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel2;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
		private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TextNombre;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnGuardarUsuario;
	}
}