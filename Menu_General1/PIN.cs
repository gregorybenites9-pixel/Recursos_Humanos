using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_General1
{
    public partial class PIN : Form
    {
        public PIN()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPin.Text = txtPin.Text + "6";
        }

        private void PIN_Load(object sender, EventArgs e)
        {

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
            if (txtPin.Text == "1234") // Ejemplo de validación
            {
                MessageBox.Show("¡Bienvenido!");
                LOGIN ventanaDestino = new LOGIN();
                ventanaDestino.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("PIN incorrecto");
                txtPin.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtPin.UseSystemPasswordChar = false;
            txtPin.PasswordChar = '\0';

            txtPin.PasswordChar = '*';
        }
    }
}
