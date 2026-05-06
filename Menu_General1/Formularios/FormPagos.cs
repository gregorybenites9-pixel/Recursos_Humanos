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

namespace Menu_General1.Forms
{
    public partial class FormPagos : Form
    {
        public FormPagos()
        {
            InitializeComponent();
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            string rol = UsuarioSesion.NombreRol;
            // Contabilidad puede todo en pagos
            // Supervisor y Empleado no tienen acceso (bloqueado desde menú)
            // Solo SuperAdmin, RRHH, Administrador y Contabilidad llegan aquí
        }
    }
}
