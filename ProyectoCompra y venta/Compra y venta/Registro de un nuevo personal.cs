using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Compra_y_venta
{
    public partial class Registro_de_un_nuevo_personal : Form
    {
        public Registro_de_un_nuevo_personal()
        {
            InitializeComponent();
        }
        int op = 0;
        public int ingresar = 0;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Usuario_Panel.Visible = false;
            DatosPanel.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Usuario_Panel.Visible = true;
            DatosPanel.Enabled = true;
        }

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    Usuario_Panel.Visible = false;

        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnTsNuevo.Enabled = false;
            btnTsGuardar.Enabled = true;
            TipoPanel.Enabled = true;
        }

        private void Registro_de_un_nuevo_personal_Load(object sender, EventArgs e)
        {

        }

        private void nomtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtapp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void nomtxt_Leave(object sender, EventArgs e)
        {
            nomtxt.BackColor = Color.White;
        }

        private void txtapp_Leave(object sender, EventArgs e)
        {
            txtapp.BackColor = Color.White;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int edad;
            edad = DateTime.Today.Year - fechaDeNacimientoDateTimePicker.Value.Year;
            edad_label.Text = Convert.ToString(edad);
        }

        private void FechaIngreso_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int antiguedad;
            antiguedad = DateTime.Today.Year - fechaDeNacimientoDateTimePicker.Value.Year;
            antiguedad_label.Text = Convert.ToString(antiguedad);
        }

        private void numci_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true || char.IsControl(e.KeyChar) == true)
            {
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.FileName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.FileName);

        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnTsGuardar_Click(object sender, EventArgs e)
        {
            string Tipo = "", Mensaje = "";
            if (nomtxt.Text == "")
            {
                MessageBox.Show("EL NOMBRE DEL CAMPO ES OBLIGATORIO, REGISTRE POR FAVOR");
            }
            else
            {
                if(txtapp.Text=="")
                {
                     MessageBox.Show("LOS APELLIDOS SON OBLIGATORIO, REGISTRELOS POR FAVOR");
                }
                else
                {
                    if(Convert.ToInt32(edad_label.Text)<15)
                {
                    MessageBox.Show("La edad para trabajar debe ser mayor o igual a 15 años");
                }
                else
                    {
                        if(sexo_cb.Text=="")
                {
                     MessageBox.Show("el campo sexo es obligatorio, registrelo por favor");
                }
                else
                        {
                            op++;
                            byte[] data = System.Text.Encoding.ASCII.GetBytes(txt_contraseña.Text);
                            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                            string ClaveEncriptada = System.Text.Encoding.ASCII.GetString(data);

                            if (AdminCadioButton.Checked == true) Tipo = "Administrador";
                            if (CajeroRadioButton.Checked == true) Tipo = "Cajero de ventas";
                            if (LimpiezaRadioButton.Checked == true) Tipo = "Limpieza";
                            if(AuxiliarRadioButton.Checked==true) Tipo="Auxiliar de ventas";
                            MemoryStream FotoMS=new MemoryStream();
                            pictureBox1.Image.Save(FotoMS,System.Drawing.Imaging.ImageFormat.Jpeg);

                        }
                    }

                }

        }
    }
    }
}
