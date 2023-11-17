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
    public class ClienteServico
    {
        
        public static void AtribuirComboCidade(ref ComboBox Cidade)
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
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


        public static void ValidarCampos_e_Cadastrar(Clientes cliente, MaskedTextBox CPF, MaskedTextBox RG, MaskedTextBox Celular)
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
            Cadastrar(cliente);
        }
        private static void Cadastrar(Clientes cliente)
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
            clienteRepositorio.Cadastrar(cliente);
            if (clienteRepositorio.error)
            {
                MessageBox.Show(clienteRepositorio.message, "Ocorreu um problema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(clienteRepositorio.message, "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cadastro_Clientes cad = new Cadastro_Clientes();
            }
        }
        public static void LimparCampos(MaskedTextBox CPF, TextBox Nome, TextBox Sobrenome, TextBox Complemento, TextBox Logradouro, TextBox Rua, TextBox Bairro, TextBox Numero, MaskedTextBox RG, MaskedTextBox Celular, TextBox User_Insta, ComboBox Id_Cidade)
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
            Id_Cidade.Text = "";
        }

        public static void ApenasLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas letras!", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void ApenasLetrasEspaço(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita esse tipo de caracter!", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static void NoSpaces(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita espaços", "Atenção.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
