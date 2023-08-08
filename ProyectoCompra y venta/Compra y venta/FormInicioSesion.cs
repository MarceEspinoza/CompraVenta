using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compra_y_venta
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }
        int op = 0;
        public int ingresar = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            op++;
            byte[] data = System.Text.Encoding.ASCII.GetBytes(textBox2.Text);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string ClaveEncriptada = System.Text.Encoding.ASCII.GetString(data);
            //textBox4.Text = ClaveEncriptada;
            //op++;
            //if (textBox1.Text == "Admin" && textBox2.Text == "Admin")//||(textBox1.Text==
            //    if ((int)qConsultas1.ValidarUsuario(textBox1.Text, ClaveEncriptada) == 1)
            //     {
            //       MessageBox.Show("Bienvenido al sistema");
            //         ingresar = 1;
            //         this.Close();

            //     }
            //     else
            //     {
            //         ingresar = 0;
            //         if (op == 3) this.Close();
            //         MessageBox.Show("Error de usuario, vuelva a intentar");
            //     }
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
