namespace Aula3_WF
{
    partial class Form1
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.listProduto = new System.Windows.Forms.ListBox();
            this.listPreco = new System.Windows.Forms.ListBox();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(83, 28);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(149, 26);
            this.txtProduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(320, 28);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(149, 26);
            this.txtPreco.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(496, 28);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 26);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // listProduto
            // 
            this.listProduto.FormattingEnabled = true;
            this.listProduto.ItemHeight = 20;
            this.listProduto.Location = new System.Drawing.Point(46, 167);
            this.listProduto.Name = "listProduto";
            this.listProduto.Size = new System.Drawing.Size(186, 224);
            this.listProduto.TabIndex = 3;
            // 
            // listPreco
            // 
            this.listPreco.FormattingEnabled = true;
            this.listPreco.ItemHeight = 20;
            this.listPreco.Location = new System.Drawing.Point(283, 167);
            this.listPreco.Name = "listPreco";
            this.listPreco.Size = new System.Drawing.Size(186, 224);
            this.listPreco.TabIndex = 3;
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Location = new System.Drawing.Point(492, 269);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(44, 20);
            this.lblTotalVenda.TabIndex = 4;
            this.lblTotalVenda.Text = "Total";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(210, 112);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(87, 36);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 408);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblTotalVenda);
            this.Controls.Add(this.listPreco);
            this.Controls.Add(this.listProduto);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Mercadinho do Jony";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListBox listProduto;
        private System.Windows.Forms.ListBox listPreco;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.Button btnRemover;
    }
}

