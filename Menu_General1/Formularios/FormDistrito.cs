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
    public partial class FormDistrito : Form
    {
        public FormDistrito()
        {
            InitializeComponent();
        }

        private void FormDistrito_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            string rol = UsuarioSesion.NombreRol;

            if (rol == Roles.Supervisor ||
                rol == Roles.Empleado ||
                rol == Roles.Contabilidad)
            {
                BTNNUEVO.Enabled = false;
                BTNGUARDAR.Enabled = false;
                BTNMODIFICAR.Enabled = false;
                BTNELIMINAR.Enabled = false;
                // BTNMOSTRAR y BTNSALIR siempre habilitados
            }
        }
    }
}
