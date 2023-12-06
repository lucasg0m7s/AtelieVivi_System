using AtelieVivi_System.Repositorios;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Servicos
{
    public class ExibirDadosServico
    {
        public void AtivarCampos(Panel panel10, TextBox txtPesquisar, Label lblPesquisar)
        {
            if (!(panel10.Visible && txtPesquisar.Visible && lblPesquisar.Visible))
            {
                panel10.Visible = true;
                txtPesquisar.Visible = true;
                lblPesquisar.Visible = true;
                txtPesquisar.Text = "";
            }
            txtPesquisar.Text = "";
        }
        public void AtivarDGVClientes(DataGridView dgvLocacoes, DataGridView dgvClientes)
        {
            if (dgvLocacoes.Visible)
            {
                dgvLocacoes.Visible = false;
            }
            dgvClientes.Visible = true;
        }
        public void AtivarDGVLocacoes(DataGridView dgvLocacoes, DataGridView dgvClientes)
        {
            if (dgvClientes.Visible)
            {
                dgvClientes.Visible = false;
            }
            dgvLocacoes.Visible = true;
        }

        public void PreencherdgvClientes(DataGridView dgvClientes)
        {
            ExibirDadosRepositorio exibirRepositorio = new ExibirDadosRepositorio();
            if (exibirRepositorio.PreencherdgvClientes(dgvClientes) != "")
            {
                MessageBox.Show(exibirRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PreencherdgvLocacoes(DataGridView dgvLocacoes)
        {
            ExibirDadosRepositorio exibirRepositorio = new ExibirDadosRepositorio();
            if (exibirRepositorio.PreencherdgvLocacoes(dgvLocacoes) != "")
            {
                MessageBox.Show(exibirRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TratardgvClientes(DataGridView dgvClientes, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvClientes.Columns["CPF"].Index)
            {
                if (e.Value != null)
                {
                    string valor = e.Value.ToString();

                    e.Value = Convert.ToUInt64(valor).ToString(@"000\.000\.000\-00");
                }
            }
            else if (e.ColumnIndex == dgvClientes.Columns["RG"].Index)
            {
                if (e.Value != null)
                {
                    string valor = e.Value.ToString();

                    e.Value = Convert.ToUInt64(valor).ToString(@"00\.000\.000\-0");
                }
            }
            else if (e.ColumnIndex == dgvClientes.Columns["Celular"].Index)
            {
                if (e.Value != null)
                {
                    string valor = e.Value.ToString();

                    e.Value = Convert.ToUInt64(valor).ToString(@"\(00\) 00000-0000");
                }
            }
            dgvClientes.Columns["User_Insta"].HeaderText = "Usuário do Instagram";
            dgvClientes.Columns["Numero"].HeaderText = "Número";
            dgvClientes.Columns[11].Visible = false;
            dgvClientes.Columns[12].Visible = false;
            dgvClientes.Columns[13].Visible = false;
            dgvClientes.Columns[14].Visible = false;
        }
        public void TratardgvClientes(DataGridView dgvClientes)
        {
            dgvClientes.Columns["User_Insta"].HeaderText = "Usuário do Instagram";
            dgvClientes.Columns["Numero"].HeaderText = "Número";
            dgvClientes.Columns[11].Visible = false;
            dgvClientes.Columns[12].Visible = false;
            dgvClientes.Columns[13].Visible = false;
            dgvClientes.Columns[14].Visible = false;
        }

        public void TratardgvLocacoes(DataGridView dgvLocacoes, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvLocacoes.Columns["CPF_Cliente"].Index)
            {
                if (e.Value != null)
                {
                    string valor = e.Value.ToString();

                    e.Value = Convert.ToUInt64(valor).ToString(@"000\.000\.000\-00");
                }
            }

            dgvLocacoes.Columns["Nome_Aniversariante"].HeaderText = "Nome do Aniversariante";
            dgvLocacoes.Columns["Sobrenome_Aniversariante"].HeaderText = "Sobrenome do Aniversariante";
            dgvLocacoes.Columns["Horario_Locacao"].HeaderText = "Horário da Locação";
            dgvLocacoes.Columns["Data_Locacao"].HeaderText = "Data da Locação";
            dgvLocacoes.Columns["Id_Locacao"].HeaderText = "Identificador da Locação";
            dgvLocacoes.Columns["CPF_Cliente"].HeaderText = "CPF do Cliente";
            dgvLocacoes.Columns["Numero"].HeaderText = "Número";
            dgvLocacoes.Columns[12].Visible = false;
            dgvLocacoes.Columns[13].Visible = false;
            dgvLocacoes.Columns[14].Visible = false;
            dgvLocacoes.Columns[15].Visible = false;
        }
        public void TratardgvLocacoes(DataGridView dgvLocacoes)
        {
            dgvLocacoes.Columns["Nome_Aniversariante"].HeaderText = "Nome do Aniversariante";
            dgvLocacoes.Columns["Sobrenome_Aniversariante"].HeaderText = "Sobrenome do Aniversariante";
            dgvLocacoes.Columns["Horario_Locacao"].HeaderText = "Horário da Locação";
            dgvLocacoes.Columns["Data_Locacao"].HeaderText = "Data da Locação";
            dgvLocacoes.Columns["Id_Locacao"].HeaderText = "Identificador da Locação";
            dgvLocacoes.Columns["CPF_Cliente"].HeaderText = "CPF do Cliente";
            dgvLocacoes.Columns["Numero"].HeaderText = "Número";
            dgvLocacoes.Columns[12].Visible = false;
            dgvLocacoes.Columns[13].Visible = false;
            dgvLocacoes.Columns[14].Visible = false;
            dgvLocacoes.Columns[15].Visible = false;
        }

        public void Filtrar(RadioButton radioCliente, RadioButton radioLocacao, DataGridView dgvClientes,DataGridView dgvLocacao, TextBox txtPesquisar)
        {
            string pesquisa = txtPesquisar.Text;
            if (radioCliente.Checked)
            {
                if (pesquisa == "") 
                {
                    LimparPesquisa(radioCliente, radioLocacao, dgvClientes, dgvLocacao, txtPesquisar); 
                }
                else
                {
                    pesquisa = string.Concat(pesquisa.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == ')'));
                    ExibirDadosRepositorio exibirRepositorio = new ExibirDadosRepositorio();
                    if (exibirRepositorio.FiltrarClientes(dgvClientes, pesquisa) != "")
                    {
                        MessageBox.Show(exibirRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (radioLocacao.Checked)
            {
                if (pesquisa == "") 
                {
                    LimparPesquisa(radioCliente, radioLocacao, dgvClientes, dgvLocacao, txtPesquisar);
                }
                else
                {
                    pesquisa = string.Concat(pesquisa.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '/' || c == ':' || c == ')'));
                    ExibirDadosRepositorio exibirRepositorio = new ExibirDadosRepositorio();
                    if (exibirRepositorio.FiltrarLocacoes(dgvLocacao, pesquisa) != "")
                    {
                        MessageBox.Show(exibirRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void LimparPesquisa(RadioButton radioCliente, RadioButton radioLocacao, DataGridView dgvClientes, DataGridView dgvLocacao, TextBox txtPesquisar)
        {
            if (radioLocacao.Checked)
            {
                if (txtPesquisar.Text == "")
                {
                    txtPesquisar.Text = String.Empty;
                    PreencherdgvLocacoes(dgvLocacao); // Recarrega todos os dados
                }
            }else if (radioCliente.Checked)
            {
                if (txtPesquisar.Text == "")
                {
                    txtPesquisar.Text = String.Empty;
                    PreencherdgvClientes(dgvClientes); // Recarrega todos os dados
                }
            }
        }
    }
}
