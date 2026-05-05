using Menu_General1.Datos;
using Menu_General1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu_General1.Entidades;
using Menu_General1.Datos;

namespace Menu_General1.Forms
{
    public partial class FormGestionarEmpleados : Form
    {
        EmpleadoDAL empleadoDAL = new EmpleadoDAL();
        int idEmpleado = 0;
        public FormGestionarEmpleados()
        {
            InitializeComponent();
        }

        private void FormGestionarEmpleados_Load(object sender, EventArgs e)
        {
            cboTipodocumento.DataSource = empleadoDAL.ListarTipoDocumento();
            cboTipodocumento.DisplayMember = "Nombre_Tipo_Doc";
            cboTipodocumento.ValueMember = "IdTipo_Documento";

            cboGenero.DataSource = empleadoDAL.ListarGenero();
            cboGenero.DisplayMember = "Nombre_Genero";
            cboGenero.ValueMember = "IdGenero";

            cboProfesion.DataSource = empleadoDAL.ListarProfesiones();
            cboProfesion.DisplayMember = "Nombre_Profesion";
            cboProfesion.ValueMember = "IdProfesion";

            cboDistrito.DataSource = empleadoDAL.ListarDistritos();
            cboDistrito.DisplayMember = "Nombre_Distrito";
            cboDistrito.ValueMember = "IdDistrito";
        }

        private void BTNMOSTRAR_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = empleadoDAL.ListarEmpleados();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null) return;

            idEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["IdEmpleado"].Value);

            txtDni.Text = dgvEmpleados.CurrentRow.Cells["Numero_Documento"].Value?.ToString();
            txtNombres.Text = dgvEmpleados.CurrentRow.Cells["Nombres"].Value?.ToString();
            txtApellidos.Text = dgvEmpleados.CurrentRow.Cells["Apellidos"].Value?.ToString();
            txtCorreo1.Text = dgvEmpleados.CurrentRow.Cells["Correo1"].Value?.ToString();

            cboTipodocumento.SelectedValue = dgvEmpleados.CurrentRow.Cells["IdTipo_Documento"].Value;
            cboGenero.SelectedValue = dgvEmpleados.CurrentRow.Cells["IdGenero"].Value;
            cboProfesion.SelectedValue = dgvEmpleados.CurrentRow.Cells["IdProfesion"].Value;
            cboDistrito.SelectedValue = dgvEmpleados.CurrentRow.Cells["IdDistrito"].Value;
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            Empleado e1 = new Empleado
            {
                IdTipoDocumento = Convert.ToInt32(cboTipodocumento.SelectedValue),
                NumeroDocumento = txtDni.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                IdGenero = Convert.ToInt32(cboGenero.SelectedValue),
                IdProfesion = Convert.ToInt32(cboProfesion.SelectedValue),
                IdDistrito = Convert.ToInt32(cboDistrito.SelectedValue),
                FechaNacimiento = dtpFecha.Value,
                FechaIngreso = dtpFechaingreso.Value,
                Correo1 = txtCorreo1.Text
            };

            MessageBox.Show(empleadoDAL.InsertarEmpleado(e1));
            dgvEmpleados.DataSource = empleadoDAL.ListarEmpleados();
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            Empleado e1 = new Empleado
            {
                IdEmpleado = idEmpleado,
                IdTipoDocumento = Convert.ToInt32(cboTipodocumento.SelectedValue),
                NumeroDocumento = txtDni.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                IdGenero = Convert.ToInt32(cboGenero.SelectedValue),
                IdProfesion = Convert.ToInt32(cboProfesion.SelectedValue),
                IdDistrito = Convert.ToInt32(cboDistrito.SelectedValue),
                FechaNacimiento = dtpFecha.Value,
                FechaIngreso = dtpFechaingreso.Value,
                Correo1 = txtCorreo1.Text
            };

            MessageBox.Show(empleadoDAL.ModificarEmpleado(e1));
            dgvEmpleados.DataSource = empleadoDAL.ListarEmpleados();
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(empleadoDAL.EliminarEmpleado(idEmpleado));
            dgvEmpleados.DataSource = empleadoDAL.ListarEmpleados();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = empleadoDAL.BuscarEmpleado(txtBuscar.Text);
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
