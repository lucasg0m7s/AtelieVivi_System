﻿namespace AtelieVivi_System
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelRemoverSubmenu = new System.Windows.Forms.Panel();
            this.btnRemoverLocacao = new FontAwesome.Sharp.IconButton();
            this.btnRemoveClientes = new FontAwesome.Sharp.IconButton();
            this.btnRemover = new FontAwesome.Sharp.IconButton();
            this.panelAtualizarSubmenu = new System.Windows.Forms.Panel();
            this.btnAtualizarLocacoes = new FontAwesome.Sharp.IconButton();
            this.btnAtualizarClientes = new FontAwesome.Sharp.IconButton();
            this.btnAtualizar = new FontAwesome.Sharp.IconButton();
            this.panelCadastrosSubmenu = new System.Windows.Forms.Panel();
            this.btnCadastroLocacoes = new FontAwesome.Sharp.IconButton();
            this.btnCadastroClientes = new FontAwesome.Sharp.IconButton();
            this.btnCadastrar = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelRemoverSubmenu.SuspendLayout();
            this.panelAtualizarSubmenu.SuspendLayout();
            this.panelCadastrosSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(213)))), ((int)(((byte)(66)))));
            this.panelSideMenu.Controls.Add(this.panelRemoverSubmenu);
            this.panelSideMenu.Controls.Add(this.btnRemover);
            this.panelSideMenu.Controls.Add(this.panelAtualizarSubmenu);
            this.panelSideMenu.Controls.Add(this.btnAtualizar);
            this.panelSideMenu.Controls.Add(this.panelCadastrosSubmenu);
            this.panelSideMenu.Controls.Add(this.btnCadastrar);
            this.panelSideMenu.Controls.Add(this.btnPesquisar);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 600);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelRemoverSubmenu
            // 
            this.panelRemoverSubmenu.BackColor = System.Drawing.Color.Silver;
            this.panelRemoverSubmenu.Controls.Add(this.btnRemoverLocacao);
            this.panelRemoverSubmenu.Controls.Add(this.btnRemoveClientes);
            this.panelRemoverSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRemoverSubmenu.Location = new System.Drawing.Point(0, 488);
            this.panelRemoverSubmenu.Name = "panelRemoverSubmenu";
            this.panelRemoverSubmenu.Size = new System.Drawing.Size(250, 100);
            this.panelRemoverSubmenu.TabIndex = 7;
            // 
            // btnRemoverLocacao
            // 
            this.btnRemoverLocacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoverLocacao.FlatAppearance.BorderSize = 0;
            this.btnRemoverLocacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverLocacao.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRemoverLocacao.IconChar = FontAwesome.Sharp.IconChar._500Px;
            this.btnRemoverLocacao.IconColor = System.Drawing.Color.Black;
            this.btnRemoverLocacao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoverLocacao.IconSize = 38;
            this.btnRemoverLocacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverLocacao.Location = new System.Drawing.Point(0, 40);
            this.btnRemoverLocacao.Name = "btnRemoverLocacao";
            this.btnRemoverLocacao.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRemoverLocacao.Size = new System.Drawing.Size(250, 40);
            this.btnRemoverLocacao.TabIndex = 1;
            this.btnRemoverLocacao.Text = "Remover Locações";
            this.btnRemoverLocacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverLocacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoverLocacao.UseVisualStyleBackColor = true;
            this.btnRemoverLocacao.Click += new System.EventHandler(this.btnRemoverLocacao_Click);
            // 
            // btnRemoveClientes
            // 
            this.btnRemoveClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveClientes.FlatAppearance.BorderSize = 0;
            this.btnRemoveClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveClientes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRemoveClientes.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnRemoveClientes.IconColor = System.Drawing.Color.Black;
            this.btnRemoveClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveClientes.IconSize = 38;
            this.btnRemoveClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveClientes.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveClientes.Name = "btnRemoveClientes";
            this.btnRemoveClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRemoveClientes.Size = new System.Drawing.Size(250, 40);
            this.btnRemoveClientes.TabIndex = 0;
            this.btnRemoveClientes.Text = "Remover Cliente";
            this.btnRemoveClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveClientes.UseVisualStyleBackColor = true;
            this.btnRemoveClientes.Click += new System.EventHandler(this.btnRemoveClientes_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnRemover.IconColor = System.Drawing.Color.Black;
            this.btnRemover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemover.IconSize = 38;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(0, 438);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRemover.Size = new System.Drawing.Size(250, 50);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover Dados";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // panelAtualizarSubmenu
            // 
            this.panelAtualizarSubmenu.BackColor = System.Drawing.Color.Silver;
            this.panelAtualizarSubmenu.Controls.Add(this.btnAtualizarLocacoes);
            this.panelAtualizarSubmenu.Controls.Add(this.btnAtualizarClientes);
            this.panelAtualizarSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtualizarSubmenu.Location = new System.Drawing.Point(0, 338);
            this.panelAtualizarSubmenu.Name = "panelAtualizarSubmenu";
            this.panelAtualizarSubmenu.Size = new System.Drawing.Size(250, 100);
            this.panelAtualizarSubmenu.TabIndex = 5;
            // 
            // btnAtualizarLocacoes
            // 
            this.btnAtualizarLocacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtualizarLocacoes.FlatAppearance.BorderSize = 0;
            this.btnAtualizarLocacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarLocacoes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAtualizarLocacoes.IconChar = FontAwesome.Sharp.IconChar._500Px;
            this.btnAtualizarLocacoes.IconColor = System.Drawing.Color.Black;
            this.btnAtualizarLocacoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtualizarLocacoes.IconSize = 38;
            this.btnAtualizarLocacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarLocacoes.Location = new System.Drawing.Point(0, 40);
            this.btnAtualizarLocacoes.Name = "btnAtualizarLocacoes";
            this.btnAtualizarLocacoes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAtualizarLocacoes.Size = new System.Drawing.Size(250, 40);
            this.btnAtualizarLocacoes.TabIndex = 1;
            this.btnAtualizarLocacoes.Text = "Atualizar Locações";
            this.btnAtualizarLocacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarLocacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizarLocacoes.UseVisualStyleBackColor = true;
            this.btnAtualizarLocacoes.Click += new System.EventHandler(this.btnAtualizarLocacoes_Click);
            // 
            // btnAtualizarClientes
            // 
            this.btnAtualizarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtualizarClientes.FlatAppearance.BorderSize = 0;
            this.btnAtualizarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarClientes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAtualizarClientes.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnAtualizarClientes.IconColor = System.Drawing.Color.Black;
            this.btnAtualizarClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtualizarClientes.IconSize = 38;
            this.btnAtualizarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarClientes.Location = new System.Drawing.Point(0, 0);
            this.btnAtualizarClientes.Name = "btnAtualizarClientes";
            this.btnAtualizarClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAtualizarClientes.Size = new System.Drawing.Size(250, 40);
            this.btnAtualizarClientes.TabIndex = 0;
            this.btnAtualizarClientes.Text = "Atualizar Clientes";
            this.btnAtualizarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizarClientes.UseVisualStyleBackColor = true;
            this.btnAtualizarClientes.Click += new System.EventHandler(this.btnAtualizarClientes_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnAtualizar.IconColor = System.Drawing.Color.Black;
            this.btnAtualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtualizar.IconSize = 38;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(0, 288);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(250, 50);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar Dados";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // panelCadastrosSubmenu
            // 
            this.panelCadastrosSubmenu.BackColor = System.Drawing.Color.Silver;
            this.panelCadastrosSubmenu.Controls.Add(this.btnCadastroLocacoes);
            this.panelCadastrosSubmenu.Controls.Add(this.btnCadastroClientes);
            this.panelCadastrosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastrosSubmenu.Location = new System.Drawing.Point(0, 200);
            this.panelCadastrosSubmenu.Name = "panelCadastrosSubmenu";
            this.panelCadastrosSubmenu.Size = new System.Drawing.Size(250, 88);
            this.panelCadastrosSubmenu.TabIndex = 3;
            // 
            // btnCadastroLocacoes
            // 
            this.btnCadastroLocacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroLocacoes.FlatAppearance.BorderSize = 0;
            this.btnCadastroLocacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroLocacoes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastroLocacoes.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnCadastroLocacoes.IconColor = System.Drawing.Color.Black;
            this.btnCadastroLocacoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastroLocacoes.IconSize = 38;
            this.btnCadastroLocacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroLocacoes.Location = new System.Drawing.Point(0, 40);
            this.btnCadastroLocacoes.Name = "btnCadastroLocacoes";
            this.btnCadastroLocacoes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastroLocacoes.Size = new System.Drawing.Size(250, 40);
            this.btnCadastroLocacoes.TabIndex = 1;
            this.btnCadastroLocacoes.Text = "Cadastro de Locações";
            this.btnCadastroLocacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroLocacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroLocacoes.UseVisualStyleBackColor = true;
            this.btnCadastroLocacoes.Click += new System.EventHandler(this.btnCadastroLocacoes_Click);
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroClientes.FlatAppearance.BorderSize = 0;
            this.btnCadastroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroClientes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastroClientes.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCadastroClientes.IconColor = System.Drawing.Color.Black;
            this.btnCadastroClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastroClientes.IconSize = 38;
            this.btnCadastroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroClientes.Location = new System.Drawing.Point(0, 0);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCadastroClientes.Size = new System.Drawing.Size(250, 40);
            this.btnCadastroClientes.TabIndex = 0;
            this.btnCadastroClientes.Text = "Cadastro de Clientes";
            this.btnCadastroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroClientes.UseVisualStyleBackColor = true;
            this.btnCadastroClientes.Click += new System.EventHandler(this.btnCadastroClientes_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCadastrar.IconColor = System.Drawing.Color.Black;
            this.btnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrar.IconSize = 38;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 150);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(250, 50);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastros";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnPesquisar.IconColor = System.Drawing.Color.Black;
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 38;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(0, 100);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(250, 50);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 600);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(1014, 639);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelRemoverSubmenu.ResumeLayout(false);
            this.panelAtualizarSubmenu.ResumeLayout(false);
            this.panelCadastrosSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.Panel panelCadastrosSubmenu;
        private FontAwesome.Sharp.IconButton btnCadastroLocacoes;
        private FontAwesome.Sharp.IconButton btnCadastroClientes;
        private FontAwesome.Sharp.IconButton btnCadastrar;
        private System.Windows.Forms.Panel panelRemoverSubmenu;
        private FontAwesome.Sharp.IconButton btnRemoverLocacao;
        private FontAwesome.Sharp.IconButton btnRemoveClientes;
        private FontAwesome.Sharp.IconButton btnRemover;
        private System.Windows.Forms.Panel panelAtualizarSubmenu;
        private FontAwesome.Sharp.IconButton btnAtualizarLocacoes;
        private FontAwesome.Sharp.IconButton btnAtualizarClientes;
        private FontAwesome.Sharp.IconButton btnAtualizar;
    }
}

