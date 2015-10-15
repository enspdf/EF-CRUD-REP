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
                var alumnos = (from alu in context.Matricula
                               select new
                               {
                                   CodigoAlumno = alu.Alumno.CodAlumno,
                                   ValorMatricula = alu.ValorMatricula,
                                   NombreApellido = alu.Alumno.Nombre + " " + alu.Alumno.Apellido,
                                   Nombre = alu.Alumno.Nombre,
                                   Apellido = alu.Alumno.Apellido,
                                   Direccion = alu.Alumno.Direccion
                               }).ToList();
                dgDatosAlumnos.DataSource = alumnos;
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

                MessageBox.Show("El estudiante " + txtNombreAlumno.Text + " " + txtApellidoAlumno.Text + " ha sido registrado satsfactoriamente");

                CargarDatos();
                Limpiar();
            }
        }

        private void dgDatosAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            
                Alumno alumno = ((Alumno)dgDatosAlumnos.Rows[indice].DataBoundItem);
                //Matricula matricula = ((Matricula)dgDatosAlumnos.Rows[indice].DataBoundItem);

                txtNombreAlumno.Text = alumno.Nombre;
                txtApellidoAlumno.Text = alumno.Apellido;
                txtCodigoAlumno.Text = alumno.CodAlumno.ToString();
                txtDireccionAlumno.Text = alumno.Direccion;
                txtValorMatricula.Text = alumno.Matricula.ToString();
                //txtValorMatricula.Text = matricula.ValorMatricula.ToString();

            
        }


    }
}
