namespace CategoriaDeAluno
{
    partial class frmCategoriaDeAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtUltimoAnoAniversario = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btInformarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Ano de nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Ultimo ano de aniversario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Categoria:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNome_Validating);
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Enabled = false;
            this.txtAnoNascimento.Location = new System.Drawing.Point(16, 83);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(131, 20);
            this.txtAnoNascimento.TabIndex = 5;
            
            // 
            // txtUltimoAnoAniversario
            // 
            this.txtUltimoAnoAniversario.Location = new System.Drawing.Point(153, 83);
            this.txtUltimoAnoAniversario.Name = "txtUltimoAnoAniversario";
            this.txtUltimoAnoAniversario.Size = new System.Drawing.Size(126, 20);
            this.txtUltimoAnoAniversario.TabIndex = 6;
            this.txtUltimoAnoAniversario.Enter += new System.EventHandler(this.TxtUltimoAnoAniversario_Enter);
            this.txtUltimoAnoAniversario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUltimoAnoAniversario_Validating);
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.Yellow;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCategoria.Location = new System.Drawing.Point(153, 133);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(126, 20);
            this.txtCategoria.TabIndex = 7;
            this.txtCategoria.Text = "CATEGORIA";
            // 
            // btInformarCategoria
            // 
            this.btInformarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInformarCategoria.Location = new System.Drawing.Point(16, 117);
            this.btInformarCategoria.Name = "btInformarCategoria";
            this.btInformarCategoria.Size = new System.Drawing.Size(131, 36);
            this.btInformarCategoria.TabIndex = 8;
            this.btInformarCategoria.Text = "&Informar Categoria";
            this.btInformarCategoria.UseVisualStyleBackColor = true;
            this.btInformarCategoria.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmCategoriaDeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 175);
            this.Controls.Add(this.btInformarCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtUltimoAnoAniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCategoriaDeAluno";
            this.Text = "Categoria De Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.TextBox txtUltimoAnoAniversario;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btInformarCategoria;
    }
}

