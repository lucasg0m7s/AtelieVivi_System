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
    public class LocacaoRemocaoRepositorio
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();
        SqlDataReader reader;
        public string message = "";
        public bool error = false;
        public string AtribuirComboLocacao(ref ComboBox locacao)
        {
            cmd.CommandText = "SELECT Id_Locacao, Data_Locacao, Horario_Locacao FROM Locacoes";
            try
            {
                cmd.Connection = conn.Conectar();

                reader = cmd.ExecuteReader();

                locacao.Items.Clear();

                while (reader.Read())
                {
                    locacao.Items.Add($"{reader["Id_Locacao"]} - {Convert.ToDateTime(reader["Data_Locacao"]).ToString("dd/MM/yyyy")} - {reader["Horario_Locacao"].ToString().Substring(0, 5)}");
                }
                reader.Close();
                conn.Desconectar();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }

        public string PreencherDataGridView(ref DataGridView dgvLocacoes, int id_Locacao)
        {
            cmd.CommandText = "SELECT * FROM LOCACOES WHERE ID_LOCACAO = @id_locacao";
            cmd.Parameters.AddWithValue("@id_locacao", id_Locacao);
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

        public string ObterNomeCidade(int id_Locacao)
        {
            error = false;
            cmd.CommandText = "SELECT ID_CIDADE FROM LOCACOES WHERE ID_LOCACAO = @ID_LOCACAO";
            cmd.Parameters.AddWithValue("@ID_LOCACAO", id_Locacao);
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

        public string RemoverCliente(int id_Locacao)
        {
            cmd.CommandText = "DELETE FROM LOCACOES WHERE ID_LOCACAO = @ID_LOCACAO";
            cmd.Parameters.AddWithValue("@ID_LOCACAO", id_Locacao);
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
    }
}
