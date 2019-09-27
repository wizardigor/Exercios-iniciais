using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValor
{
    public partial class frmTrocaDeValor : Form
    {
        public frmTrocaDeValor()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtTrocar_Click(object sender, EventArgs e)
        {
            string auxiliar = txtValor1.Text;
            txtValor1.Text = txtValor2.Text;
            txtValor2.Text = auxiliar;
            MessageBox.Show("Troca de Valores Comcluida.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

