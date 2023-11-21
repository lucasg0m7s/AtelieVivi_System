using AtelieVivi_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Repositorios
{
    public class LocacaoCadastroRepositorio
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();
        SqlDataReader reader;
        public string message = "";
        public bool error = false;
        public string AtribuirComboCidade(ref ComboBox Cidade)
        {
            cmd.CommandText = "SELECT Id_cidade, Cidade FROM Cidades";
            try
            {
                cmd.Connection = conn.Conectar();

                reader = cmd.ExecuteReader();

                Cidade.Items.Clear();

                while (reader.Read())
                {
                    Cidade.Items.Add($"{reader["Id_Cidade"]}) {reader["Cidade"]}");
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
        public string AtribuirComboCliente(ref ComboBox locacao)
        {
            cmd.CommandText = "SELECT CPF, Nome, Sobrenome FROM Clientes";
            try
            {
                cmd.Connection = conn.Conectar();

                reader = cmd.ExecuteReader();

                locacao.Items.Clear();

                while (reader.Read())
                {
                    locacao.Items.Add($"{Convert.ToUInt64(reader["CPF"]).ToString(@"000\.000\.000\-00")} - {reader["Nome"]} {reader["Sobrenome"]}");
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

        public void Cadastrar(Locacoes locacao)
        {
            error = false;

            cmd.CommandText = "INSERT INTO Locacoes (DATA_LOCACAO, HORARIO_LOCACAO, Nome_Aniversariante, Sobrenome_Aniversariante, Complemento, Logradouro, Rua, Bairro, Numero, Id_Cidade, CPF_CLIENTE, Tema) VALUES (CONVERT(DATE, '@DATA_LOCACAO', 103), @HORARIO_LOCACAO, @Nome_Aniversariante, @Sobrenome_Aniversariante, @Complemento, @Logradouro, @Rua, @Bairro, @Numero, @Id_Cidade, @CPF_CLIENTE, @Tema)";
            cmd.Parameters.AddWithValue("@DATA_LOCACAO", locacao.Data_Locacao);
            cmd.Parameters.AddWithValue("@HORARIO_LOCACAO", locacao.Horario_Locacao);
            cmd.Parameters.AddWithValue("@Nome_Aniversariante", locacao.Nome_Aniversariante);
            cmd.Parameters.AddWithValue("@Sobrenome_Aniversariante", locacao.Sobrenome_Aniversariante);
            cmd.Parameters.AddWithValue("@Complemento", locacao.Complemento);
            cmd.Parameters.AddWithValue("@Logradouro", locacao.Logradouro);
            cmd.Parameters.AddWithValue("@Rua", locacao.Rua);
            cmd.Parameters.AddWithValue("@Bairro", locacao.Bairro);
            cmd.Parameters.AddWithValue("@Numero", locacao.Numero);
            cmd.Parameters.AddWithValue("@Id_Cidade", locacao.Id_Cidade);
            cmd.Parameters.AddWithValue("@CPF_CLIENTE", locacao.CPF_Cliente);
            cmd.Parameters.AddWithValue("@Tema", locacao.CPF_Cliente);


            try
            {
                cmd.Connection = conn.Conectar();
                cmd.ExecuteNonQuery();
                message = "Cadastrado com sucesso!";
                conn.Desconectar();
            }
            catch (Exception ex)
            {
                error = true;
                message = ex.Message;
            }
        }
    }
}
