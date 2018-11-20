using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualPlus.Toolkit.Controls.Interactivity;

namespace XLight
{
	public partial class MenuGeneral : Form
	{
		List<Dictionary<string, Color>> templates = new List<Dictionary<string, Color>>();
		int cur_template = 0;
		DateTime endTime = DateTime.Now;
		private int selectBtn = 0;

		public MenuGeneral()
		{
			InitializeComponent();

			CargarTemplates();

			AplicarElipse();

			actualizadorDia.Start();
		}

		#region Metodos Btns
		private void btnInicio_Click(object sender, EventArgs e)
		{
			selectBtn = 0;
			SetSelectForeColor();
			panelDashboard.Show();
		}

		private void btnClientes_Click(object sender, EventArgs e)
		{
			selectBtn = 1;
			SetSelectForeColor();
			panelDashboard.Hide();
		}

		private void btnBalance_Click(object sender, EventArgs e)
		{
			selectBtn = 2;
			SetSelectForeColor();
		}

		private void btnHistorial_Click(object sender, EventArgs e)
		{
			selectBtn = 3;
			SetSelectForeColor();
		}

		private void btnOpciones_Click(object sender, EventArgs e)
		{
			selectBtn = 4;
			SetSelectForeColor();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			selectBtn = 5;
			SetSelectForeColor();

			// Cierre de formulario
			this.Close();
		}

		private void btnCambiarUsuario_Click(object sender, EventArgs e)
		{
			selectBtn = 6;
			SetSelectForeColor();
		}

		private void btnMaximizar_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			else
			{
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnTransparente_Click(object sender, EventArgs e)
		{
			if (this.Opacity == 1.0f)
			{
				this.Opacity = 0.8f;
			}
			else
			{
				this.Opacity = 1.0f;
			}
		}
		#endregion

		#region Metodos GUI
		private void SetSelectForeColor()
		{
			VisualPlus.Structure.ControlColorState oldState = new VisualPlus.Structure.ControlColorState();
			oldState.Disabled = Color.FromArgb(224, 224, 224);
			oldState.Enabled = Color.FromArgb(26, 32, 40);
			oldState.Hover = Color.FromArgb(0, 102, 204);
			oldState.Pressed = Color.FromArgb(0, 162, 204);

			VisualPlus.Structure.ControlColorState newState = new VisualPlus.Structure.ControlColorState();
			newState.Disabled = Color.FromArgb(224, 224, 224);
			newState.Enabled = Color.FromArgb(37, 46, 59);
			newState.Hover = Color.FromArgb(0, 102, 204);
			newState.Pressed = Color.FromArgb(0, 162, 204);

			btnInicio.BackColorState = oldState;
			btnClientes.BackColorState = oldState;
			btnBalance.BackColorState = oldState;
			btnHistorial.BackColorState = oldState;
			btnOpciones.BackColorState = oldState;
			btnSalir.BackColorState = oldState;
			btnCambiarUsuario.BackColorState = oldState;

			switch (selectBtn)
			{
				case 0:
					btnInicio.BackColorState = newState;
					btnClientes.BackColorState = oldState;
					btnBalance.BackColorState = oldState;
					btnHistorial.BackColorState = oldState;
					btnOpciones.BackColorState = oldState;
					btnSalir.BackColorState = oldState;
					btnCambiarUsuario.BackColorState = oldState;
					break;

				case 1:
					btnInicio.BackColorState = oldState;
					btnClientes.BackColorState = newState;
					btnBalance.BackColorState = oldState;
					btnHistorial.BackColorState = oldState;
					btnOpciones.BackColorState = oldState;
					btnSalir.BackColorState = oldState;
					btnCambiarUsuario.BackColorState = oldState;
					break;

				case 2:
					btnInicio.BackColorState = oldState;
					btnClientes.BackColorState = oldState;
					btnBalance.BackColorState = newState;
					btnHistorial.BackColorState = oldState;
					btnOpciones.BackColorState = oldState;
					btnSalir.BackColorState = oldState;
					btnCambiarUsuario.BackColorState = oldState;
					break;

				case 3:
					btnInicio.BackColorState = oldState;
					btnClientes.BackColorState = oldState;
					btnBalance.BackColorState = oldState;
					btnHistorial.BackColorState = newState;
					btnOpciones.BackColorState = oldState;
					btnSalir.BackColorState = oldState;
					btnCambiarUsuario.BackColorState = oldState;
					break;

				case 4:
					btnInicio.BackColorState = oldState;
					btnClientes.BackColorState = oldState;
					btnBalance.BackColorState = oldState;
					btnHistorial.BackColorState = oldState;
					btnOpciones.BackColorState = newState;
					btnSalir.BackColorState = oldState;
					btnCambiarUsuario.BackColorState = oldState;
					break;

				case 5:
					btnInicio.BackColorState = oldState;
					btnClientes.BackColorState = oldState;
					btnBalance.BackColorState = oldState;
					btnHistorial.BackColorState = oldState;
					btnOpciones.BackColorState = oldState;
					btnSalir.BackColorState = newState;
					btnCambiarUsuario.BackColorState = oldState;
					break;

				case 6:
					btnInicio.BackColorState = oldState;
					btnClientes.BackColorState = oldState;
					btnBalance.BackColorState = oldState;
					btnHistorial.BackColorState = oldState;
					btnOpciones.BackColorState = oldState;
					btnSalir.BackColorState = oldState;
					btnCambiarUsuario.BackColorState = newState;
					break;

				default:
					btnInicio.BackColorState = newState;
					btnClientes.BackColorState = oldState;
					btnBalance.BackColorState = oldState;
					btnHistorial.BackColorState = oldState;
					btnOpciones.BackColorState = oldState;
					btnSalir.BackColorState = oldState;
					btnCambiarUsuario.BackColorState = oldState;
					break;
			}
		}

		private void btnSlider_Click(object sender, EventArgs e)
		{
			if (panelControl.Width == 85)
			{
				panelControl.Visible = false;
				panelControl.Width = 256;
				panelControlAnimator2.ShowSync(panelControl);
				logoAnimator.ShowSync(imgLogoAmpliado);
			}
			else
			{
				logoAnimator.HideSync(imgLogoAmpliado);
				panelControl.Visible = false;
				panelControl.Width = 85;
				panelControlAnimator.ShowSync(panelControl);
			}
		}
		#endregion

		#region Funcionalidades
		public void load_theme(Dictionary<string, Color> theme)
		{

			panelDashboard.GradientBottomLeft = theme["bottomleft"];
			panelDashboard.GradientBottomRight = theme["bottomright"];
			panelDashboard.GradientTopLeft = theme["topleft"];
			panelDashboard.GradientTopRight = theme["topright"];
		}

		public void CargarTemplates()
		{
			Dictionary<string, Color> template = new Dictionary<string, Color>();

			template.Add("bottomleft", Color.FromArgb(255, 192, 128));
			template.Add("bottomright", Color.FromArgb(251, 97, 122));
			template.Add("topleft", Color.FromArgb(251, 97, 122));
			template.Add("topright", Color.FromArgb(251, 97, 122));

			templates.Add(template);


			template = new Dictionary<string, Color>();

			template.Add("bottomleft", Color.FromArgb(192, 0, 192));
			template.Add("bottomright", Color.Black);
			template.Add("topleft", Color.FromArgb(251, 97, 122));
			template.Add("topright", Color.FromArgb(251, 97, 122));

			templates.Add(template);

			template = new Dictionary<string, Color>();

			template.Add("bottomleft", Color.Black);
			template.Add("bottomright", Color.Black);
			template.Add("topleft", Color.FromArgb(251, 97, 122));
			template.Add("topright", Color.DarkTurquoise);

			templates.Add(template);

			load_theme(templates[cur_template]);
		}

		public void AplicarElipse()
		{
			Bunifu.Framework.Lib.Elipse.Apply(card1, 5);
			Bunifu.Framework.Lib.Elipse.Apply(card2, 5);
			Bunifu.Framework.Lib.Elipse.Apply(card3, 5);
		}
		#endregion

		#region Ticks
		private void actualizadorDia_Tick(object sender, EventArgs e)
		{
			endTime = DateTime.Now;

			d.Text = endTime.Day.ToString();
			h.Text = endTime.Hour.ToString();
			m.Text = endTime.Minute.ToString();
			s.Text = endTime.Second.ToString();
		}
		#endregion
	}
}
