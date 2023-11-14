namespace AtelieVivi_System.View
{
    partial class Cadastro_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSobrenome = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCPF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtCelular = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtRG = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtInsta = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTopBar = new System.Windows.Forms.Label();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboCidade = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLogradouro = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBairro = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRua = new MaterialSkin.Controls.MaterialTextBox();
            this.txtComplemento = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.LeaveOnEnterKey = true;
            this.txtNome.Location = new System.Drawing.Point(12, 60);
            this.txtNome.MaxLength = 50;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 50);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "";
            this.txtNome.TrailingIcon = null;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSobrenome.AnimateReadOnly = false;
            this.txtSobrenome.BackColor = System.Drawing.Color.White;
            this.txtSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSobrenome.Depth = 0;
            this.txtSobrenome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSobrenome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSobrenome.Hint = "Sobrenome";
            this.txtSobrenome.LeadingIcon = null;
            this.txtSobrenome.LeaveOnEnterKey = true;
            this.txtSobrenome.Location = new System.Drawing.Point(12, 116);
            this.txtSobrenome.MaxLength = 50;
            this.txtSobrenome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSobrenome.Multiline = false;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(204, 50);
            this.txtSobrenome.TabIndex = 1;
            this.txtSobrenome.Text = "";
            this.txtSobrenome.TrailingIcon = null;
            // 
            // txtCPF
            // 
            this.txtCPF.AllowPromptAsInput = true;
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.AnimateReadOnly = false;
            this.txtCPF.AsciiOnly = false;
            this.txtCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCPF.BeepOnError = false;
            this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCPF.Depth = 0;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.HidePromptOnLeave = false;
            this.txtCPF.HideSelection = true;
            this.txtCPF.Hint = "CPF";
            this.txtCPF.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCPF.LeadingIcon = null;
            this.txtCPF.Location = new System.Drawing.Point(12, 172);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.MaxLength = 32767;
            this.txtCPF.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.PrefixSuffixText = null;
            this.txtCPF.PromptChar = '_';
            this.txtCPF.ReadOnly = false;
            this.txtCPF.RejectInputOnFirstFailure = false;
            this.txtCPF.ResetOnPrompt = true;
            this.txtCPF.ResetOnSpace = true;
            this.txtCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.ShortcutsEnabled = true;
            this.txtCPF.Size = new System.Drawing.Size(204, 48);
            this.txtCPF.SkipLiterals = true;
            this.txtCPF.TabIndex = 3;
            this.txtCPF.TabStop = false;
            this.txtCPF.Text = "   .   .   -";
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCPF.TrailingIcon = null;
            this.txtCPF.UseSystemPasswordChar = false;
            this.txtCPF.ValidatingType = null;
            // 
            // txtCelular
            // 
            this.txtCelular.AllowPromptAsInput = true;
            this.txtCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCelular.AnimateReadOnly = false;
            this.txtCelular.AsciiOnly = false;
            this.txtCelular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCelular.BeepOnError = false;
            this.txtCelular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCelular.Depth = 0;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCelular.HidePromptOnLeave = false;
            this.txtCelular.HideSelection = true;
            this.txtCelular.Hint = "Celular";
            this.txtCelular.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCelular.LeadingIcon = null;
            this.txtCelular.Location = new System.Drawing.Point(12, 280);
            this.txtCelular.Mask = "(00)00000-0000";
            this.txtCelular.MaxLength = 32767;
            this.txtCelular.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.PrefixSuffixText = null;
            this.txtCelular.PromptChar = '_';
            this.txtCelular.ReadOnly = false;
            this.txtCelular.RejectInputOnFirstFailure = false;
            this.txtCelular.ResetOnPrompt = true;
            this.txtCelular.ResetOnSpace = true;
            this.txtCelular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCelular.SelectedText = "";
            this.txtCelular.SelectionLength = 0;
            this.txtCelular.SelectionStart = 0;
            this.txtCelular.ShortcutsEnabled = true;
            this.txtCelular.Size = new System.Drawing.Size(204, 48);
            this.txtCelular.SkipLiterals = true;
            this.txtCelular.TabIndex = 5;
            this.txtCelular.TabStop = false;
            this.txtCelular.Text = "(  )     -";
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCelular.TrailingIcon = null;
            this.txtCelular.UseSystemPasswordChar = false;
            this.txtCelular.ValidatingType = null;
            // 
            // txtRG
            // 
            this.txtRG.AllowPromptAsInput = true;
            this.txtRG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRG.AnimateReadOnly = false;
            this.txtRG.AsciiOnly = false;
            this.txtRG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRG.BeepOnError = false;
            this.txtRG.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRG.Depth = 0;
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRG.HidePromptOnLeave = false;
            this.txtRG.HideSelection = true;
            this.txtRG.Hint = "RG";
            this.txtRG.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtRG.LeadingIcon = null;
            this.txtRG.Location = new System.Drawing.Point(12, 226);
            this.txtRG.Mask = "00,000,000-0";
            this.txtRG.MaxLength = 32767;
            this.txtRG.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRG.Name = "txtRG";
            this.txtRG.PasswordChar = '\0';
            this.txtRG.PrefixSuffixText = null;
            this.txtRG.PromptChar = '_';
            this.txtRG.ReadOnly = false;
            this.txtRG.RejectInputOnFirstFailure = false;
            this.txtRG.ResetOnPrompt = true;
            this.txtRG.ResetOnSpace = true;
            this.txtRG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRG.SelectedText = "";
            this.txtRG.SelectionLength = 0;
            this.txtRG.SelectionStart = 0;
            this.txtRG.ShortcutsEnabled = true;
            this.txtRG.Size = new System.Drawing.Size(204, 48);
            this.txtRG.SkipLiterals = true;
            this.txtRG.TabIndex = 4;
            this.txtRG.TabStop = false;
            this.txtRG.Text = "  .   .   -";
            this.txtRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRG.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtRG.TrailingIcon = null;
            this.txtRG.UseSystemPasswordChar = false;
            this.txtRG.ValidatingType = null;
            // 
            // txtInsta
            // 
            this.txtInsta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsta.AnimateReadOnly = false;
            this.txtInsta.BackColor = System.Drawing.Color.White;
            this.txtInsta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsta.Depth = 0;
            this.txtInsta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInsta.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtInsta.Hint = "User do Instagram";
            this.txtInsta.LeadingIcon = null;
            this.txtInsta.LeaveOnEnterKey = true;
            this.txtInsta.Location = new System.Drawing.Point(12, 334);
            this.txtInsta.MaxLength = 50;
            this.txtInsta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInsta.Multiline = false;
            this.txtInsta.Name = "txtInsta";
            this.txtInsta.Size = new System.Drawing.Size(204, 50);
            this.txtInsta.TabIndex = 6;
            this.txtInsta.Text = "";
            this.txtInsta.TrailingIcon = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelTopBar);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtInsta);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.txtSobrenome);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtRG);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 454);
            this.panel1.TabIndex = 10;
            // 
            // labelTopBar
            // 
            this.labelTopBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTopBar.AutoSize = true;
            this.labelTopBar.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.labelTopBar.Location = new System.Drawing.Point(11, 11);
            this.labelTopBar.Name = "labelTopBar";
            this.labelTopBar.Size = new System.Drawing.Size(95, 35);
            this.labelTopBar.TabIndex = 10;
            this.labelTopBar.Text = "Dados";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.HighEmphasis = true;
            this.btnCadastrar.Icon = null;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 393);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCadastrar.Size = new System.Drawing.Size(106, 36);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCadastrar.UseAccentColor = false;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.comboCidade);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNumero);
            this.panel2.Controls.Add(this.txtLogradouro);
            this.panel2.Controls.Add(this.txtBairro);
            this.panel2.Controls.Add(this.txtRua);
            this.panel2.Controls.Add(this.txtComplemento);
            this.panel2.Location = new System.Drawing.Point(345, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 454);
            this.panel2.TabIndex = 11;
            // 
            // comboCidade
            // 
            this.comboCidade.AutoResize = false;
            this.comboCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboCidade.Depth = 0;
            this.comboCidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboCidade.DropDownHeight = 174;
            this.comboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCidade.DropDownWidth = 121;
            this.comboCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboCidade.FormattingEnabled = true;
            this.comboCidade.IntegralHeight = false;
            this.comboCidade.ItemHeight = 43;
            this.comboCidade.Items.AddRange(new object[] {
            "1) Nova Odessa",
            "2) Sumaré"});
            this.comboCidade.Location = new System.Drawing.Point(12, 333);
            this.comboCidade.MaxDropDownItems = 4;
            this.comboCidade.MouseState = MaterialSkin.MouseState.OUT;
            this.comboCidade.Name = "comboCidade";
            this.comboCidade.Size = new System.Drawing.Size(204, 49);
            this.comboCidade.StartIndex = 0;
            this.comboCidade.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Endereço";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.AnimateReadOnly = false;
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Depth = 0;
            this.txtNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumero.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNumero.Hint = "Número";
            this.txtNumero.LeadingIcon = null;
            this.txtNumero.LeaveOnEnterKey = true;
            this.txtNumero.Location = new System.Drawing.Point(12, 276);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(204, 50);
            this.txtNumero.TabIndex = 9;
            this.txtNumero.Text = "";
            this.txtNumero.TrailingIcon = null;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogradouro.AnimateReadOnly = false;
            this.txtLogradouro.BackColor = System.Drawing.Color.White;
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogradouro.Depth = 0;
            this.txtLogradouro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogradouro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtLogradouro.Hint = "Logradouro";
            this.txtLogradouro.LeadingIcon = null;
            this.txtLogradouro.LeaveOnEnterKey = true;
            this.txtLogradouro.Location = new System.Drawing.Point(12, 52);
            this.txtLogradouro.MaxLength = 50;
            this.txtLogradouro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLogradouro.Multiline = false;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(204, 50);
            this.txtLogradouro.TabIndex = 0;
            this.txtLogradouro.Text = "";
            this.txtLogradouro.TrailingIcon = null;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.AnimateReadOnly = false;
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Depth = 0;
            this.txtBairro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBairro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtBairro.Hint = "Bairro";
            this.txtBairro.LeadingIcon = null;
            this.txtBairro.LeaveOnEnterKey = true;
            this.txtBairro.Location = new System.Drawing.Point(12, 220);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBairro.Multiline = false;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(204, 50);
            this.txtBairro.TabIndex = 8;
            this.txtBairro.Text = "";
            this.txtBairro.TrailingIcon = null;
            // 
            // txtRua
            // 
            this.txtRua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRua.AnimateReadOnly = false;
            this.txtRua.BackColor = System.Drawing.Color.White;
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRua.Depth = 0;
            this.txtRua.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRua.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtRua.Hint = "Rua";
            this.txtRua.LeadingIcon = null;
            this.txtRua.LeaveOnEnterKey = true;
            this.txtRua.Location = new System.Drawing.Point(12, 164);
            this.txtRua.MaxLength = 50;
            this.txtRua.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRua.Multiline = false;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(204, 50);
            this.txtRua.TabIndex = 6;
            this.txtRua.Text = "";
            this.txtRua.TrailingIcon = null;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplemento.AnimateReadOnly = false;
            this.txtComplemento.BackColor = System.Drawing.Color.White;
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplemento.Depth = 0;
            this.txtComplemento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtComplemento.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtComplemento.Hint = "Complemento";
            this.txtComplemento.LeadingIcon = null;
            this.txtComplemento.LeaveOnEnterKey = true;
            this.txtComplemento.Location = new System.Drawing.Point(12, 108);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtComplemento.Multiline = false;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(204, 50);
            this.txtComplemento.TabIndex = 1;
            this.txtComplemento.Text = "";
            this.txtComplemento.TrailingIcon = null;
            // 
            // Cadastro_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Cadastro_Clientes";
            this.Text = "Cadastro de Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtNome;
        private MaterialSkin.Controls.MaterialTextBox txtSobrenome;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCPF;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCelular;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRG;
        private MaterialSkin.Controls.MaterialTextBox txtInsta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox txtLogradouro;
        private MaterialSkin.Controls.MaterialButton btnCadastrar;
        private MaterialSkin.Controls.MaterialTextBox txtBairro;
        private MaterialSkin.Controls.MaterialTextBox txtRua;
        private MaterialSkin.Controls.MaterialTextBox txtComplemento;
        private MaterialSkin.Controls.MaterialTextBox txtNumero;
        private System.Windows.Forms.Label labelTopBar;
        private MaterialSkin.Controls.MaterialComboBox comboCidade;
        private System.Windows.Forms.Label label1;
    }
}