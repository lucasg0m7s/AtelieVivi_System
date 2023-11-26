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
    public class ClienteRemocaoRepositorio
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();
        SqlDataReader reader;
        public string message = "";
        public bool error = false;
        public string AtribuirComboCliente(ref ComboBox Cliente)
        {
            cmd.CommandText = "SELECT CPF, Nome, Sobrenome FROM Clientes";
            try
            {
                cmd.Connection = conn.Conectar();

                reader = cmd.ExecuteReader();

                Cliente.Items.Clear();

                while (reader.Read())
                {
                    Cliente.Items.Add($"{Convert.ToUInt64(reader["CPF"]).ToString(@"000\.000\.000\-00")} - {reader["Nome"]} {reader["Sobrenome"]}");
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                reader.Close();
                conn.Desconectar();
            }
            return message;
        }

        public string PreencherDataGridView(ref DataGridView dgvClientes, string cpfSelecionado)
        {
            cmd.CommandText = "SELECT * FROM CLIENTES WHERE CPF = @cpfSelecionado";
            cmd.Parameters.AddWithValue("@cpfSelecionado", cpfSelecionado);
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

        public string RemoverCliente(string cpfSelecionado)
        {
            cmd.CommandText = "DELETE FROM CLIENTES WHERE CPF = @cpfSelecionado";
            cmd.Parameters.AddWithValue("@cpfSelecionado", cpfSelecionado);
            try
            {
                cmd.Connection = conn.Conectar();
                cmd.ExecuteNonQuery();
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

        public string ObterNomeCidade(string cpfSelecionado)
        {
            error = false;
            cmd.CommandText = "SELECT ID_CIDADE FROM CLIENTES WHERE CPF = @cpfSelecionado";
            cmd.Parameters.AddWithValue("@cpfSelecionado", cpfSelecionado);
            try
            {
                cmd.Connection = conn.Conectar();
                int Id_Cidade = (int)cmd.ExecuteScalar();

                cmd.CommandText = "SELECT * FROM CIDADES WHERE ID_CIDADE = @ID_CIDADE";
                cmd.Parameters.AddWithValue("@ID_CIDADE", Id_Cidade);

                reader = cmd.ExecuteReader();

                if(reader.Read())
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
    }
}
