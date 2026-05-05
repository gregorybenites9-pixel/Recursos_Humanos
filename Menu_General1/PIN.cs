using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Menu_General1
{
    public partial class PIN : Form
    {
        public PIN()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void button6_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "6";
        }

        private void PIN_Load(object sender, EventArgs e)
        {
            txtPin.PasswordChar = '●';
            txtPin.KeyPress += (s, ev) => ev.Handled = true; // bloquea el teclado
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtPin.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == "1234")
            {
                MessageBox.Show("¡Bienvenido a SENATI!", "Bienvenido",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOGIN ventanaDestino = new LOGIN();
                ventanaDestino.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("PIN incorrecto", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPin.Clear();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarPin.Checked)
                txtPin.PasswordChar = '\0'; // muestra el texto
            else
                txtPin.PasswordChar = '●'; // oculta el texto
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtPin.UseSystemPasswordChar = false;
            txtPin.PasswordChar = '\0';

            txtPin.PasswordChar = '*';
        }
    }
}
