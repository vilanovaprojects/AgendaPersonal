using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Serialization;
using System.Reflection;

namespace cu031ejercicio2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPrincipal());
        }
    }

    public class TotalAgenda
    {
        ArrayList documentos = new ArrayList();

        public int Count 
        {
            get { return documentos.Count; }    
        }

        public void BorrarAgenda()
        {
            documentos.Clear();
        }

        public Documento this[int idx]
        {
            get
            {
                if (idx >= this.documentos.Count || idx < 0)
                    throw new Exception("No se encuentra en la lista");
                else
                    return (Documento)this.documentos[idx];
            }
            set
            {
                if (idx > this.documentos.Count || idx < 0)
                    throw new Exception("No se puede asignar a este elemento");
                else
                {
                    if (value == null)
                        this.documentos.Remove(this.documentos[idx]);
                    else
                        this.documentos.Add(value);
                }
            }
        }
        public void Substituirpor (Documento doc, int idx)
        {
            documentos[idx] = doc;
        }






        public bool Guardar(string filename, TotalAgenda agenda)
        {

            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(TotalAgenda));
                Stream st = new FileStream(filename, FileMode.Create);

                serializador.Serialize(st, agenda);
                st.Close();
                st.Dispose();

                return true;
            }
            catch { return false; }  //si hay algún error a la hora de guardar devolvemos false
        }

        public static ArrayList Cargar(string filename) 
        {
            try
            { 

                XmlSerializer desserializador = new XmlSerializer (typeof(ArrayList), new Type[] { typeof(Documento) });
                FileStream st = new FileStream(filename, FileMode.Open);
                ArrayList lista =(ArrayList)desserializador.Deserialize(st);
                st.Close ();
                st.Dispose();
 
                    return lista;

            }
            catch { return null; }
        }











    }

    public class Documento
    {

        private string nombrecontacto;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string fechadenacimiento;
        private string direccion;
        private string localidad;
        private string codigopostal;
        private string provincia;
        private string telefonofijo;
        private string telefonomovil;
        private string otrostelefonos;
        private string emailpersonal;
        private string emailtrabajo;


        public Documento()
        {
            nombrecontacto = "";
            nombre = "";
            apellido1 = "";
            apellido2 = "";
            fechadenacimiento = "";
            direccion = "";
            localidad = "";
            codigopostal = "";
            provincia = "";
            telefonofijo = "";
            telefonomovil = "";
            otrostelefonos = "";
            emailpersonal = "";
            emailtrabajo = "";

    }

        public Documento(string nombrecontacto, string nombre, string apellido1, string apellido2)
        {
            this.nombrecontacto = nombrecontacto;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
        }
        public string Nombrecontacto
        {
            get { return this.nombrecontacto; }
            set { this.nombrecontacto = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido1
        {
            get { return this.apellido1; }
            set { this.apellido1 = value; }
        }
        public string Apellido2
        {
            get { return this.apellido2; }
            set { this.apellido2 = value; }
        }
        public string Fechadenacimiento
        {
            get { return this.fechadenacimiento; }
            set { this.fechadenacimiento = value; }
        }
        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        public string Localidad
        {
            get { return this.localidad; }
            set { this.localidad = value; }
        }
        public string Codigopostal
        {
            get { return this.codigopostal; }
            set { this.codigopostal = value; }
        }
        public string Provincia
        {
            get { return this.provincia; }
            set { this.provincia = value; }
        }
        public string Telefonofijo
        {
            get { return this.telefonofijo; }
            set { this.telefonofijo = value; }
        }
        public string Telefonomovil
        {
            get { return this.telefonomovil; }
            set { this.telefonomovil = value; }
        }
        public string Otrostelefonos
        {
            get { return this.otrostelefonos; }
            set { this.otrostelefonos = value; }
        }
        public string Emailpersonal
        {
            get { return this.emailpersonal; }
            set { this.emailpersonal = value; }
        }
        public string Emailtrabajo
        {
            get { return this.emailtrabajo; }
            set { this.emailtrabajo = value; }
        }






    }
}