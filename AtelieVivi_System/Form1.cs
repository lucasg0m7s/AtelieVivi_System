using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelCadastrosSubmenu.Visible = false;
            panelAtualizarSubmenu.Visible = false;
            panelRemoverSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelCadastrosSubmenu.Visible == true)
            {
                panelCadastrosSubmenu.Visible = false;
            }
            if (panelAtualizarSubmenu.Visible == true)
            {
                panelAtualizarSubmenu.Visible = false;
            }
            if (panelRemoverSubmenu.Visible == true)
            {
                panelRemoverSubmenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCadastrosSubmenu);
        }
    }
}
