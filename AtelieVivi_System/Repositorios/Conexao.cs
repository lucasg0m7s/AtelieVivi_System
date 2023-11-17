using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelieVivi_System.Repositorios
{
    public class Conexao
    {
        SqlConnection conn = new SqlConnection();
        public Conexao() 
        {
            conn.ConnectionString = @"Data Source=DESKTOP-O0ACRA3\SQLEXPRESS;Initial Catalog=AtelieViviSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public SqlConnection Conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        public void Desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
