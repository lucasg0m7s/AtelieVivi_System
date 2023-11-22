using AtelieVivi_System.Model;
using AtelieVivi_System.Servicos;
using MaterialSkin;
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
    public partial class Cadastro_Clientes : Form
    {
        public Cadastro_Clientes()
        {
            InitializeComponent();
            ClienteCadastroServico.AtribuirComboCidade(ref comboCidade);
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            var cliente = new Clientes
            {
                CPF = mskCPF.Text,
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                Complemento = txtComplemento.Text,
                Logradouro = txtLogradouro.Text,
                Rua = txtRua.Text,
                Bairro = txtBairro.Text,
                Numero = txtNumero.Text,
                RG = mskRG.Text,
                Celular = mskCelular.Text,
                User_Insta = txtInsta.Text,
                Id_Cidade = ClienteCadastroServico.ObterComboCidade(comboCidade.Text)
            };
            ClienteCadastroServico.ValidarCampos_e_Cadastrar(cliente, mskCPF, mskRG, mskCelular, txtNome, txtSobrenome, txtComplemento, txtLogradouro, txtRua, txtBairro, txtNumero, txtInsta);
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
           Validacao_Eventos.PermitirCTRL_Letras(sender, e);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_Letras(txtNome);
        }

        private void txtSobrenome_KeyDown(object sender, KeyEventArgs e)
        {
            Validacao_Eventos.PermitirCTRL_Letras(sender, e);
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_Letras(txtSobrenome);
        }

        private void txtInsta_TextChanged(object sender, EventArgs e)
        {
            Validacao_Eventos.VerificarConteudoCampo_SemEspacos(txtInsta);
        }

        private void txtInsta_KeyDown(object sender, KeyEventArgs e)
        {
            Validacao_Eventos.PermitirCTRL_SemEspaco(sender, e);
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
