using AtelieVivi_System.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AtelieVivi_System.Repositorios
{
    public class ExibirDadosRepositorio
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conn = new Conexao();
        SqlDataReader reader;
        public string message = "";
        public bool error = false;
      
        public string PreencherdgvLocacoes(DataGridView dgvLocacoes)
        {
            cmd.CommandText = "SELECT *, CONCAT(Locacoes.Id_Cidade, ') ', Cidades.Cidade) AS Cidades FROM Locacoes LEFT JOIN Cidades ON Locacoes.Id_Cidade = Cidades.Id_Cidade";
            try
            {
                cmd.Connection = conn.Conectar();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                DataTable tabela = new DataTable();
                sqlDataAdapter.Fill(tabela);

                dgvLocacoes.DataSource = tabela;
                dgvLocacoes.Columns[12].Visible = false;
                dgvLocacoes.Columns[13].Visible = false;
                dgvLocacoes.Columns[14].Visible = false;
                dgvLocacoes.Columns[15].Visible = false;
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
            cmd.CommandText = "SELECT *, CONCAT(Clientes.Id_Cidade, ') ', Cidades.Cidade) AS Cidades FROM Clientes LEFT JOIN Cidades ON Clientes.Id_Cidade = Cidades.Id_Cidade";
            try
            {
                cmd.Connection = conn.Conectar();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                DataTable tabela = new DataTable();
                sqlDataAdapter.Fill(tabela);

                dgvClientes.DataSource = tabela;
                dgvClientes.Columns[11].Visible = false;
                dgvClientes.Columns[12].Visible = false;
                dgvClientes.Columns[13].Visible = false;
                dgvClientes.Columns[14].Visible = false;

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

        public string FiltrarClientes(DataGridView dgvClientes, string pesquisa)
        {
            try
            {
                cmd.Connection = conn.Conectar();
                cmd.CommandText = "SELECT *, CONCAT(Clientes.Id_Cidade, ') ', Cidades.Cidade) AS Cidades FROM Clientes LEFT JOIN Cidades ON Clientes.ID_CIDADE = Cidades.ID_CIDADE WHERE Nome LIKE @pesquisa OR  Sobrenome LIKE @pesquisa OR CONCAT(Nome, ' ', Sobrenome) LIKE @pesquisa OR  CPF LIKE @pesquisa OR RG LIKE @pesquisa OR CELULAR LIKE @pesquisa OR LOGRADOURO LIKE @pesquisa OR RUA LIKE @pesquisa OR BAIRRO LIKE @pesquisa OR NUMERO LIKE @pesquisa OR  COMPLEMENTO LIKE @pesquisa OR CONCAT(Clientes.ID_CIDADE, ')', Cidades.CIDADE) LIKE @pesquisa OR USER_INSTA LIKE @pesquisa";
                cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            
                DataTable tabela = new DataTable();
                tabela.Clear(); 
                adaptador.Fill(tabela); 
                dgvClientes.DataSource = tabela;

                dgvClientes.Columns[11].Visible = false;
                dgvClientes.Columns[12].Visible = false;
                dgvClientes.Columns[13].Visible = false;
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
        public string FiltrarLocacoes(DataGridView dgvLocacao, string pesquisa)
        {
            try
            {
                cmd.Connection = conn.Conectar();
                cmd.CommandText = "SELECT *, CONCAT(Locacoes.Id_Cidade, ') ', Cidades.Cidade) AS Cidades FROM LOCACOES LEFT JOIN Cidades ON Locacoes.ID_CIDADE = Cidades.ID_CIDADE WHERE CONVERT(VARCHAR, Data_Locacao, 103) LIKE @pesquisa OR Horario_Locacao LIKE @pesquisa OR Nome_Aniversariante LIKE @pesquisa OR Sobrenome_Aniversariante LIKE @pesquisa OR CONCAT(Nome_Aniversariante, ' ', Sobrenome_Aniversariante) LIKE @pesquisa OR CPF_Cliente LIKE @pesquisa OR Tema LIKE @pesquisa OR LOGRADOURO LIKE @pesquisa OR RUA LIKE @pesquisa OR BAIRRO LIKE @pesquisa OR NUMERO LIKE @pesquisa OR COMPLEMENTO LIKE @pesquisa OR CONCAT(Locacoes.ID_CIDADE, ')', CIDADE) LIKE @pesquisa OR ID_LOCACAO LIKE @pesquisa";
                cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);

                DataTable tabela = new DataTable();
                tabela.Clear();
                adaptador.Fill(tabela);
                dgvLocacao.DataSource = tabela;

                dgvLocacao.Columns[11].Visible = false;
                dgvLocacao.Columns[12].Visible = false;
                dgvLocacao.Columns[13].Visible = false;
                dgvLocacao.Columns[14].HeaderText = "Cidade";
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
