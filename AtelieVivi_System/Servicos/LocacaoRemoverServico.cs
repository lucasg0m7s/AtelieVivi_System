using AtelieVivi_System.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Servicos
{
    public class LocacaoRemoverServico
    {
        private int Id_Locacao;
        public LocacaoRemoverServico(string Id_Selecionado)
        {
            Id_Locacao = ObterComboLocacao(Id_Selecionado);
        }
        public static void AtribuirComboLocacao(ref ComboBox Locacao)
        {
            LocacaoRemocaoRepositorio locacoesRepositorio = new LocacaoRemocaoRepositorio();
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

        public void PreencherDataGridView(ref DataGridView dgvLocacoes, Button remover)
        {
            LocacaoRemocaoRepositorio locacoesRepositorio = new LocacaoRemocaoRepositorio();
            if (locacoesRepositorio.PreencherDataGridView(ref dgvLocacoes, Id_Locacao) != "")
            {
                MessageBox.Show(locacoesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                remover.Enabled = true;
                dgvLocacoes.Visible = true;
            }
        }
        public void TratarDataGridView(DataGridView dgvLocacoes, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvLocacoes.Columns["CPF_Cliente"].Index)
            {
                if (e.Value != null)
                {
                    string valor = e.Value.ToString();

                    e.Value = Convert.ToUInt64(valor).ToString(@"000\.000\.000\-00");
                }
            }

            if (e.ColumnIndex == dgvLocacoes.Columns["Id_Cidade"].Index && e.RowIndex == 0)
            {
                e.Value = ObterNomeCidade();
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
        private string ObterNomeCidade()
        {
            LocacaoRemocaoRepositorio locacoesRepositorio = new LocacaoRemocaoRepositorio();
            locacoesRepositorio.ObterNomeCidade(Id_Locacao);
            if (locacoesRepositorio.error == true)
            {
                MessageBox.Show(locacoesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Erro";
            }
            return locacoesRepositorio.message;
        }
        public void RemoverLocacao(Button remover, DataGridView dgvLocacoes, ComboBox comboLocacoes)
        {
            LocacaoRemocaoRepositorio locacoesRepositorio = new LocacaoRemocaoRepositorio();
            DialogResult removerLocacao = MessageBox.Show("Deseja mesmo excluir essa locação?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (removerLocacao == DialogResult.Yes)
            {
                if (locacoesRepositorio.RemoverCliente(Id_Locacao) != "")
                {
                    MessageBox.Show(locacoesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Locação Removida com Sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    comboLocacoes.SelectedIndex = -1;
                    remover.Enabled = false;
                    dgvLocacoes.Visible = false;
                    AtribuirComboLocacao(ref comboLocacoes);
                }
            }
        }
    }
}
