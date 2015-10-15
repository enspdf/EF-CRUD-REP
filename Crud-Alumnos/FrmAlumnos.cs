using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Alumnos
{
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent();
            this.CenterToScreen();
            dgDatosAlumnos.AutoGenerateColumns = false;
        }

        private void CargarDatos()
        {
            using (var context = new EntidadesAlumnos())
            {
                dgDatosAlumnos.DataSource = (from q in context.Alumno
                                             from w in context.Matricula
                                             select new { q, w }).ToList();
                dgDatosAlumnos.Refresh();
            }
        }

        private void Limpiar()
        {
            txtApellidoAlumno.Text = string.Empty;
            txtCodigoAlumno.Text = string.Empty;
            txtDireccionAlumno.Text = string.Empty;
            txtNombreAlumno.Text = string.Empty;
            txtValorMatricula.Text = string.Empty;
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new EntidadesAlumnos())
            {
                Alumno oAlumno = new Alumno()
                {
                    CodAlumno = Convert.ToInt32(txtCodigoAlumno.Text),
                    Nombre = txtNombreAlumno.Text,
                    Apellido = txtApellidoAlumno.Text,
                    Direccion = txtDireccionAlumno.Text
                };

                Matricula oMatricula = new Matricula()
                {
                    CodAlumno = oAlumno.CodAlumno,
                    ValorMatricula = Convert.ToInt32(txtValorMatricula.Text)
                };

                context.Alumno.Add(oAlumno);
                context.Matricula.Add(oMatricula);

                context.SaveChanges();

                MessageBox.Show("El estudiante " + txtNombreAlumno.Text + " " + txtApellidoAlumno + " ha sido registrado satsfactoriamente");

                CargarDatos();
                Limpiar();
            }
        }


    }
}
