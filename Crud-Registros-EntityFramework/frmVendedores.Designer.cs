namespace Crud_Registros_EntityFramework
{
    partial class frmVendedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoVendedor = new System.Windows.Forms.TextBox();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgVendedores = new System.Windows.Forms.DataGridView();
            this.CodigoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Vendedor:";
            // 
            // txtCodigoVendedor
            // 
            this.txtCodigoVendedor.Location = new System.Drawing.Point(122, 21);
            this.txtCodigoVendedor.Name = "txtCodigoVendedor";
            this.txtCodigoVendedor.Size = new System.Drawing.Size(214, 20);
            this.txtCodigoVendedor.TabIndex = 2;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(122, 57);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(214, 20);
            this.txtNombreVendedor.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(56, 92);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(137, 92);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(218, 92);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgVendedores
            // 
            this.dgVendedores.AllowUserToAddRows = false;
            this.dgVendedores.AllowUserToDeleteRows = false;
            this.dgVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoVendedor,
            this.NombreVendedor});
            this.dgVendedores.Location = new System.Drawing.Point(16, 129);
            this.dgVendedores.Name = "dgVendedores";
            this.dgVendedores.ReadOnly = true;
            this.dgVendedores.Size = new System.Drawing.Size(320, 150);
            this.dgVendedores.TabIndex = 7;
            this.dgVendedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVendedores_CellClick);
            // 
            // CodigoVendedor
            // 
            this.CodigoVendedor.DataPropertyName = "CodVendedor";
            this.CodigoVendedor.HeaderText = "Código Vendedor";
            this.CodigoVendedor.Name = "CodigoVendedor";
            this.CodigoVendedor.ReadOnly = true;
            this.CodigoVendedor.Width = 120;
            // 
            // NombreVendedor
            // 
            this.NombreVendedor.DataPropertyName = "NombreCompleto";
            this.NombreVendedor.HeaderText = "Nombre Vendedor";
            this.NombreVendedor.Name = "NombreVendedor";
            this.NombreVendedor.ReadOnly = true;
            this.NombreVendedor.Width = 120;
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 300);
            this.Controls.Add(this.dgVendedores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.txtCodigoVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVendedores";
            this.Text = "Vendedores";
            this.Load += new System.EventHandler(this.frmVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoVendedor;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreVendedor;
    }
}