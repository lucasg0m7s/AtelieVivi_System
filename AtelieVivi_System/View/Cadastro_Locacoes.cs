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

        private void mskData_Validating(object sender, CancelEventArgs e)
        {
        }
    }
}
