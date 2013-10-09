using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.NewFolder12
{
    public partial class Afiliado : Form
    {
        public Afiliado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clinica_Frba.CapaPresentacion.Abm_de_Afiliado.Alta_Afiliado frm = new Clinica_Frba.CapaPresentacion.Abm_de_Afiliado.Alta_Afiliado();
            frm.Show(); 
        }
    }
}
