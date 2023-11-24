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
    }
}
