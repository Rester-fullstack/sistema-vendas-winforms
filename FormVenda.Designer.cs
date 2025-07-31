namespace SistemaVendasWinForms
{
    partial class FormVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(50, 69);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(198, 24);
            this.cbCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(50, 182);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(198, 24);
            this.cbProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(88, 272);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(105, 22);
            this.txtQuantidade.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(50, 342);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(198, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(545, 342);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(174, 23);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(361, 50);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.RowHeadersWidth = 53;
            this.dgvVendas.RowTemplate.Height = 24;
            this.dgvVendas.Size = new System.Drawing.Size(523, 244);
            this.dgvVendas.TabIndex = 9;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCliente);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvVendas;
    }
}