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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgProductos.AutoGenerateColumns = false;
        }

        private void CargarGrid()
        {
            using (var context = new EntidadesVentas())
            {
                var productos = from q in context.Producto select q;
                dgProductos.DataSource = productos.ToList();
                dgProductos.Refresh();
            }
        }

        private void Limpiar()
        {
            txtCodigoProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                Producto oProducto = new Producto
                {
                    CodProducto = Convert.ToInt32(txtCodigoProducto.Text),
                    NomProducto = txtNombreProducto.Text
                };

                context.Producto.Add(oProducto);
                context.SaveChanges();
                MessageBox.Show("El producto " + txtNombreProducto.Text + " ha sido registrado correctamente");
                CargarGrid();
                Limpiar();
            }
        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            Producto contexto = ((Producto)(dgProductos.Rows[indice].DataBoundItem));
            txtCodigoProducto.Text = contexto.CodProducto.ToString();
            txtNombreProducto.Text = contexto.NomProducto;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                int cod = Convert.ToInt32(txtCodigoProducto.Text);
                Producto oProducto = context.Producto.Single(p => p.CodProducto == cod);
                oProducto.NomProducto = txtNombreProducto.Text;
                context.SaveChanges();
                MessageBox.Show("El producto " + txtCodigoProducto.Text + " ha sido actualizado correctamente");
                CargarGrid();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                int cod = Convert.ToInt32(txtCodigoProducto.Text);
                Producto oProducto = context.Producto.Single(p => p.CodProducto == cod);
                context.Producto.Remove(oProducto);
                context.SaveChanges();
                MessageBox.Show("El producto " + txtNombreProducto.Text + " ha sido eliminado correctamente");
                CargarGrid();
                Limpiar();
            }
        }
    }
}
