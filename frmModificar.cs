using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cu031ejercicio2
{
    public partial class frmModificar : Form
    {
        private frmPrincipal padre;
        int selectedRow;
        public frmModificar(frmPrincipal f)
        {
            InitializeComponent();
            padre = f;

            MostrarDatos();
        }

        public frmModificar(frmPrincipal f, int numero)
        {
            InitializeComponent();
            padre = f;

            MostrarDatos();

            selectedRow = numero;

            frmModificarNombreContacto.Text = padre.Agenda[selectedRow].Nombrecontacto;
            frmModificarNombre.Text = padre.Agenda[selectedRow].Nombre;
            frmModificarApellido1.Text = padre.Agenda[selectedRow].Apellido1;
            frmModificarApellido2.Text = padre.Agenda[selectedRow].Apellido2;
            frmModificarFechaNacimiento.Text = padre.Agenda[selectedRow].Fechadenacimiento;
            frmModificarDireccion.Text = padre.Agenda[selectedRow].Direccion;
            frmModificarLocalidad.Text = padre.Agenda[selectedRow].Localidad;
            frmModificarCodigoPostal.Text = padre.Agenda[selectedRow].Codigopostal;
            frmModificarProvincia.Text = padre.Agenda[selectedRow].Provincia;
            frmModificarTelefonoFijo.Text = padre.Agenda[selectedRow].Telefonofijo;
            frmModificarTelefonoMovil.Text = padre.Agenda[selectedRow].Telefonomovil;
            frmModificarOtroTelefono.Text = padre.Agenda[selectedRow].Otrostelefonos;
            frmModificarEmailPersonal.Text = padre.Agenda[selectedRow].Emailpersonal;
            frmModificarEmailTrabajo.Text = padre.Agenda[selectedRow].Emailtrabajo;

        }

        private void MostrarDatos()
        {

            frmModificarGridView.Rows.Clear();

            for (int i = 0; i < padre.Agenda.Count; i++)
            {
                frmModificarGridView.Rows.Add(padre.Agenda[i].Nombrecontacto, padre.Agenda[i].Nombre, padre.Agenda[i].Apellido1, padre.Agenda[i].Apellido2);
            }

        }

        private void frmModificarGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = e.RowIndex;

            frmModificarNombreContacto.Text = padre.Agenda[selectedRow].Nombrecontacto;
            frmModificarNombre.Text = padre.Agenda[selectedRow].Nombre;
            frmModificarApellido1.Text = padre.Agenda[selectedRow].Apellido1;
            frmModificarApellido2.Text = padre.Agenda[selectedRow].Apellido2;
            frmModificarFechaNacimiento.Text = padre.Agenda[selectedRow].Fechadenacimiento;
            frmModificarDireccion.Text = padre.Agenda[selectedRow].Direccion;
            frmModificarLocalidad.Text = padre.Agenda[selectedRow].Localidad;
            frmModificarCodigoPostal.Text = padre.Agenda[selectedRow].Codigopostal;
            frmModificarProvincia.Text = padre.Agenda[selectedRow].Provincia;
            frmModificarTelefonoFijo.Text = padre.Agenda[selectedRow].Telefonofijo;
            frmModificarTelefonoMovil.Text = padre.Agenda[selectedRow].Telefonomovil;
            frmModificarOtroTelefono.Text = padre.Agenda[selectedRow].Otrostelefonos;
            frmModificarEmailPersonal.Text = padre.Agenda[selectedRow].Emailpersonal;
            frmModificarEmailTrabajo.Text = padre.Agenda[selectedRow].Emailtrabajo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComprobarNombreContacto() == true)
            {
                Documento doc = new Documento();

                doc.Nombrecontacto = frmModificarNombreContacto.Text;
                doc.Nombre = frmModificarNombre.Text;
                doc.Apellido1 = frmModificarApellido1.Text;
                doc.Apellido2 = frmModificarApellido2.Text;
                doc.Fechadenacimiento = frmModificarFechaNacimiento.Text;
                doc.Direccion = frmModificarDireccion.Text;
                doc.Localidad = frmModificarLocalidad.Text;
                doc.Codigopostal = frmModificarCodigoPostal.Text;
                doc.Provincia = frmModificarProvincia.Text;
                doc.Telefonofijo = frmModificarTelefonoFijo.Text;
                doc.Telefonomovil = frmModificarTelefonoMovil.Text;
                doc.Otrostelefonos = frmModificarOtroTelefono.Text;
                doc.Emailpersonal = frmModificarEmailPersonal.Text;
                doc.Emailtrabajo = frmModificarEmailTrabajo.Text;


                padre.guardarModificado(doc, selectedRow);

                MostrarDatos();
            }

        }

        private void frmModificarBtnVolver_Click(object sender, EventArgs e)
        {
            Close();
            padre.ActivarBotones();
            padre.MostrarDatos();
        }

        private bool ComprobarNombreContacto()
        {
            if (frmModificarNombreContacto.Text.Trim() != String.Empty)
            {
                frmModificarErrorProvider.SetError(frmModificarNombreContacto, "");
                return true;
            }
            else
            {
                frmModificarErrorProvider.SetError(frmModificarNombreContacto, "El Nombre de contacto no puede estar vacío");
                frmModificarNombreContacto.Focus();
                return false;

            }

        }
    }
}
