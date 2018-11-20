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
			BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGeneral));
			BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
			BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
			this.buniElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panelControl = new System.Windows.Forms.Panel();
			this.btnSalir = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.btnCambiarUsuario = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.separadorInferior = new Bunifu.Framework.UI.BunifuSeparator();
			this.btnOpciones = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.btnHistorial = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.btnBalance = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.btnClientes = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.separadorSuperior = new Bunifu.Framework.UI.BunifuSeparator();
			this.btnInicio = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.imgLogoAmpliado = new System.Windows.Forms.PictureBox();
			this.header = new System.Windows.Forms.Panel();
			this.btnTransparente = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnSlider = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
			this.lblSuperior = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.controlDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.panelDashboard = new Bunifu.Framework.UI.BunifuGradientPanel();
			this.s = new System.Windows.Forms.Label();
			this.m = new System.Windows.Forms.Label();
			this.h = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.d = new System.Windows.Forms.Label();
			this.reloj = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.panelControlAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.panelControlAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.actualizadorDia = new System.Windows.Forms.Timer(this.components);
			this.panelBase = new System.Windows.Forms.Panel();
			this.panelStats = new Bunifu.Framework.UI.BunifuCards();
			this.panelControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgLogoAmpliado)).BeginInit();
			this.header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnTransparente)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
			this.panelDashboard.SuspendLayout();
			this.panelBase.SuspendLayout();
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
			// header
			// 
			this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.header.Controls.Add(this.btnTransparente);
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
			// btnTransparente
			// 
			this.btnTransparente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTransparente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.logoAnimator.SetDecoration(this.btnTransparente, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.btnTransparente, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.btnTransparente, BunifuAnimatorNS.DecorationType.None);
			this.btnTransparente.Image = global::XLight.Properties.Resources.Target_100px;
			this.btnTransparente.ImageActive = null;
			this.btnTransparente.Location = new System.Drawing.Point(927, 7);
			this.btnTransparente.Name = "btnTransparente";
			this.btnTransparente.Size = new System.Drawing.Size(34, 37);
			this.btnTransparente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnTransparente.TabIndex = 8;
			this.btnTransparente.TabStop = false;
			this.btnTransparente.Zoom = 20;
			this.btnTransparente.Click += new System.EventHandler(this.btnTransparente_Click);
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
			// logoAnimator
			// 
			this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
			this.logoAnimator.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(30);
			animation1.RotateCoeff = 0.5F;
			animation1.RotateLimit = 0.2F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 0F;
			this.logoAnimator.DefaultAnimation = animation1;
			// 
			// panelDashboard
			// 
			this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(97)))), ((int)(((byte)(122)))));
			this.panelDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDashboard.BackgroundImage")));
			this.panelDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelDashboard.Controls.Add(this.panelStats);
			this.panelDashboard.Controls.Add(this.panelBase);
			this.logoAnimator.SetDecoration(this.panelDashboard, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.panelDashboard, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.panelDashboard, BunifuAnimatorNS.DecorationType.None);
			this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panelDashboard.GradientBottomLeft = System.Drawing.Color.DarkBlue;
			this.panelDashboard.GradientBottomRight = System.Drawing.Color.Black;
			this.panelDashboard.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(97)))), ((int)(((byte)(122)))));
			this.panelDashboard.GradientTopRight = System.Drawing.Color.DarkTurquoise;
			this.panelDashboard.Location = new System.Drawing.Point(256, 53);
			this.panelDashboard.Name = "panelDashboard";
			this.panelDashboard.Quality = 10;
			this.panelDashboard.Size = new System.Drawing.Size(932, 597);
			this.panelDashboard.TabIndex = 2;
			// 
			// s
			// 
			this.s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.s.AutoSize = true;
			this.s.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.s, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.s, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.s, BunifuAnimatorNS.DecorationType.None);
			this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
			this.s.ForeColor = System.Drawing.Color.White;
			this.s.Location = new System.Drawing.Point(621, 243);
			this.s.Name = "s";
			this.s.Size = new System.Drawing.Size(107, 76);
			this.s.TabIndex = 21;
			this.s.Text = "02";
			// 
			// m
			// 
			this.m.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.m.AutoSize = true;
			this.m.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.m, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.m, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.m, BunifuAnimatorNS.DecorationType.None);
			this.m.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
			this.m.ForeColor = System.Drawing.Color.White;
			this.m.Location = new System.Drawing.Point(495, 243);
			this.m.Name = "m";
			this.m.Size = new System.Drawing.Size(107, 76);
			this.m.TabIndex = 20;
			this.m.Text = "02";
			// 
			// h
			// 
			this.h.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.h.AutoSize = true;
			this.h.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.h, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.h, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.h, BunifuAnimatorNS.DecorationType.None);
			this.h.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
			this.h.ForeColor = System.Drawing.Color.White;
			this.h.Location = new System.Drawing.Point(367, 243);
			this.h.Name = "h";
			this.h.Size = new System.Drawing.Size(107, 76);
			this.h.TabIndex = 19;
			this.h.Text = "02";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(588, 231);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 91);
			this.label5.TabIndex = 15;
			this.label5.Text = ":";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(459, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 91);
			this.label4.TabIndex = 14;
			this.label4.Text = ":";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(323, 231);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 91);
			this.label3.TabIndex = 13;
			this.label3.Text = ":";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(639, 333);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 20);
			this.label8.TabIndex = 18;
			this.label8.Text = "Segundos";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(513, 333);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 20);
			this.label7.TabIndex = 17;
			this.label7.Text = "Minuto";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(386, 333);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 20);
			this.label6.TabIndex = 16;
			this.label6.Text = "Hora";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(274, 333);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "Dia";
			// 
			// d
			// 
			this.d.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.d.AutoSize = true;
			this.d.BackColor = System.Drawing.Color.Transparent;
			this.panelControlAnimator2.SetDecoration(this.d, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.d, BunifuAnimatorNS.DecorationType.None);
			this.logoAnimator.SetDecoration(this.d, BunifuAnimatorNS.DecorationType.None);
			this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
			this.d.ForeColor = System.Drawing.Color.White;
			this.d.Location = new System.Drawing.Point(234, 243);
			this.d.Name = "d";
			this.d.Size = new System.Drawing.Size(107, 76);
			this.d.TabIndex = 11;
			this.d.Text = "02";
			// 
			// reloj
			// 
			this.reloj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.reloj.animated = true;
			this.reloj.animationIterval = 1;
			this.reloj.animationSpeed = 50;
			this.reloj.BackColor = System.Drawing.Color.Transparent;
			this.reloj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reloj.BackgroundImage")));
			this.logoAnimator.SetDecoration(this.reloj, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.reloj, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.reloj, BunifuAnimatorNS.DecorationType.None);
			this.reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
			this.reloj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(97)))), ((int)(((byte)(122)))));
			this.reloj.LabelVisible = false;
			this.reloj.LineProgressThickness = 8;
			this.reloj.LineThickness = 2;
			this.reloj.Location = new System.Drawing.Point(377, 9);
			this.reloj.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.reloj.MaxValue = 100;
			this.reloj.Name = "reloj";
			this.reloj.ProgressBackColor = System.Drawing.Color.White;
			this.reloj.ProgressColor = System.Drawing.Color.White;
			this.reloj.Size = new System.Drawing.Size(225, 225);
			this.reloj.TabIndex = 0;
			this.reloj.Value = 20;
			// 
			// panelControlAnimator
			// 
			this.panelControlAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
			this.panelControlAnimator.Cursor = null;
			animation2.AnimateOnlyDifferences = true;
			animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
			animation2.LeafCoeff = 0F;
			animation2.MaxTime = 1F;
			animation2.MinTime = 0F;
			animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
			animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
			animation2.MosaicSize = 1;
			animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
			animation2.RotateCoeff = 0F;
			animation2.RotateLimit = 0F;
			animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
			animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
			animation2.TimeCoeff = 2F;
			animation2.TransparencyCoeff = 0F;
			this.panelControlAnimator.DefaultAnimation = animation2;
			// 
			// panelControlAnimator2
			// 
			this.panelControlAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
			this.panelControlAnimator2.Cursor = null;
			animation3.AnimateOnlyDifferences = true;
			animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
			animation3.LeafCoeff = 0F;
			animation3.MaxTime = 1F;
			animation3.MinTime = 0F;
			animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
			animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
			animation3.MosaicSize = 0;
			animation3.Padding = new System.Windows.Forms.Padding(0);
			animation3.RotateCoeff = 0F;
			animation3.RotateLimit = 0F;
			animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
			animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
			animation3.TimeCoeff = 0F;
			animation3.TransparencyCoeff = 0F;
			this.panelControlAnimator2.DefaultAnimation = animation3;
			// 
			// actualizadorDia
			// 
			this.actualizadorDia.Interval = 1000;
			this.actualizadorDia.Tick += new System.EventHandler(this.actualizadorDia_Tick);
			// 
			// panelBase
			// 
			this.panelBase.BackColor = System.Drawing.Color.Transparent;
			this.panelBase.Controls.Add(this.h);
			this.panelBase.Controls.Add(this.reloj);
			this.panelBase.Controls.Add(this.s);
			this.panelBase.Controls.Add(this.d);
			this.panelBase.Controls.Add(this.m);
			this.panelBase.Controls.Add(this.label2);
			this.panelBase.Controls.Add(this.label6);
			this.panelBase.Controls.Add(this.label5);
			this.panelBase.Controls.Add(this.label7);
			this.panelBase.Controls.Add(this.label4);
			this.panelBase.Controls.Add(this.label8);
			this.panelBase.Controls.Add(this.label3);
			this.logoAnimator.SetDecoration(this.panelBase, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.panelBase, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.panelBase, BunifuAnimatorNS.DecorationType.None);
			this.panelBase.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBase.Location = new System.Drawing.Point(0, 0);
			this.panelBase.Name = "panelBase";
			this.panelBase.Size = new System.Drawing.Size(932, 352);
			this.panelBase.TabIndex = 22;
			// 
			// panelStats
			// 
			this.panelStats.BackColor = System.Drawing.Color.White;
			this.panelStats.BorderRadius = 5;
			this.panelStats.BottomSahddow = true;
			this.panelStats.color = System.Drawing.Color.Tomato;
			this.logoAnimator.SetDecoration(this.panelStats, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator.SetDecoration(this.panelStats, BunifuAnimatorNS.DecorationType.None);
			this.panelControlAnimator2.SetDecoration(this.panelStats, BunifuAnimatorNS.DecorationType.None);
			this.panelStats.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelStats.LeftSahddow = false;
			this.panelStats.Location = new System.Drawing.Point(6, 358);
			this.panelStats.Name = "panelStats";
			this.panelStats.RightSahddow = true;
			this.panelStats.ShadowDepth = 20;
			this.panelStats.Size = new System.Drawing.Size(923, 227);
			this.panelStats.TabIndex = 23;
			// 
			// MenuGeneral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.ClientSize = new System.Drawing.Size(1188, 650);
			this.Controls.Add(this.panelDashboard);
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
			((System.ComponentModel.ISupportInitialize)(this.imgLogoAmpliado)).EndInit();
			this.header.ResumeLayout(false);
			this.header.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnTransparente)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
			this.panelDashboard.ResumeLayout(false);
			this.panelBase.ResumeLayout(false);
			this.panelBase.PerformLayout();
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
		private Bunifu.Framework.UI.BunifuGradientPanel panelDashboard;
		private Bunifu.Framework.UI.BunifuCircleProgressbar reloj;
		private System.Windows.Forms.Label s;
		private System.Windows.Forms.Label m;
		private System.Windows.Forms.Label h;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label d;
		private Bunifu.Framework.UI.BunifuImageButton btnTransparente;
		private System.Windows.Forms.Timer actualizadorDia;
		private System.Windows.Forms.Panel panelBase;
		private Bunifu.Framework.UI.BunifuCards panelStats;
	}
}

