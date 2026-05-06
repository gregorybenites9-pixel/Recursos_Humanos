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
    public partial class FormRoles : Form
    {
        public FormRoles()
        {
            InitializeComponent();
        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
        }

        // Solo SuperAdmin y Administrador
        private void AplicarPermisos()
        {
            string rol = UsuarioSesion.NombreRol;
            if (rol != Roles.SuperAdmin &&
                rol != Roles.Administrador)
            {
                BTNNUEVO.Enabled = false;
                BTNGUARDAR.Enabled = false;
                BTNMODIFICAR.Enabled = false;
                BTNELIMINAR.Enabled = false;
            }
        }
    }
}
