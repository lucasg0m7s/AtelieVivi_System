using AtelieVivi_System.Model;
using AtelieVivi_System.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Servicos
{
    public class ClientesAtualizarServicos
    {
        private static Panel[] Panels { get; set; }
        private static TextBox[] textBoxes { get; set; }
        private static ComboBox[] comboBoxes { get; set; }
        private static MaskedTextBox[] maskedTextBoxes { get; set; }
        private static Button[] buttons { get; set; }

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
        public static void AtribuirComboCliente(ref ComboBox Cliente)
        {
            LocacaoCadastroRepositorio locacoesRepositorio = new LocacaoCadastroRepositorio();
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
        public static void Ativar_Atribuir(Panel[] panels, ComboBox ClienteSelecionado, MaskedTextBox CPF, MaskedTextBox RG, MaskedTextBox Celular, TextBox Nome, TextBox Sobrenome, TextBox Complemento, TextBox Logradouro, TextBox Rua, TextBox Bairro, TextBox Numero, TextBox User_Insta, ComboBox Cidade, Button Atualizar)
        {
            textBoxes = new TextBox[]{ Nome, Sobrenome, Complemento, Logradouro, Rua, Bairro, Numero, User_Insta };
            comboBoxes = new ComboBox[]{ ClienteSelecionado, Cidade };
            maskedTextBoxes = new MaskedTextBox[] { CPF, RG, Celular };
            buttons = new Button[] {Atualizar};
            Panels = panels;

            for(int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = true;
            }

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].Enabled = true;
            }

            for (int i = 0; i < maskedTextBoxes.Length; i++)
            {
                maskedTextBoxes[i].Enabled = true;
            }

            for (int i = 0; i < Panels.Length; i++)
            {
                Panels[i].BackColor = System.Drawing.Color.Green;
            }

            buttons[0].Enabled = true;   

            if(ClienteSelecionado.Text != String.Empty)
            {
                PreencherCampos(ObterComboCliente(ClienteSelecionado.Text), ref CPF, ref RG, ref Celular, ref Nome, ref Sobrenome, ref Complemento, ref Logradouro, ref Rua, ref Bairro, ref Numero, ref User_Insta, ref Cidade);
            }
        }
        private static void PreencherCampos(string CPF_Cliente, ref MaskedTextBox CPF, ref MaskedTextBox RG, ref MaskedTextBox Celular, ref TextBox Nome, ref TextBox Sobrenome, ref TextBox Complemento, ref TextBox Logradouro, ref TextBox Rua, ref TextBox Bairro, ref TextBox Numero, ref TextBox User_Insta, ref ComboBox Cidade)
        {
            ClientesAtualizarRepositorio clientesRepositorio = new ClientesAtualizarRepositorio();
            if (clientesRepositorio.AtribuirCampos(CPF_Cliente, ref CPF, ref RG, ref Celular, ref Nome, ref Sobrenome, ref Complemento, ref Logradouro, ref Rua, ref Bairro, ref Numero, ref User_Insta, ref Cidade) != "")
            {
                MessageBox.Show(clientesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public static void ValidarCampos_e_Atualizar(Clientes cliente)
        {
            TratarCampos(cliente);
            if (maskedTextBoxes[0].MaskCompleted && maskedTextBoxes[1].MaskCompleted && maskedTextBoxes[2].MaskCompleted && cliente.Id_Cidade != 0)
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
                MessageBox.Show("Existem campos incompletos. Por favor, preencha todos os campos completamente.", "Verifique os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Atualizar(cliente)) 
            {
                ResetarCampos();
            }
        }

        private static bool Atualizar(Clientes cliente)
        {
            ClientesAtualizarRepositorio clienteRepositorio = new ClientesAtualizarRepositorio();
            clienteRepositorio.Atualizar(cliente, ObterComboCliente(comboBoxes[0].Text));
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
        public static void ResetarCampos()
        {
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = false;
                textBoxes[i].Text = String.Empty;
            }

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].SelectedIndex = -1;
            }

            comboBoxes[1].Enabled = false;

            for (int i = 0; i < maskedTextBoxes.Length; i++)
            {
                maskedTextBoxes[i].Enabled = false;
                maskedTextBoxes[i].Text = String.Empty;
            }

            for (int i = 0; i < Panels.Length; i++)
            {
                Panels[i].BackColor = System.Drawing.Color.Red;
            }

            buttons[0].Enabled = false;

            AtribuirComboCliente(ref comboBoxes[0]);
        }
    }
}
