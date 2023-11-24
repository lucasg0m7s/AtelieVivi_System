using System;
using System.Collections.Generic;
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
    }
}
