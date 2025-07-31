using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaVendasWinForms.Database;

namespace SistemaVendasWinForms
{
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarProdutos();
        }

        private void CarregarClientes()
        {
            using (SqlConnection conn = SqlConnectionFactory.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nome FROM Clientes", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbCliente.DataSource = dt;
                cbCliente.DisplayMember = "Nome";
                cbCliente.ValueMember = "Id";
            }
        }

        private void CarregarProdutos()
        {
            using (SqlConnection conn = SqlConnectionFactory.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nome FROM Produtos", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbProduto.DataSource = dt;
                cbProduto.DisplayMember = "Nome";
                cbProduto.ValueMember = "Id";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlConnectionFactory.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Vendas (ClienteId, ProdutoId, Quantidade) VALUES (@cliente, @produto, @quantidade)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cliente", cbCliente.SelectedValue);
                cmd.Parameters.AddWithValue("@produto", cbProduto.SelectedValue);
                cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venda registrada!");
                CarregarVendas();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void CarregarVendas()
        {
            using (SqlConnection conn = SqlConnectionFactory.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT V.Id, C.Nome AS Cliente, P.Nome AS Produto, V.Quantidade, V.DataVenda
                    FROM Vendas V
                    INNER JOIN Clientes C ON V.ClienteId = C.Id
                    INNER JOIN Produtos P ON V.ProdutoId = P.Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVendas.DataSource = dt;
            }
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
