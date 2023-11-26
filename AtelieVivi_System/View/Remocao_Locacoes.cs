using AtelieVivi_System.Repositorios;
using AtelieVivi_System.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.View
{
    public partial class Remocao_Locacoes : Form
    {
        public Remocao_Locacoes()
        {
            InitializeComponent();
            LocacaoRemoverServico.AtribuirComboLocacao(ref comboLocacoes);
        }

        private void comboLocacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocacaoRemoverServico locacaoRemocao = new LocacaoRemoverServico(comboLocacoes.Text);
            locacaoRemocao.PreencherDataGridView(ref dgvLocacoes, btnRemover);
        }

        private void dgvLocacoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            LocacaoRemoverServico locacaoRemocao = new LocacaoRemoverServico(comboLocacoes.Text);
            locacaoRemocao.TratarDataGridView(dgvLocacoes, e);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            LocacaoRemoverServico locacaoRemocao = new LocacaoRemoverServico(comboLocacoes.Text);
            locacaoRemocao.RemoverLocacao(btnRemover , dgvLocacoes, comboLocacoes);
        }
    }
}
