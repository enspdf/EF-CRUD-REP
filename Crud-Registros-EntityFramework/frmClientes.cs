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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgClientes.AutoGenerateColumns = false;
        }

        public void CargarGrid()
        {
            using (var context = new EntidadesVentas())
            {
                var clientes = from q in context.Cliente select q;
                dgClientes.DataSource = clientes.ToList();
                dgClientes.Refresh();
            }
        }

        private void Limpiar()
        {
            txtCodigoCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                Cliente oCliente = new Cliente
                {
                    CodCliente = Convert.ToInt32(txtCodigoCliente.Text),
                    NombreCompleto = txtNombreCliente.Text
                };

                context.Cliente.Add(oCliente);
                context.SaveChanges();
                MessageBox.Show("El cliente " + txtNombreCliente.Text + " ha sido registrado satisfatoriamente");
                CargarGrid();
                Limpiar();
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                int cod = Convert.ToInt32(txtCodigoCliente.Text);
                Cliente oCliente = context.Cliente.Single(c => c.CodCliente == cod);
                oCliente.NombreCompleto = txtNombreCliente.Text;
                context.SaveChanges();
                MessageBox.Show("El cliente " + txtCodigoCliente.Text + " ha sido actualizado correctamente");
                CargarGrid();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                int cod = Convert.ToInt32(txtCodigoCliente.Text);
                Cliente oCliente = context.Cliente.Single(c => c.CodCliente == cod);
                context.Cliente.Remove(oCliente);
                context.SaveChanges();
                MessageBox.Show("El cliente " + txtNombreCliente.Text + " ha sido eliminado correctamente");
                CargarGrid();
                Limpiar();
            }
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            Cliente contexto = ((Cliente)(dgClientes.Rows[indice].DataBoundItem));
            txtCodigoCliente.Text = contexto.CodCliente.ToString();
            txtNombreCliente.Text = contexto.NombreCompleto;
        }
    }
}
