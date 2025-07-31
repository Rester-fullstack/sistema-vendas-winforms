namespace SistemaVendasWinForms
{
    partial class FormMenu
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(41, 51);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(230, 77);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Abrir Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(271, 134);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(230, 77);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Abrir Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click_1);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(501, 217);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(230, 77);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = "Abrir Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click_1);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnClientes);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnVendas;
    }
}