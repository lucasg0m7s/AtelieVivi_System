namespace AtelieVivi_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAbrirMenu = new FontAwesome.Sharp.IconButton();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.labelTopBar = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelSideMenu.SuspendLayout();
            this.panelRemoverSubmenu.SuspendLayout();
            this.panelAtualizarSubmenu.SuspendLayout();
            this.panelCadastrosSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTopBar.SuspendLayout();
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
            this.panelRemoverSubmenu.Location = new System.Drawing.Point(0, 499);
            this.panelRemoverSubmenu.Name = "panelRemoverSubmenu";
            this.panelRemoverSubmenu.Size = new System.Drawing.Size(250, 84);
            this.panelRemoverSubmenu.TabIndex = 7;
            // 
            // btnRemoverLocacao
            // 
            this.btnRemoverLocacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoverLocacao.FlatAppearance.BorderSize = 0;
            this.btnRemoverLocacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverLocacao.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRemoverLocacao.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnRemoverLocacao.IconColor = System.Drawing.Color.Black;
            this.btnRemoverLocacao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoverLocacao.IconSize = 38;
            this.btnRemoverLocacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverLocacao.Location = new System.Drawing.Point(0, 40);
            this.btnRemoverLocacao.Name = "btnRemoverLocacao";
            this.btnRemoverLocacao.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btnRemoverLocacao.Size = new System.Drawing.Size(250, 40);
            this.btnRemoverLocacao.TabIndex = 1;
            this.btnRemoverLocacao.Tag = "Remover Locações";
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
            this.btnRemoveClientes.Tag = "Remover Cliente";
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
            this.btnRemover.Location = new System.Drawing.Point(0, 449);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRemover.Size = new System.Drawing.Size(250, 50);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Tag = "Remover Dados";
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
            this.panelAtualizarSubmenu.Location = new System.Drawing.Point(0, 365);
            this.panelAtualizarSubmenu.Name = "panelAtualizarSubmenu";
            this.panelAtualizarSubmenu.Size = new System.Drawing.Size(250, 84);
            this.panelAtualizarSubmenu.TabIndex = 5;
            // 
            // btnAtualizarLocacoes
            // 
            this.btnAtualizarLocacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtualizarLocacoes.FlatAppearance.BorderSize = 0;
            this.btnAtualizarLocacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarLocacoes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAtualizarLocacoes.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnAtualizarLocacoes.IconColor = System.Drawing.Color.Black;
            this.btnAtualizarLocacoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtualizarLocacoes.IconSize = 38;
            this.btnAtualizarLocacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarLocacoes.Location = new System.Drawing.Point(0, 40);
            this.btnAtualizarLocacoes.Name = "btnAtualizarLocacoes";
            this.btnAtualizarLocacoes.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btnAtualizarLocacoes.Size = new System.Drawing.Size(250, 40);
            this.btnAtualizarLocacoes.TabIndex = 1;
            this.btnAtualizarLocacoes.Tag = "Atualizar Locações";
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
            this.btnAtualizarClientes.Tag = "Atualizar Clientes";
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
            this.btnAtualizar.Location = new System.Drawing.Point(0, 315);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(250, 50);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Tag = "Atualizar Dados";
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
            this.panelCadastrosSubmenu.Location = new System.Drawing.Point(0, 231);
            this.panelCadastrosSubmenu.Name = "panelCadastrosSubmenu";
            this.panelCadastrosSubmenu.Size = new System.Drawing.Size(250, 84);
            this.panelCadastrosSubmenu.TabIndex = 3;
            // 
            // btnCadastroLocacoes
            // 
            this.btnCadastroLocacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroLocacoes.FlatAppearance.BorderSize = 0;
            this.btnCadastroLocacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroLocacoes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCadastroLocacoes.IconChar = FontAwesome.Sharp.IconChar.LocationDot;
            this.btnCadastroLocacoes.IconColor = System.Drawing.Color.Black;
            this.btnCadastroLocacoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastroLocacoes.IconSize = 36;
            this.btnCadastroLocacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroLocacoes.Location = new System.Drawing.Point(0, 40);
            this.btnCadastroLocacoes.Name = "btnCadastroLocacoes";
            this.btnCadastroLocacoes.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btnCadastroLocacoes.Size = new System.Drawing.Size(250, 40);
            this.btnCadastroLocacoes.TabIndex = 1;
            this.btnCadastroLocacoes.Tag = "Cadastro de Locações";
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
            this.btnCadastroClientes.Tag = "Cadastro de Clientes";
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
            this.btnCadastrar.Location = new System.Drawing.Point(0, 181);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(250, 50);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Tag = "Cadastros";
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
            this.btnPesquisar.Location = new System.Drawing.Point(0, 131);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(250, 50);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Tag = "Pesquisar";
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.btnAbrirMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 131);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAbrirMenu
            // 
            this.btnAbrirMenu.FlatAppearance.BorderSize = 0;
            this.btnAbrirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirMenu.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnAbrirMenu.IconColor = System.Drawing.Color.Black;
            this.btnAbrirMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbrirMenu.Location = new System.Drawing.Point(205, 0);
            this.btnAbrirMenu.Name = "btnAbrirMenu";
            this.btnAbrirMenu.Size = new System.Drawing.Size(45, 60);
            this.btnAbrirMenu.TabIndex = 0;
            this.btnAbrirMenu.UseVisualStyleBackColor = true;
            this.btnAbrirMenu.Click += new System.EventHandler(this.btnAbrirMenu_Click);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(213)))), ((int)(((byte)(66)))));
            this.panelTopBar.Controls.Add(this.btnHome);
            this.panelTopBar.Controls.Add(this.btnMinimize);
            this.panelTopBar.Controls.Add(this.btnMaximize);
            this.panelTopBar.Controls.Add(this.btnClose);
            this.panelTopBar.Controls.Add(this.labelTopBar);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(250, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(748, 100);
            this.panelTopBar.TabIndex = 1;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.SlateGray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(646, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 30);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.SlateGray;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.Location = new System.Drawing.Point(679, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(36, 30);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.SlateGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(712, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelTopBar
            // 
            this.labelTopBar.AutoSize = true;
            this.labelTopBar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopBar.Location = new System.Drawing.Point(32, 67);
            this.labelTopBar.Name = "labelTopBar";
            this.labelTopBar.Size = new System.Drawing.Size(59, 22);
            this.labelTopBar.TabIndex = 0;
            this.labelTopBar.Text = "Home";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(748, 500);
            this.panelChildForm.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.SlateGray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 30;
            this.btnHome.Location = new System.Drawing.Point(613, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(36, 30);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelSideMenu.ResumeLayout(false);
            this.panelRemoverSubmenu.ResumeLayout(false);
            this.panelAtualizarSubmenu.ResumeLayout(false);
            this.panelCadastrosSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
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
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label labelTopBar;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnAbrirMenu;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnHome;
    }
}

