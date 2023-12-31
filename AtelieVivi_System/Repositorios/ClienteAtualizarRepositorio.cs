﻿using AtelieVivi_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Repositorios
{
    public class ClienteAtualizarRepositorio
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
            cmd.CommandText = "SELECT * FROM Clientes WHERE CPF = @Cpf_Verificado and Nome = @Nome_Verificado and Sobrenome = @Sobrenome_Verificado and Complemento = @Complemento_Verificado and Logradouro = @Logradouro_Verificado and Rua = @Rua_Verificado and Bairro = @Bairro_Verificado and Numero = @Numero_Verificado and RG = @RG_Verificado and Celular = @Celular_Verificado and User_Insta = @User_Insta_Verificado and Id_Cidade = @Id_Cidade_Verificado";
            cmd.Parameters.AddWithValue("@Cpf_Verificado", cliente.CPF);
            cmd.Parameters.AddWithValue("@Nome_Verificado", cliente.Nome);
            cmd.Parameters.AddWithValue("@Sobrenome_Verificado", cliente.Sobrenome);
            cmd.Parameters.AddWithValue("@Complemento_Verificado", cliente.Complemento);
            cmd.Parameters.AddWithValue("@Logradouro_Verificado", cliente.Logradouro);
            cmd.Parameters.AddWithValue("@Rua_Verificado", cliente.Rua);
            cmd.Parameters.AddWithValue("@Bairro_Verificado", cliente.Bairro);
            cmd.Parameters.AddWithValue("@Numero_Verificado", cliente.Numero);
            cmd.Parameters.AddWithValue("@RG_Verificado", cliente.RG);
            cmd.Parameters.AddWithValue("@Celular_Verificado", cliente.Celular);
            cmd.Parameters.AddWithValue("@User_Insta_Verificado", cliente.User_Insta);
            cmd.Parameters.AddWithValue("@Id_Cidade_Verificado", cliente.Id_Cidade);

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
