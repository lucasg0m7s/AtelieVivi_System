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

namespace AtelieVivi_System.View
{
    public partial class Atualizacao_Clientes : Form
    {
        public Atualizacao_Clientes()
        {
            InitializeComponent();
            ClienteAtualizarServicos.AtribuirComboCidade(ref comboCidade);
            ClienteAtualizarServicos.AtribuirComboCliente(ref comboClientes);
        }
        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {    
            Panel[] panels = {panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12, panel13, panel14, panel15};
            ClienteAtualizarServicos.Ativar_Atribuir(panels, comboClientes ,mskCPF, mskRG, mskCelular, txtNome, txtSobrenome, txtComplemento, txtLogradouro, txtRua, txtBairro, txtNumero, txtInsta, comboCidade, btnAtualizar);
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
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
                Id_Cidade = ClienteAtualizarServicos.ObterComboCidade(comboCidade.Text)
            };
            ClienteAtualizarServicos.ValidarCampos_e_Atualizar(cliente);
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
