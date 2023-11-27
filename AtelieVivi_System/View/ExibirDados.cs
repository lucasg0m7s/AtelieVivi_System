using AtelieVivi_System.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.View
{
    public partial class ExibirDados : Form
    {
        public ExibirDados()
        {
            InitializeComponent();
            ExibirDadosServico exibirDadosServico = new ExibirDadosServico();
            exibirDadosServico.PreencherdgvClientes(dgvClientes);
            exibirDadosServico.PreencherdgvLocacoes(dgvLocacoes);
        }

        private void dgvLocacoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ExibirDadosServico exibirDadosServico = new ExibirDadosServico();
            exibirDadosServico.TratardgvLocacoes(dgvLocacoes, e);
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ExibirDadosServico exibirDadosServico = new ExibirDadosServico();
            exibirDadosServico.TratardgvClientes(dgvClientes, e);
        }

        private void radioCliente_CheckedChanged(object sender, EventArgs e)
        {
            ExibirDadosServico exibirDadosServico = new ExibirDadosServico();
            exibirDadosServico.AtivarCampos(panel10, txtPesquisar, lblPesquisar);
            exibirDadosServico.AtivarDGVClientes(dgvLocacoes, dgvClientes);

        }

        private void radioLocacao_CheckedChanged(object sender, EventArgs e)
        {
            ExibirDadosServico exibirDadosServico = new ExibirDadosServico();
            exibirDadosServico.AtivarCampos(panel10, txtPesquisar, lblPesquisar);
            exibirDadosServico.AtivarDGVLocacoes(dgvLocacoes, dgvClientes);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            ExibirDadosServico exibirDadosServico = new ExibirDadosServico();
            exibirDadosServico.Filtrar(radioCliente, radioLocacao, dgvClientes, dgvLocacoes, txtPesquisar);
        }

        private void txtPesquisar_Validating(object sender, CancelEventArgs e)
        {
            ExibirDadosServico exibirDadosServico = new ExibirDadosServico();
            exibirDadosServico.LimparPesquisa(radioCliente, radioLocacao, dgvClientes, dgvLocacoes, txtPesquisar);
        }
    }
}
