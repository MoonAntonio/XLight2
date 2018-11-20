namespace XLight
{
	partial class MenuGeneral
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			BunifuAnimatorNS.Animation animation14 = new BunifuAnimatorNS.Animation();
			BunifuAnimatorNS.Animation animation13 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGeneral));
			BunifuAnimatorNS.Animation animation15 = new BunifuAnimatorNS.Animation();
			this.buniElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panelControl = new System.Windows.Forms.Panel();
			this.separadorInferior = new Bunifu.Framework.UI.BunifuSeparator();
			this.separadorSuperior = new Bunifu.Framework.UI.BunifuSeparator();
			this.header = new System.Windows.Forms.Panel();
			this.lblSuperior = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.controlDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.btnSalir = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.btnCambiarUsuario = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.btnOpciones = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.btnHistorial = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.btnBalance = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.btnClientes = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.btnInicio = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.imgLogoAmpliado = new System.Windows.Forms.PictureBox();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnSlider = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
			this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.panelControlAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.panelControlAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.panelControl.SuspendLayout();
			this.header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgLogoAmpliado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
			this.SuspendLayout();
			// 
			// buniElipse
			// 
			this.buniElipse.ElipseRadius = 5;
			this.buniElipse.TargetControl = this;
			// 
			// panelControl
			// 
			this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.panelControl.Controls.Add(this.btnSalir);
			this.panelControl.Controls.Add(this.btnCambiarUsuario);
			this.panelControl.Controls.Add(this.separadorInferior);
			this.panelControl.Controls.Add(this.btnOpciones);
			this.panelControl.Controls.Add(this.btnHistorial);
			this.panelControl.Controls.Add(this.btnBalance);
			this.panelControl.Controls.Add(this.btnClientes);
			this.panelControl.Controls.Add(this.separadorSuperior);
			this.panelControl.Controls.Add(this.btnInicio);
			this.panelControl.Controls.Add(this.imgLogoAmpliado);
			this.logoAnimator.SetDecoration(this.panelControl, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.panelControl, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.panelControl, BunifuAnimatorNS.DecorationType.None);
			this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelControl.Location = new System.Drawing.Point(0, 53);
			this.panelControl.Name = "panelControl";
			this.panelControl.Size = new System.Drawing.Size(256, 597);
			this.panelControl.TabIndex = 0;
			// 
			// separadorInferior
			// 
			this.separadorInferior.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.separadorInferior.BackColor = System.Drawing.Color.Transparent;
			this.logoAnimator.SetDecoration(this.separadorInferior, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.separadorInferior, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.separadorInferior, BunifuAnimatorNS.DecorationType.None);
			this.separadorInferior.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
			this.separadorInferior.LineThickness = 1;
			this.separadorInferior.Location = new System.Drawing.Point(12, 492);
			this.separadorInferior.Name = "separadorInferior";
			this.separadorInferior.Size = new System.Drawing.Size(228, 35);
			this.separadorInferior.TabIndex = 8;
			this.separadorInferior.Transparency = 255;
			this.separadorInferior.Vertical = false;
			// 
			// separadorSuperior
			// 
			this.separadorSuperior.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.separadorSuperior.BackColor = System.Drawing.Color.Transparent;
			this.logoAnimator.SetDecoration(this.separadorSuperior, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.separadorSuperior, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.separadorSuperior, BunifuAnimatorNS.DecorationType.None);
			this.separadorSuperior.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
			this.separadorSuperior.LineThickness = 1;
			this.separadorSuperior.Location = new System.Drawing.Point(12, 110);
			this.separadorSuperior.Name = "separadorSuperior";
			this.separadorSuperior.Size = new System.Drawing.Size(228, 35);
			this.separadorSuperior.TabIndex = 3;
			this.separadorSuperior.Transparency = 255;
			this.separadorSuperior.Vertical = false;
			// 
			// header
			// 
			this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.header.Controls.Add(this.bunifuImageButton1);
			this.header.Controls.Add(this.btnSlider);
			this.header.Controls.Add(this.btnMaximizar);
			this.header.Controls.Add(this.lblSuperior);
			this.logoAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
			this.header.Dock = System.Windows.Forms.DockStyle.Top;
			this.header.Location = new System.Drawing.Point(0, 0);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(1188, 53);
			this.header.TabIndex = 1;
			// 
			// lblSuperior
			// 
			this.lblSuperior.AutoSize = true;
			this.panelControlAnimator2.SetDecoration(this.lblSuperior, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.lblSuperior, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.lblSuperior, BunifuAnimatorNS.DecorationType.None);
			this.lblSuperior.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSuperior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
			this.lblSuperior.Location = new System.Drawing.Point(79, 17);
			this.lblSuperior.Name = "lblSuperior";
			this.lblSuperior.Size = new System.Drawing.Size(57, 21);
			this.lblSuperior.TabIndex = 0;
			this.lblSuperior.Text = "XLight";
			// 
			// controlDrag
			// 
			this.controlDrag.Fixed = true;
			this.controlDrag.Horizontal = true;
			this.controlDrag.TargetControl = this.header;
			this.controlDrag.Vertical = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalir.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSalir.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnSalir.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.btnSalir.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(204)))));
			this.btnSalir.Border.Color = System.Drawing.Color.White;
			this.btnSalir.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.btnSalir.Border.HoverVisible = true;
			this.btnSalir.Border.Rounding = 6;
			this.btnSalir.Border.Thickness = 1;
			this.btnSalir.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.btnSalir.Border.Visible = true;
			this.panelControlAnimator.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Image = global::XLight.Properties.Resources.Shutdown_50px;
			this.btnSalir.Location = new System.Drawing.Point(12, 441);
			this.btnSalir.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(228, 52);
			this.btnSalir.TabIndex = 10;
			this.btnSalir.Text = "               Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.btnSalir.TextStyle.Enabled = System.Drawing.Color.White;
			this.btnSalir.TextStyle.Hover = System.Drawing.Color.White;
			this.btnSalir.TextStyle.Pressed = System.Drawing.Color.White;
			this.btnSalir.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btnSalir.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.btnSalir.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnCambiarUsuario
			// 
			this.btnCambiarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCambiarUsuario.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCambiarUsuario.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnCambiarUsuario.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.btnCambiarUsuario.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(204)))));
			this.btnCambiarUsuario.Border.Color = System.Drawing.Color.White;
			this.btnCambiarUsuario.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.btnCambiarUsuario.Border.HoverVisible = true;
			this.btnCambiarUsuario.Border.Rounding = 6;
			this.btnCambiarUsuario.Border.Thickness = 1;
			this.btnCambiarUsuario.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.btnCambiarUsuario.Border.Visible = true;
			this.panelControlAnimator.SetDecoration(this.btnCambiarUsuario, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.btnCambiarUsuario, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.btnCambiarUsuario, BunifuAnimatorNS.DecorationType.None);
			this.btnCambiarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCambiarUsuario.ForeColor = System.Drawing.Color.White;
			this.btnCambiarUsuario.Image = global::XLight.Properties.Resources.Console_50px;
			this.btnCambiarUsuario.Location = new System.Drawing.Point(12, 533);
			this.btnCambiarUsuario.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.btnCambiarUsuario.Name = "btnCambiarUsuario";
			this.btnCambiarUsuario.Size = new System.Drawing.Size(228, 52);
			this.btnCambiarUsuario.TabIndex = 9;
			this.btnCambiarUsuario.Text = "      Cambiar Usuario";
			this.btnCambiarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCambiarUsuario.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.btnCambiarUsuario.TextStyle.Enabled = System.Drawing.Color.White;
			this.btnCambiarUsuario.TextStyle.Hover = System.Drawing.Color.White;
			this.btnCambiarUsuario.TextStyle.Pressed = System.Drawing.Color.White;
			this.btnCambiarUsuario.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btnCambiarUsuario.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.btnCambiarUsuario.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
			// 
			// btnOpciones
			// 
			this.btnOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpciones.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnOpciones.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnOpciones.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.btnOpciones.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(204)))));
			this.btnOpciones.Border.Color = System.Drawing.Color.White;
			this.btnOpciones.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.btnOpciones.Border.HoverVisible = true;
			this.btnOpciones.Border.Rounding = 6;
			this.btnOpciones.Border.Thickness = 1;
			this.btnOpciones.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.btnOpciones.Border.Visible = true;
			this.panelControlAnimator.SetDecoration(this.btnOpciones, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.btnOpciones, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.btnOpciones, BunifuAnimatorNS.DecorationType.None);
			this.btnOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpciones.ForeColor = System.Drawing.Color.White;
			this.btnOpciones.Image = global::XLight.Properties.Resources.Slider__50px;
			this.btnOpciones.Location = new System.Drawing.Point(12, 383);
			this.btnOpciones.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.btnOpciones.Name = "btnOpciones";
			this.btnOpciones.Size = new System.Drawing.Size(228, 52);
			this.btnOpciones.TabIndex = 7;
			this.btnOpciones.Text = "           Opciones";
			this.btnOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOpciones.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.btnOpciones.TextStyle.Enabled = System.Drawing.Color.White;
			this.btnOpciones.TextStyle.Hover = System.Drawing.Color.White;
			this.btnOpciones.TextStyle.Pressed = System.Drawing.Color.White;
			this.btnOpciones.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btnOpciones.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.btnOpciones.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
			// 
			// btnHistorial
			// 
			this.btnHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHistorial.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnHistorial.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnHistorial.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.btnHistorial.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(204)))));
			this.btnHistorial.Border.Color = System.Drawing.Color.White;
			this.btnHistorial.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.btnHistorial.Border.HoverVisible = true;
			this.btnHistorial.Border.Rounding = 6;
			this.btnHistorial.Border.Thickness = 1;
			this.btnHistorial.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.btnHistorial.Border.Visible = true;
			this.panelControlAnimator.SetDecoration(this.btnHistorial, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.btnHistorial, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.btnHistorial, BunifuAnimatorNS.DecorationType.None);
			this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHistorial.ForeColor = System.Drawing.Color.White;
			this.btnHistorial.Image = global::XLight.Properties.Resources.Heart_with_Pulse_50px;
			this.btnHistorial.Location = new System.Drawing.Point(12, 325);
			this.btnHistorial.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.btnHistorial.Name = "btnHistorial";
			this.btnHistorial.Size = new System.Drawing.Size(228, 52);
			this.btnHistorial.TabIndex = 6;
			this.btnHistorial.Text = "            Historial";
			this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHistorial.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.btnHistorial.TextStyle.Enabled = System.Drawing.Color.White;
			this.btnHistorial.TextStyle.Hover = System.Drawing.Color.White;
			this.btnHistorial.TextStyle.Pressed = System.Drawing.Color.White;
			this.btnHistorial.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btnHistorial.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.btnHistorial.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
			// 
			// btnBalance
			// 
			this.btnBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBalance.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnBalance.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnBalance.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.btnBalance.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(204)))));
			this.btnBalance.Border.Color = System.Drawing.Color.White;
			this.btnBalance.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.btnBalance.Border.HoverVisible = true;
			this.btnBalance.Border.Rounding = 6;
			this.btnBalance.Border.Thickness = 1;
			this.btnBalance.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.btnBalance.Border.Visible = true;
			this.panelControlAnimator.SetDecoration(this.btnBalance, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.btnBalance, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.btnBalance, BunifuAnimatorNS.DecorationType.None);
			this.btnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBalance.ForeColor = System.Drawing.Color.White;
			this.btnBalance.Image = global::XLight.Properties.Resources.Combo_Chart_50px;
			this.btnBalance.Location = new System.Drawing.Point(12, 267);
			this.btnBalance.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.btnBalance.Name = "btnBalance";
			this.btnBalance.Size = new System.Drawing.Size(228, 52);
			this.btnBalance.TabIndex = 5;
			this.btnBalance.Text = "            Balance";
			this.btnBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBalance.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.btnBalance.TextStyle.Enabled = System.Drawing.Color.White;
			this.btnBalance.TextStyle.Hover = System.Drawing.Color.White;
			this.btnBalance.TextStyle.Pressed = System.Drawing.Color.White;
			this.btnBalance.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btnBalance.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.btnBalance.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
			// 
			// btnClientes
			// 
			this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClientes.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnClientes.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnClientes.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.btnClientes.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(204)))));
			this.btnClientes.Border.Color = System.Drawing.Color.White;
			this.btnClientes.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.btnClientes.Border.HoverVisible = true;
			this.btnClientes.Border.Rounding = 6;
			this.btnClientes.Border.Thickness = 1;
			this.btnClientes.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.btnClientes.Border.Visible = true;
			this.panelControlAnimator.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
			this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClientes.ForeColor = System.Drawing.Color.White;
			this.btnClientes.Image = global::XLight.Properties.Resources.Customer_50px;
			this.btnClientes.Location = new System.Drawing.Point(12, 209);
			this.btnClientes.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(228, 52);
			this.btnClientes.TabIndex = 4;
			this.btnClientes.Text = "            Clientes";
			this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClientes.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.btnClientes.TextStyle.Enabled = System.Drawing.Color.White;
			this.btnClientes.TextStyle.Hover = System.Drawing.Color.White;
			this.btnClientes.TextStyle.Pressed = System.Drawing.Color.White;
			this.btnClientes.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btnClientes.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.btnClientes.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
			// 
			// btnInicio
			// 
			this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInicio.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnInicio.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnInicio.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.btnInicio.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(204)))));
			this.btnInicio.Border.Color = System.Drawing.Color.White;
			this.btnInicio.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.btnInicio.Border.HoverVisible = true;
			this.btnInicio.Border.Rounding = 6;
			this.btnInicio.Border.Thickness = 1;
			this.btnInicio.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
			this.btnInicio.Border.Visible = true;
			this.panelControlAnimator.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
			this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInicio.ForeColor = System.Drawing.Color.White;
			this.btnInicio.Image = global::XLight.Properties.Resources.Registry_Editor_50px;
			this.btnInicio.Location = new System.Drawing.Point(12, 151);
			this.btnInicio.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(228, 52);
			this.btnInicio.TabIndex = 1;
			this.btnInicio.Text = "          DashBoard";
			this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInicio.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.btnInicio.TextStyle.Enabled = System.Drawing.Color.White;
			this.btnInicio.TextStyle.Hover = System.Drawing.Color.White;
			this.btnInicio.TextStyle.Pressed = System.Drawing.Color.White;
			this.btnInicio.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btnInicio.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
			this.btnInicio.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// imgLogoAmpliado
			// 
			this.imgLogoAmpliado.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panelControlAnimator2.SetDecoration(this.imgLogoAmpliado, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.imgLogoAmpliado, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.imgLogoAmpliado, BunifuAnimatorNS.DecorationType.None);
			this.imgLogoAmpliado.Image = global::XLight.Properties.Resources.Icono;
			this.imgLogoAmpliado.Location = new System.Drawing.Point(66, 18);
			this.imgLogoAmpliado.Name = "imgLogoAmpliado";
			this.imgLogoAmpliado.Size = new System.Drawing.Size(137, 95);
			this.imgLogoAmpliado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgLogoAmpliado.TabIndex = 0;
			this.imgLogoAmpliado.TabStop = false;
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.logoAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton1.Image = global::XLight.Properties.Resources.Minimize_Window_100px;
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(967, 7);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(34, 37);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 7;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 20;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// btnSlider
			// 
			this.btnSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.logoAnimator.SetDecoration(this.btnSlider, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.btnSlider, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.btnSlider, BunifuAnimatorNS.DecorationType.None);
			this.btnSlider.Image = global::XLight.Properties.Resources.ACLC_College_100px;
			this.btnSlider.ImageActive = null;
			this.btnSlider.Location = new System.Drawing.Point(17, 3);
			this.btnSlider.Name = "btnSlider";
			this.btnSlider.Size = new System.Drawing.Size(53, 47);
			this.btnSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnSlider.TabIndex = 6;
			this.btnSlider.TabStop = false;
			this.btnSlider.Zoom = 20;
			this.btnSlider.Click += new System.EventHandler(this.btnSlider_Click);
			// 
			// btnMaximizar
			// 
			this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.logoAnimator.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
			this.btnMaximizar.Image = global::XLight.Properties.Resources.Currency_100px;
			this.btnMaximizar.ImageActive = null;
			this.btnMaximizar.Location = new System.Drawing.Point(1007, 7);
			this.btnMaximizar.Name = "btnMaximizar";
			this.btnMaximizar.Size = new System.Drawing.Size(34, 37);
			this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMaximizar.TabIndex = 4;
			this.btnMaximizar.TabStop = false;
			this.btnMaximizar.Zoom = 20;
			this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
			// 
			// logoAnimator
			// 
			this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
			this.logoAnimator.Cursor = null;
			animation14.AnimateOnlyDifferences = true;
			animation14.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.BlindCoeff")));
			animation14.LeafCoeff = 0F;
			animation14.MaxTime = 1F;
			animation14.MinTime = 0F;
			animation14.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicCoeff")));
			animation14.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation14.MosaicShift")));
			animation14.MosaicSize = 0;
			animation14.Padding = new System.Windows.Forms.Padding(30);
			animation14.RotateCoeff = 0.5F;
			animation14.RotateLimit = 0.2F;
			animation14.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.ScaleCoeff")));
			animation14.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation14.SlideCoeff")));
			animation14.TimeCoeff = 0F;
			animation14.TransparencyCoeff = 0F;
			this.logoAnimator.DefaultAnimation = animation14;
			// 
			// panelControlAnimator
			// 
			this.panelControlAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
			this.panelControlAnimator.Cursor = null;
			animation13.AnimateOnlyDifferences = true;
			animation13.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.BlindCoeff")));
			animation13.LeafCoeff = 0F;
			animation13.MaxTime = 1F;
			animation13.MinTime = 0F;
			animation13.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicCoeff")));
			animation13.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation13.MosaicShift")));
			animation13.MosaicSize = 1;
			animation13.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
			animation13.RotateCoeff = 0F;
			animation13.RotateLimit = 0F;
			animation13.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.ScaleCoeff")));
			animation13.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation13.SlideCoeff")));
			animation13.TimeCoeff = 2F;
			animation13.TransparencyCoeff = 0F;
			this.panelControlAnimator.DefaultAnimation = animation13;
			// 
			// panelControlAnimator2
			// 
			this.panelControlAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
			this.panelControlAnimator2.Cursor = null;
			animation15.AnimateOnlyDifferences = true;
			animation15.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.BlindCoeff")));
			animation15.LeafCoeff = 0F;
			animation15.MaxTime = 1F;
			animation15.MinTime = 0F;
			animation15.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.MosaicCoeff")));
			animation15.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation15.MosaicShift")));
			animation15.MosaicSize = 0;
			animation15.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
			animation15.RotateCoeff = 0F;
			animation15.RotateLimit = 0F;
			animation15.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.ScaleCoeff")));
			animation15.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation15.SlideCoeff")));
			animation15.TimeCoeff = 0F;
			animation15.TransparencyCoeff = 0F;
			this.panelControlAnimator2.DefaultAnimation = animation15;
			// 
			// MenuGeneral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(1188, 650);
			this.Controls.Add(this.panelControl);
			this.Controls.Add(this.header);
			this.panelControlAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MenuGeneral";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "XLight";
			this.panelControl.ResumeLayout(false);
			this.header.ResumeLayout(false);
			this.header.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgLogoAmpliado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse buniElipse;
		private System.Windows.Forms.Panel panelControl;
		private System.Windows.Forms.Panel header;
		private System.Windows.Forms.PictureBox imgLogoAmpliado;
		private Bunifu.Framework.UI.BunifuCustomLabel lblSuperior;
		private Bunifu.Framework.UI.BunifuImageButton btnMaximizar;
		private Bunifu.Framework.UI.BunifuDragControl controlDrag;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnInicio;
		private Bunifu.Framework.UI.BunifuImageButton btnSlider;
		private Bunifu.Framework.UI.BunifuSeparator separadorSuperior;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnClientes;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnBalance;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnHistorial;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnOpciones;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnCambiarUsuario;
		private Bunifu.Framework.UI.BunifuSeparator separadorInferior;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnSalir;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		private BunifuAnimatorNS.BunifuTransition logoAnimator;
		private BunifuAnimatorNS.BunifuTransition panelControlAnimator;
		private BunifuAnimatorNS.BunifuTransition panelControlAnimator2;
	}
}

