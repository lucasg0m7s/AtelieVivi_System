using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Repositorios
{
    public class ExibirDadosRepositorio
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();
        SqlDataReader reader;
        public string message = "";
        public bool error = false;
        public string ObterNomeCidadeCliente()
        {
            error = false;
            cmd.CommandText = "SELECT ID_CIDADE FROM CLIENTES";
            try
            {
                cmd.Connection = conn.Conectar();
                int Id_Cidade = (int)cmd.ExecuteScalar();

                cmd.CommandText = "SELECT * FROM CIDADES WHERE ID_CIDADE = @ID_CIDADE";
                cmd.Parameters.AddWithValue("@ID_CIDADE", Id_Cidade);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    message = $"{reader["Id_Cidade"]}) {reader["Cidade"]}";
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                error = true;
            }
            finally
            {
                reader.Close();
                conn.Desconectar();
            }
            return message;
        }
        public string ObterNomeCidadeLocacao()
        {
            error = false;
            cmd.CommandText = "SELECT ID_CIDADE FROM LOCACOES";
            try
            {
                cmd.Connection = conn.Conectar();
                int Id_Cidade = (int)cmd.ExecuteScalar();

                cmd.CommandText = "SELECT * FROM CIDADES WHERE ID_CIDADE = @ID_CIDADE";
                cmd.Parameters.AddWithValue("@ID_CIDADE", Id_Cidade);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    message = $"{reader["Id_Cidade"]}) {reader["Cidade"]}";
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                error = true;
            }
            finally
            {
                reader.Close();
                conn.Desconectar();
            }
            return message;
        }
        public string PreencherdgvLocacoes(DataGridView dgvLocacoes)
        {
            cmd.CommandText = "SELECT * FROM LOCACOES";
            try
            {
                cmd.Connection = conn.Conectar();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                DataTable tabela = new DataTable();
                sqlDataAdapter.Fill(tabela);

                dgvLocacoes.DataSource = tabela;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                conn.Desconectar();
            }
            return message;
        }

        public string PreencherdgvClientes(DataGridView dgvClientes)
        {
            cmd.CommandText = "SELECT * FROM CLIENTES";
            try
            {
                cmd.Connection = conn.Conectar();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                DataTable tabela = new DataTable();
                sqlDataAdapter.Fill(tabela);

                dgvClientes.DataSource = tabela;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                conn.Desconectar();
            }
            return message;
        }
    }
}
