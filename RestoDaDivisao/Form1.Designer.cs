namespace RestoDaDivisao
{
    partial class frmRestoDaDivisao
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
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(15, 25);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 0;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(133, 25);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 1;
            // 
            // txtResto
            // 
            this.txtResto.Location = new System.Drawing.Point(133, 64);
            this.txtResto.Name = "txtResto";
            this.txtResto.Size = new System.Drawing.Size(100, 20);
            this.txtResto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dividendo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Divisor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resto:";
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(15, 48);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(100, 39);
            this.btDividir.TabIndex = 6;
            this.btDividir.Text = "Realizar Divisão";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.BtDividir_Click);
            // 
            // frmRestoDaDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 94);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResto);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtDividendo);
            this.MaximizeBox = false;
            this.Name = "frmRestoDaDivisao";
            this.Text = "Resto da divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtResto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDividir;
    }
}

