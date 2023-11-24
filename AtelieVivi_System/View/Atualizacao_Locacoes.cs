using AtelieVivi_System.Model;
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
using System.Windows.Interop;

namespace AtelieVivi_System.View
{
    public partial class Atualizacao_Locacoes : Form
    {
        public Atualizacao_Locacoes()
        {
            InitializeComponent();
            LocacaoAtualizarServico.AtribuirComboLocacao(ref comboLocacoes);
            LocacaoAtualizarServico.AtribuirComboCidade(ref comboCidade);
            LocacaoAtualizarServico.AtribuirComboCliente(ref comboCliente);
        }

        private void comboLocacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel[] panels = {panel3, panel4, panel5, panel6, panel8, panel9, panel10, panel11, panel12, panel13, panel14, panel1, panel2};
            LocacaoAtualizarServico.Ativar_Atribuir(panels, comboLocacoes, mskData, mskHora, txtNome, txtSobrenome, txtTema, txtComplemento, txtLogradouro, txtRua, txtBairro, txtNumero, comboCidade, comboCliente, btnAtualizar);
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var Locacoes = new Locacoes
            {
                Data_Locacao = mskData.Text,
                Horario_Locacao = mskHora.Text,
                Nome_Aniversariante = txtNome.Text,
                Sobrenome_Aniversariante = txtSobrenome.Text,
                Tema = txtTema.Text,
                Complemento = txtComplemento.Text,
                Logradouro = txtLogradouro.Text,
                Rua = txtRua.Text,
                Bairro = txtBairro.Text,
                Numero = txtNumero.Text,
                Id_Cidade = LocacaoAtualizarServico.ObterComboCidade(comboCidade.Text),
                CPF_Cliente = LocacaoAtualizarServico.ObterComboCliente(comboCliente.Text),
            };
            LocacaoAtualizarServico.ValidarCampos_e_Atualizar(Locacoes);
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_Letras(txtNome);
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            Validacao_Eventos.PermitirCTRL_Letras(sender, e);
        }
        private void txtSobrenome_KeyDown(object sender, KeyEventArgs e)
        {
            Validacao_Eventos.PermitirCTRL_Letras(sender, e);
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_Letras(txtSobrenome);
        }

        private void txtTema_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_LetrasNumerosEspacos(txtTema);
        }

        private void txtTema_KeyDown(object sender, KeyEventArgs e)
        {
            Validacao_Eventos.PermitirCTRL_LetrasNumerosEspacos(sender, e);
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_LetrasEspacos(txtLogradouro);
        }

        private void txtLogradouro_KeyDown(object sender, KeyEventArgs e)
        {
            Validacao_Eventos.PermitirCTRL_LetrasEspacos(sender, e);
        }
        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_LetrasEspacos(txtComplemento);
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            Validacao_Eventos.PermitirCTRL_LetrasEspacos(sender, e);
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_LetrasEspacos(txtBairro);
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            Validacao_Eventos.PermitirCTRL_LetrasEspacos(sender, e);
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_LetrasNumeros(txtNumero);
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            Validacao_Eventos.PermitirCTRL_LetrasNumeros(sender, e);
        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_LetrasEspacos(txtRua);
        }

        private void txtRua_KeyDown(object sender, KeyEventArgs e)
        {
            Validacao_Eventos.PermitirCTRL_LetrasEspacos(sender, e);
        }
    }
}
