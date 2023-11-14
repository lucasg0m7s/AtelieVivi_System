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
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes
            {
                CPF = txtCPF.Text,
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                Complemento = txtComplemento.Text,
                Logradouro = txtLogradouro.Text,
                Rua = txtRua.Text,
                Bairro = txtBairro.Text,
                Numero = txtNumero.Text,
                RG = txtRG.Text,
                Celular = txtCelular.Text,
                User_Insta = txtInsta.Text,
                Id_Cidade = ClienteServico.ObterComboCidade(comboCidade.Text)
            };
            MessageBox.Show($"{cliente.Id_Cidade}");
            MessageBox.Show(ClienteServico.Cadastrar(cliente));
        }
    }
}
