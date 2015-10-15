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
        public List<DetalleFactura> ListaDetalles = new List<DetalleFactura>();

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
            ListaDetalles.Add(new DetalleFactura 
            {
                CodProducto = ((Producto)cbProducto.SelectedItem).CodProducto,
                Cantidad = Convert.ToInt32(txtCantidad.Text),
                VlrTotal = Convert.ToInt32(txtValorTotal.Text)
            });

            Limpiar();
            dgFactura.DataSource = null;
            dgFactura.DataSource = ListaDetalles;
            dgFactura.Refresh();
            txtTotal.Text = ListaDetalles.Sum(x => x.VlrTotal).ToString();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int fila = dgFactura.CurrentRow.Index;
            if (fila > 0)
            {
                ListaDetalles.RemoveAt(fila);
                Limpiar();
                dgFactura.DataSource = null;
                dgFactura.DataSource = ListaDetalles;
                MessageBox.Show("El registro se ha eliminado correctamente");
                dgFactura.Refresh();
                txtTotal.Text = ListaDetalles.Sum(x => x.VlrTotal).ToString();
            }

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

                foreach (var item in ListaDetalles)
                {
                    item.CodFactura = oFactura.CodFactura;
                    oFactura.DetalleFactura.Add(item);
                }

                context.Factura.Add(oFactura);

                context.SaveChanges();
                MessageBox.Show("Factura guardada correctamente");
            }
        }
    }
}
