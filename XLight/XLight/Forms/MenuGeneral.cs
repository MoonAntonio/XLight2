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
		public MenuGeneral()
		{
			InitializeComponent();
		}

		#region Variables
		private int selectBtn = 0;
		#endregion

		#region Metodos Btns
		private void btnInicio_Click(object sender, EventArgs e)
		{
			selectBtn = 0;
			SetSelectForeColor();
		}

		private void btnClientes_Click(object sender, EventArgs e)
		{
			selectBtn = 1;
			SetSelectForeColor();
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
		#endregion
	}
}
