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
            ClienteServico.AtribuirComboCidade(ref comboCidade);
            ClienteServico.LimparCampos(mskCPF, txtNome, txtSobrenome, txtComplemento, txtLogradouro, txtRua, txtBairro, txtNumero, mskRG, mskCelular, txtInsta, comboCidade);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClienteServico.ApenasLetrasEspaço(sender, e);
        }

        private void txtSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClienteServico.ApenasLetrasEspaço(sender, e);
        }

        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClienteServico.ApenasLetras(sender, e);
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
                Id_Cidade = ClienteServico.ObterComboCidade(comboCidade.Text)
            };
            ClienteServico.ValidarCampos_e_Cadastrar(cliente, mskCPF, mskRG, mskCelular);
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClienteServico.ApenasLetrasEspaço(sender, e);
        }

        private void txtLogradouro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClienteServico.ApenasLetrasEspaço(sender, e);
        }

        private void txtInsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClienteServico.NoSpaces(sender, e);
        }
    }
}
