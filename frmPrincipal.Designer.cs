namespace cu031ejercicio2
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoCargarEjemplo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPrincipalGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.frmPrincipalPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmPrincipalGridView)).BeginInit();
            this.frmPrincipalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuAlta,
            this.menuModificar,
            this.menuEliminar,
            this.menuBuscar,
            this.menuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivoAbrir,
            this.menuArchivoGuardar,
            this.menuArchivoGuardarComo,
            this.menuArchivoCargarEjemplo,
            this.toolStripSeparator1,
            this.menuArchivoSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            // 
            // menuArchivoAbrir
            // 
            this.menuArchivoAbrir.Name = "menuArchivoAbrir";
            this.menuArchivoAbrir.Size = new System.Drawing.Size(180, 22);
            this.menuArchivoAbrir.Text = "Abrir";
            this.menuArchivoAbrir.Click += new System.EventHandler(this.frmPrincipalAbrir_Click);
            // 
            // menuArchivoGuardar
            // 
            this.menuArchivoGuardar.Name = "menuArchivoGuardar";
            this.menuArchivoGuardar.Size = new System.Drawing.Size(180, 22);
            this.menuArchivoGuardar.Text = "Guardar";
            this.menuArchivoGuardar.Click += new System.EventHandler(this.menuArchivoGuardar_Click);
            // 
            // menuArchivoGuardarComo
            // 
            this.menuArchivoGuardarComo.Name = "menuArchivoGuardarComo";
            this.menuArchivoGuardarComo.Size = new System.Drawing.Size(180, 22);
            this.menuArchivoGuardarComo.Text = "Guardar como";
            this.menuArchivoGuardarComo.Click += new System.EventHandler(this.frmPrincipalGuardarComo_Click);
            // 
            // menuArchivoCargarEjemplo
            // 
            this.menuArchivoCargarEjemplo.Name = "menuArchivoCargarEjemplo";
            this.menuArchivoCargarEjemplo.Size = new System.Drawing.Size(180, 22);
            this.menuArchivoCargarEjemplo.Text = "Cargar Ejemplo";
            this.menuArchivoCargarEjemplo.Click += new System.EventHandler(this.menuArchivoCargarEjemplo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuArchivoSalir
            // 
            this.menuArchivoSalir.Name = "menuArchivoSalir";
            this.menuArchivoSalir.Size = new System.Drawing.Size(180, 22);
            this.menuArchivoSalir.Text = "Salir";
            this.menuArchivoSalir.Click += new System.EventHandler(this.menuArchivoSalir_Click);
            // 
            // menuAlta
            // 
            this.menuAlta.Name = "menuAlta";
            this.menuAlta.Size = new System.Drawing.Size(40, 20);
            this.menuAlta.Text = "Alta";
            this.menuAlta.Click += new System.EventHandler(this.menuAlta_Click);
            // 
            // menuModificar
            // 
            this.menuModificar.Name = "menuModificar";
            this.menuModificar.Size = new System.Drawing.Size(70, 20);
            this.menuModificar.Text = "Modificar";
            this.menuModificar.Click += new System.EventHandler(this.menuModificar_Click);
            // 
            // menuEliminar
            // 
            this.menuEliminar.Name = "menuEliminar";
            this.menuEliminar.Size = new System.Drawing.Size(62, 20);
            this.menuEliminar.Text = "Eliminar";
            this.menuEliminar.Click += new System.EventHandler(this.menuEliminar_Click);
            // 
            // menuBuscar
            // 
            this.menuBuscar.Name = "menuBuscar";
            this.menuBuscar.Size = new System.Drawing.Size(54, 20);
            this.menuBuscar.Text = "Buscar";
            this.menuBuscar.Click += new System.EventHandler(this.menuBuscar_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(41, 20);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // frmPrincipalGridView
            // 
            this.frmPrincipalGridView.AllowUserToAddRows = false;
            this.frmPrincipalGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            this.frmPrincipalGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.frmPrincipalGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.frmPrincipalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmPrincipalGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.frmPrincipalGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.frmPrincipalGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.frmPrincipalGridView.Location = new System.Drawing.Point(67, 52);
            this.frmPrincipalGridView.Name = "frmPrincipalGridView";
            this.frmPrincipalGridView.ReadOnly = true;
            this.frmPrincipalGridView.RowTemplate.Height = 25;
            this.frmPrincipalGridView.Size = new System.Drawing.Size(687, 604);
            this.frmPrincipalGridView.TabIndex = 4;
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
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // frmPrincipalPanel
            // 
            this.frmPrincipalPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.frmPrincipalPanel.Controls.Add(this.frmPrincipalGridView);
            this.frmPrincipalPanel.Location = new System.Drawing.Point(0, 22);
            this.frmPrincipalPanel.Name = "frmPrincipalPanel";
            this.frmPrincipalPanel.Size = new System.Drawing.Size(834, 659);
            this.frmPrincipalPanel.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 675);
            this.Controls.Add(this.frmPrincipalPanel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Agenda Personal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmPrincipalGridView)).EndInit();
            this.frmPrincipalPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuAlta;
        private ToolStripMenuItem menuModificar;
        private ToolStripMenuItem menuEliminar;
        private ToolStripMenuItem menuBuscar;
        private ToolStripMenuItem menuSalir;
        private DataGridView frmPrincipalGridView;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem menuArchivoAbrir;
        private ToolStripMenuItem menuArchivoGuardar;
        private ToolStripMenuItem menuArchivoGuardarComo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuArchivoSalir;
        private SaveFileDialog dlgSave;
        private OpenFileDialog dlgAbrir;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel frmPrincipalPanel;
        private ToolStripMenuItem menuArchivoCargarEjemplo;
    }
}