using AtelieVivi_System.Model;
using AtelieVivi_System.Repositorios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace AtelieVivi_System.Servicos
{
    public class LocacaoAtualizarServico
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
            LocacaoAtualizarRepositorio locacoesRepositorio = new LocacaoAtualizarRepositorio();
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
        public static void AtribuirComboLocacao(ref ComboBox Locacao)
        {
            LocacaoAtualizarRepositorio locacoesRepositorio = new LocacaoAtualizarRepositorio();
            if (locacoesRepositorio.AtribuirComboLocacao(ref Locacao) != "")
            {
                MessageBox.Show(locacoesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static int ObterComboLocacao(string Locacao)
        {
            int Id_Locacao = 0;
            if (!string.IsNullOrWhiteSpace(Locacao))
            {
                string caracterDelimitador = " -";
                int indiceDelimitador = Locacao.IndexOf(caracterDelimitador);

                if (indiceDelimitador != -1)
                {
                    Locacao = Locacao.Substring(0, indiceDelimitador);
                    Id_Locacao = Convert.ToInt32(Locacao);
                }
            }
            return Id_Locacao;
        }
        public static void Ativar_Atribuir(Panel[] panels, ComboBox Id_Selecionado, MaskedTextBox Data, MaskedTextBox Hora, TextBox Nome_Niver, TextBox Sobrenome_Niver, TextBox Tema, TextBox Complemento, TextBox Logradouro, TextBox Rua, TextBox Bairro, TextBox Numero, ComboBox Cidade, ComboBox CPF_cliente, Button Atualizar)
        {
            textBoxes = new TextBox[] { Nome_Niver, Sobrenome_Niver, Complemento, Logradouro, Rua, Bairro, Numero, Tema };
            comboBoxes = new ComboBox[] { Id_Selecionado, Cidade, CPF_cliente };
            maskedTextBoxes = new MaskedTextBox[] {Data, Hora};
            buttons = new Button[] { Atualizar };
            Panels = panels;

            for (int i = 0; i < textBoxes.Length; i++)
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

            if (Id_Selecionado.Text != String.Empty)
            {
                PreencherCampos(ObterComboLocacao(Id_Selecionado.Text), ref Data, ref Hora, ref Tema, ref Nome_Niver, ref Sobrenome_Niver, ref Complemento, ref Logradouro, ref Rua, ref Bairro, ref Numero, ref Cidade, ref CPF_cliente);
            }
        }
        private static void PreencherCampos(int Id_Selecionado, ref MaskedTextBox Data, ref MaskedTextBox Hora, ref TextBox Tema, ref TextBox Nome_Niver, ref TextBox Sobrenome_Niver, ref TextBox Complemento, ref TextBox Logradouro, ref TextBox Rua, ref TextBox Bairro, ref TextBox Numero, ref ComboBox Cidade, ref ComboBox CPF_Cliente)
        {
            LocacaoAtualizarRepositorio clientesRepositorio = new LocacaoAtualizarRepositorio();
            if (clientesRepositorio.AtribuirCampos(Id_Selecionado, ref Data, ref Hora, ref Tema, ref Nome_Niver, ref Sobrenome_Niver, ref Complemento, ref Logradouro, ref Rua, ref Bairro, ref Numero, ref Cidade, ref CPF_Cliente) != "")
            {
                MessageBox.Show(clientesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void TratarCampos(Locacoes locacao)
        {
            locacao.Nome_Aniversariante = locacao.Nome_Aniversariante.Trim().ToUpper();
            locacao.Sobrenome_Aniversariante = locacao.Sobrenome_Aniversariante.Trim().ToUpper();
            locacao.Tema = locacao.Tema.Trim().ToUpper();
            locacao.Complemento = locacao.Complemento.Trim().ToUpper();
            locacao.Logradouro = locacao.Logradouro.Trim().ToUpper();
            locacao.Rua = locacao.Rua.Trim().ToUpper();
            locacao.Bairro = locacao.Bairro.Trim().ToUpper();
            locacao.Numero = locacao.Numero.Trim().ToUpper();
            locacao.CPF_Cliente = locacao.CPF_Cliente.Replace(".", "").Replace("-", "");
            DateTime dataConvertida = DateTime.ParseExact(locacao.Data_Locacao, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            locacao.Data_Locacao = dataConvertida.ToString("yyyy-MM-dd");
        }

        public static void ValidarCampos_e_Atualizar(Locacoes locacao)
        {
            if (maskedTextBoxes[0].MaskCompleted && maskedTextBoxes[1].MaskCompleted && locacao.Id_Cidade != 0 && locacao.CPF_Cliente != "0")
            {
                if (ValidarData())
                {
                    if (ValidarHora())
                    {
                        TratarCampos(locacao);
                        Type tipoDoObjeto = locacao.GetType();
                        PropertyInfo[] propriedades = tipoDoObjeto.GetProperties();

                        foreach (PropertyInfo propriedade in propriedades)
                        {
                            object valor = propriedade.GetValue(locacao);
                            if (string.IsNullOrWhiteSpace(valor.ToString()))
                            {
                                MessageBox.Show($"O campo '{propriedade.Name}' está vazio. Preencha-o e tente novamente.", "Verifique os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Existem campos incompletos. Por favor, preencha todos os campos corretamente.", "Verifique os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Atualizar(locacao))
            {
                ResetarCampos();
            }
        }

        private static bool Atualizar(Locacoes locacao)
        {
            LocacaoAtualizarRepositorio locacaoRepositorio = new LocacaoAtualizarRepositorio();
            locacaoRepositorio.Atualizar(locacao, ObterComboLocacao(comboBoxes[0].Text));
            if (locacaoRepositorio.error)
            {
                MessageBox.Show(locacaoRepositorio.message, "Ocorreu um problema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show(locacaoRepositorio.message, "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            comboBoxes[2].Enabled = false;

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

            AtribuirComboLocacao(ref comboBoxes[0]);
        }
        private static bool ValidarData()
        {
            string data = maskedTextBoxes[0].Text;

            if (!DateTime.TryParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Data inválida. Insira no formato DD/MM/YYYY", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private static bool ValidarHora()
        {
            string hora = maskedTextBoxes[1].Text;

            if (!DateTime.TryParseExact(hora, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Hora inválida. Insira no formato HH:mm", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

