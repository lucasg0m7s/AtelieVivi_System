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
    public partial class Remocao_Clientes : Form
    {
        public Remocao_Clientes()
        {
            InitializeComponent();
            ClientesRemocaoServico.AtribuirComboCliente(ref comboClientes);

        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientesRemocaoServico clientesRemocao = new ClientesRemocaoServico(comboClientes.Text);
            clientesRemocao.PreencherDataGridView(ref dgvClientes, btnRemover);
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ClientesRemocaoServico clientesRemocao = new ClientesRemocaoServico(comboClientes.Text);
            clientesRemocao.TratarDataGridView(dgvClientes, e);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ClientesRemocaoServico clientesRemocao = new ClientesRemocaoServico(comboClientes.Text);
            clientesRemocao.RemoverCliente(btnRemover, dgvClientes, comboClientes);
        }
    }
}
