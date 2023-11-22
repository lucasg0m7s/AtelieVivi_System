using AtelieVivi_System.Model;
using AtelieVivi_System.Repositorios;
using AtelieVivi_System.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Servicos
{
    public class ClienteCadastroServico
    {
        
        public static void AtribuirComboCidade(ref ComboBox Cidade)
        {
            ClienteCadastroRepositorio clienteRepositorio = new ClienteCadastroRepositorio();
            if (clienteRepositorio.AtribuirComboCidade(ref Cidade) != "")
            {
                MessageBox.Show(clienteRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int ObterComboCidade(string Cidade)
        {
            int Id_Cidade = 0;
            if (!string.IsNullOrWhiteSpace(Cidade))
            {
                char caracterDelimitador = ')';
                int indiceDelimitador = Cidade.IndexOf(caracterDelimitador);

                if (indiceDelimitador != -1)
                {
                    Cidade = Cidade.Substring(0, indiceDelimitador);
                    Id_Cidade = Convert.ToInt32(Cidade);
                }
            }
            return Id_Cidade;
        }

        private static void TratarCampos(Clientes cliente)
        {
            cliente.Nome = cliente.Nome.Trim().ToUpper();
            cliente.Sobrenome = cliente.Sobrenome.Trim().ToUpper();
            cliente.Complemento = cliente.Complemento.Trim().ToUpper();
            cliente.Logradouro = cliente.Logradouro.Trim().ToUpper();
            cliente.Rua = cliente.Rua.Trim().ToUpper();
            cliente.Bairro = cliente.Bairro.Trim().ToUpper();
            cliente.Numero = cliente.Numero.Trim().ToUpper();
            cliente.User_Insta = cliente.User_Insta.Trim().ToLower();
        }

        public static void ValidarCampos_e_Cadastrar(Clientes cliente, MaskedTextBox CPF, MaskedTextBox RG, MaskedTextBox Celular, TextBox Nome, TextBox Sobrenome, TextBox Complemento, TextBox Logradouro, TextBox Rua, TextBox Bairro, TextBox Numero, TextBox User_Insta)
        {
            TratarCampos(cliente);
            if (CPF.MaskCompleted && RG.MaskCompleted && Celular.MaskCompleted && cliente.Id_Cidade != 0)
            {
                Type tipoDoObjeto = cliente.GetType();
                PropertyInfo[] propriedades = tipoDoObjeto.GetProperties();

                foreach (PropertyInfo propriedade in propriedades)
                {
                    object valor = propriedade.GetValue(cliente);
                    if (string.IsNullOrWhiteSpace(valor.ToString()))
                    {
                        MessageBox.Show($"O campo '{propriedade.Name}' está vazio. Preencha-o e tente novamente.", "Verifique os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Existem campos incompletos. Por favor, preencha todos os campos corretamente.", "Verifique os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Cadastrar(cliente))
            {
                LimparCampos(CPF, Nome, Sobrenome, Complemento, Logradouro, Rua, Bairro, Numero, RG, Celular, User_Insta);
            }
        }

        private static bool Cadastrar(Clientes cliente)
        {
            ClienteCadastroRepositorio clienteRepositorio = new ClienteCadastroRepositorio();
            clienteRepositorio.Cadastrar(cliente);
            if (clienteRepositorio.error)
            {
                MessageBox.Show(clienteRepositorio.message, "Ocorreu um problema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show(clienteRepositorio.message, "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        public static void LimparCampos(MaskedTextBox CPF, TextBox Nome, TextBox Sobrenome, TextBox Complemento, TextBox Logradouro, TextBox Rua, TextBox Bairro, TextBox Numero, MaskedTextBox RG, MaskedTextBox Celular, TextBox User_Insta)
        {
            CPF.Text = "";
            Nome.Text = "";
            Sobrenome.Text = "";
            Complemento.Text = "";
            Logradouro.Text = "";
            Rua.Text = "";
            Bairro.Text = "";
            Numero.Text = "";
            RG.Text = "";
            Celular.Text = "";
            User_Insta.Text = "";
        } 
    }
}
