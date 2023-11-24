using AtelieVivi_System.Model;
using AtelieVivi_System.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Servicos
{
    public class LocacaoCadastroServico
    {
        public static void AtribuirComboCidade(ref ComboBox Cidade)
        {
            LocacaoCadastroRepositorio clienteRepositorio = new LocacaoCadastroRepositorio();
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

        public static void ValidarCampos_e_Cadastrar(Locacoes locacao, MaskedTextBox Data, MaskedTextBox Hora, TextBox Nome_Aniversariante, TextBox Sobrenome_Aniversariante, TextBox Tema, TextBox Complemento, TextBox Logradouro, TextBox Rua, TextBox Bairro, TextBox Numero, ComboBox Cidade, ComboBox Cliente)
        {
            
            if (Data.MaskCompleted && Hora.MaskCompleted && locacao.Id_Cidade != 0 && locacao.CPF_Cliente != "0")
            {
                if (ValidarData(Data))
                {
                    if (ValidarHora(Hora))
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
            if (Cadastrar(locacao))
            {
                LimparCampos(Data, Hora, Nome_Aniversariante, Sobrenome_Aniversariante, Complemento, Logradouro, Rua, Bairro, Numero, Tema, Cidade, Cliente);
            }
        }
        private static bool Cadastrar(Locacoes locacao)
        {
            LocacaoCadastroRepositorio locacaoRepositorio = new LocacaoCadastroRepositorio();
            locacaoRepositorio.Cadastrar(locacao);
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
        public static void LimparCampos(MaskedTextBox Data, MaskedTextBox Hora, TextBox Nome, TextBox Sobrenome, TextBox Complemento, TextBox Logradouro, TextBox Rua, TextBox Bairro, TextBox Numero, TextBox Tema, ComboBox Cidade, ComboBox Cliente)
        {
            Data.Text = "";
            Hora.Text = "";
            Nome.Text = "";
            Sobrenome.Text = "";
            Tema.Text = "";
            Complemento.Text = "";
            Logradouro.Text = "";
            Rua.Text = "";
            Bairro.Text = "";
            Numero.Text = "";
            Cidade.SelectedIndex = -1;
            Cliente.SelectedIndex = -1;
        }
        private static bool ValidarData(MaskedTextBox mskData)
        {
            string data = mskData.Text;

            if (!DateTime.TryParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Data inválida. Insira no formato DD/MM/YYYY", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private static bool ValidarHora(MaskedTextBox mskHora)
        {
            string hora = mskHora.Text;

            if (!DateTime.TryParseExact(hora, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Hora inválida. Insira no formato HH:mm", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
