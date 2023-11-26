using AtelieVivi_System.Model;
using AtelieVivi_System.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System.Servicos
{
    public class ClienteRemocaoServico
    {
        private string CPF_Selecionado;

        public ClienteRemocaoServico(string CPF_Selecionado)
        {
            this.CPF_Selecionado = ObterComboCliente(CPF_Selecionado);
        }

        public static void AtribuirComboCliente(ref ComboBox Cliente)
        {
            ClienteRemocaoRepositorio clientesRepositorio = new ClienteRemocaoRepositorio();
            if (clientesRepositorio.AtribuirComboCliente(ref Cliente) != "")
            {
                MessageBox.Show(clientesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string ObterComboCliente(string Cliente)
        {
            string cpf_cliente = "0";
            if (!string.IsNullOrWhiteSpace(Cliente))
            {
                string caracterDelimitador = " -";
                int indiceDelimitador = Cliente.IndexOf(caracterDelimitador);

                if (indiceDelimitador != -1)
                {
                    Cliente = Cliente.Substring(0, indiceDelimitador);
                    cpf_cliente = Cliente.Replace(".", "").Replace("-", "");
                }
            }
            return cpf_cliente;
        }

        public void PreencherDataGridView(ref DataGridView dgvClientes, Button remover)
        {
            ClienteRemocaoRepositorio clientesRepositorio = new ClienteRemocaoRepositorio();
            if (clientesRepositorio.PreencherDataGridView(ref dgvClientes, CPF_Selecionado) != "")
            {
                MessageBox.Show(clientesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                remover.Enabled = true;
                dgvClientes.Visible = true;
            }
        }

        public void TratarDataGridView(DataGridView dgvClientes, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvClientes.Columns["CPF"].Index)
            {
                if (e.Value != null)
                {
                    string valor = e.Value.ToString();

                    e.Value = Convert.ToUInt64(valor).ToString(@"000\.000\.000\-00");
                }
            }
            else if (e.ColumnIndex == dgvClientes.Columns["RG"].Index)
            {
                if (e.Value != null)
                {
                    string valor = e.Value.ToString();

                    e.Value = Convert.ToUInt64(valor).ToString(@"00\.000\.000\-0");
                }
            }
            else if (e.ColumnIndex == dgvClientes.Columns["Celular"].Index)
            {
                if (e.Value != null)
                {
                    string valor = e.Value.ToString();

                    e.Value = Convert.ToUInt64(valor).ToString(@"\(00\) 00000-0000");
                }
            }

            if (e.ColumnIndex == dgvClientes.Columns["Id_Cidade"].Index && e.RowIndex == 0)
            {
                e.Value = ObterNomeCidade();
            }
            dgvClientes.Columns["User_Insta"].HeaderText = "Usuário do Instagram";
            dgvClientes.Columns["Numero"].HeaderText = "Número";
            dgvClientes.Columns["Id_Cidade"].HeaderText = "Cidade";
        }

        private string ObterNomeCidade()
        {
            ClienteRemocaoRepositorio clientesRepositorio = new ClienteRemocaoRepositorio();
            clientesRepositorio.ObterNomeCidade(CPF_Selecionado);
            if (clientesRepositorio.error == true)
            {
                MessageBox.Show(clientesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Erro";
            }
            return clientesRepositorio.message;
        }

        public void RemoverCliente(Button remover, DataGridView dgvClientes, ComboBox comboClientes)
        {
            ClienteRemocaoRepositorio clientesRepositorio = new ClienteRemocaoRepositorio();
            DialogResult removerCliente = MessageBox.Show("Deseja mesmo excluir esse cliente? Ao fazer isso, todas as locações relacionadas a ele também serão excluídas.", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(removerCliente == DialogResult.Yes)
            {
                if (clientesRepositorio.RemoverCliente(CPF_Selecionado) != "")
                {
                    MessageBox.Show(clientesRepositorio.message, "Ocorreu um problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente Removido com Sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    comboClientes.SelectedIndex = -1;
                    remover.Enabled = false;
                    dgvClientes.Visible = false;
                    AtribuirComboCliente(ref comboClientes);
                }
            }
        }
    }
}
