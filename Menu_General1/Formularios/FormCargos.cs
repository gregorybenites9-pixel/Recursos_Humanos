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
    public partial class FormCargos : Form
    {
        public FormCargos()
        {
            InitializeComponent();
        }

        private void FormCargos_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            string rol = UsuarioSesion.NombreRol;
            // Solo SuperAdmin, RRHH y Administrador acceden
            // Si llega otro rol por seguridad extra:
            if (rol != Roles.SuperAdmin &&
                rol != Roles.RecursosHumanos &&
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
