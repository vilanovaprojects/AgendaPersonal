using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace cu031ejercicio2
{
    public partial class frmAlta : Form
    {
        private frmPrincipal padre;

        public frmAlta(frmPrincipal f)
        {
            InitializeComponent();
            padre = f;
        }

        private void frmAltaBtnGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarNombreContacto() == true)
            {
                Documento doc = new Documento();

                doc.Nombrecontacto = frmAltaNombreContacto.Text;
                doc.Nombre = frmAltaNombre.Text;
                doc.Apellido1 = frmAltaApellido1.Text;
                doc.Apellido2 = frmAltaApellido2.Text;
                doc.Fechadenacimiento = frmAltaFechaNacimiento.Text;
                doc.Direccion = frmAltaDireccion.Text;
                doc.Localidad = frmAltaLocalidad.Text;
                doc.Codigopostal = frmAltaCodigoPostal.Text;
                doc.Provincia = frmAltaProvincia.Text;
                doc.Telefonofijo = frmAltaTelefonoFijo.Text;
                doc.Telefonomovil = frmAltaTelefonoMovil.Text;
                doc.Otrostelefonos = frmAltaOtroTelefono.Text;
                doc.Emailpersonal = frmAltaEmailPersonal.Text;
                doc.Emailtrabajo = frmAltaEmailTrabajo.Text;

                padre.guardarAlta(doc);
                Close();
                padre.ActivarBotones();
                padre.MostrarDatos();
            }
            


        }

        private void frmAltaBtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            padre.ActivarBotones();
        }
        

        private bool ComprobarNombreContacto()
        {
            if (frmAltaNombreContacto.Text.Trim() != String.Empty)   
            {
                frmAltaErrorProvider.SetError(frmAltaNombreContacto, "");
                return true;
            }
            else
            {
                frmAltaErrorProvider.SetError(frmAltaNombreContacto, "Debe introducir un Nombre de contacto");
                frmAltaNombreContacto.Focus();
                return false;

            }

        }
    }
}
