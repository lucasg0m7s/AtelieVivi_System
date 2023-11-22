using AtelieVivi_System.Servicos;
using AtelieVivi_System.Model;
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
using System.Globalization;

namespace AtelieVivi_System.View
{
    public partial class Cadastro_Locacoes : Form
    {
        public Cadastro_Locacoes()
        {
            InitializeComponent();
            LocacaoCadastroServico.AtribuirComboCidade(ref comboCidade);
            LocacaoCadastroServico.AtribuirComboCliente(ref comboCliente);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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
                Id_Cidade = LocacaoCadastroServico.ObterComboCidade(comboCidade.Text),
                CPF_Cliente = LocacaoCadastroServico.ObterComboCliente(comboCliente.Text),               
            };
            LocacaoCadastroServico.ValidarCampos_e_Cadastrar(Locacoes, mskData, mskHora, txtNome, txtSobrenome, txtTema, txtComplemento, txtLogradouro, txtRua, txtBairro, txtNumero);
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
