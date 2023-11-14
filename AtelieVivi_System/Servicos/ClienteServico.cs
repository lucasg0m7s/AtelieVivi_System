using AtelieVivi_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AtelieVivi_System.Servicos
{
    public static class ClienteServico
    {
        public static int ObterComboCidade(string Cidade)
        {
            char caracterDelimitador = ')';
            int indiceDelimitador = Cidade.IndexOf(caracterDelimitador);

            if (indiceDelimitador != -1)
            {
                Cidade = Cidade.Substring(0, indiceDelimitador);
            }

            int Id_cidade = Convert.ToInt32(Cidade);
            return Id_cidade;
        }

        public static string Cadastrar(Clientes cliente)
        {
            Type tipoDoObjeto = cliente.GetType();
            PropertyInfo[] propriedades = tipoDoObjeto.GetProperties();
            string mensagem = "";

            foreach (PropertyInfo propriedade in propriedades)
            {
                object valor = propriedade.GetValue(cliente);
                if (valor == null || string.IsNullOrWhiteSpace(valor.ToString()))
                {
                    mensagem = $"A propriedade '{propriedade.Name}' é nula ou vazia. O cadastro não foi efetuado.";
                    return mensagem;
                }
            }
            return mensagem;
        }
    }
}
