using System;
using System.Windows.Forms;
using SistemaVendasWinForms;



namespace SistemaVendasWinForms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new FormCliente().ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            new FormProduto().ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            new FormVenda().ShowDialog();
        }

        private void btnProdutos_Click_1(object sender, EventArgs e)
        {
            new FormProduto().ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click_1(object sender, EventArgs e)
        {
            new FormVenda().ShowDialog();
        }
    }
}
