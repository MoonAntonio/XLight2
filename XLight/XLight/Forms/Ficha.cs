﻿//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Ficha.cs (01/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de Ficha											\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using XLight.Clases;
#endregion

namespace XLight.Forms
{
	/// <summary>
	/// <para>Formulario de Ficha</para>
	/// </summary>
	public partial class Ficha : Form
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
		/// <para>Nombre y apellidos del cliente.</para>
		/// </summary>
		public string clienteN;                                                 // Nombre y apellidos del cliente
		/// <summary>
		/// <para>Cliente</para>
		/// </summary>
		public Cliente cliente;                                                 // Cliente
		/// <summary>
		/// <para>Ruta del cliente.</para>
		/// </summary>
		public string rutaCliente;												// Ruta del cliente
		/// <summary>
		/// <para>Ruta de los recordatorios.</para>
		/// </summary>
		public string rutaClienteRecordatorio;									// Ruta de los recordatorios
		/// <summary>
		/// <para>Ruta de hipnosis.</para>
		/// </summary>
		public string rutaClienteHipnosis;										// Ruta de hipnosis
		/// <summary>
		/// <para>Ruta de interpretar.</para>
		/// </summary>
		public string rutaClienteSueno;											// Ruta de interpretar
		/// <summary>
		/// <para>Ruta de regresion.</para>
		/// </summary>
		public string rutaClienteRegresion;										// Ruta de regresion
		/// <summary>
		/// <para>Ruta de reiki.</para>
		/// </summary>
		public string rutaClienteReiki;											// Ruta de reiki
		/// <summary>
		/// <para>Ruta de tetra.</para>
		/// </summary>
		public string rutaClienteTetra;											// Ruta de tetra
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Determina si se esta creando actualmente el archivo.</para>
		/// </summary>
		private bool isCreando = false;											// Determina si se esta creando actualmente el archivo
		/// <summary>
		/// <para>Ruta de lectura del archivo.</para>
		/// </summary>
		private string rutaLectura;												// Ruta de lectura del archivo
		#endregion

		#region Constructores
		/// <summary>
		/// <para>Constructor de <see cref="Ficha"/>.</para>
		/// </summary>
		public Ficha()// Constructor de Ficha
		{
			InitializeComponent();

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

			// Cargar el cliente
			if (cliente == null)
			{
				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");
				XmlNode inCliente;

				for (int n = 0; n < listaClientes.Count; n++)
				{
					inCliente = listaClientes.Item(n);

					string nombr = inCliente.SelectSingleNode("nombre").InnerText;
					string apelli = inCliente.SelectSingleNode("apellidos").InnerText;

					if (clienteN == nombr + " " + apelli)
					{
						TextNombre.Text = inCliente.SelectSingleNode("nombre").InnerText;
						TextApellidos.Text = inCliente.SelectSingleNode("apellidos").InnerText;
						TextDNI.Text = inCliente.SelectSingleNode("dni").InnerText;
						TextTelefono.Text = inCliente.SelectSingleNode("telefono").InnerText;
						DataFecha.Text = inCliente.SelectSingleNode("fecha").InnerText;
						TextDireccion.Text = inCliente.SelectSingleNode("direccion").InnerText;
						txtUltimaConsulta.Text = inCliente.SelectSingleNode("ultconsulta").InnerText;

						cliente = new Cliente(Int32.Parse(inCliente.SelectSingleNode("id").InnerText), inCliente.SelectSingleNode("nombre").InnerText,
												inCliente.SelectSingleNode("apellidos").InnerText, inCliente.SelectSingleNode("dni").InnerText,
												inCliente.SelectSingleNode("telefono").InnerText, inCliente.SelectSingleNode("fecha").InnerText,
												inCliente.SelectSingleNode("direccion").InnerText, inCliente.SelectSingleNode("ultconsulta").InnerText);
					}
				}
			}

			// Si la patch no existe
			if (!File.Exists(configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos))
			{

				rutaCliente = configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos + "/";
				rutaClienteRecordatorio = rutaCliente + "Recordatorio";
				rutaClienteHipnosis = rutaCliente + "Hipnosis";
				rutaClienteSueno = rutaCliente + "Interpretar";
				rutaClienteRegresion = rutaCliente + "Regresion";
				rutaClienteReiki = rutaCliente + "Reiki";
				rutaClienteTetra = rutaCliente + "Tetra";

				Directory.CreateDirectory(configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos);
				Directory.CreateDirectory(rutaCliente + "Recordatorio");
				Directory.CreateDirectory(rutaCliente + "Hipnosis");
				Directory.CreateDirectory(rutaCliente + "Interpretar");
				Directory.CreateDirectory(rutaCliente + "Regresion");
				Directory.CreateDirectory(rutaCliente + "Reiki");
				Directory.CreateDirectory(rutaCliente + "Tetra");
			}
			else
			{
				rutaCliente = configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos + "/";
				rutaClienteRecordatorio = rutaCliente + "Recordatorio";
				rutaClienteHipnosis = rutaCliente + "Hipnosis";
				rutaClienteSueno = rutaCliente + "Interpretar";
				rutaClienteRegresion = rutaCliente + "Regresion";
				rutaClienteReiki = rutaCliente + "Reiki";
				rutaClienteTetra = rutaCliente + "Tetra";
			}


			// Cargar los documentos
			CargarHipnosis();
			CargarInterpretar();
			CargarRegresion();
			CargarReiki();
			CargarTetra();

			// Resetear GUI
			richTextBoxHipnosis.Visible = false;
			BtnGuardarHipnosis.Visible = false;
			BtnImprimirHipnosis.Visible = false;

			richTextBoxInterpretar.Visible = false;
			BtnGuardarInterpretar.Visible = false;
			BtnImprimirInterpretar.Visible = false;

			richTextBoxRegresion.Visible = false;
			BtnGuardarRegresion.Visible = false;
			BtnImprimirRegresion.Visible = false;

			richTextBoxReiki.Visible = false;
			BtnGuardarReiki.Visible = false;
			BtnImprimirReiki.Visible = false;

			richTextBoxTetra.Visible = false;
			BtnGuardarTetra.Visible = false;
			BtnImprimirTetra.Visible = false;
		}

		/// <summary>
		/// <para>Constructor de <see cref="Ficha"/>.</para>
		/// </summary>
		/// <param name="config">Configuracion actual de los ajustes</param>
		/// <param name="user">Usuario actual del sistema</param>
		/// <param name="nombre">Nombre y apellidos del cliente</param>
		public Ficha(Ajustes config, Usuario user, string nombre)// Constructor de Ficha
		{
			configuracionActual = config;
			usuarioActual = user;
			clienteN = nombre;

			InitializeComponent();

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

			// Cargar el cliente
			if (cliente == null)
			{
				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");
				XmlNode inCliente;

				for (int n = 0; n < listaClientes.Count; n++)
				{
					inCliente = listaClientes.Item(n);

					string nombr = inCliente.SelectSingleNode("nombre").InnerText;
					string apelli = inCliente.SelectSingleNode("apellidos").InnerText;

					if (clienteN == nombr + " " + apelli)
					{
						TextNombre.Text = inCliente.SelectSingleNode("nombre").InnerText;
						TextApellidos.Text = inCliente.SelectSingleNode("apellidos").InnerText;
						TextDNI.Text = inCliente.SelectSingleNode("dni").InnerText;
						TextTelefono.Text = inCliente.SelectSingleNode("telefono").InnerText;
						DataFecha.Text = inCliente.SelectSingleNode("fecha").InnerText;
						TextDireccion.Text = inCliente.SelectSingleNode("direccion").InnerText;
						txtUltimaConsulta.Text = inCliente.SelectSingleNode("ultconsulta").InnerText;

						cliente = new Cliente(Int32.Parse(inCliente.SelectSingleNode("id").InnerText), inCliente.SelectSingleNode("nombre").InnerText,
												inCliente.SelectSingleNode("apellidos").InnerText, inCliente.SelectSingleNode("dni").InnerText,
												inCliente.SelectSingleNode("telefono").InnerText, inCliente.SelectSingleNode("fecha").InnerText,
												inCliente.SelectSingleNode("direccion").InnerText, inCliente.SelectSingleNode("ultconsulta").InnerText);
					}
				}
			}

			// Si la patch no existe
			if (!File.Exists(configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos))
			{

				rutaCliente = configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos + "/";
				rutaClienteRecordatorio = rutaCliente + "Recordatorio";
				rutaClienteHipnosis = rutaCliente + "Hipnosis";
				rutaClienteSueno = rutaCliente + "Interpretar";
				rutaClienteRegresion = rutaCliente + "Regresion";
				rutaClienteReiki = rutaCliente + "Reiki";
				rutaClienteTetra = rutaCliente + "Tetra";

				Directory.CreateDirectory(configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos);
				Directory.CreateDirectory(rutaCliente + "Recordatorio");
				Directory.CreateDirectory(rutaCliente + "Hipnosis");
				Directory.CreateDirectory(rutaCliente + "Interpretar");
				Directory.CreateDirectory(rutaCliente + "Regresion");
				Directory.CreateDirectory(rutaCliente + "Reiki");
				Directory.CreateDirectory(rutaCliente + "Tetra");
			}
			else
			{
				rutaCliente = configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos + "/";
				rutaClienteRecordatorio = rutaCliente + "Recordatorio";
				rutaClienteHipnosis = rutaCliente + "Hipnosis";
				rutaClienteSueno = rutaCliente + "Interpretar";
				rutaClienteRegresion = rutaCliente + "Regresion";
				rutaClienteReiki = rutaCliente + "Reiki";
				rutaClienteTetra = rutaCliente + "Tetra";
			}


			// Cargar los documentos
			CargarHipnosis();
			CargarInterpretar();
			CargarRegresion();
			CargarReiki();
			CargarTetra();

			// Resetear GUI
			richTextBoxHipnosis.Visible = false;
			BtnGuardarHipnosis.Visible = false;
			BtnImprimirHipnosis.Visible = false;

			richTextBoxInterpretar.Visible = false;
			BtnGuardarInterpretar.Visible = false;
			BtnImprimirInterpretar.Visible = false;

			richTextBoxRegresion.Visible = false;
			BtnGuardarRegresion.Visible = false;
			BtnImprimirRegresion.Visible = false;

			richTextBoxReiki.Visible = false;
			BtnGuardarReiki.Visible = false;
			BtnImprimirReiki.Visible = false;

			richTextBoxTetra.Visible = false;
			BtnGuardarTetra.Visible = false;
			BtnImprimirTetra.Visible = false;
		}
		#endregion

		#region Loader
		/// <summary>
		/// <para>Loader de <see cref="Ficha"/>.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Ficha_Load(object sender, EventArgs e)// Loader de Ficha
		{
			
		}
		#endregion

		#region Metodos Publicos
		#region Hipnosis
		/// <summary>
		/// <para>Cargar los documentos de hipnosis.</para>
		/// </summary>
		public void CargarHipnosis()// Cargar los documentos de hipnosis
		{
			visualListBoxHipnosis.Items.Clear();

			DirectoryInfo d = new DirectoryInfo(rutaClienteHipnosis);
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				visualListBoxHipnosis.Items.Add(file.Name);
			}
		}

		/// <summary>
		/// <para>Abrir el log.</para>
		/// </summary>
		/// <param name="value"></param>
		public void AbrirLogHipnosis(string value)// Abrir el log
		{
			richTextBoxHipnosis.Visible = true;
			richTextBoxHipnosis.Text = File.ReadAllText(rutaClienteHipnosis + "/" + value);
			rutaLectura = rutaClienteHipnosis + "/" + value;
		}
		#endregion

		#region Interpretar
		/// <summary>
		/// <para>Cargar los documentos de sueños.</para>
		/// </summary>
		public void CargarInterpretar()// Cargar los documentos de sueños
		{
			visualListBoxInterpretar.Items.Clear();

			DirectoryInfo d = new DirectoryInfo(rutaClienteSueno);
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				visualListBoxInterpretar.Items.Add(file.Name);
			}
		}

		/// <summary>
		/// <para>Abrir el log.</para>
		/// </summary>
		/// <param name="value"></param>
		public void AbrirLogInterpretar(string value)// Abrir el log
		{
			richTextBoxInterpretar.Visible = true;
			richTextBoxInterpretar.Text = File.ReadAllText(rutaClienteSueno + "/" + value);
			rutaLectura = rutaClienteSueno + "/" + value;
		}
		#endregion

		#region Regresion
		/// <summary>
		/// <para>Cargar los documentos de regresion.</para>
		/// </summary>
		public void CargarRegresion()// Cargar los documentos de regresion
		{
			visualListBoxRegresion.Items.Clear();

			DirectoryInfo d = new DirectoryInfo(rutaClienteRegresion);
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				visualListBoxRegresion.Items.Add(file.Name);
			}
		}

		/// <summary>
		/// <para>Abrir el log.</para>
		/// </summary>
		/// <param name="value"></param>
		public void AbrirLogRegresion(string value)// Abrir el log
		{
			richTextBoxRegresion.Visible = true;
			richTextBoxRegresion.Text = File.ReadAllText(rutaClienteRegresion + "/" + value);
			rutaLectura = rutaClienteRegresion + "/" + value;
		}
		#endregion

		#region Reiki
		/// <summary>
		/// <para>Cargar los documentos de reiki.</para>
		/// </summary>
		public void CargarReiki()// Cargar los documentos de reiki
		{
			visualListBoxReiki.Items.Clear();

			DirectoryInfo d = new DirectoryInfo(rutaClienteReiki);
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				visualListBoxReiki.Items.Add(file.Name);
			}
		}

		/// <summary>
		/// <para>Abrir el log.</para>
		/// </summary>
		/// <param name="value"></param>
		public void AbrirLogReiki(string value)// Abrir el log
		{
			richTextBoxReiki.Visible = true;
			richTextBoxReiki.Text = File.ReadAllText(rutaClienteReiki + "/" + value);
			rutaLectura = rutaClienteReiki + "/" + value;
		}
		#endregion

		#region Tetra
		/// <summary>
		/// <para>Cargar los documentos de tetra.</para>
		/// </summary>
		public void CargarTetra()// Cargar los documentos de tetra
		{
			visualListBoxTetra.Items.Clear();

			DirectoryInfo d = new DirectoryInfo(rutaClienteTetra);
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				visualListBoxTetra.Items.Add(file.Name);
			}
		}

		/// <summary>
		/// <para>Abrir el log.</para>
		/// </summary>
		/// <param name="value"></param>
		public void AbrirLogTetra(string value)// Abrir el log
		{
			richTextBoxTetra.Visible = true;
			richTextBoxTetra.Text = File.ReadAllText(rutaClienteTetra + "/" + value);
			rutaLectura = rutaClienteTetra + "/" + value;
		}
		#endregion
		#endregion

		#region Metodos GUI
		#region Generales
		/// <summary>
		/// <para>Cuando cambia</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void visualListBoxHipnosis_SelectedIndexChanged(object sender, EventArgs e)// Cuando cambia
		{
			AbrirLogHipnosis(visualListBoxHipnosis.SelectedItem.ToString());
		}

		/// <summary>
		/// <para>Cuando cambia</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void visualListBoxInterpretar_SelectedIndexChanged(object sender, EventArgs e)// Cuando cambia
		{
			AbrirLogInterpretar(visualListBoxInterpretar.SelectedItem.ToString());
		}

		/// <summary>
		/// <para>Cuando cambia</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void visualListBoxRegresion_SelectedIndexChanged(object sender, EventArgs e)// Cuando cambia
		{
			AbrirLogRegresion(visualListBoxRegresion.SelectedItem.ToString());
		}

		/// <summary>
		/// <para>Cuando cambia</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void visualListBoxReiki_SelectedIndexChanged(object sender, EventArgs e)// Cuando cambia
		{
			AbrirLogReiki(visualListBoxReiki.SelectedItem.ToString());
		}

		/// <summary>
		/// <para>Cuando cambia</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void visualListBoxTetra_SelectedIndexChanged(object sender, EventArgs e)// Cuando cambia
		{
			AbrirLogTetra(visualListBoxTetra.SelectedItem.ToString());
		}
		#endregion

		#region Hipnosis
		/// <summary>
		/// <para>Cuando hay texto</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void richTextBoxHipnosis_TextChanged(object sender, EventArgs e)// Cuando hay texto
		{
			BtnGuardarHipnosis.Visible = true;
			BtnImprimirHipnosis.Visible = true;
		}

		/// <summary>
		/// <para>Para crear un nuevo log.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCrearHipnosis_Click(object sender, EventArgs e)// Para crear un nuevo log
		{
			richTextBoxHipnosis.Visible = true;
			isCreando = true;
		}

		/// <summary>
		/// <para>Guarda el documento hipnosis.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnGuardarHipnosis_Click(object sender, EventArgs e)// Guarda el documento hipnosis
		{
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			if (isCreando)
			{
				isCreando = false;
				txtUltimaConsulta.Text = dia + " (Hipnosis)";

				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlElement clientes = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				XmlNode nuevoCliente = doc.CreateElement("Cliente");

				XmlElement xid = doc.CreateElement("id");
				xid.InnerText = cliente.ID.ToString();
				nuevoCliente.AppendChild(xid);

				XmlElement xnom = doc.CreateElement("nombre");
				xnom.InnerText = cliente.Nombre;
				nuevoCliente.AppendChild(xnom);

				XmlElement xapell = doc.CreateElement("apellidos");
				xapell.InnerText = cliente.Apellidos;
				nuevoCliente.AppendChild(xapell);

				XmlElement xdni = doc.CreateElement("dni");
				xdni.InnerText = cliente.DNI;
				nuevoCliente.AppendChild(xdni);

				XmlElement xtele = doc.CreateElement("telefono");
				xtele.InnerText = cliente.Telefono;
				nuevoCliente.AppendChild(xtele);

				XmlElement xfecha = doc.CreateElement("fecha");
				xfecha.InnerText = cliente.Fecha;
				nuevoCliente.AppendChild(xfecha);

				XmlElement xdirecc = doc.CreateElement("direccion");
				xdirecc.InnerText = cliente.Direccion;
				nuevoCliente.AppendChild(xdirecc);

				XmlElement xultco = doc.CreateElement("ultconsulta");
				xultco.InnerText = txtUltimaConsulta.Text;
				nuevoCliente.AppendChild(xultco);

				foreach (XmlNode item in listaClientes)
				{
					if (item.FirstChild.InnerText == cliente.ID.ToString())
					{
						XmlNode nodo = item;
						clientes.ReplaceChild(nuevoCliente, nodo);
					}
				}

				doc.Save(usuarioActual.PathClientes);

				File.WriteAllText(rutaClienteHipnosis + "/" + dia + ".txt", richTextBoxHipnosis.Text);
				richTextBoxHipnosis.Clear();
				richTextBoxHipnosis.Visible = false;
				CargarHipnosis();
			}
			else
			{
				isCreando = false;
				txtUltimaConsulta.Text = dia + " (Hipnosis)";

				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlElement clientes = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				XmlNode nuevoCliente = doc.CreateElement("Cliente");

				XmlElement xid = doc.CreateElement("id");
				xid.InnerText = cliente.ID.ToString();
				nuevoCliente.AppendChild(xid);

				XmlElement xnom = doc.CreateElement("nombre");
				xnom.InnerText = cliente.Nombre;
				nuevoCliente.AppendChild(xnom);

				XmlElement xapell = doc.CreateElement("apellidos");
				xapell.InnerText = cliente.Apellidos;
				nuevoCliente.AppendChild(xapell);

				XmlElement xdni = doc.CreateElement("dni");
				xdni.InnerText = cliente.DNI;
				nuevoCliente.AppendChild(xdni);

				XmlElement xtele = doc.CreateElement("telefono");
				xtele.InnerText = cliente.Telefono;
				nuevoCliente.AppendChild(xtele);

				XmlElement xfecha = doc.CreateElement("fecha");
				xfecha.InnerText = cliente.Fecha;
				nuevoCliente.AppendChild(xfecha);

				XmlElement xdirecc = doc.CreateElement("direccion");
				xdirecc.InnerText = cliente.Direccion;
				nuevoCliente.AppendChild(xdirecc);

				XmlElement xultco = doc.CreateElement("ultconsulta");
				xultco.InnerText = txtUltimaConsulta.Text;
				nuevoCliente.AppendChild(xultco);

				foreach (XmlNode item in listaClientes)
				{
					if (item.FirstChild.InnerText == cliente.ID.ToString())
					{
						XmlNode nodo = item;
						clientes.ReplaceChild(nuevoCliente, nodo);
					}
				}

				doc.Save(usuarioActual.PathClientes);

				File.WriteAllText(rutaLectura, richTextBoxHipnosis.Text);
				richTextBoxHipnosis.Clear();
				richTextBoxHipnosis.Visible = false;
				CargarHipnosis();
			}
		}

		/// <summary>
		/// <para>Imprime el documento de hipnosis.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnImprimirHipnosis_Click(object sender, EventArgs e)// Imprime el documento de hipnosis
		{

		}
		#endregion

		#region Interpretar
		/// <summary>
		/// <para>Cuando hay texto</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void richTextBoxInterpretar_TextChanged(object sender, EventArgs e)// Cuando hay texto
		{
			BtnGuardarInterpretar.Visible = true;
			BtnImprimirInterpretar.Visible = true;
		}

		/// <summary>
		/// <para>Para crear un nuevo log.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCrearInterpretar_Click(object sender, EventArgs e)// Para crear un nuevo log
		{
			richTextBoxInterpretar.Visible = true;
			isCreando = true;
		}

		/// <summary>
		/// <para>Guarda el documento interpretar</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnGuardarInterpretar_Click(object sender, EventArgs e)// Guarda el documento interpretar
		{
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			if (isCreando)
			{
				isCreando = false;
				txtUltimaConsulta.Text = dia + " (Sueños)";

				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlElement clientes = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				XmlNode nuevoCliente = doc.CreateElement("Cliente");

				XmlElement xid = doc.CreateElement("id");
				xid.InnerText = cliente.ID.ToString();
				nuevoCliente.AppendChild(xid);

				XmlElement xnom = doc.CreateElement("nombre");
				xnom.InnerText = cliente.Nombre;
				nuevoCliente.AppendChild(xnom);

				XmlElement xapell = doc.CreateElement("apellidos");
				xapell.InnerText = cliente.Apellidos;
				nuevoCliente.AppendChild(xapell);

				XmlElement xdni = doc.CreateElement("dni");
				xdni.InnerText = cliente.DNI;
				nuevoCliente.AppendChild(xdni);

				XmlElement xtele = doc.CreateElement("telefono");
				xtele.InnerText = cliente.Telefono;
				nuevoCliente.AppendChild(xtele);

				XmlElement xfecha = doc.CreateElement("fecha");
				xfecha.InnerText = cliente.Fecha;
				nuevoCliente.AppendChild(xfecha);

				XmlElement xdirecc = doc.CreateElement("direccion");
				xdirecc.InnerText = cliente.Direccion;
				nuevoCliente.AppendChild(xdirecc);

				XmlElement xultco = doc.CreateElement("ultconsulta");
				xultco.InnerText = txtUltimaConsulta.Text;
				nuevoCliente.AppendChild(xultco);

				foreach (XmlNode item in listaClientes)
				{
					if (item.FirstChild.InnerText == cliente.ID.ToString())
					{
						XmlNode nodo = item;
						clientes.ReplaceChild(nuevoCliente, nodo);
					}
				}

				doc.Save(usuarioActual.PathClientes);

				File.WriteAllText(rutaClienteSueno + "/" + dia + ".txt", richTextBoxInterpretar.Text);
				richTextBoxInterpretar.Clear();
				richTextBoxInterpretar.Visible = false;
				CargarInterpretar();
			}
			else
			{
				isCreando = false;
				txtUltimaConsulta.Text = dia + " (Sueños)";

				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlElement clientes = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				XmlNode nuevoCliente = doc.CreateElement("Cliente");

				XmlElement xid = doc.CreateElement("id");
				xid.InnerText = cliente.ID.ToString();
				nuevoCliente.AppendChild(xid);

				XmlElement xnom = doc.CreateElement("nombre");
				xnom.InnerText = cliente.Nombre;
				nuevoCliente.AppendChild(xnom);

				XmlElement xapell = doc.CreateElement("apellidos");
				xapell.InnerText = cliente.Apellidos;
				nuevoCliente.AppendChild(xapell);

				XmlElement xdni = doc.CreateElement("dni");
				xdni.InnerText = cliente.DNI;
				nuevoCliente.AppendChild(xdni);

				XmlElement xtele = doc.CreateElement("telefono");
				xtele.InnerText = cliente.Telefono;
				nuevoCliente.AppendChild(xtele);

				XmlElement xfecha = doc.CreateElement("fecha");
				xfecha.InnerText = cliente.Fecha;
				nuevoCliente.AppendChild(xfecha);

				XmlElement xdirecc = doc.CreateElement("direccion");
				xdirecc.InnerText = cliente.Direccion;
				nuevoCliente.AppendChild(xdirecc);

				XmlElement xultco = doc.CreateElement("ultconsulta");
				xultco.InnerText = txtUltimaConsulta.Text;
				nuevoCliente.AppendChild(xultco);

				foreach (XmlNode item in listaClientes)
				{
					if (item.FirstChild.InnerText == cliente.ID.ToString())
					{
						XmlNode nodo = item;
						clientes.ReplaceChild(nuevoCliente, nodo);
					}
				}

				doc.Save(usuarioActual.PathClientes);

				File.WriteAllText(rutaLectura, richTextBoxInterpretar.Text);
				richTextBoxInterpretar.Clear();
				richTextBoxInterpretar.Visible = false;
				CargarInterpretar();
			}
		}

		/// <summary>
		/// <para>Imprime el documento de hipnosis.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnImprimirInterpretar_Click(object sender, EventArgs e)// Imprime el documento de hipnosis
		{

		}
		#endregion

		#region Regresion
		/// <summary>
		/// <para>Cuando hay texto</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void richTextBoxRegresion_TextChanged(object sender, EventArgs e)// Cuando hay texto
		{
			BtnGuardarRegresion.Visible = true;
			BtnImprimirRegresion.Visible = true;
		}

		/// <summary>
		/// <para>Para crear un nuevo log</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCrearRegresion_Click(object sender, EventArgs e)// Para crear un nuevo log
		{
			richTextBoxRegresion.Visible = true;
			isCreando = true;
		}

		/// <summary>
		/// <para>Guarda el documento regresion</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnGuardarRegresion_Click(object sender, EventArgs e)// Guarda el documento regresion
		{
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			if (isCreando)
			{
				isCreando = false;
				txtUltimaConsulta.Text = dia + " (Regresion)";

				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlElement clientes = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				XmlNode nuevoCliente = doc.CreateElement("Cliente");

				XmlElement xid = doc.CreateElement("id");
				xid.InnerText = cliente.ID.ToString();
				nuevoCliente.AppendChild(xid);

				XmlElement xnom = doc.CreateElement("nombre");
				xnom.InnerText = cliente.Nombre;
				nuevoCliente.AppendChild(xnom);

				XmlElement xapell = doc.CreateElement("apellidos");
				xapell.InnerText = cliente.Apellidos;
				nuevoCliente.AppendChild(xapell);

				XmlElement xdni = doc.CreateElement("dni");
				xdni.InnerText = cliente.DNI;
				nuevoCliente.AppendChild(xdni);

				XmlElement xtele = doc.CreateElement("telefono");
				xtele.InnerText = cliente.Telefono;
				nuevoCliente.AppendChild(xtele);

				XmlElement xfecha = doc.CreateElement("fecha");
				xfecha.InnerText = cliente.Fecha;
				nuevoCliente.AppendChild(xfecha);

				XmlElement xdirecc = doc.CreateElement("direccion");
				xdirecc.InnerText = cliente.Direccion;
				nuevoCliente.AppendChild(xdirecc);

				XmlElement xultco = doc.CreateElement("ultconsulta");
				xultco.InnerText = txtUltimaConsulta.Text;
				nuevoCliente.AppendChild(xultco);

				foreach (XmlNode item in listaClientes)
				{
					if (item.FirstChild.InnerText == cliente.ID.ToString())
					{
						XmlNode nodo = item;
						clientes.ReplaceChild(nuevoCliente, nodo);
					}
				}

				doc.Save(usuarioActual.PathClientes);

				File.WriteAllText(rutaClienteRegresion + "/" + dia + ".txt", richTextBoxRegresion.Text);
				richTextBoxRegresion.Clear();
				richTextBoxRegresion.Visible = false;
				CargarRegresion();
			}
			else
			{
				isCreando = false;
				txtUltimaConsulta.Text = dia + " (Regresion)";

				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlElement clientes = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				XmlNode nuevoCliente = doc.CreateElement("Cliente");

				XmlElement xid = doc.CreateElement("id");
				xid.InnerText = cliente.ID.ToString();
				nuevoCliente.AppendChild(xid);

				XmlElement xnom = doc.CreateElement("nombre");
				xnom.InnerText = cliente.Nombre;
				nuevoCliente.AppendChild(xnom);

				XmlElement xapell = doc.CreateElement("apellidos");
				xapell.InnerText = cliente.Apellidos;
				nuevoCliente.AppendChild(xapell);

				XmlElement xdni = doc.CreateElement("dni");
				xdni.InnerText = cliente.DNI;
				nuevoCliente.AppendChild(xdni);

				XmlElement xtele = doc.CreateElement("telefono");
				xtele.InnerText = cliente.Telefono;
				nuevoCliente.AppendChild(xtele);

				XmlElement xfecha = doc.CreateElement("fecha");
				xfecha.InnerText = cliente.Fecha;
				nuevoCliente.AppendChild(xfecha);

				XmlElement xdirecc = doc.CreateElement("direccion");
				xdirecc.InnerText = cliente.Direccion;
				nuevoCliente.AppendChild(xdirecc);

				XmlElement xultco = doc.CreateElement("ultconsulta");
				xultco.InnerText = txtUltimaConsulta.Text;
				nuevoCliente.AppendChild(xultco);

				foreach (XmlNode item in listaClientes)
				{
					if (item.FirstChild.InnerText == cliente.ID.ToString())
					{
						XmlNode nodo = item;
						clientes.ReplaceChild(nuevoCliente, nodo);
					}
				}

				doc.Save(usuarioActual.PathClientes);

				File.WriteAllText(rutaLectura, richTextBoxRegresion.Text);
				richTextBoxRegresion.Clear();
				richTextBoxRegresion.Visible = false;
				CargarRegresion();
			}
		}

		/// <summary>
		/// <para>Imprime el documento de hipnosis.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnImprimirRegresion_Click(object sender, EventArgs e)// Imprime el documento de hipnosis
		{

		}
		#endregion

		#region Reiki
		/// <summary>
		/// <para>Cuando hay texto</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void richTextBoxReiki_TextChanged(object sender, EventArgs e)// Cuando hay texto
		{
			BtnGuardarReiki.Visible = true;
			BtnImprimirReiki.Visible = true;
		}

		/// <summary>
		/// <para>Para crear un nuevo log</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCrearReiki_Click(object sender, EventArgs e)// Para crear un nuevo log
		{
			richTextBoxReiki.Visible = true;
			isCreando = true;
		}

		/// <summary>
		/// <para>Guarda el documento reiki</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnGuardarReiki_Click(object sender, EventArgs e)// Guarda el documento reiki
		{
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			if (isCreando)
			{
				isCreando = false;
				txtUltimaConsulta.Text = dia + " (Reiki)";

				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlElement clientes = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				XmlNode nuevoCliente = doc.CreateElement("Cliente");

				XmlElement xid = doc.CreateElement("id");
				xid.InnerText = cliente.ID.ToString();
				nuevoCliente.AppendChild(xid);

				XmlElement xnom = doc.CreateElement("nombre");
				xnom.InnerText = cliente.Nombre;
				nuevoCliente.AppendChild(xnom);

				XmlElement xapell = doc.CreateElement("apellidos");
				xapell.InnerText = cliente.Apellidos;
				nuevoCliente.AppendChild(xapell);

				XmlElement xdni = doc.CreateElement("dni");
				xdni.InnerText = cliente.DNI;
				nuevoCliente.AppendChild(xdni);

				XmlElement xtele = doc.CreateElement("telefono");
				xtele.InnerText = cliente.Telefono;
				nuevoCliente.AppendChild(xtele);

				XmlElement xfecha = doc.CreateElement("fecha");
				xfecha.InnerText = cliente.Fecha;
				nuevoCliente.AppendChild(xfecha);

				XmlElement xdirecc = doc.CreateElement("direccion");
				xdirecc.InnerText = cliente.Direccion;
				nuevoCliente.AppendChild(xdirecc);

				XmlElement xultco = doc.CreateElement("ultconsulta");
				xultco.InnerText = txtUltimaConsulta.Text;
				nuevoCliente.AppendChild(xultco);

				foreach (XmlNode item in listaClientes)
				{
					if (item.FirstChild.InnerText == cliente.ID.ToString())
					{
						XmlNode nodo = item;
						clientes.ReplaceChild(nuevoCliente, nodo);
					}
				}

				doc.Save(usuarioActual.PathClientes);

				File.WriteAllText(rutaClienteReiki + "/" + dia + ".txt", richTextBoxReiki.Text);
				richTextBoxReiki.Clear();
				richTextBoxReiki.Visible = false;
				CargarReiki();
			}
			else
			{
				isCreando = false;
				txtUltimaConsulta.Text = dia + " (Reiki)";

				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlElement clientes = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				XmlNode nuevoCliente = doc.CreateElement("Cliente");

				XmlElement xid = doc.CreateElement("id");
				xid.InnerText = cliente.ID.ToString();
				nuevoCliente.AppendChild(xid);

				XmlElement xnom = doc.CreateElement("nombre");
				xnom.InnerText = cliente.Nombre;
				nuevoCliente.AppendChild(xnom);

				XmlElement xapell = doc.CreateElement("apellidos");
				xapell.InnerText = cliente.Apellidos;
				nuevoCliente.AppendChild(xapell);

				XmlElement xdni = doc.CreateElement("dni");
				xdni.InnerText = cliente.DNI;
				nuevoCliente.AppendChild(xdni);

				XmlElement xtele = doc.CreateElement("telefono");
				xtele.InnerText = cliente.Telefono;
				nuevoCliente.AppendChild(xtele);

				XmlElement xfecha = doc.CreateElement("fecha");
				xfecha.InnerText = cliente.Fecha;
				nuevoCliente.AppendChild(xfecha);

				XmlElement xdirecc = doc.CreateElement("direccion");
				xdirecc.InnerText = cliente.Direccion;
				nuevoCliente.AppendChild(xdirecc);

				XmlElement xultco = doc.CreateElement("ultconsulta");
				xultco.InnerText = txtUltimaConsulta.Text;
				nuevoCliente.AppendChild(xultco);

				foreach (XmlNode item in listaClientes)
				{
					if (item.FirstChild.InnerText == cliente.ID.ToString())
					{
						XmlNode nodo = item;
						clientes.ReplaceChild(nuevoCliente, nodo);
					}
				}

				doc.Save(usuarioActual.PathClientes);

				File.WriteAllText(rutaLectura, richTextBoxReiki.Text);
				richTextBoxReiki.Clear();
				richTextBoxReiki.Visible = false;
				CargarReiki();
			}
		}

		/// <summary>
		/// <para>Imprime el documento de reiki</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnImprimirReiki_Click(object sender, EventArgs e)// Imprime el documento de reiki
		{

		}
		#endregion

		#region Tetra
		/// <summary>
		/// <para>Cuando hay texto</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void richTextBoxTetra_TextChanged(object sender, EventArgs e)// Cuando hay texto
		{
			BtnGuardarTetra.Visible = true;
			BtnImprimirTetra.Visible = true;
		}

		/// <summary>
		/// <para>Para crear un nuevo log</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCrearTetra_Click(object sender, EventArgs e)// Para crear un nuevo log
		{
			richTextBoxTetra.Visible = true;
			isCreando = true;
		}

		/// <summary>
		/// <para>Guarda el documento tetra</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnGuardarTetra_Click(object sender, EventArgs e)// Guarda el documento tetra
		{
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			if (isCreando)
			{
				isCreando = false;
				txtUltimaConsulta.Text = dia + " (Tetra)";

				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlElement clientes = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				XmlNode nuevoCliente = doc.CreateElement("Cliente");

				XmlElement xid = doc.CreateElement("id");
				xid.InnerText = cliente.ID.ToString();
				nuevoCliente.AppendChild(xid);

				XmlElement xnom = doc.CreateElement("nombre");
				xnom.InnerText = cliente.Nombre;
				nuevoCliente.AppendChild(xnom);

				XmlElement xapell = doc.CreateElement("apellidos");
				xapell.InnerText = cliente.Apellidos;
				nuevoCliente.AppendChild(xapell);

				XmlElement xdni = doc.CreateElement("dni");
				xdni.InnerText = cliente.DNI;
				nuevoCliente.AppendChild(xdni);

				XmlElement xtele = doc.CreateElement("telefono");
				xtele.InnerText = cliente.Telefono;
				nuevoCliente.AppendChild(xtele);

				XmlElement xfecha = doc.CreateElement("fecha");
				xfecha.InnerText = cliente.Fecha;
				nuevoCliente.AppendChild(xfecha);

				XmlElement xdirecc = doc.CreateElement("direccion");
				xdirecc.InnerText = cliente.Direccion;
				nuevoCliente.AppendChild(xdirecc);

				XmlElement xultco = doc.CreateElement("ultconsulta");
				xultco.InnerText = txtUltimaConsulta.Text;
				nuevoCliente.AppendChild(xultco);

				foreach (XmlNode item in listaClientes)
				{
					if (item.FirstChild.InnerText == cliente.ID.ToString())
					{
						XmlNode nodo = item;
						clientes.ReplaceChild(nuevoCliente, nodo);
					}
				}

				doc.Save(usuarioActual.PathClientes);

				File.WriteAllText(rutaClienteTetra + "/" + dia + ".txt", richTextBoxTetra.Text);
				richTextBoxTetra.Clear();
				richTextBoxTetra.Visible = false;
				CargarTetra();
			}
			else
			{
				isCreando = false;
				txtUltimaConsulta.Text = dia + " (Tetra)";

				XmlDocument doc = new XmlDocument();

				doc.Load(usuarioActual.PathClientes);

				XmlElement clientes = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				XmlNode nuevoCliente = doc.CreateElement("Cliente");

				XmlElement xid = doc.CreateElement("id");
				xid.InnerText = cliente.ID.ToString();
				nuevoCliente.AppendChild(xid);

				XmlElement xnom = doc.CreateElement("nombre");
				xnom.InnerText = cliente.Nombre;
				nuevoCliente.AppendChild(xnom);

				XmlElement xapell = doc.CreateElement("apellidos");
				xapell.InnerText = cliente.Apellidos;
				nuevoCliente.AppendChild(xapell);

				XmlElement xdni = doc.CreateElement("dni");
				xdni.InnerText = cliente.DNI;
				nuevoCliente.AppendChild(xdni);

				XmlElement xtele = doc.CreateElement("telefono");
				xtele.InnerText = cliente.Telefono;
				nuevoCliente.AppendChild(xtele);

				XmlElement xfecha = doc.CreateElement("fecha");
				xfecha.InnerText = cliente.Fecha;
				nuevoCliente.AppendChild(xfecha);

				XmlElement xdirecc = doc.CreateElement("direccion");
				xdirecc.InnerText = cliente.Direccion;
				nuevoCliente.AppendChild(xdirecc);

				XmlElement xultco = doc.CreateElement("ultconsulta");
				xultco.InnerText = txtUltimaConsulta.Text;
				nuevoCliente.AppendChild(xultco);

				foreach (XmlNode item in listaClientes)
				{
					if (item.FirstChild.InnerText == cliente.ID.ToString())
					{
						XmlNode nodo = item;
						clientes.ReplaceChild(nuevoCliente, nodo);
					}
				}

				doc.Save(usuarioActual.PathClientes);

				File.WriteAllText(rutaLectura, richTextBoxTetra.Text);
				richTextBoxTetra.Clear();
				richTextBoxTetra.Visible = false;
				CargarTetra();
			}
		}

		/// <summary>
		/// <para>Imprime el documento de tetra</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnImprimirTetra_Click(object sender, EventArgs e)// Imprime el documento de tetra
		{

		}
		#endregion

		#endregion

		private void BtnClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
