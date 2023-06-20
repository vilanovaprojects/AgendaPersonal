namespace cu031ejercicio2
{
    partial class frmModificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.frmModificarGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frmModificarOtroTelefono = new System.Windows.Forms.TextBox();
            this.frmModificarEmailTrabajo = new System.Windows.Forms.TextBox();
            this.frmModificarEmailPersonal = new System.Windows.Forms.TextBox();
            this.frmModificarTelefonoMovil = new System.Windows.Forms.TextBox();
            this.frmModificarTelefonoFijo = new System.Windows.Forms.TextBox();
            this.frmModificarProvincia = new System.Windows.Forms.TextBox();
            this.frmModificarCodigoPostal = new System.Windows.Forms.TextBox();
            this.frmModificarNombreContacto = new System.Windows.Forms.TextBox();
            this.frmModificarLocalidad = new System.Windows.Forms.TextBox();
            this.frmModificarDireccion = new System.Windows.Forms.TextBox();
            this.frmModificarFechaNacimiento = new System.Windows.Forms.TextBox();
            this.frmModificarApellido2 = new System.Windows.Forms.TextBox();
            this.frmModificarApellido1 = new System.Windows.Forms.TextBox();
            this.frmModificarNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.frmModificarBtnModificar = new System.Windows.Forms.Button();
            this.frmModificarBtnVolver = new System.Windows.Forms.Button();
            this.frmModificarErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.frmModificarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmModificarErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // frmModificarGridView
            // 
            this.frmModificarGridView.AllowUserToAddRows = false;
            this.frmModificarGridView.AllowUserToDeleteRows = false;
            this.frmModificarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmModificarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.frmModificarGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.frmModificarGridView.Location = new System.Drawing.Point(75, 58);
            this.frmModificarGridView.Name = "frmModificarGridView";
            this.frmModificarGridView.ReadOnly = true;
            this.frmModificarGridView.RowTemplate.Height = 25;
            this.frmModificarGridView.Size = new System.Drawing.Size(690, 218);
            this.frmModificarGridView.TabIndex = 0;
            this.frmModificarGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.frmModificarGridView_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nombre Contacto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Primer Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Segundo Apellido";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmModificarOtroTelefono
            // 
            this.frmModificarOtroTelefono.Location = new System.Drawing.Point(610, 437);
            this.frmModificarOtroTelefono.Name = "frmModificarOtroTelefono";
            this.frmModificarOtroTelefono.Size = new System.Drawing.Size(201, 23);
            this.frmModificarOtroTelefono.TabIndex = 51;
            // 
            // frmModificarEmailTrabajo
            // 
            this.frmModificarEmailTrabajo.Location = new System.Drawing.Point(610, 497);
            this.frmModificarEmailTrabajo.Name = "frmModificarEmailTrabajo";
            this.frmModificarEmailTrabajo.Size = new System.Drawing.Size(201, 23);
            this.frmModificarEmailTrabajo.TabIndex = 55;
            // 
            // frmModificarEmailPersonal
            // 
            this.frmModificarEmailPersonal.Location = new System.Drawing.Point(610, 467);
            this.frmModificarEmailPersonal.Name = "frmModificarEmailPersonal";
            this.frmModificarEmailPersonal.Size = new System.Drawing.Size(201, 23);
            this.frmModificarEmailPersonal.TabIndex = 53;
            // 
            // frmModificarTelefonoMovil
            // 
            this.frmModificarTelefonoMovil.Location = new System.Drawing.Point(610, 407);
            this.frmModificarTelefonoMovil.Name = "frmModificarTelefonoMovil";
            this.frmModificarTelefonoMovil.Size = new System.Drawing.Size(201, 23);
            this.frmModificarTelefonoMovil.TabIndex = 49;
            // 
            // frmModificarTelefonoFijo
            // 
            this.frmModificarTelefonoFijo.Location = new System.Drawing.Point(610, 377);
            this.frmModificarTelefonoFijo.Name = "frmModificarTelefonoFijo";
            this.frmModificarTelefonoFijo.Size = new System.Drawing.Size(201, 23);
            this.frmModificarTelefonoFijo.TabIndex = 47;
            // 
            // frmModificarProvincia
            // 
            this.frmModificarProvincia.Location = new System.Drawing.Point(610, 347);
            this.frmModificarProvincia.Name = "frmModificarProvincia";
            this.frmModificarProvincia.Size = new System.Drawing.Size(201, 23);
            this.frmModificarProvincia.TabIndex = 45;
            // 
            // frmModificarCodigoPostal
            // 
            this.frmModificarCodigoPostal.Location = new System.Drawing.Point(610, 317);
            this.frmModificarCodigoPostal.Name = "frmModificarCodigoPostal";
            this.frmModificarCodigoPostal.Size = new System.Drawing.Size(201, 23);
            this.frmModificarCodigoPostal.TabIndex = 43;
            // 
            // frmModificarNombreContacto
            // 
            this.frmModificarNombreContacto.Location = new System.Drawing.Point(194, 317);
            this.frmModificarNombreContacto.Name = "frmModificarNombreContacto";
            this.frmModificarNombreContacto.Size = new System.Drawing.Size(201, 23);
            this.frmModificarNombreContacto.TabIndex = 29;
            // 
            // frmModificarLocalidad
            // 
            this.frmModificarLocalidad.Location = new System.Drawing.Point(194, 497);
            this.frmModificarLocalidad.Name = "frmModificarLocalidad";
            this.frmModificarLocalidad.Size = new System.Drawing.Size(201, 23);
            this.frmModificarLocalidad.TabIndex = 41;
            // 
            // frmModificarDireccion
            // 
            this.frmModificarDireccion.Location = new System.Drawing.Point(194, 467);
            this.frmModificarDireccion.Name = "frmModificarDireccion";
            this.frmModificarDireccion.Size = new System.Drawing.Size(201, 23);
            this.frmModificarDireccion.TabIndex = 39;
            // 
            // frmModificarFechaNacimiento
            // 
            this.frmModificarFechaNacimiento.Location = new System.Drawing.Point(194, 437);
            this.frmModificarFechaNacimiento.Name = "frmModificarFechaNacimiento";
            this.frmModificarFechaNacimiento.Size = new System.Drawing.Size(201, 23);
            this.frmModificarFechaNacimiento.TabIndex = 37;
            // 
            // frmModificarApellido2
            // 
            this.frmModificarApellido2.Location = new System.Drawing.Point(194, 407);
            this.frmModificarApellido2.Name = "frmModificarApellido2";
            this.frmModificarApellido2.Size = new System.Drawing.Size(201, 23);
            this.frmModificarApellido2.TabIndex = 35;
            // 
            // frmModificarApellido1
            // 
            this.frmModificarApellido1.Location = new System.Drawing.Point(194, 377);
            this.frmModificarApellido1.Name = "frmModificarApellido1";
            this.frmModificarApellido1.Size = new System.Drawing.Size(201, 23);
            this.frmModificarApellido1.TabIndex = 33;
            // 
            // frmModificarNombre
            // 
            this.frmModificarNombre.Location = new System.Drawing.Point(194, 347);
            this.frmModificarNombre.Name = "frmModificarNombre";
            this.frmModificarNombre.Size = new System.Drawing.Size(201, 23);
            this.frmModificarNombre.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 54;
            this.label11.Text = "Email Trabajo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 52;
            this.label12.Text = "Email Personal:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 50;
            this.label13.Text = "Otros Teléfonos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(440, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 48;
            this.label14.Text = "Teléfono Móvil:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(440, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 15);
            this.label15.TabIndex = 46;
            this.label15.Text = "Teléfono Fijo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(440, 350);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "Provincia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Código Postal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Localidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Segundo Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Primer Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre del Contacto:";
            // 
            // frmModificarBtnModificar
            // 
            this.frmModificarBtnModificar.Location = new System.Drawing.Point(262, 561);
            this.frmModificarBtnModificar.Name = "frmModificarBtnModificar";
            this.frmModificarBtnModificar.Size = new System.Drawing.Size(296, 36);
            this.frmModificarBtnModificar.TabIndex = 56;
            this.frmModificarBtnModificar.Text = "Modificar";
            this.frmModificarBtnModificar.UseVisualStyleBackColor = true;
            this.frmModificarBtnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmModificarBtnVolver
            // 
            this.frmModificarBtnVolver.Location = new System.Drawing.Point(12, 12);
            this.frmModificarBtnVolver.Name = "frmModificarBtnVolver";
            this.frmModificarBtnVolver.Size = new System.Drawing.Size(75, 23);
            this.frmModificarBtnVolver.TabIndex = 57;
            this.frmModificarBtnVolver.Text = "Volver";
            this.frmModificarBtnVolver.UseVisualStyleBackColor = true;
            this.frmModificarBtnVolver.Click += new System.EventHandler(this.frmModificarBtnVolver_Click);
            // 
            // frmModificarErrorProvider
            // 
            this.frmModificarErrorProvider.ContainerControl = this;
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 670);
            this.ControlBox = false;
            this.Controls.Add(this.frmModificarBtnVolver);
            this.Controls.Add(this.frmModificarBtnModificar);
            this.Controls.Add(this.frmModificarOtroTelefono);
            this.Controls.Add(this.frmModificarEmailTrabajo);
            this.Controls.Add(this.frmModificarEmailPersonal);
            this.Controls.Add(this.frmModificarTelefonoMovil);
            this.Controls.Add(this.frmModificarTelefonoFijo);
            this.Controls.Add(this.frmModificarProvincia);
            this.Controls.Add(this.frmModificarCodigoPostal);
            this.Controls.Add(this.frmModificarNombreContacto);
            this.Controls.Add(this.frmModificarLocalidad);
            this.Controls.Add(this.frmModificarDireccion);
            this.Controls.Add(this.frmModificarFechaNacimiento);
            this.Controls.Add(this.frmModificarApellido2);
            this.Controls.Add(this.frmModificarApellido1);
            this.Controls.Add(this.frmModificarNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmModificarGridView);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "frmModificar";
            this.Text = "frmModificar";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.frmModificarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmModificarErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView frmModificarGridView;
        private TextBox frmModificarOtroTelefono;
        private TextBox frmModificarEmailTrabajo;
        private TextBox frmModificarEmailPersonal;
        private TextBox frmModificarTelefonoMovil;
        private TextBox frmModificarTelefonoFijo;
        private TextBox frmModificarProvincia;
        private TextBox frmModificarCodigoPostal;
        private TextBox frmModificarNombreContacto;
        private TextBox frmModificarLocalidad;
        private TextBox frmModificarDireccion;
        private TextBox frmModificarFechaNacimiento;
        private TextBox frmModificarApellido2;
        private TextBox frmModificarApellido1;
        private TextBox frmModificarNombre;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button frmModificarBtnModificar;
        private Button frmModificarBtnVolver;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ErrorProvider frmModificarErrorProvider;
    }
}