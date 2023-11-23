using AtelieVivi_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Repositorios
{
    public class ClientesAtualizarRepositorio
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
        public string AtribuirCampos(string CPF_Cliente, ref MaskedTextBox CPF, ref MaskedTextBox RG, ref MaskedTextBox Celular, ref TextBox Nome, ref TextBox Sobrenome, ref TextBox Complemento, ref TextBox Logradouro, ref TextBox Rua, ref TextBox Bairro, ref TextBox Numero, ref TextBox User_Insta, ref ComboBox Cidade)
        {
            cmd.CommandText = "SELECT * FROM Clientes where CPF = @CPF";
            cmd.Parameters.AddWithValue("@CPF", CPF_Cliente);
            try
            {
                cmd.Connection = conn.Conectar();

                reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    CPF.Text = reader["CPF"].ToString();
                    RG.Text = reader["RG"].ToString();
                    Celular.Text = reader["Celular"].ToString();
                    Nome.Text = reader["Nome"].ToString();
                    Sobrenome.Text = reader["Sobrenome"].ToString();
                    Complemento.Text = reader["Complemento"].ToString();
                    Logradouro.Text = reader["Logradouro"].ToString();
                    Rua.Text = reader["Rua"].ToString();
                    Bairro.Text = reader["Bairro"].ToString();
                    Numero.Text = reader["Numero"].ToString();
                    User_Insta.Text = reader["User_Insta"].ToString();
                    Cidade.SelectedIndex = Convert.ToInt32(reader["Id_Cidade"]) - 1;
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


        public void Atualizar(Clientes cliente, string CPF_Selecionado)
        {
            error = false;
            cmd.CommandText = "UPDATE Clientes SET CPF = @Cpf, Nome = @Nome, Sobrenome = @Sobrenome, Complemento = @Complemento, Logradouro = @Logradouro, Rua = @Rua, Bairro = @Bairro, Numero = @Numero, RG = @RG, Celular = @Celular, User_Insta = @User_Insta, Id_Cidade = @Id_Cidade where CPF = @Cpf_Selecionado";
            cmd.Parameters.AddWithValue("@Cpf_Selecionado", CPF_Selecionado);
            cmd.Parameters.AddWithValue("@Cpf", cliente.CPF);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Sobrenome", cliente.Sobrenome);
            cmd.Parameters.AddWithValue("@Complemento", cliente.Complemento);
            cmd.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
            cmd.Parameters.AddWithValue("@Rua", cliente.Rua);
            cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
            cmd.Parameters.AddWithValue("@RG", cliente.RG);
            cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
            cmd.Parameters.AddWithValue("@User_Insta", cliente.User_Insta);
            cmd.Parameters.AddWithValue("@Id_Cidade", cliente.Id_Cidade);
            try
            {
                cmd.Connection = conn.Conectar();

                cmd.ExecuteNonQuery();

                message = "Os dados foram atualizados com sucesso!";

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
