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


namespace Menu_General1.Forms
{
    public partial class FormGestionarEmpleados : Form
    {
        EmpleadoDAL empleadoDAL = new EmpleadoDAL();
        int idEmpleado = 0;
        bool cargando = true;
        bool modoEdicion = false;

        public FormGestionarEmpleados()
        {
            InitializeComponent();
        }

        private void FormGestionarEmpleados_Load(object sender, EventArgs e)
        {
            cargando = true;

            // 🔽 PAÍS (con placeholder)
            DataTable dtPais = empleadoDAL.ObtenerPaises();
            DataRow fila = dtPais.NewRow();
            fila["IdPais"] = 0;
            fila["Nombre_Pais"] = "<< Seleccione el Pais>>";
            dtPais.Rows.InsertAt(fila, 0);

            cboPais.DataSource = dtPais;
            cboPais.DisplayMember = "Nombre_Pais";
            cboPais.ValueMember = "IdPais";
            cboPais.SelectedIndex = 0;

            // 🔽 OTROS COMBOS
            cboTipodocumento.DataSource = empleadoDAL.ListarTipoDocumento();
            cboTipodocumento.DisplayMember = "Nombre_Tipo_Doc";
            cboTipodocumento.ValueMember = "IdTipo_Documento";

            cboGenero.DataSource = empleadoDAL.ListarGenero();
            cboGenero.DisplayMember = "Nombre_Genero";
            cboGenero.ValueMember = "IdGenero";

            cboProfesion.DataSource = empleadoDAL.ListarProfesiones();
            cboProfesion.DisplayMember = "Nombre_Profesion";
            cboProfesion.ValueMember = "IdProfesion";

            cargando = false;
        }

        private void BTNMOSTRAR_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = empleadoDAL.ListarEmpleados();

            // 🔒 Ocultar IDs (FK + PK)
            dgvEmpleados.Columns["IdEmpleado"].Visible = false;
            dgvEmpleados.Columns["IdTipo_Documento"].Visible = false;
            dgvEmpleados.Columns["IdGenero"].Visible = false;
            dgvEmpleados.Columns["IdProfesion"].Visible = false;
            dgvEmpleados.Columns["IdDistrito"].Visible = false;
            dgvEmpleados.Columns["Estado"].Visible = false;
            dgvEmpleados.Columns["IdDepartamento"].Visible = false;
            dgvEmpleados.Columns["IdProvincia"].Visible = false;
            dgvEmpleados.Columns["IdPais"].Visible = false;


            // 🧼 NOMBRES BONITOS
            dgvEmpleados.Columns["Numero_Documento"].HeaderText = "DNI";
            dgvEmpleados.Columns["Nombres"].HeaderText = "Nombres";
            dgvEmpleados.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvEmpleados.Columns["NombreCompleto"].HeaderText = "Nombre Completo";

            dgvEmpleados.Columns["Nombre_Tipo_Doc"].HeaderText = "Tipo Documento";
            dgvEmpleados.Columns["Nombre_Genero"].HeaderText = "Género";
            dgvEmpleados.Columns["Nombre_Profesion"].HeaderText = "Profesión";

            dgvEmpleados.Columns["Nombre_Distrito"].HeaderText = "Distrito";
            dgvEmpleados.Columns["Nombre_Provincia"].HeaderText = "Provincia";
            dgvEmpleados.Columns["Nombre_Departamento"].HeaderText = "Departamento";
            dgvEmpleados.Columns["Nombre_Pais"].HeaderText = "País";

            dgvEmpleados.Columns["Direccion_Actual"].HeaderText = "Dirección";
            dgvEmpleados.Columns["Telefono1"].HeaderText = "Teléfono 1";
            dgvEmpleados.Columns["Telefono2"].HeaderText = "Teléfono 2";

            dgvEmpleados.Columns["Correo1"].HeaderText = "Correo Principal";
            dgvEmpleados.Columns["Correo2"].HeaderText = "Correo Secundario";

            dgvEmpleados.Columns["Observaciones"].HeaderText = "Observaciones";
            dgvEmpleados.Columns["Fecha_Nacimiento"].HeaderText = "F. Nacimiento";
            dgvEmpleados.Columns["Fecha_Ingreso"].HeaderText = "F. Ingreso";
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null) return;

            var row = dgvEmpleados.CurrentRow;
            idEmpleado = Convert.ToInt32(row.Cells["IdEmpleado"].Value);

            txtDni.Text = row.Cells["Numero_Documento"].Value?.ToString();
            txtNombres.Text = row.Cells["Nombres"].Value?.ToString();
            txtApellidos.Text = row.Cells["Apellidos"].Value?.ToString();

            txtCorreo1.Text = row.Cells["Correo1"].Value?.ToString();
            txtCorreo2.Text = row.Cells["Correo2"].Value?.ToString();

            textDireccion.Text = row.Cells["Direccion_Actual"].Value?.ToString();
            textTel1.Text = row.Cells["Telefono1"].Value?.ToString();
            textTel2.Text = row.Cells["Telefono2"].Value?.ToString();
            txtObservaciones.Text = row.Cells["Observaciones"].Value?.ToString();

            cboTipodocumento.SelectedValue = row.Cells["IdTipo_Documento"].Value;
            cboGenero.SelectedValue = row.Cells["IdGenero"].Value;
            cboProfesion.SelectedValue = row.Cells["IdProfesion"].Value;

            // 🔥 UBICACIÓN EN CASCADA CORRECTA
            CargarUbicacionEmpleado(idEmpleado);

        }
        // =====================================================
        // CASCADA CONTROLADA
        // =====================================================
        private void CargarUbicacionEmpleado(int id)
        {
            var dt = empleadoDAL.ObtenerUbicacionEmpleado(id);
            if (dt.Rows.Count == 0) return;

            var u = dt.Rows[0];

            cargando = true;

            cboPais.SelectedValue = u["IdPais"];

            cboDepartamento.DataSource = empleadoDAL.ObtenerDepartamentos(Convert.ToInt32(u["IdPais"]));
            cboDepartamento.DisplayMember = "Nombre_Departamento";
            cboDepartamento.ValueMember = "IdDepartamento";
            cboDepartamento.SelectedValue = u["IdDepartamento"];

            cboProvincia.DataSource = empleadoDAL.ObtenerProvincias(Convert.ToInt32(u["IdDepartamento"]));
            cboProvincia.DisplayMember = "Nombre_Provincia";
            cboProvincia.ValueMember = "IdProvincia";
            cboProvincia.SelectedValue = u["IdProvincia"];

            cboDistrito.DataSource = empleadoDAL.ObtenerDistritosPorProvincia(Convert.ToInt32(u["IdProvincia"]));
            cboDistrito.DisplayMember = "Nombre_Distrito";
            cboDistrito.ValueMember = "IdDistrito";
            cboDistrito.SelectedValue = u["IdDistrito"];

            cargando = false;
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            if (cboDistrito.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un distrito");
                return;
            }
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
            if (cargando) return;
            if (cboPais.SelectedValue == null) return;
            if (!int.TryParse(cboPais.SelectedValue.ToString(), out int idPais)) return;
            if (idPais == 0)
            {
                cboDepartamento.DataSource = null;
                cboProvincia.DataSource = null;
                cboDistrito.DataSource = null;
                return;
            }

            var dtDep = empleadoDAL.ObtenerDepartamentos(idPais);

            // 🔽 AQUI VA
            DataRow filaDep = dtDep.NewRow();
            filaDep["IdDepartamento"] = 0;
            filaDep["Nombre_Departamento"] = "<< Seleccionar Departamento >>";
            dtDep.Rows.InsertAt(filaDep, 0);

            cboDepartamento.DataSource = dtDep;
            cboDepartamento.DisplayMember = "Nombre_Departamento";
            cboDepartamento.ValueMember = "IdDepartamento";
            cboDepartamento.SelectedIndex = 0;

            cboProvincia.DataSource = null;
            cboDistrito.DataSource = null;
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            if (cboDepartamento.SelectedValue == null) return;
            if (!int.TryParse(cboDepartamento.SelectedValue.ToString(), out int idDep)) return;
            if (idDep == 0)
            {
                cboProvincia.DataSource = null;
                cboDistrito.DataSource = null;
                return;
            }

            var dtProv = empleadoDAL.ObtenerProvincias(idDep);

            // 🔽 AQUI VA
            DataRow filaProv = dtProv.NewRow();
            filaProv["IdProvincia"] = 0;
            filaProv["Nombre_Provincia"] = "<< Seleccionar Provincia >>";
            dtProv.Rows.InsertAt(filaProv, 0);

            cboProvincia.DataSource = dtProv;
            cboProvincia.DisplayMember = "Nombre_Provincia";
            cboProvincia.ValueMember = "IdProvincia";
            cboProvincia.SelectedIndex = 0;

            cboDistrito.DataSource = null;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            if (cboProvincia.SelectedValue == null) return;
            if (!int.TryParse(cboProvincia.SelectedValue.ToString(), out int idProv)) return;
            if (idProv == 0)
            {
                cboDistrito.DataSource = null;
                return;
            }

            var dtDist = empleadoDAL.ObtenerDistritosPorProvincia(idProv);

            // 🔽 AQUI VA
            DataRow filaDist = dtDist.NewRow();
            filaDist["IdDistrito"] = 0;
            filaDist["Nombre_Distrito"] = "<< Seleccionar Distrito >>";
            dtDist.Rows.InsertAt(filaDist, 0);

            cboDistrito.DataSource = dtDist;
            cboDistrito.DisplayMember = "Nombre_Distrito";
            cboDistrito.ValueMember = "IdDistrito";
            cboDistrito.SelectedIndex = 0;
        }
        
    }
}
