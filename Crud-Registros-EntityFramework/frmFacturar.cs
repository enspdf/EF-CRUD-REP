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
    public partial class frmFacturar : Form
    {
        public frmFacturar()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgFactura.AutoGenerateColumns = false;
        }

        private void CargarDatos()
        {
            using (var context = new EntidadesVentas())
            {
                cbProducto.DataSource = (from q in context.Producto select q).ToList();
                cbProducto.DisplayMember = "NomProducto";
                cbCliente.ValueMember = "CodProducto";

                cbCliente.DataSource = (from q in context.Cliente select q).ToList();
                cbCliente.DisplayMember = "NombreCompleto";
                cbCliente.ValueMember = "CodCliente";

                cbVendedor.DataSource = (from q in context.Vendedor select q).ToList();
                cbVendedor.DisplayMember = "NombreCompleto";
                cbVendedor.ValueMember = "CodVendedor";
            }
        }

        private void Limpiar()
        {
            txtCantidad.Text = string.Empty;
            txtValorTotal.Text = string.Empty;
            cbProducto.SelectedIndex = 0;
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgFactura.Rows.Add(cbProducto.Text, txtCantidad.Text, txtValorTotal.Text);
            Limpiar();
            int result = dgFactura.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["ValorTotal"].Value));
            txtTotal.Text = result.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int fila = dgFactura.CurrentRow.Index;
            dgFactura.Rows.RemoveAt(fila);
            int result = dgFactura.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["ValorTotal"].Value));
            txtTotal.Text = result.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                Factura oFactura = new Factura()
                {
                    CodVendedor = Convert.ToInt32(cbVendedor.SelectedValue),
                    CodCliente = Convert.ToInt32(cbCliente.SelectedValue),
                    VlrTotal = Convert.ToInt32(txtTotal.Text)
                };


                
                    DetalleFactura oDetalleFactura = new DetalleFactura()
                    {
                        CodFactura = 1,
                        CodProducto = Convert.ToInt32("1"),
                        Cantidad = Convert.ToInt32(dgFactura.CurrentRow.Cells["Cantidad"].Value),
                        VlrTotal = Convert.ToInt32(txtTotal.Text)
                    };
                

                context.Factura.Add(oFactura);
                context.DetalleFactura.Add(oDetalleFactura);

                context.SaveChanges();
                MessageBox.Show("Factura guardada correctamente");
            }
        }
    }
}
