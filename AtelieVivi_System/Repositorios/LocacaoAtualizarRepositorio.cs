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
    public class LocacaoAtualizarRepositorio
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
                reader.Close();
                conn.Desconectar();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }
        //public string ObterCpfCliente(int Id_Locacao)
        //{
        //    cmd.CommandText = "SELECT CPF_Cliente FROM LOCACOES WHERE Id_Locacao = @Id_Locacao";
        //    cmd.Parameters.AddWithValue("@Id_Locacao", Id_Locacao);
        //    try
        //    {
        //        cmd.Connection = conn.Conectar();

        //        var CPF = cmd.ExecuteScalar();
        //        string CPF_Formatado = Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");

        //        conn.Desconectar();

        //        return CPF_Formatado;
        //    }
        //    catch (Exception ex)
        //    {
        //        message = ex.Message;
        //    }
        //    return message;
        //}

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
        public string AtribuirCampos(int Id_Selecionado, ref MaskedTextBox Data, ref MaskedTextBox Hora, ref TextBox Tema, ref TextBox Nome_Niver, ref TextBox Sobrenome_Niver, ref TextBox Complemento, ref TextBox Logradouro, ref TextBox Rua, ref TextBox Bairro, ref TextBox Numero, ref ComboBox Cidade, ref ComboBox CPF_Cliente)
        {
            cmd.CommandText = "SELECT * FROM Locacoes WHERE Id_Locacao = @Id_selecionado";
            cmd.Parameters.AddWithValue("@Id_selecionado", Id_Selecionado);
            try
            {
                cmd.Connection = conn.Conectar();

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Data.Text = reader["Data_Locacao"].ToString();
                    Hora.Text = reader["Horario_Locacao"].ToString();
                    Tema.Text = reader["Tema"].ToString();
                    Nome_Niver.Text = reader["Nome_Aniversariante"].ToString();
                    Sobrenome_Niver.Text = reader["Sobrenome_Aniversariante"].ToString();
                    Complemento.Text = reader["Complemento"].ToString();
                    Logradouro.Text = reader["Logradouro"].ToString();
                    Rua.Text = reader["Rua"].ToString();
                    Bairro.Text = reader["Bairro"].ToString();
                    Numero.Text = reader["Numero"].ToString();
                    Cidade.SelectedIndex = Convert.ToInt32(reader["Id_Cidade"]) - 1;
                    string textoDesejado = Convert.ToUInt64(reader["CPF_Cliente"]).ToString(@"000\.000\.000\-00");
                    for (int i = 0; i < CPF_Cliente.Items.Count; i++)
                    {
                        string item = CPF_Cliente.Items[i].ToString();
                        if (item.StartsWith(textoDesejado))
                        {
                            CPF_Cliente.SelectedIndex = i;
                            break; // Uma vez que encontramos o item desejado, saímos do loop
                        }
                    }
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

        public void Atualizar(Locacoes locacao, int Id_Selecionado)
        {
            error = false;
            cmd.CommandText = "SELECT * FROM Locacoes WHERE CPF_Cliente = @Cpf_Verificado and Nome_Aniversariante = @Nome_Verificado and Sobrenome_Aniversariante = @Sobrenome_Verificado and Complemento = @Complemento_Verificado and Logradouro = @Logradouro_Verificado and Rua = @Rua_Verificado and Bairro = @Bairro_Verificado and Numero = @Numero_Verificado and Tema = @Tema_Verificado and Data_Locacao = @Data_Verificado and Horario_Locacao = @Horario_Verificado and Id_Cidade = @Id_Cidade_Verificado";
            cmd.Parameters.AddWithValue("@Cpf_Verificado", locacao.CPF_Cliente);
            cmd.Parameters.AddWithValue("@Nome_Verificado", locacao.Nome_Aniversariante);
            cmd.Parameters.AddWithValue("@Sobrenome_Verificado", locacao.Sobrenome_Aniversariante);
            cmd.Parameters.AddWithValue("@Complemento_Verificado", locacao.Complemento);
            cmd.Parameters.AddWithValue("@Logradouro_Verificado", locacao.Logradouro);
            cmd.Parameters.AddWithValue("@Rua_Verificado", locacao.Rua);
            cmd.Parameters.AddWithValue("@Bairro_Verificado", locacao.Bairro);
            cmd.Parameters.AddWithValue("@Numero_Verificado", locacao.Numero);
            cmd.Parameters.AddWithValue("@Tema_Verificado", locacao.Tema);
            cmd.Parameters.AddWithValue("@Data_Verificado", locacao.Data_Locacao);
            cmd.Parameters.AddWithValue("@Horario_Verificado", locacao.Horario_Locacao);
            cmd.Parameters.AddWithValue("@Id_Cidade_Verificado", locacao.Id_Cidade);

            try
            {
                cmd.Connection = conn.Conectar();

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    message = "Não houve nenhuma alteração nos campos, os dados continuam iguais.";
                    error = true;
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    cmd.CommandText = "UPDATE Locacoes SET CPF_Cliente = @Cpf_Cliente, Nome_Aniversariante = @Nome_Aniversariante, Sobrenome_Aniversariante = @Sobrenome_Aniversariante, Complemento = @Complemento, Logradouro = @Logradouro, Rua = @Rua, Bairro = @Bairro, Numero = @Numero, Tema = @Tema, Data_Locacao = @Data, Horario_Locacao = @Horario, Id_Cidade = @Id_Cidade WHERE Id_Locacao = @Id_Selecionado";
                    cmd.Parameters.AddWithValue("@Id_Selecionado", Id_Selecionado);
                    cmd.Parameters.AddWithValue("@Cpf_Cliente", locacao.CPF_Cliente);
                    cmd.Parameters.AddWithValue("@Nome_Aniversariante", locacao.Nome_Aniversariante);
                    cmd.Parameters.AddWithValue("@Sobrenome_Aniversariante", locacao.Sobrenome_Aniversariante);
                    cmd.Parameters.AddWithValue("@Complemento", locacao.Complemento);
                    cmd.Parameters.AddWithValue("@Logradouro", locacao.Logradouro);
                    cmd.Parameters.AddWithValue("@Rua", locacao.Rua);
                    cmd.Parameters.AddWithValue("@Bairro", locacao.Bairro);
                    cmd.Parameters.AddWithValue("@Numero", locacao.Numero);
                    cmd.Parameters.AddWithValue("@Tema", locacao.Tema);
                    cmd.Parameters.AddWithValue("@Data", locacao.Data_Locacao);
                    cmd.Parameters.AddWithValue("@Horario", locacao.Horario_Locacao);
                    cmd.Parameters.AddWithValue("@Id_Cidade", locacao.Id_Cidade);

                    cmd.ExecuteNonQuery();

                    message = "Os dados foram atualizados com sucesso!";
                }
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
