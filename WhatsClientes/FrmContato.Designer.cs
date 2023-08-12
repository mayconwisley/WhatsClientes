namespace WhatsClientes
{
    partial class FrmContato
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContato));
            groupBox2 = new GroupBox();
            DgvListarContato = new DataGridView();
            ContatoId = new DataGridViewTextBoxColumn();
            ContatoNome = new DataGridViewTextBoxColumn();
            ContatoDDI = new DataGridViewTextBoxColumn();
            ContatoTelefone = new DataGridViewLinkColumn();
            groupBox1 = new GroupBox();
            TxtDDI = new TextBox();
            BtnIrWhats = new Button();
            BtnExcluir = new Button();
            BtnAtualizar = new Button();
            BtnAdicionar = new Button();
            MktTelefone = new MaskedTextBox();
            Telefone = new Label();
            TxtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            TxtPesquisa = new TextBox();
            LblInfo = new Label();
            label3 = new Label();
            LkLblProjetoGit = new LinkLabel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListarContato).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvListarContato);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(12, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 226);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Contatos";
            // 
            // DgvListarContato
            // 
            DgvListarContato.AllowUserToAddRows = false;
            DgvListarContato.AllowUserToDeleteRows = false;
            DgvListarContato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvListarContato.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvListarContato.BackgroundColor = SystemColors.Control;
            DgvListarContato.BorderStyle = BorderStyle.Fixed3D;
            DgvListarContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListarContato.Columns.AddRange(new DataGridViewColumn[] { ContatoId, ContatoNome, ContatoDDI, ContatoTelefone });
            DgvListarContato.Dock = DockStyle.Fill;
            DgvListarContato.Location = new Point(3, 19);
            DgvListarContato.MultiSelect = false;
            DgvListarContato.Name = "DgvListarContato";
            DgvListarContato.ReadOnly = true;
            DgvListarContato.RowTemplate.Height = 25;
            DgvListarContato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvListarContato.Size = new Size(373, 204);
            DgvListarContato.TabIndex = 0;
            DgvListarContato.CellContentClick += DgvListarContato_CellContentClick;
            DgvListarContato.CellDoubleClick += DgvListarContato_CellDoubleClick;
            // 
            // ContatoId
            // 
            ContatoId.DataPropertyName = "Id";
            ContatoId.HeaderText = "Id";
            ContatoId.Name = "ContatoId";
            ContatoId.ReadOnly = true;
            ContatoId.Visible = false;
            ContatoId.Width = 42;
            // 
            // ContatoNome
            // 
            ContatoNome.DataPropertyName = "Nome";
            ContatoNome.HeaderText = "Nome";
            ContatoNome.Name = "ContatoNome";
            ContatoNome.ReadOnly = true;
            ContatoNome.Width = 65;
            // 
            // ContatoDDI
            // 
            ContatoDDI.DataPropertyName = "DDI";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            ContatoDDI.DefaultCellStyle = dataGridViewCellStyle1;
            ContatoDDI.HeaderText = "DDI";
            ContatoDDI.Name = "ContatoDDI";
            ContatoDDI.ReadOnly = true;
            ContatoDDI.Width = 51;
            // 
            // ContatoTelefone
            // 
            ContatoTelefone.ActiveLinkColor = Color.Blue;
            ContatoTelefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            ContatoTelefone.DefaultCellStyle = dataGridViewCellStyle2;
            ContatoTelefone.HeaderText = "Telefone";
            ContatoTelefone.LinkBehavior = LinkBehavior.NeverUnderline;
            ContatoTelefone.LinkColor = Color.Blue;
            ContatoTelefone.Name = "ContatoTelefone";
            ContatoTelefone.ReadOnly = true;
            ContatoTelefone.VisitedLinkColor = Color.Blue;
            ContatoTelefone.Width = 57;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtDDI);
            groupBox1.Controls.Add(BtnIrWhats);
            groupBox1.Controls.Add(BtnExcluir);
            groupBox1.Controls.Add(BtnAtualizar);
            groupBox1.Controls.Add(BtnAdicionar);
            groupBox1.Controls.Add(MktTelefone);
            groupBox1.Controls.Add(Telefone);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(15, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionar Contato";
            // 
            // TxtDDI
            // 
            TxtDDI.Location = new Point(223, 37);
            TxtDDI.MaxLength = 4;
            TxtDDI.Name = "TxtDDI";
            TxtDDI.Size = new Size(40, 23);
            TxtDDI.TabIndex = 1;
            TxtDDI.Text = "55";
            // 
            // BtnIrWhats
            // 
            BtnIrWhats.FlatAppearance.MouseDownBackColor = Color.DimGray;
            BtnIrWhats.FlatAppearance.MouseOverBackColor = Color.Green;
            BtnIrWhats.FlatStyle = FlatStyle.Flat;
            BtnIrWhats.Location = new Point(253, 75);
            BtnIrWhats.Name = "BtnIrWhats";
            BtnIrWhats.Size = new Size(113, 23);
            BtnIrWhats.TabIndex = 6;
            BtnIrWhats.Text = "Ir &Whatsapp Web";
            BtnIrWhats.UseVisualStyleBackColor = true;
            BtnIrWhats.Click += BtnIrWhats_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Enabled = false;
            BtnExcluir.FlatAppearance.MouseDownBackColor = Color.DimGray;
            BtnExcluir.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnExcluir.FlatStyle = FlatStyle.Flat;
            BtnExcluir.Location = new Point(172, 75);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(75, 23);
            BtnExcluir.TabIndex = 5;
            BtnExcluir.Text = "&Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.Enabled = false;
            BtnAtualizar.FlatAppearance.MouseDownBackColor = Color.DimGray;
            BtnAtualizar.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnAtualizar.FlatStyle = FlatStyle.Flat;
            BtnAtualizar.Location = new Point(91, 75);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(75, 23);
            BtnAtualizar.TabIndex = 4;
            BtnAtualizar.Text = "At&ualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.FlatAppearance.MouseDownBackColor = Color.DimGray;
            BtnAdicionar.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnAdicionar.FlatStyle = FlatStyle.Flat;
            BtnAdicionar.Location = new Point(10, 75);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(75, 23);
            BtnAdicionar.TabIndex = 3;
            BtnAdicionar.Text = "&Adicionar";
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += BtnAdicionar_Click;
            // 
            // MktTelefone
            // 
            MktTelefone.Location = new Point(269, 37);
            MktTelefone.Mask = "(99) 9 0000-0000";
            MktTelefone.Name = "MktTelefone";
            MktTelefone.Size = new Size(100, 23);
            MktTelefone.TabIndex = 2;
            MktTelefone.Leave += MktTelefone_Leave;
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(269, 19);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 2;
            Telefone.Text = "Número";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(9, 37);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(208, 23);
            TxtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 19);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 0;
            label2.Text = "DDI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TxtPesquisa);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(12, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(379, 58);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pesquisa";
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(9, 18);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(360, 23);
            TxtPesquisa.TabIndex = 0;
            TxtPesquisa.TextChanged += TxtPesquisa_TextChanged;
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Location = new Point(18, 424);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(79, 15);
            LblInfo.TabIndex = 3;
            LblInfo.Text = "Contatos: 000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 463);
            label3.Name = "label3";
            label3.Size = new Size(309, 30);
            label3.TabIndex = 4;
            label3.Text = "Dois cliques sobre o item para excluir ou alterar\r\nUm clique sobre o telefone para acessar o Whatsapp Web";
            // 
            // LkLblProjetoGit
            // 
            LkLblProjetoGit.AutoSize = true;
            LkLblProjetoGit.Location = new Point(18, 500);
            LkLblProjetoGit.Name = "LkLblProjetoGit";
            LkLblProjetoGit.Size = new Size(92, 15);
            LkLblProjetoGit.TabIndex = 5;
            LkLblProjetoGit.TabStop = true;
            LkLblProjetoGit.Text = "Projeto - Github";
            LkLblProjetoGit.LinkClicked += LkLblProjetoGit_LinkClicked;
            // 
            // FrmContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(402, 524);
            Controls.Add(LkLblProjetoGit);
            Controls.Add(label3);
            Controls.Add(LblInfo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contatos";
            Load += FrmContato_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListarContato).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView DgvListarContato;
        private GroupBox groupBox1;
        private Button BtnExcluir;
        private Button BtnAdicionar;
        private MaskedTextBox MktTelefone;
        private Label Telefone;
        private TextBox TxtNome;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox TxtPesquisa;
        private Button BtnAtualizar;
        private TextBox TxtDDI;
        private Label label2;
        private Label LblInfo;
        private Label label3;
        private DataGridViewTextBoxColumn ContatoId;
        private DataGridViewTextBoxColumn ContatoNome;
        private DataGridViewTextBoxColumn ContatoDDI;
        private DataGridViewLinkColumn ContatoTelefone;
        private LinkLabel LkLblProjetoGit;
        private Button BtnIrWhats;
    }
}