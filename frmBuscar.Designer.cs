namespace cu031ejercicio2
{
    partial class frmBuscar
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
            this.frmBuscarTextBox1 = new System.Windows.Forms.TextBox();
            this.frmBuscarComboBox1 = new System.Windows.Forms.ComboBox();
            this.frmBuscarBtnBuscar = new System.Windows.Forms.Button();
            this.frmBuscarComboBox2 = new System.Windows.Forms.ComboBox();
            this.frmBuscarTextBox2 = new System.Windows.Forms.TextBox();
            this.frmBuscarComboBox3 = new System.Windows.Forms.ComboBox();
            this.frmBuscarTextBox3 = new System.Windows.Forms.TextBox();
            this.frmBuscarGridView = new System.Windows.Forms.DataGridView();
            this.frmBuscarLimpiar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.frmBuscarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // frmBuscarTextBox1
            // 
            this.frmBuscarTextBox1.Location = new System.Drawing.Point(218, 42);
            this.frmBuscarTextBox1.Name = "frmBuscarTextBox1";
            this.frmBuscarTextBox1.Size = new System.Drawing.Size(192, 23);
            this.frmBuscarTextBox1.TabIndex = 0;
            // 
            // frmBuscarComboBox1
            // 
            this.frmBuscarComboBox1.FormattingEnabled = true;
            this.frmBuscarComboBox1.Location = new System.Drawing.Point(61, 42);
            this.frmBuscarComboBox1.Name = "frmBuscarComboBox1";
            this.frmBuscarComboBox1.Size = new System.Drawing.Size(121, 23);
            this.frmBuscarComboBox1.TabIndex = 1;
            // 
            // frmBuscarBtnBuscar
            // 
            this.frmBuscarBtnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frmBuscarBtnBuscar.Location = new System.Drawing.Point(522, 56);
            this.frmBuscarBtnBuscar.Name = "frmBuscarBtnBuscar";
            this.frmBuscarBtnBuscar.Size = new System.Drawing.Size(145, 46);
            this.frmBuscarBtnBuscar.TabIndex = 2;
            this.frmBuscarBtnBuscar.Text = "Buscar";
            this.frmBuscarBtnBuscar.UseVisualStyleBackColor = true;
            this.frmBuscarBtnBuscar.Click += new System.EventHandler(this.frmBuscarBtnBuscar_Click);
            // 
            // frmBuscarComboBox2
            // 
            this.frmBuscarComboBox2.FormattingEnabled = true;
            this.frmBuscarComboBox2.Location = new System.Drawing.Point(61, 79);
            this.frmBuscarComboBox2.Name = "frmBuscarComboBox2";
            this.frmBuscarComboBox2.Size = new System.Drawing.Size(121, 23);
            this.frmBuscarComboBox2.TabIndex = 4;
            // 
            // frmBuscarTextBox2
            // 
            this.frmBuscarTextBox2.Location = new System.Drawing.Point(218, 79);
            this.frmBuscarTextBox2.Name = "frmBuscarTextBox2";
            this.frmBuscarTextBox2.Size = new System.Drawing.Size(192, 23);
            this.frmBuscarTextBox2.TabIndex = 3;
            // 
            // frmBuscarComboBox3
            // 
            this.frmBuscarComboBox3.FormattingEnabled = true;
            this.frmBuscarComboBox3.Location = new System.Drawing.Point(61, 117);
            this.frmBuscarComboBox3.Name = "frmBuscarComboBox3";
            this.frmBuscarComboBox3.Size = new System.Drawing.Size(121, 23);
            this.frmBuscarComboBox3.TabIndex = 6;
            // 
            // frmBuscarTextBox3
            // 
            this.frmBuscarTextBox3.Location = new System.Drawing.Point(218, 117);
            this.frmBuscarTextBox3.Name = "frmBuscarTextBox3";
            this.frmBuscarTextBox3.Size = new System.Drawing.Size(192, 23);
            this.frmBuscarTextBox3.TabIndex = 5;
            // 
            // frmBuscarGridView
            // 
            this.frmBuscarGridView.AllowUserToAddRows = false;
            this.frmBuscarGridView.AllowUserToDeleteRows = false;
            this.frmBuscarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmBuscarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.frmBuscarGridView.Location = new System.Drawing.Point(61, 205);
            this.frmBuscarGridView.Name = "frmBuscarGridView";
            this.frmBuscarGridView.ReadOnly = true;
            this.frmBuscarGridView.RowTemplate.Height = 25;
            this.frmBuscarGridView.Size = new System.Drawing.Size(642, 260);
            this.frmBuscarGridView.TabIndex = 7;
            this.frmBuscarGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.frmBuscarGridView_RowHeaderMouseDoubleClick);
            // 
            // frmBuscarLimpiar
            // 
            this.frmBuscarLimpiar.Location = new System.Drawing.Point(573, 137);
            this.frmBuscarLimpiar.Name = "frmBuscarLimpiar";
            this.frmBuscarLimpiar.Size = new System.Drawing.Size(75, 23);
            this.frmBuscarLimpiar.TabIndex = 8;
            this.frmBuscarLimpiar.Text = "Limpiar lista";
            this.frmBuscarLimpiar.UseVisualStyleBackColor = true;
            this.frmBuscarLimpiar.Click += new System.EventHandler(this.frmBuscarLimpiar_Click);
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
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 510);
            this.Controls.Add(this.frmBuscarLimpiar);
            this.Controls.Add(this.frmBuscarGridView);
            this.Controls.Add(this.frmBuscarComboBox3);
            this.Controls.Add(this.frmBuscarTextBox3);
            this.Controls.Add(this.frmBuscarComboBox2);
            this.Controls.Add(this.frmBuscarTextBox2);
            this.Controls.Add(this.frmBuscarBtnBuscar);
            this.Controls.Add(this.frmBuscarComboBox1);
            this.Controls.Add(this.frmBuscarTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.frmBuscarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox frmBuscarTextBox1;
        private ComboBox frmBuscarComboBox1;
        private Button frmBuscarBtnBuscar;
        private ComboBox frmBuscarComboBox2;
        private TextBox frmBuscarTextBox2;
        private ComboBox frmBuscarComboBox3;
        private TextBox frmBuscarTextBox3;
        private DataGridView frmBuscarGridView;
        private Button frmBuscarLimpiar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}