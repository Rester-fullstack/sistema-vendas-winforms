using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaVendasWinForms.Database;

namespace SistemaVendasWinForms
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlConnectionFactory.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Produtos (Nome, Preco, Estoque) VALUES (@nome, @preco, @estoque)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));
                cmd.Parameters.AddWithValue("@estoque", Convert.ToInt32(txtEstoque.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto salvo com sucesso!");
                CarregarProdutos();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            using (SqlConnection conn = SqlConnectionFactory.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produtos", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProdutos.DataSource = dt;
            }
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["Id"].Value);

                var confirmar = MessageBox.Show("Deseja excluir este produto?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    using (SqlConnection conn = SqlConnectionFactory.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Produtos WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto excluído com sucesso!");
                        CarregarProdutos();
                    }
                }
            }
        }

    }
}
