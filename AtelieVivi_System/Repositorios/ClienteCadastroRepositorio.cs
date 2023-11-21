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
    public class ClienteCadastroRepositorio
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

        public void Cadastrar(Clientes cliente)
        {
            error = false;
            cmd.CommandText = "SELECT * FROM Clientes WHERE CPF = @CPF_Verificar OR RG = @RG_Verificar OR Celular = @CELULAR_Verificar";
            cmd.Parameters.AddWithValue("@CPF_Verificar", cliente.CPF);
            cmd.Parameters.AddWithValue("@RG_Verificar", cliente.RG);
            cmd.Parameters.AddWithValue("@CELULAR_Verificar", cliente.Celular);
            try
            {
                cmd.Connection = conn.Conectar();
                reader = cmd.ExecuteReader();
                if(reader.HasRows) 
                {
                    message = "Os dados informados já foram cadastrados. Verifique os campos de CPF, RG e Celular e tente novamente.";
                    error = true;
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    cmd.CommandText = "INSERT INTO Clientes (CPF, Nome, Sobrenome, Complemento, Logradouro, Rua, Bairro, Numero, RG, Celular, User_Insta, Id_Cidade) VALUES (@Cpf, @Nome, @Sobrenome, @Complemento, @Logradouro, @Rua, @Bairro, @Numero, @RG, @Celular, @User_Insta, @Id_Cidade)";
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
         
                    cmd.ExecuteNonQuery();
                    message = "Cadastrado com sucesso!";
                }
            }
            catch (Exception ex)
            {
                error = true;
                message = ex.Message;
            }
            conn.Desconectar();
        }
    }
}
