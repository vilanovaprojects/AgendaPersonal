namespace cu031ejercicio2
{
    partial class frmEliminar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.frmEliminarGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.frmEliminarBtnEliminar = new System.Windows.Forms.Button();
            this.frmModificarBtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frmEliminarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // frmEliminarGridView
            // 
            this.frmEliminarGridView.AllowUserToAddRows = false;
            this.frmEliminarGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.frmEliminarGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.frmEliminarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmEliminarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.frmEliminarGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.frmEliminarGridView.Location = new System.Drawing.Point(80, 91);
            this.frmEliminarGridView.Name = "frmEliminarGridView";
            this.frmEliminarGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.frmEliminarGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.frmEliminarGridView.RowTemplate.Height = 25;
            this.frmEliminarGridView.Size = new System.Drawing.Size(659, 404);
            this.frmEliminarGridView.TabIndex = 0;
            this.frmEliminarGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.frmEliminarGridView_RowHeaderMouseClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(234, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona el registro que desea eliminar";
            // 
            // frmEliminarBtnEliminar
            // 
            this.frmEliminarBtnEliminar.Location = new System.Drawing.Point(275, 501);
            this.frmEliminarBtnEliminar.Name = "frmEliminarBtnEliminar";
            this.frmEliminarBtnEliminar.Size = new System.Drawing.Size(217, 41);
            this.frmEliminarBtnEliminar.TabIndex = 2;
            this.frmEliminarBtnEliminar.Text = "ELIMINAR";
            this.frmEliminarBtnEliminar.UseVisualStyleBackColor = true;
            this.frmEliminarBtnEliminar.Click += new System.EventHandler(this.frmEliminarBtnEliminar_Click);
            // 
            // frmModificarBtnVolver
            // 
            this.frmModificarBtnVolver.Location = new System.Drawing.Point(12, 12);
            this.frmModificarBtnVolver.Name = "frmModificarBtnVolver";
            this.frmModificarBtnVolver.Size = new System.Drawing.Size(75, 23);
            this.frmModificarBtnVolver.TabIndex = 58;
            this.frmModificarBtnVolver.Text = "Volver";
            this.frmModificarBtnVolver.UseVisualStyleBackColor = true;
            this.frmModificarBtnVolver.Click += new System.EventHandler(this.frmModificarBtnVolver_Click);
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 600);
            this.ControlBox = false;
            this.Controls.Add(this.frmModificarBtnVolver);
            this.Controls.Add(this.frmEliminarBtnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmEliminarGridView);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "frmEliminar";
            this.Text = "frmEliminar";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.frmEliminarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView frmEliminarGridView;
        private Label label1;
        private Button frmEliminarBtnEliminar;
        private Button frmModificarBtnVolver;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}