﻿//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Main.cs (01/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de Main											\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using XLight.Clases;
using XLight.Forms;
#endregion

namespace XLight
{
	public partial class MenuGeneral : Form
	{

		#region Variables Publicas
		/// <summary>
		/// <para>Configuracion actual de los ajustes.</para>
		/// </summary>
		public Ajustes configuracionActual;                                     // Configuracion actual de los ajustes
		/// <summary>
		/// <para>Usuario actual del sistema.</para>
		/// </summary>
		public Usuario usuarioActual;                                           // Usuario actual del sistema
		/// <summary>
		/// <para>Nombre de los clientes</para>
		/// </summary>
		public List<string> nombresClientes = new List<string>();				// Nombre de los clientes
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Id actual</para>
		/// </summary>
		private int idActual;                                                   // Id actual
		List<Dictionary<string, Color>> templates = new List<Dictionary<string, Color>>();
		int cur_template = 0;
		DateTime endTime = DateTime.Now;
		private int selectBtn = 0;
		#endregion

		#region Constructores
		/// <summary>
		/// <para>Constructor de <see cref="Main"/>.</para>
		/// </summary>
		public MenuGeneral()
		{
			InitializeComponent();

			CargarTemplates();

			AplicarElipse();

			actualizadorDia.Start();

			// TODO Para testear
			if (configuracionActual == null)
			{
				string pD = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data");
				string pU = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), pD + @"\Usuarios");
				string pA = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ajustes\ajustes.xml");
				string uU = "Admin";

				configuracionActual = new Ajustes(pD, pU, pA, uU);
			}

			if (usuarioActual == null)
			{
				string pH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), configuracionActual.PathData + @"\Usuarios\Admin\historial.xml");
				string pC = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), configuracionActual.PathData + @"\Usuarios\Admin\clientes.xml");

				usuarioActual = new Usuario("Admin", "Admin", 0, pH, pC, 0, 0);
			}

			//LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios;
			idActual = usuarioActual.IdActual;

			ActualizarBusquedaRegistro();

			AutoCompletar();

			PanelClientes.Visible = false;
			PanelBalance.Visible = false;
			PanelHistorial.Visible = false;
			PanelOpciones.Visible = false;

			//BtnUsuarioSetup.Visible = false;

			GuardarAjustes();
		}

		/// <summary>
		/// <para>Constructor de <see cref="Main"/>.</para>
		/// </summary>
		public MenuGeneral(Ajustes config, Usuario user)// Constructor de Main
		{
			configuracionActual = config;
			usuarioActual = user;

			InitializeComponent();
		}
		#endregion

		#region Metodos Btns
		private void btnInicio_Click(object sender, EventArgs e)
		{
			selectBtn = 0;
			SetSelectForeColor();
			PanelDashShow(true);
		}

		private void btnClientes_Click(object sender, EventArgs e)
		{
			selectBtn = 1;
			SetSelectForeColor();
			PanelDashShow(false);
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

			usuarioActual.InicioAutomatico = 0;

			GuardarUsuario();

			Login log = new Login(configuracionActual, this);
			log.Show();
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

		private void PanelDashShow(bool show)
		{
			if (show == true)
			{
				panelDashboard.Visible = false;
				transi1.ShowSync(panelDashboard);
			}
			else
			{
				panelDashboard.Hide();
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

		#region Metodos
		/// <summary>
		/// <para>Agrega un elemento.</para>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="tipo"></param>
		/// <param name="fecha"></param>
		/// <param name="precio"></param>
		/// <param name="resultado"></param>
		public void AgregarCliente(string id, string nom, string apell, string dni, string telefon, string fecha, string direccion, string ultima)// Agrega un elemento
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlNode cliente = doc.CreateElement("Cliente");
			XmlElement xid = doc.CreateElement("id");
			xid.InnerText = id;
			cliente.AppendChild(xid);

			XmlElement xnom = doc.CreateElement("nombre");
			xnom.InnerText = nom;
			cliente.AppendChild(xnom);

			XmlElement xapell = doc.CreateElement("apellidos");
			xapell.InnerText = apell;
			cliente.AppendChild(xapell);

			XmlElement xdni = doc.CreateElement("dni");
			xdni.InnerText = dni;
			cliente.AppendChild(xdni);

			XmlElement xtele = doc.CreateElement("telefono");
			xtele.InnerText = telefon;
			cliente.AppendChild(xtele);

			XmlElement xfecha = doc.CreateElement("fecha");
			xfecha.InnerText = fecha;
			cliente.AppendChild(xfecha);

			XmlElement xdirecc = doc.CreateElement("direccion");
			xdirecc.InnerText = direccion;
			cliente.AppendChild(xdirecc);

			XmlElement xult = doc.CreateElement("ultconsulta");
			xult.InnerText = ultima;
			cliente.AppendChild(xult);

			doc.DocumentElement.AppendChild(cliente);
			doc.Save(usuarioActual.PathClientes);

			usuarioActual.IdActual = usuarioActual.IdActual + 1;
			idActual = usuarioActual.IdActual;

			GuardarCliente(idActual.ToString(), nom, apell, dni, telefon, fecha, direccion, ultima);
		}

		/// <summary>
		/// <para>Guarda los datos de un cliente.</para>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="apell"></param>
		/// <param name="dni"></param>
		/// <param name="telefon"></param>
		/// <param name="fecha"></param>
		/// <param name="direccion"></param>
		public void GuardarCliente(string id, string nom, string apell, string dni, string telefon, string fecha, string direccion, string ult)// Guarda los datos de un cliente
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlElement clientes = doc.DocumentElement;

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

			XmlNode nuevoCliente = doc.CreateElement("Cliente");

			XmlElement xid = doc.CreateElement("id");
			xid.InnerText = id;
			nuevoCliente.AppendChild(xid);

			XmlElement xnom = doc.CreateElement("nombre");
			xnom.InnerText = nom;
			nuevoCliente.AppendChild(xnom);

			XmlElement xapell = doc.CreateElement("apellidos");
			xapell.InnerText = apell;
			nuevoCliente.AppendChild(xapell);

			XmlElement xdni = doc.CreateElement("dni");
			xdni.InnerText = dni;
			nuevoCliente.AppendChild(xdni);

			XmlElement xtele = doc.CreateElement("telefono");
			xtele.InnerText = telefon;
			nuevoCliente.AppendChild(xtele);

			XmlElement xfecha = doc.CreateElement("fecha");
			xfecha.InnerText = fecha;
			nuevoCliente.AppendChild(xfecha);

			XmlElement xdirecc = doc.CreateElement("direccion");
			xdirecc.InnerText = direccion;
			nuevoCliente.AppendChild(xdirecc);

			XmlElement xultco = doc.CreateElement("ultconsulta");
			xultco.InnerText = ult;
			nuevoCliente.AppendChild(xultco);

			foreach (XmlNode item in listaClientes)
			{
				if (item.FirstChild.InnerText == id)
				{
					XmlNode nodo = item;
					clientes.ReplaceChild(nuevoCliente, nodo);
				}
			}

			doc.Save(usuarioActual.PathClientes);
		}

		/// <summary>
		/// <para>Guarda los ajustes</para>
		/// </summary>
		/// <param name="path"></param>
		public void GuardarAjustes()// Guarda los ajustes
		{
			XmlDocument doc = new XmlDocument();

			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlNode root = doc.DocumentElement;
			doc.InsertBefore(xmlDeclaration, root);

			XmlNode elemento = doc.CreateElement("Ajustes");
			doc.AppendChild(elemento);

			XmlElement rutaData = doc.CreateElement("rutadata");
			rutaData.AppendChild(doc.CreateTextNode(configuracionActual.PathData));
			elemento.AppendChild(rutaData);

			XmlElement rutaUsuarios = doc.CreateElement("rutausuarios");
			rutaUsuarios.AppendChild(doc.CreateTextNode(configuracionActual.PathUsuarios));
			elemento.AppendChild(rutaUsuarios);

			XmlElement rutaAjustes = doc.CreateElement("rutaajustes");
			rutaAjustes.AppendChild(doc.CreateTextNode(configuracionActual.PathAjustes));
			elemento.AppendChild(rutaAjustes);

			XmlElement ultUser = doc.CreateElement("ultimouser");
			ultUser.AppendChild(doc.CreateTextNode(configuracionActual.UltimoUser));
			elemento.AppendChild(ultUser);

			doc.Save(configuracionActual.PathAjustes);
		}

		/// <summary>
		/// <para>Guarda el user</para>
		/// </summary>
		public void GuardarUsuario()// Guarda el user
		{

			XmlDocument doc = new XmlDocument();

			doc.Load(configuracionActual.PathUsuarios + "/usuarios.xml");

			XmlElement usuarios = doc.DocumentElement;

			XmlNodeList listaUsuarios = doc.SelectNodes("Usuarios/Usuario");

			XmlNode nuevoUsuario = doc.CreateElement("Usuario");

			XmlElement xnom = doc.CreateElement("nombre");
			xnom.InnerText = usuarioActual.Nombre;
			nuevoUsuario.AppendChild(xnom);

			XmlElement xpass = doc.CreateElement("password");
			xpass.InnerText = usuarioActual.Password;
			nuevoUsuario.AppendChild(xpass);

			XmlElement xniv = doc.CreateElement("nivel");
			xniv.InnerText = usuarioActual.NivelPrivilegios.ToString();
			nuevoUsuario.AppendChild(xniv);

			XmlElement xruHi = doc.CreateElement("rutahistorial");
			xruHi.InnerText = usuarioActual.PathHistorial;
			nuevoUsuario.AppendChild(xruHi);

			XmlElement xruCli = doc.CreateElement("rutaclientes");
			xruCli.InnerText = usuarioActual.PathClientes;
			nuevoUsuario.AppendChild(xruCli);

			XmlElement xidac = doc.CreateElement("idactual");
			xidac.InnerText = usuarioActual.IdActual.ToString();
			nuevoUsuario.AppendChild(xidac);

			XmlElement xinia = doc.CreateElement("inicioautomatico");
			xinia.InnerText = usuarioActual.InicioAutomatico.ToString();
			nuevoUsuario.AppendChild(xinia);

			foreach (XmlNode item in listaUsuarios)
			{
				if (item.FirstChild.InnerText == usuarioActual.Nombre)
				{
					XmlNode nodo = item;
					usuarios.ReplaceChild(nuevoUsuario, nodo);
				}
			}

			doc.Save(configuracionActual.PathUsuarios + "/usuarios.xml");

		}

		/// <summary>
		/// <para>Crea una entrada en el registro</para>
		/// </summary>
		/// <param name="ruta"></param>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="tipo"></param>
		/// <param name="fecha"></param>
		/// <param name="precio"></param>
		/// <param name="resultado"></param>
		public void CrearEntradaHistoria(string nombre, string apellidos, string suceso, string fecha)// Crea una entrada en el registro
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathHistorial);

			XmlNode cliente = doc.CreateElement("Entrada");

			XmlElement xnomb = doc.CreateElement("nombre");
			xnomb.InnerText = nombre;
			cliente.AppendChild(xnomb);

			XmlElement xapell = doc.CreateElement("apellidos");
			xapell.InnerText = apellidos;
			cliente.AppendChild(xapell);

			XmlElement xsuceso = doc.CreateElement("suceso");
			xsuceso.InnerText = suceso;
			cliente.AppendChild(xsuceso);

			XmlElement xfecha = doc.CreateElement("fecha");
			xfecha.InnerText = fecha;
			cliente.AppendChild(xfecha);

			doc.DocumentElement.AppendChild(cliente);
			doc.Save(usuarioActual.PathHistorial);
		}

		/// <summary>
		/// <para>Actualiza la busqueda de registro</para>
		/// </summary>
		public void ActualizarBusquedaRegistro()// Actualiza la busqueda de registro
		{
			//dataGridView1.Rows.Clear();
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");
			XmlNode inCliente;

			DataTable tabla = new DataTable();


			for (int n = 0; n < listaClientes.Count; n++)
			{
				inCliente = listaClientes.Item(n);

				string id = inCliente.SelectSingleNode("id").InnerText;
				string nombre = inCliente.SelectSingleNode("nombre").InnerText;
				string apellidos = inCliente.SelectSingleNode("apellidos").InnerText;
				string dni = inCliente.SelectSingleNode("dni").InnerText;
				string telefono = inCliente.SelectSingleNode("telefono").InnerText;
				string fecha = inCliente.SelectSingleNode("fecha").InnerText;
				string direccion = inCliente.SelectSingleNode("direccion").InnerText;

				//dataGridView1.Rows.Add(id, nombre, apellidos, dni, telefono, fecha, direccion);
			}
		}

		/// <summary>
		/// <para>Autocompleta la busqueda</para>
		/// </summary>
		public void AutoCompletar()// Autocompleta la busqueda
		{
			nombresClientes.Clear();

			//txtBoxBuscadorRegistro.AutoCompleteSource = AutoCompleteSource.CustomSource;
			//txtBoxBuscadorRegistro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlElement cliente = doc.DocumentElement;

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

			foreach (XmlNode item in listaClientes)
			{
				string nodo = item["nombre"].InnerText;
				string nodoape = item["apellidos"].InnerText;

				nombresClientes.Add(nodo + " " + nodoape);
			}

			doc.Save(usuarioActual.PathClientes);

			DataTable dt = new DataTable();
			dt.Columns.Add("nombre", typeof(string));

			for (int i = 0; i < nombresClientes.Count; i++)
			{
				dt.Rows.Add(nombresClientes[i]);
			}

			for (int n = 0; n < dt.Rows.Count; n++)
			{
				string name = dt.Rows[n]["nombre"].ToString();
				coll.Add(name);
			}

			//txtBoxBuscadorRegistro.AutoCompleteCustomSource = coll;
		}

		/// <summary>
		/// <para>Imprimir Lista</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnImprimirClientes_Click(object sender, EventArgs e)// Imprimir Lista
		{
			//printDocument1.Print();
		}

		/// <summary>
		/// <para>Preparar pagina para imprimir.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)// Preparar pagina para imprimir
		{
			/*Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
			dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
			e.Graphics.DrawImage(bm, 10, 10);*/
		}

		/// <summary>
		/// <para>Carga el historial</para>
		/// </summary>
		private void CargarHistorial()// Carga el historial
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathHistorial);

			XmlNodeList listaClientes = doc.SelectNodes("Entradas/Entrada");
			XmlNode inCliente;

			for (int n = 0; n < listaClientes.Count; n++)
			{
				inCliente = listaClientes.Item(n);

				string nombre = inCliente.SelectSingleNode("nombre").InnerText;
				string apellidos = inCliente.SelectSingleNode("apellidos").InnerText;
				string suceso = inCliente.SelectSingleNode("suceso").InnerText;
				string fecha = inCliente.SelectSingleNode("fecha").InnerText;

				ListViewItem listaItems = new ListViewItem(n.ToString());
				listaItems.SubItems.Add(nombre);
				listaItems.SubItems.Add(apellidos);
				listaItems.SubItems.Add(suceso);
				listaItems.SubItems.Add(fecha);

				//listViewHistorial.Items.Add(listaItems);
			}
		}

		/// <summary>
		/// <para>Borra el historial</para>
		/// </summary>
		/// <param name="id"></param>
		public void BorrarHistorial()// Borra el historial
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathHistorial);

			XmlElement cliente = doc.DocumentElement;

			XmlNodeList listaClientes = doc.SelectNodes("Entradas/Entrada");

			foreach (XmlNode item in listaClientes)
			{
				XmlNode nodo = item;

				cliente.RemoveChild(nodo);
			}

			doc.Save(usuarioActual.PathHistorial);

			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			CrearEntradaHistoria(usuarioActual.Nombre + " (Usuario)", "***", "Borro el historial.", dia);
		}

		/// <summary>
		/// <para>Actualizar la lista.</para>
		/// </summary>
		public void ActualizarLista()// Actualizar la lista
		{
			ActualizarBusquedaRegistro();

			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			CrearEntradaHistoria(usuarioActual.Nombre + " (Usuario)", "***", "Edito su configuracion.", dia);
		}

		/// <summary>
		/// <para>Cmabio de contra</para>
		/// </summary>
		/// <param name="user"></param>
		public void CambioContr(Usuario user)// Cmabio de contra
		{
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			usuarioActual = user;

			GuardarUsuario();

			CrearEntradaHistoria(usuarioActual.Nombre + " (Usuario)", "***", "Cambio la contraseña.", dia);
		}
		#endregion

		#region Metodos GUI
		/// <summary>
		/// <para>Minimiza la pantalla.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnMinimizar_Click(object sender, EventArgs e)// Minimiza la pantalla
		{
			this.WindowState = FormWindowState.Minimized;
		}

		/// <summary>
		/// <para>Maximiza la pantalla.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnMaximizar_Click(object sender, EventArgs e)// Maximiza la pantalla
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

		/// <summary>
		/// <para>Sale de la app.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnSalir_Click(object sender, EventArgs e)// Sale de la app
		{
			Application.Exit();
		}

		/// <summary>
		/// <para>Abre clientes.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnClientes_Click(object sender, EventArgs e)// Abre clientes
		{
			if (PanelClientes.Visible) return;

			PanelClientes.Visible = true;
			PanelBalance.Visible = false;
			PanelHistorial.Visible = false;
			PanelOpciones.Visible = false;

			//LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios + " >> " + "Clientes";

			//BtnUsuarioSetup.Visible = false;
		}

		/// <summary>
		/// <para>Abre el balance.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnBalance_Click(object sender, EventArgs e)// Abre el balance
		{
			if (usuarioActual.NivelPrivilegios == 0)
			{
				if (PanelBalance.Visible) return;

				PanelBalance.Visible = true;
				PanelClientes.Visible = false;
				PanelHistorial.Visible = false;
				PanelOpciones.Visible = false;

				//LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios + " >> " + "Balance";
			}
			else
			{
				MessageBox.Show("No tienes privilegios suficientes. Contacta con tu admin.");
			}

			//BtnUsuarioSetup.Visible = false;
		}

		/// <summary>
		/// <para>Abre el historial</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnHistorial_Click(object sender, EventArgs e)// Abre el historial
		{
			CargarHistorial();

			if (PanelHistorial.Visible) return;

			PanelHistorial.Visible = true;
			PanelClientes.Visible = false;
			PanelBalance.Visible = false;
			PanelOpciones.Visible = false;

			//LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios + " >> " + "Historial";

			//BtnUsuarioSetup.Visible = false;
		}

		/// <summary>
		/// <para>Abre las opciones</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnOpciones_Click(object sender, EventArgs e)// Abre las opciones
		{
			if (PanelOpciones.Visible) return;

			PanelHistorial.Visible = false;
			PanelClientes.Visible = false;
			PanelBalance.Visible = false;
			PanelOpciones.Visible = true;

			//LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios + " >> " + "Opciones";

			/*LblData.Text = configuracionActual.PathData;
			LblUsuarios.Text = configuracionActual.PathUsuarios;
			LblClientes.Text = usuarioActual.PathClientes;
			LblHistorial.Text = usuarioActual.PathHistorial;

			if (usuarioActual.InicioAutomatico == 0)
			{
				checkBoxAuto.CheckState = CheckState.Unchecked;
			}
			else
			{
				checkBoxAuto.CheckState = CheckState.Checked;
			}

			BtnUsuarioSetup.Visible = true;*/
		}

		/// <summary>
		/// <para>Agregar cliente</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAgregarNuevoCliente_Click(object sender, EventArgs e)// Agregar cliente
		{
			/*if (TextNombre.Text == string.Empty)
			{
				MessageBox.Show("Tienes que completar nombre como minimo.");
			}
			else
			{
				DateTime diahora = DateTime.Now;
				string dia = diahora.ToString("dddd dd MMMM");

				// Agregar cliente
				AgregarCliente(idActual.ToString(), TextNombre.Text, TextApellidos.Text, TextDNI.Text, TextTelefono.Text, DataFecha.Text, TextDireccion.Text, "Nunca");

				// Agregar entrada
				CrearEntradaHistoria(TextNombre.Text, TextApellidos.Text, "Nuevo cliente", dia);

				// Borrar info
				TextNombre.Text = "";
				TextApellidos.Text = "";

				// Actualizar lista
				ActualizarBusquedaRegistro();
				AutoCompletar();

				// Mostrar mensaje
				MessageBox.Show("Cliente agregado.");
			}*/
		}

		/// <summary>
		/// <para>Abre la ficha del usuario.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAbrirFicha_Click(object sender, EventArgs e)// Abre la ficha del usuario
		{
			//dataGridView1.ClearSelection();

			/*if (txtBoxBuscadorRegistro.Text != string.Empty)
			{
				string nombreFicha = txtBoxBuscadorRegistro.Text;

				Ficha ficha = new Ficha(configuracionActual, usuarioActual, nombreFicha);
				ficha.Show();

				txtBoxBuscadorRegistro.Text = "";
			}
			else
			{
				MessageBox.Show("Tienes que buscar algun cliente.");
			}*/
		}

		/// <summary>
		/// <para>Borrar un cliente.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnBorrar_Click(object sender, EventArgs e)// Borrar un cliente
		{
			/*XmlDocument doc = new XmlDocument();
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");
			string no = "";
			string ap = "";

			if (txtBoxBuscadorRegistro.Text != string.Empty)
			{
				doc.Load(usuarioActual.PathClientes);

				XmlElement cliente = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				foreach (XmlNode item in listaClientes)
				{
					string nombreConjunto = item.SelectSingleNode("nombre").InnerText + " " + item.SelectSingleNode("apellidos").InnerText;

					no = item.SelectSingleNode("nombre").InnerText;
					ap = item.SelectSingleNode("apellidos").InnerText;

					if (nombreConjunto == txtBoxBuscadorRegistro.Text)
					{
						MessageBoxButtons buttons = MessageBoxButtons.YesNo;
						DialogResult result = MessageBox.Show("¿Quieres eliminar a " + no + " ?", "Seguro", buttons);

						if (result == System.Windows.Forms.DialogResult.Yes)
						{
							XmlNode nodo = item;

							cliente.RemoveChild(nodo);

							CrearEntradaHistoria(no, ap, no + " " + ap + " ha sido borrado.", dia);
						}
					}
				}


				doc.Save(usuarioActual.PathClientes);

				ActualizarBusquedaRegistro();

				txtBoxBuscadorRegistro.Text = "";

				ActualizarBusquedaRegistro();
			}
			else
			{
				MessageBox.Show("Primero busca un usuario");
			}*/
		}

		/// <summary>
		/// <para>Editar un usuario.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnEditar_Click(object sender, EventArgs e)// Editar un usuario
		{
			/*if (txtBoxBuscadorRegistro.Text != string.Empty)
			{
				string nombreFicha = txtBoxBuscadorRegistro.Text;

				EditarUsuario ficha = new EditarUsuario(configuracionActual, usuarioActual, nombreFicha, this);
				ficha.Show();

				txtBoxBuscadorRegistro.Text = "";
			}
			else
			{
				MessageBox.Show("Tienes que buscar algun cliente.");
			}*/
		}

		/// <summary>
		/// <para>Ruta data</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnRutaData_Click(object sender, EventArgs e)// Ruta data
		{
			FolderBrowserDialog busqueda = new FolderBrowserDialog();

			if (busqueda.ShowDialog() == DialogResult.OK)
			{
				string path = busqueda.SelectedPath;
				//LblData.Text = path;
				configuracionActual.PathData = path;
				GuardarAjustes();
			}
		}

		/// <summary>
		/// <para>Ruta usuarios</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnRutaUsuarios_Click(object sender, EventArgs e)// Ruta usuarios
		{
			FolderBrowserDialog busqueda = new FolderBrowserDialog();

			if (busqueda.ShowDialog() == DialogResult.OK)
			{
				string path = busqueda.SelectedPath;
				//LblUser.Text = path;
				configuracionActual.PathUsuarios = path;
				GuardarAjustes();
			}
		}

		/// <summary>
		/// <para>Ruta clientes</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnRutaClientes_Click(object sender, EventArgs e)// Ruta clientes
		{
			OpenFileDialog busqueda = new OpenFileDialog();

			if (busqueda.ShowDialog() == DialogResult.OK)
			{
				string path = busqueda.FileName;
				//LblClientes.Text = path;
				usuarioActual.PathClientes = path;
				GuardarUsuario();
			}
		}

		/// <summary>
		/// <para>Ruta Historial</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnRutaHistorial_Click(object sender, EventArgs e)// Ruta Historial
		{
			OpenFileDialog busqueda = new OpenFileDialog();

			if (busqueda.ShowDialog() == DialogResult.OK)
			{
				string path = busqueda.FileName;
				//LblHistorial.Text = path;
				usuarioActual.PathHistorial = path;
				GuardarUsuario();
			}
		}

		/// <summary>
		/// <para>Borrar historial</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnBorrarHistorial_Click(object sender, EventArgs e)// Borrar historial
		{
			BorrarHistorial();

			MessageBox.Show("Historial borrado.");
		}

		/// <summary>
		/// <para>Cambiar estado check</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void checkBoxAuto_CheckStateChanged(object sender, EventArgs e)// Cambiar estado check
		{
			/*if (checkBoxAuto.CheckState == CheckState.Checked)
			{
				usuarioActual.InicioAutomatico = 1;
			}
			else
			{
				usuarioActual.InicioAutomatico = 0;
			}

			GuardarUsuario();*/
		}

		/// <summary>
		/// <para>Setup Usuario</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnUsuarioSetup_Click(object sender, EventArgs e)// Setup Usuario
		{
			usuarioActual.InicioAutomatico = 0;

			GuardarUsuario();

			Login log = new Login(configuracionActual, this);
			log.Show();
		}

		/// <summary>
		/// <para>Cambia la contra</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCambiarContraseña_Click(object sender, EventArgs e)// Cambia la contra
		{
			CambiarContrase us = new CambiarContrase(usuarioActual, this);
			us.Show();
		}

		/// <summary>
		/// <para>Crear nuevo usuario</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCrearUsuario_Click(object sender, EventArgs e)// Crear nuevo usuario
		{
			/*if (usuarioActual.NivelPrivilegios == 0)
			{
				NuevoUsuario nUser = new NuevoUsuario(configuracionActual);
				nUser.Show();
			}
			else
			{
				MessageBox.Show("No tienes nivel suficiente para esta opcion.");
			}*/
		}
		#endregion
	}
}
