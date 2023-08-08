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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Registro_de_un_nuevo_personal registrodenuevopersonal = new Registro_de_un_nuevo_personal();
            //registrodenuevopersonal.MdiParent = this;
            //registrodenuevopersonal.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            FormPresentacion frmp = new FormPresentacion();
            frmp.ShowDialog();
            //
            FormInicioSesion frmi = new FormInicioSesion();
            frmi.ShowDialog();
            this.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Registro_de_un_nuevo_personal registrodenuevopersonal = new Registro_de_un_nuevo_personal();
            registrodenuevopersonal.MdiParent = this;
            registrodenuevopersonal.Show();
        }

        private void nuevoPersonalCtrlMayusAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_de_un_nuevo_personal registrodenuevopersonal = new Registro_de_un_nuevo_personal();
            registrodenuevopersonal.MdiParent = this;
            registrodenuevopersonal.Show();
        }
    }
}
