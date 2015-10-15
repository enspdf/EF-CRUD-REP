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
    public partial class frmVendedores : Form
    {
        public frmVendedores()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgVendedores.AutoGenerateColumns = false;
        }

        private void CargarGrid()
        {
            using (var context = new EntidadesVentas())
            {
                var vendedores = from q in context.Vendedor select q;
                dgVendedores.DataSource = vendedores.ToList();
                dgVendedores.Refresh();
            }
        }

        private void Limpiar()
        {
            txtCodigoVendedor.Text = string.Empty;
            txtNombreVendedor.Text = string.Empty;
        }

        private void frmVendedores_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                Vendedor oVendedor = new Vendedor
                {
                    CodVendedor = Convert.ToInt32(txtCodigoVendedor.Text),
                    NombreCompleto = txtNombreVendedor.Text
                };

                context.Vendedor.Add(oVendedor);
                context.SaveChanges();
                MessageBox.Show("El vendedor " + txtNombreVendedor.Text + " ha sido registrado correctamente");
                CargarGrid();
                Limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                int cod = Convert.ToInt32(txtCodigoVendedor.Text);
                Vendedor oVendedor = context.Vendedor.Single(v => v.CodVendedor == cod);
                oVendedor.NombreCompleto = txtNombreVendedor.Text;
                context.SaveChanges();
                MessageBox.Show("El vendedor " + txtCodigoVendedor.Text + " ha sido actualizado correctamente");
                CargarGrid();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesVentas())
            {
                int cod = Convert.ToInt32(txtCodigoVendedor.Text);
                Vendedor oVendedor = context.Vendedor.Single(v => v.CodVendedor == cod);
                context.Vendedor.Remove(oVendedor);
                context.SaveChanges();
                MessageBox.Show("El vendedor " + txtNombreVendedor.Text + "ha sido eliminado correctamente");
                CargarGrid();
                Limpiar();
            }
        }

        private void dgVendedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            Vendedor contexto = ((Vendedor)(dgVendedores.Rows[indice].DataBoundItem));
            txtCodigoVendedor.Text = contexto.CodVendedor.ToString();
            txtNombreVendedor.Text = contexto.NombreCompleto;
        }
    }
}
