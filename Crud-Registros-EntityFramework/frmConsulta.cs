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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgConsulta.AutoGenerateColumns = false;
        }

        private void CargarDatos()
        {
            using (var context = new EntidadesVentas())
            {
                cbCliente.DataSource = (from q in context.Cliente select q).ToList();
                cbCliente.DisplayMember = "NombreCompleto";
                cbCliente.ValueMember = "CodCliente";

                cbProducto.DataSource = (from q in context.Producto select q).ToList();
                cbProducto.DisplayMember = "NomProducto";
                cbProducto.ValueMember = "CodProducto";
            }
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                var lista = (from det in context.DetalleFactura
                             where
                                 det.Factura.CodCliente == ((Cliente)cbCliente.SelectedItem).CodCliente
                                 && det.CodProducto == ((Producto)cbProducto.SelectedItem).CodProducto
                             select new
                             {
                                 Cliente = det.Factura.Cliente.NombreCompleto,
                                 Producto = det.Producto.NomProducto,
                                 Factura = det.Factura.CodFactura
                             }).ToList();

                dgConsulta.DataSource = null;
                dgConsulta.DataSource = lista;
                dgConsulta.Refresh();
            }
        }

        private void dgConsulta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}
