using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaVendasWinForms.Database;

namespace SistemaVendasWinForms
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlConnectionFactory.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Clientes (Nome, Email, Telefone) VALUES (@nome, @email, @telefone)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente salvo com sucesso!");
                CarregarClientes();
            }
        }


        private void CarregarClientes()
        {
            using (SqlConnection conn = SqlConnectionFactory.GetConnection())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvClientes.DataSource = dt;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);

                var confirmar = MessageBox.Show("Deseja excluir este cliente?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    using (SqlConnection conn = SqlConnectionFactory.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Clientes WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente excluído com sucesso!");
                        CarregarClientes();
                    }
                }
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            CarregarClientes();
        }
    }
}
