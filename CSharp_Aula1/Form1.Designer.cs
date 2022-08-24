namespace CSharp_Aula1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNomeSobrenome = new System.Windows.Forms.Label();
            this.btnConcatenacao = new System.Windows.Forms.Button();
            this.txtNomeSobrenome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSE = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblRst = new System.Windows.Forms.Label();
            this.txtRst = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(44, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(81, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 5);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(3, 36);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblNomeSobrenome
            // 
            this.lblNomeSobrenome.AutoSize = true;
            this.lblNomeSobrenome.Location = new System.Drawing.Point(3, 91);
            this.lblNomeSobrenome.Name = "lblNomeSobrenome";
            this.lblNomeSobrenome.Size = new System.Drawing.Size(99, 13);
            this.lblNomeSobrenome.TabIndex = 3;
            this.lblNomeSobrenome.Text = "Nome e sobrenome";
            // 
            // btnConcatenacao
            // 
            this.btnConcatenacao.Location = new System.Drawing.Point(12, 59);
            this.btnConcatenacao.Name = "btnConcatenacao";
            this.btnConcatenacao.Size = new System.Drawing.Size(89, 23);
            this.btnConcatenacao.TabIndex = 4;
            this.btnConcatenacao.Text = "Juntar nomes";
            this.btnConcatenacao.UseVisualStyleBackColor = true;
            this.btnConcatenacao.Click += new System.EventHandler(this.btnConcatenacao_Click);
            // 
            // txtNomeSobrenome
            // 
            this.txtNomeSobrenome.Location = new System.Drawing.Point(108, 88);
            this.txtNomeSobrenome.Name = "txtNomeSobrenome";
            this.txtNomeSobrenome.Size = new System.Drawing.Size(80, 20);
            this.txtNomeSobrenome.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(70, 33);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(79, 20);
            this.txtSobrenome.TabIndex = 6;
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(211, 5);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(21, 13);
            this.lblN1.TabIndex = 7;
            this.lblN1.Text = "N1";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(211, 36);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(21, 13);
            this.lblN2.TabIndex = 8;
            this.lblN2.Text = "N2";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(248, 2);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 9;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(248, 33);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(211, 95);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado";
            // 
            // btnSE
            // 
            this.btnSE.Location = new System.Drawing.Point(259, 59);
            this.btnSE.Name = "btnSE";
            this.btnSE.Size = new System.Drawing.Size(75, 23);
            this.btnSE.TabIndex = 12;
            this.btnSE.Text = "Soma";
            this.btnSE.UseVisualStyleBackColor = true;
            this.btnSE.Click += new System.EventHandler(this.btnSE_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(272, 92);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(207, 20);
            this.txtResultado.TabIndex = 13;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(564, 30);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(163, 23);
            this.btnSoma.TabIndex = 14;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(519, 5);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(21, 13);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "N3";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(499, 95);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(105, 13);
            this.lblQtd.TabIndex = 16;
            this.lblQtd.Text = "Quantidade da soma";
            // 
            // lblRst
            // 
            this.lblRst.AutoSize = true;
            this.lblRst.Location = new System.Drawing.Point(521, 69);
            this.lblRst.Name = "lblRst";
            this.lblRst.Size = new System.Drawing.Size(23, 13);
            this.lblRst.TabIndex = 17;
            this.lblRst.Text = "Rst";
            // 
            // txtRst
            // 
            this.txtRst.Location = new System.Drawing.Point(564, 62);
            this.txtRst.Name = "txtRst";
            this.txtRst.Size = new System.Drawing.Size(163, 20);
            this.txtRst.TabIndex = 18;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(564, 2);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(163, 20);
            this.txtValor.TabIndex = 18;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(610, 91);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(163, 20);
            this.txtQtd.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtRst);
            this.Controls.Add(this.lblRst);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSE);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNomeSobrenome);
            this.Controls.Add(this.btnConcatenacao);
            this.Controls.Add(this.lblNomeSobrenome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Formulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNomeSobrenome;
        private System.Windows.Forms.Button btnConcatenacao;
        private System.Windows.Forms.TextBox txtNomeSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSE;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblRst;
        private System.Windows.Forms.TextBox txtRst;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtd;
    }
}

