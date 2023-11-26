using AtelieVivi_System.Repositorios;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Servicos
{
    public class ExibirDadosServico
    {
        public void AtivarCampos(Panel panel10, IconButton btnPesquisar, TextBox txtPesquisar, Label lblPesquisar)
        {
            if (!(panel10.Visible && btnPesquisar.Visible && txtPesquisar.Visible && lblPesquisar.Visible))
            {
                panel10.Visible = true;
                btnPesquisar.Visible = true;
                txtPesquisar.Visible = true;
                lblPesquisar.Visible = true;
                txtPesquisar.Text = "";
            }
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
            else if(e.ColumnIndex == dgvClientes.Columns["Id_Cidade"].Index)
            {
                if(e.Value != null)
                {
                    e.Value = ObterNomeCidadeCliente();
                }
            }
            dgvClientes.Columns["User_Insta"].HeaderText = "Usuário do Instagram";
            dgvClientes.Columns["Numero"].HeaderText = "Número";
            dgvClientes.Columns["Id_Cidade"].HeaderText = "Cidade";
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
            else if(e.ColumnIndex == dgvLocacoes.Columns["Id_Cidade"].Index)
            {
                if (e.Value != null)
                {
                    e.Value = ObterNomeCidadeLocacao();
                }
            }

            dgvLocacoes.Columns["Nome_Aniversariante"].HeaderText = "Nome do Aniversariante";
            dgvLocacoes.Columns["Sobrenome_Aniversariante"].HeaderText = "Sobrenome do Aniversariante";
            dgvLocacoes.Columns["Horario_Locacao"].HeaderText = "Horário da Locação";
            dgvLocacoes.Columns["Data_Locacao"].HeaderText = "Data da Locação";
            dgvLocacoes.Columns["Id_Locacao"].HeaderText = "Identificador da Locação";
            dgvLocacoes.Columns["CPF_Cliente"].HeaderText = "CPF do Cliente";
            dgvLocacoes.Columns["Numero"].HeaderText = "Número";
            dgvLocacoes.Columns["Id_Cidade"].HeaderText = "Cidade";
        }
        private string ObterNomeCidadeCliente()
        {
            ExibirDadosRepositorio exibirRepositorio = new ExibirDadosRepositorio();
            exibirRepositorio.ObterNomeCidadeCliente();
            if (exibirRepositorio.error == true)
            {
                MessageBox.Show(exibirRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Erro";
            }
            return exibirRepositorio.message;
        }
        private string ObterNomeCidadeLocacao()
        {
            ExibirDadosRepositorio exibirRepositorio = new ExibirDadosRepositorio();
            exibirRepositorio.ObterNomeCidadeLocacao();
            if (exibirRepositorio.error == true)
            {
                MessageBox.Show(exibirRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Erro";
            }
            return exibirRepositorio.message;
        }
    }
}
