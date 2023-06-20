using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cu031ejercicio2
{
    public partial class frmBuscar : Form
    {
        private frmPrincipal padre;
        ArrayList encontrados1 = new ArrayList();
        ArrayList encontrados2 = new ArrayList();
        ArrayList encontrados3 = new ArrayList();
        ArrayList totalencontrados = new ArrayList();
        ArrayList numeroindicegrid = new ArrayList();


        string[] DatosCombobox = { "Nombre Contacto", "Nombre", "Primer Apellido", "Segundo Apellido"
                , "Fecha de Nacimiento", "Dirección", "Localidad", "Código Postal", "Provincia", "Teléfono fijo"
                , "Teléfono móvil", "Otros teléfonos", "Email personal", "Email trabajo"};

        string[] MetodosDocumento = { "Nombrecontacto", "Nombre", "Apellido1", "Apellido2", "Fechadenacimiento", "Direccion"
                , "Localidad", "Codigopostal", "Provincia", "Telefonofijo", "Telefonomovil", "Otrostelefonos", "Emailpersonal", "Emailtrabajo"};

        public frmBuscar(frmPrincipal f)
        {
            InitializeComponent();
            padre = f;

            FillCombobox();
        }

        private void FillCombobox()
        {
            for (int i = 0; i < DatosCombobox.Length; i++)
            {
                frmBuscarComboBox1.Items.Add(DatosCombobox[i]);
                frmBuscarComboBox2.Items.Add(DatosCombobox[i]);
                frmBuscarComboBox3.Items.Add(DatosCombobox[i]);
            }
            
        }

        private void frmBuscarBtnBuscar_Click(object sender, EventArgs e)
        {
            numeroindicegrid.Clear();
            bool combobox1 = false;
            bool combobox2 = false;
            bool combobox3 = false;
            if (frmBuscarComboBox1.SelectedIndex != -1)
            {
                combobox1 = true;
            }
            if (frmBuscarComboBox2.SelectedIndex != -1)
            {
                combobox2 = true;
            }
            if (frmBuscarComboBox3.SelectedIndex != -1)
            {
                combobox3 = true;
            }

            int contador = 0;
            if (combobox1) contador++;
            if (combobox2) contador++;
            if (combobox3) contador++;

            if (contador == 1)
            {
                if (frmBuscarComboBox1.SelectedIndex != -1)
                {
                    frmBuscarGridView.Rows.Clear();
                    BuscarComboBox1();

                    for (int i = 0; i < (encontrados1.Count); i++)
                    {
                        MostrarDato(int.Parse(encontrados1[i].ToString()));
                    }
                    numeroindicegrid.AddRange(encontrados1);
                }
                else if(frmBuscarComboBox2.SelectedIndex != -1)
                {
                    frmBuscarGridView.Rows.Clear();
                    BuscarComboBox2();

                    for (int i = 0; i < (encontrados2.Count); i++)
                    {
                        MostrarDato(int.Parse(encontrados2[i].ToString()));
                    }
                    numeroindicegrid.AddRange(encontrados2);
                }
                else
                {
                    frmBuscarGridView.Rows.Clear();
                    BuscarComboBox3();

                    for (int i = 0; i < (encontrados3.Count); i++)
                    {
                        MostrarDato(int.Parse(encontrados3[i].ToString()));
                    }
                    numeroindicegrid.AddRange(encontrados3);
                }

            }
            if(contador > 1)
            {
                if (combobox1) BuscarComboBox1();
                if (combobox2) BuscarComboBox2();
                if (combobox3) BuscarComboBox3();
                totalencontrados.AddRange(encontrados1);
                totalencontrados.AddRange(encontrados2);
                totalencontrados.AddRange(encontrados2);

                HashSet<int> numerosEncontrados = new HashSet<int>();
                ArrayList numerosRepetidos = new ArrayList();

                foreach (int numero in totalencontrados)
                {
                    if (!numerosEncontrados.Add(numero))
                    {
                        numerosRepetidos.Add(numero);
                    }
                }

                frmBuscarGridView.Rows.Clear();
                for (int i = 0; i < (numerosRepetidos.Count/2); i++)
                {
                    MostrarDato(int.Parse(numerosRepetidos[i].ToString()));
                }

                numeroindicegrid.AddRange(numerosRepetidos);
            }




            encontrados1.Clear();
            encontrados2.Clear();
            encontrados3.Clear();
            totalencontrados.Clear();
            combobox1 = false;
            combobox2 = false;
            combobox3 = false;
            contador = 0;
        }

        private void BuscarComboBox1()
        {
            int index = frmBuscarComboBox1.SelectedIndex;
            string metodoSeleccionado = MetodosDocumento[index];

            for (int i = 0; i < (padre.NumeroElementos()); i++)
            {
                var doc = padre.DameDocumento(i);
                Type tipo = doc.GetType();
                PropertyInfo propiedad = tipo.GetProperty(metodoSeleccionado);
                if (propiedad != null)
                {
                    var resultado = propiedad.GetValue(doc);
                    if (resultado.ToString() == frmBuscarTextBox1.Text)
                    {
                        encontrados1.Add(i);
                    }
                }
            }
        }

        private void BuscarComboBox2()
        {
            int index = frmBuscarComboBox2.SelectedIndex;
            string metodoSeleccionado = MetodosDocumento[index];

            for (int i = 0; i < (padre.NumeroElementos()); i++)
            {
                var doc = padre.DameDocumento(i);
                Type tipo = doc.GetType();
                PropertyInfo propiedad = tipo.GetProperty(metodoSeleccionado);
                if (propiedad != null)
                {
                    var resultado = propiedad.GetValue(doc);
                    if (resultado.ToString() == frmBuscarTextBox2.Text)
                    {
                        encontrados2.Add(i);
                    }
                }
            }
        }

        private void BuscarComboBox3()
        {
            int index = frmBuscarComboBox3.SelectedIndex;
            string metodoSeleccionado = MetodosDocumento[index];

            for (int i = 0; i < (padre.NumeroElementos()); i++)
            {
                var doc = padre.DameDocumento(i);
                Type tipo = doc.GetType();
                PropertyInfo propiedad = tipo.GetProperty(metodoSeleccionado);
                if (propiedad != null)
                {
                    var resultado = propiedad.GetValue(doc);
                    if (resultado.ToString() == frmBuscarTextBox3.Text)
                    {
                        encontrados3.Add(i);
                    }
                }
            }
        }



        private void MostrarDato(int idx)
        {
            frmBuscarGridView.Rows.Add(padre.Agenda[idx].Nombrecontacto, padre.Agenda[idx].Nombre, padre.Agenda[idx].Apellido1, padre.Agenda[idx].Apellido2);
        }

        private void frmBuscarLimpiar_Click(object sender, EventArgs e)
        {
            frmBuscarGridView.Rows.Clear();
            frmBuscarComboBox1.SelectedIndex = -1;
            frmBuscarComboBox2.SelectedIndex = -1;
            frmBuscarComboBox3.SelectedIndex = -1;
            frmBuscarTextBox1.Clear();
            frmBuscarTextBox2.Clear();
            frmBuscarTextBox3.Clear();

        }

        private void frmBuscarGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //selectedRow = e.RowIndex;
            int numero = Convert.ToInt32(numeroindicegrid[e.RowIndex]);
            Close();
            padre.BuscarModificar(numero);


        }
    }
}
