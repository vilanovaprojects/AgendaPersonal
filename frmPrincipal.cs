using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;


namespace cu031ejercicio2
{
    public partial class frmPrincipal : Form
    {
        TotalAgenda agenda;
        string filename;
        string[] registrosejemplo;
        string[] registrossss;
        string[] celdas;
        public frmPrincipal()
        {
            InitializeComponent();
            agenda = new TotalAgenda();

        }

        public TotalAgenda Agenda
        {
            get { return agenda; }
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void menuAlta_Click(object sender, EventArgs e)
        {
            frmAlta f = new frmAlta(this);
            f.MdiParent = this;
            f.Show();

            DesactivarBotones();
        }
        private void menuModificar_Click(object sender, EventArgs e)
        {
            frmModificar g = new frmModificar(this);
            g.MdiParent = this;
            g.Show();

            DesactivarBotones();
        }
        private void menuEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar y = new frmEliminar(this);
            y.MdiParent = this;
            y.Show();

            DesactivarBotones();
        }
        private void menuBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar w = new frmBuscar(this);
            w.ShowDialog();

        }

        /*----------------------------------------   DESACTIVAR ACTIVAR BOTONES MENU  -----------------------------------------------------*/
        private void DesactivarBotones()
        {
            menuAlta.Enabled = false;
            menuModificar.Enabled = false;
            menuEliminar.Enabled = false;
            menuBuscar.Enabled = false;
            menuSalir.Enabled = false;
            menuArchivo.Enabled = false;
            frmPrincipalPanel.Visible = false;
        }
        public void ActivarBotones()
        {
            menuAlta.Enabled = true;
            menuModificar.Enabled = true;
            menuEliminar.Enabled = true;
            menuBuscar.Enabled = true;
            menuSalir.Enabled = true;
            menuArchivo.Enabled = true;
            frmPrincipalPanel.Visible = true;
        }
        /*----------------------------------------   DESACTIVAR ACTIVAR BOTONES MENU  -----------------------------------------------------*/



        public void guardarAlta(Documento doc)
        {
            agenda[agenda.Count] = doc;
        }

        public void guardarModificado(Documento doc, int idx)
        {
            agenda.Substituirpor(doc, idx);
        }

        public void Eliminar(int idx)
        {
            agenda[idx] = null;
        }

        public Documento DameDocumento (int idx)
        {
            return agenda[idx];
        }

        public int NumeroElementos()
        {
            return agenda.Count;
        }

        public void BuscarModificar(int numero)
        {
            frmModificar g = new frmModificar(this, numero);
            g.MdiParent = this;
            g.Show();

            DesactivarBotones();
        }

        public void MostrarDatos()
        {

            frmPrincipalGridView.Rows.Clear();

            for (int i = 0; i < agenda.Count; i++)
            {
                frmPrincipalGridView.Rows.Add(agenda[i].Nombrecontacto, agenda[i].Nombre, agenda[i].Apellido1, agenda[i].Apellido2);
            }

        }

        private void menuArchivoSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        /*--------------------------------------------   GUARDAR  -----------------------------------------------------------------*/
        private void menuArchivoGuardar_Click(object sender, EventArgs e)
        {
            if (Guardar() == DialogResult.Cancel)
            {
                MessageBox.Show(this, "No se ha podido guardar el archivo");
            }
        }

        private DialogResult Guardar() //Si se guarda bien devolverá Dialogresult.OK
        {
            if (filename != null)
            {
                if (Guardar(filename))
                    return DialogResult.OK;
                else
                    return DialogResult.Cancel;
            }
            else
                return GuardarComo();
        }
        bool Guardar(string filename)
        {
            try
            {
                ArrayList lista = new ArrayList();

                for (int i = 0; i < agenda.Count; i++)
                {
                    lista.Add(agenda[i]);
                }

                XmlSerializer serializador = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Documento) });
                using (FileStream st = new FileStream(filename, FileMode.Create))
                {
                    serializador.Serialize(st, lista);
                }

                return true;
            }
            catch { return false; }
        }
        /*--------------------------------------------   GUARDAR  -----------------------------------------------------------------*/



        /*--------------------------------------------   GUARDAR COMO -----------------------------------------------------------------*/
        private void frmPrincipalGuardarComo_Click(object sender, EventArgs e)
        {
            if (GuardarComo() == DialogResult.OK)
            {
                MessageBox.Show(this, "Archivo guardado correctamente");
            }
        }
        private DialogResult GuardarComo()
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                ArrayList lista = new ArrayList();

                filename = dlgSave.FileName;

                for (int i = 0; i < agenda.Count; i++)
                {
                    lista.Add(agenda[i]);
                }

                XmlSerializer serializador = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Documento) });
                using (FileStream st = new FileStream(filename, FileMode.Create))
                {
                    serializador.Serialize(st, lista);
                }
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
        /*--------------------------------------------   GUARDAR COMO -----------------------------------------------------------------*/


        /*---------------------------------------------   ABRIR  -------------------------------------------------------------------*/
        private void frmPrincipalAbrir_Click(object sender, EventArgs e)
        {
            
            ArrayList lista = new ArrayList();

            if (dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                filename = dlgAbrir.FileName;

                lista = TotalAgenda.Cargar(filename);
                if (agenda == null) 
                    MessageBox.Show(this, "HA OCURRIDO UN ERROR AL CARGAR");


                CargarDatos(lista);

                MostrarDatos();
            }
        }

        private void CargarDatos(ArrayList lista)
        {
            TotalAgenda AgendaNueva = new TotalAgenda();

            for (int i = 0; i < lista.Count; i++)
            {
                AgendaNueva[AgendaNueva.Count] = (Documento)lista[i];

            }
            agenda = AgendaNueva;

        }
        /*---------------------------------------------   ABRIR  -------------------------------------------------------------------*/





        /*--------------------------------------------Cargar Ejemplos--------------------------------------------------------------------*/
        private void CargarEjemplos()
        {
            agenda.BorrarAgenda();

            string listaderegistros = Properties.Resources.registros2.ToString();
            registrosejemplo = listaderegistros.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < registrosejemplo.Length; i++)
            {
                Documento documento = new Documento();

                string registro = registrosejemplo[i].ToString();

                celdas = registro.Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

                for( int j = 0; j < celdas.Length; j++)
                {
                    switch (j)
                    {
                        case 0:
                            documento.Nombrecontacto = celdas[j];
                            break;
                        case 1:
                            documento.Nombre = celdas[j];
                            break;
                        case 2:
                            documento.Apellido1 = celdas[j];
                            break;
                        case 3:
                            documento.Apellido2 = celdas[j];
                            break;
                        case 4:
                            documento.Fechadenacimiento = celdas[j];
                            break;
                        case 5:
                            documento.Direccion = celdas[j];
                            break;
                        case 6:
                            documento.Localidad = celdas[j];
                            break;
                        case 7:
                            documento.Codigopostal = celdas[j];
                            break;
                        case 8:
                            documento.Provincia = celdas[j];
                            break;
                        case 9:
                            documento.Telefonofijo = celdas[j];
                            break;
                        case 10:
                            documento.Telefonomovil = celdas[j];
                            break;
                        case 11:
                            documento.Otrostelefonos = celdas[j];
                            break;
                        case 12:
                            documento.Emailpersonal = celdas[j];
                            break;
                        case 13:
                            documento.Emailtrabajo = celdas[j];
                            break;

                    }
                }
                guardarAlta(documento);
            }
            MostrarDatos();
        }
        private void menuArchivoCargarEjemplo_Click(object sender, EventArgs e)
        {
            CargarEjemplos();
        }
        /*--------------------------------------------Cargar Ejemplos--------------------------------------------------------------------*/




    }
}