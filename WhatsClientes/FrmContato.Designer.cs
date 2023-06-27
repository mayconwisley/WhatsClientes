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
            groupBox2 = new GroupBox();
            DgvListarContato = new DataGridView();
            ContatoId = new DataGridViewTextBoxColumn();
            ContatoNome = new DataGridViewTextBoxColumn();
            ContatoDDI = new DataGridViewTextBoxColumn();
            ContatoTelefone = new DataGridViewLinkColumn();
            groupBox1 = new GroupBox();
            TxtDDI = new TextBox();
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
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListarContato).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvListarContato);
            groupBox2.Location = new Point(12, 199);
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
            ContatoDDI.HeaderText = "DDI";
            ContatoDDI.Name = "ContatoDDI";
            ContatoDDI.ReadOnly = true;
            ContatoDDI.Width = 51;
            // 
            // ContatoTelefone
            // 
            ContatoTelefone.DataPropertyName = "Telefone";
            ContatoTelefone.HeaderText = "Telefone";
            ContatoTelefone.Name = "ContatoTelefone";
            ContatoTelefone.ReadOnly = true;
            ContatoTelefone.Width = 57;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtDDI);
            groupBox1.Controls.Add(BtnExcluir);
            groupBox1.Controls.Add(BtnAtualizar);
            groupBox1.Controls.Add(BtnAdicionar);
            groupBox1.Controls.Add(MktTelefone);
            groupBox1.Controls.Add(Telefone);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionar Contato";
            // 
            // TxtDDI
            // 
            TxtDDI.Location = new Point(220, 37);
            TxtDDI.MaxLength = 4;
            TxtDDI.Name = "TxtDDI";
            TxtDDI.Size = new Size(40, 23);
            TxtDDI.TabIndex = 1;
            TxtDDI.Text = "55";
            // 
            // BtnExcluir
            // 
            BtnExcluir.Enabled = false;
            BtnExcluir.Location = new Point(230, 75);
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
            BtnAtualizar.Location = new Point(149, 75);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(75, 23);
            BtnAtualizar.TabIndex = 4;
            BtnAtualizar.Text = "At&ualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Location = new Point(68, 75);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(75, 23);
            BtnAdicionar.TabIndex = 3;
            BtnAdicionar.Text = "&Adicionar";
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += BtnAdicionar_Click;
            // 
            // MktTelefone
            // 
            MktTelefone.Location = new Point(266, 37);
            MktTelefone.Mask = "(99) 9 0000-0000";
            MktTelefone.Name = "MktTelefone";
            MktTelefone.Size = new Size(100, 23);
            MktTelefone.TabIndex = 2;
            MktTelefone.Leave += MktTelefone_Leave;
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(266, 19);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 2;
            Telefone.Text = "Número";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(6, 37);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(208, 23);
            TxtNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 19);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 0;
            label2.Text = "DDI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TxtPesquisa);
            groupBox3.Location = new Point(12, 135);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(372, 58);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pesquisa";
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Location = new Point(6, 18);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(360, 23);
            TxtPesquisa.TabIndex = 0;
            TxtPesquisa.TextChanged += TxtPesquisa_TextChanged;
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Location = new Point(18, 428);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(79, 15);
            LblInfo.TabIndex = 3;
            LblInfo.Text = "Contatos: 000";
            // 
            // FrmContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 464);
            Controls.Add(LblInfo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private DataGridViewTextBoxColumn ContatoId;
        private DataGridViewTextBoxColumn ContatoNome;
        private DataGridViewTextBoxColumn ContatoDDI;
        private DataGridViewLinkColumn ContatoTelefone;
        private Label LblInfo;
    }
}