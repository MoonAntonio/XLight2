using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLight
{
	public partial class MenuGeneral : Form
	{
		public MenuGeneral()
		{
			InitializeComponent();
		}

		#region Funcionalidad
		private void btnClose_Click(object sender, EventArgs e)
		{
			// Cierre de formulario
			this.Close();
		}
		#endregion
	}
}
