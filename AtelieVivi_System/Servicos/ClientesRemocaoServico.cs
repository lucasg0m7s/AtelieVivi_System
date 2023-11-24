using AtelieVivi_System.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Servicos
{
    public class ClientesRemocaoServico
    {
        public static void AtribuirComboCliente(ref ComboBox Cliente)
        {
            ClienteRemocaoRepositorio locacoesRepositorio = new ClienteRemocaoRepositorio();
            if (locacoesRepositorio.AtribuirComboCliente(ref Cliente) != "")
            {
                MessageBox.Show(locacoesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string ObterComboCliente(string Cliente)
        {
            string cpf_cliente = "0";
            if (!string.IsNullOrWhiteSpace(Cliente))
            {
                string caracterDelimitador = " -";
                int indiceDelimitador = Cliente.IndexOf(caracterDelimitador);

                if (indiceDelimitador != -1)
                {
                    Cliente = Cliente.Substring(0, indiceDelimitador);
                    cpf_cliente = Cliente.Replace(".", "").Replace("-", "");
                }
            }
            return cpf_cliente;
        }
    }
}
