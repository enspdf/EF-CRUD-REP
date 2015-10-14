namespace Crud_Registros_EntityFramework
{
    partial class Menu
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
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVendedores
            // 
            this.btnVendedores.Location = new System.Drawing.Point(77, 27);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(230, 23);
            this.btnVendedores.TabIndex = 0;
            this.btnVendedores.Text = "Gestionar Vendedores";
            this.btnVendedores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVendedores.UseVisualStyleBackColor = true;
            this.btnVendedores.Click += new System.EventHandler(this.btnVendedores_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(77, 70);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(230, 23);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Gestionar Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(77, 114);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(230, 23);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Gestionar Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(77, 160);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(230, 23);
            this.btnFacturar.TabIndex = 3;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(77, 252);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(230, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(77, 206);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(230, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 303);
            this.ControlBox = false;
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnVendedores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Menu de selección";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendedores;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConsultar;
    }
}

