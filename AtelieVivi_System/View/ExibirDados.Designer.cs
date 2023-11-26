namespace AtelieVivi_System.View
{
    partial class ExibirDados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTopBar = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.radioCliente = new System.Windows.Forms.RadioButton();
            this.radioLocacao = new System.Windows.Forms.RadioButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvLocacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTopBar
            // 
            this.labelTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTopBar.AutoSize = true;
            this.labelTopBar.Font = new System.Drawing.Font("Yu Gothic", 20F);
            this.labelTopBar.Location = new System.Drawing.Point(44, 28);
            this.labelTopBar.Name = "labelTopBar";
            this.labelTopBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTopBar.Size = new System.Drawing.Size(391, 35);
            this.labelTopBar.TabIndex = 12;
            this.labelTopBar.Text = "O que você deseja pesquisar?";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel10.Location = new System.Drawing.Point(148, 166);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(239, 1);
            this.panel10.TabIndex = 51;
            this.panel10.Visible = false;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPesquisar.ForeColor = System.Drawing.Color.Black;
            this.lblPesquisar.Location = new System.Drawing.Point(45, 141);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(97, 21);
            this.lblPesquisar.TabIndex = 50;
            this.lblPesquisar.Text = "PESQUISAR";
            this.lblPesquisar.Visible = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtPesquisar.Location = new System.Drawing.Point(148, 141);
            this.txtPesquisar.MaxLength = 30;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(239, 19);
            this.txtPesquisar.TabIndex = 49;
            this.txtPesquisar.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(213)))), ((int)(((byte)(66)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnPesquisar.IconColor = System.Drawing.Color.Black;
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 38;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(402, 131);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(63, 43);
            this.btnPesquisar.TabIndex = 52;
            this.btnPesquisar.Tag = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Visible = false;
            // 
            // radioCliente
            // 
            this.radioCliente.AutoSize = true;
            this.radioCliente.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCliente.Location = new System.Drawing.Point(49, 86);
            this.radioCliente.Name = "radioCliente";
            this.radioCliente.Size = new System.Drawing.Size(92, 25);
            this.radioCliente.TabIndex = 53;
            this.radioCliente.TabStop = true;
            this.radioCliente.Text = "Clientes";
            this.radioCliente.UseVisualStyleBackColor = true;
            this.radioCliente.CheckedChanged += new System.EventHandler(this.radioCliente_CheckedChanged);
            // 
            // radioLocacao
            // 
            this.radioLocacao.AutoSize = true;
            this.radioLocacao.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLocacao.Location = new System.Drawing.Point(148, 86);
            this.radioLocacao.Name = "radioLocacao";
            this.radioLocacao.Size = new System.Drawing.Size(101, 25);
            this.radioLocacao.TabIndex = 54;
            this.radioLocacao.TabStop = true;
            this.radioLocacao.Text = "Locações";
            this.radioLocacao.UseVisualStyleBackColor = true;
            this.radioLocacao.CheckedChanged += new System.EventHandler(this.radioLocacao_CheckedChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(213)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(213)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(49, 196);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowTemplate.Height = 40;
            this.dgvClientes.Size = new System.Drawing.Size(586, 233);
            this.dgvClientes.TabIndex = 55;
            this.dgvClientes.Visible = false;
            this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientes_CellFormatting);
            // 
            // dgvLocacoes
            // 
            this.dgvLocacoes.AllowUserToAddRows = false;
            this.dgvLocacoes.AllowUserToDeleteRows = false;
            this.dgvLocacoes.AllowUserToResizeColumns = false;
            this.dgvLocacoes.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLocacoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLocacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLocacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLocacoes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLocacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLocacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(213)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(213)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLocacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocacoes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLocacoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvLocacoes.EnableHeadersVisualStyles = false;
            this.dgvLocacoes.Location = new System.Drawing.Point(50, 196);
            this.dgvLocacoes.Name = "dgvLocacoes";
            this.dgvLocacoes.ReadOnly = true;
            this.dgvLocacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLocacoes.RowHeadersVisible = false;
            this.dgvLocacoes.RowTemplate.Height = 40;
            this.dgvLocacoes.Size = new System.Drawing.Size(586, 233);
            this.dgvLocacoes.TabIndex = 56;
            this.dgvLocacoes.Visible = false;
            this.dgvLocacoes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLocacoes_CellFormatting);
            // 
            // ExibirDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 461);
            this.Controls.Add(this.dgvLocacoes);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.radioLocacao);
            this.Controls.Add(this.radioCliente);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.labelTopBar);
            this.Name = "ExibirDados";
            this.Text = "Pesquisar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTopBar;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.RadioButton radioCliente;
        private System.Windows.Forms.RadioButton radioLocacao;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvLocacoes;
    }
}