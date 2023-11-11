using AtelieVivi_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtelieVivi_System
{
    public partial class Form1 : Form
    {
        //Construtor
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
            CollapseMenu();
            openChildFormInPanel(new Home());
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
        private void btnAbrirMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            CollapseMenu();
        }
        private void CollapseMenu()
        {
            if (this.panelSideMenu.Width > 200) //Collapse menu
            {
                panelSideMenu.Width = 100;
                pictureBox1.Visible = false;
                btnAbrirMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelSideMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                foreach (Button menuButton in panelCadastrosSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                foreach (Button menuButton in panelAtualizarSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                foreach (Button menuButton in panelRemoverSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelSideMenu.Width = 250;
                pictureBox1.Visible = true;
                btnAbrirMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelSideMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                foreach (Button menuButton in panelCadastrosSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(35, 0, 0, 0);
                }
                foreach (Button menuButton in panelAtualizarSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(35, 0, 0, 0);
                }
                foreach (Button menuButton in panelRemoverSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(35, 0, 0, 0);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
        #region Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCadastrosSubmenu);
        }
        private void btnCadastroClientes_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Cadastro_Clientes());
            hideSubMenu();
        }

        private void btnCadastroLocacoes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAtualizarSubmenu);

        }
        private void btnAtualizarClientes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAtualizarLocacoes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region Remover
        private void btnRemover_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRemoverSubmenu);

        }

        private void btnRemoveClientes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRemoverLocacao_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Home());
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }  
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTopBar.Text = childForm.Text.ToUpper();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
