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
    public partial class FormVacaciones : Form
    {
        public FormVacaciones()
        {
            InitializeComponent();
        }

        private void FormVacaciones_Load(object sender, EventArgs e)
        {
            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            string rol = UsuarioSesion.NombreRol;
            // Empleado solo ve, Supervisor puede todo
            if (rol == Roles.Empleado)
            {
                BTNNUEVO.Enabled = false;
                BTNGUARDAR.Enabled = false;
                BTNMODIFICAR.Enabled = false;
                BTNELIMINAR.Enabled = false;
            }
        }
    }
}
