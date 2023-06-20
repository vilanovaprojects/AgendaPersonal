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
    public partial class frmEliminar : Form
    {
        frmPrincipal padre;
        int selectedRow;
        public frmEliminar(frmPrincipal f)
        {
            InitializeComponent();
            padre = f;

            MostrarDatos();
        }
        private void MostrarDatos()
        {

            frmEliminarGridView.Rows.Clear();

            for (int i = 0; i < padre.Agenda.Count; i++)
            {
                frmEliminarGridView.Rows.Add(padre.Agenda[i].Nombrecontacto, padre.Agenda[i].Nombre, padre.Agenda[i].Apellido1, padre.Agenda[i].Apellido2);
            }

        }

        private void frmEliminarGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void frmEliminarBtnEliminar_Click(object sender, EventArgs e)
        {
            padre.Eliminar(selectedRow);

            MostrarDatos();
        }

        private void frmModificarBtnVolver_Click(object sender, EventArgs e)
        {
            Close();
            padre.ActivarBotones();
            padre.MostrarDatos();
        }
    }
}
