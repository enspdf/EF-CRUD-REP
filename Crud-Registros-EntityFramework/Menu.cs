using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Registros_EntityFramework
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.CenterToScreen();
            MessageBox.Show("Bienvenido al sistema de gestión comercial");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            frmVendedores vendedores = new frmVendedores();
            vendedores.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmFacturar factura = new frmFacturar();
            factura.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.Show();
        }
    }
}
