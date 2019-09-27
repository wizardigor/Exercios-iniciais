using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoriaDeAluno
{
    public partial class frmCategoriaDeAluno : Form
    {
        public frmCategoriaDeAluno()
        {
            InitializeComponent();
        }

        private void TxtUltimoAnoAniversario_Enter(object sender, EventArgs e)
        {
            if ((txtAnoNascimento.Text.Length < 4) || (txtAnoNascimento.Text.Length > 4))
            {
                MessageBox.Show("ANO DE NACIMENTO tem que ter 4 (quatro) numeros,", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
            
        }

        private void TxtUltimoAnoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if ((Convert.ToInt32(txtUltimoAnoAniversario.Text)) < (Convert.ToInt32(txtAnoNascimento.Text)))
            {
                MessageBox.Show("ULTIMO ANO DE ANIVERSARIO tem que ser maior que o do ANO NASCIMENTO.,", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text == string.Empty) || (txtAnoNascimento.Text == string.Empty) || (txtUltimoAnoAniversario.Text == string.Empty))
            {
                MessageBox.Show("TODOS OS CAMPOS DEVEM SER PREENCHIDOS.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            { 
                int idade = ((Convert.ToInt32(txtUltimoAnoAniversario.Text)) - (Convert.ToInt32(txtAnoNascimento.Text)));

                if (idade >= 18)
                {
                    txtCategoria.Text = "Adulto";
                }
                else if ((idade >= 14) && (idade < 18))
                {
                    txtCategoria.Text = "Juvenil B";
                }
                else if ((idade >= 11) && (idade < 14))
                {
                    txtCategoria.Text = "Juvenil A";
                }
                else if ((idade >= 8) && (idade < 11))
                {
                    txtCategoria.Text = "Infantil B";
                }
                else if ((idade >= 5) && (idade < 8))
                {
                    txtCategoria.Text = "Infantil A";
                }
                else if (idade < 5)
                {
                    txtCategoria.Text = "Maternal";
                }

               
            }
            
        }

        private void TxtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("INFORME UM NOME.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                txtAnoNascimento.Enabled = true;
                txtAnoNascimento.Focus();
            }
        }
    }
}
