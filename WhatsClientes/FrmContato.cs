using System.Diagnostics;
using WhatsClientes.Model;
using WhatsClientes.Repository;

namespace WhatsClientes
{
    public partial class FrmContato : Form
    {
        IContatoRepository _contatoRepository;
        int id;

        public FrmContato(IContatoRepository contatoRepository)
        {
            InitializeComponent();
            _contatoRepository = contatoRepository;
        }

        private async void ListarContatos(string pesquisa)
        {
            DgvListarContato.DataSource = await _contatoRepository.ListarContatos(pesquisa);
            int totalContatos = DgvListarContato.RowCount;
            LblInfo.Text = $"Contatos: {totalContatos:000}";
        }
        private void LimparCampos()
        {
            MktTelefone.Clear();
            MktTelefone.Mask = "(99) 9 0000-0000";
            TxtNome.Clear();
            TxtDDI.Text = "55";

            BtnAdicionar.Enabled = true;
            BtnAtualizar.Enabled = false;
            BtnExcluir.Enabled = false;
        }
        private void FrmContato_Load(object sender, EventArgs e)
        {
            ListarContatos(TxtPesquisa.Text.Trim());
        }

        private async void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Contato contato = new();

            try
            {
                contato.DDI = TxtDDI.Text.Trim();
                contato.Nome = TxtNome.Text.Trim();
                contato.Telefone = MktTelefone.Text.Trim();

                await _contatoRepository.Inserir(contato);
                LimparCampos();
                ListarContatos(TxtPesquisa.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                await _contatoRepository.Excluir(id);
                LimparCampos();
                ListarContatos(TxtPesquisa.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Contato contato = new();

            try
            {
                contato.Id = id;
                contato.DDI = TxtDDI.Text.Trim();
                contato.Nome = TxtNome.Text.Trim();
                contato.Telefone = MktTelefone.Text.Trim();

                await _contatoRepository.Alterar(contato);
                LimparCampos();
                ListarContatos(TxtPesquisa.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvListarContato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var strId = DgvListarContato.Rows[e.RowIndex].Cells["ContatoId"].Value.ToString();
                if (strId is not null)
                {
                    id = int.Parse(strId);
                }

                TxtDDI.Text = DgvListarContato.Rows[e.RowIndex].Cells["ContatoDDI"].Value.ToString();
                TxtNome.Text = DgvListarContato.Rows[e.RowIndex].Cells["ContatoNome"].Value.ToString();

                var telefone = DgvListarContato.Rows[e.RowIndex].Cells["ContatoTelefone"].Value.ToString();

                if (telefone is not null)
                {
                    if (telefone.Length == 14)
                    {
                        MktTelefone.Mask = "(99) 0000-0000";
                    }
                    else
                    {
                        MktTelefone.Mask = "(99) 9 0000-0000";
                    }

                    MktTelefone.Text = telefone;
                }

                BtnAdicionar.Enabled = false;
                BtnAtualizar.Enabled = true;
                BtnExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvListarContato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListarContato.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                string? tel = DgvListarContato.Rows[e.RowIndex].Cells["ContatoTelefone"].Value.ToString();
                string? ddi = DgvListarContato.Rows[e.RowIndex].Cells["ContatoDDI"].Value.ToString();

                if (tel is not null)
                {
                    tel = tel.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                }

                string apiTel = $"https://api.whatsapp.com/send?phone={ddi}{tel}";

                // Verificar o sistema operacional atual
                if (OperatingSystem.IsWindows())
                {
                    // Abrir a página da web no navegador padrão do Windows
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = apiTel,
                        UseShellExecute = true
                    });
                }
                else if (OperatingSystem.IsMacOS())
                {
                    // Abrir a página da web no navegador padrão do macOS
                    Process.Start("open", apiTel);
                }
                else if (OperatingSystem.IsLinux())
                {
                    // Abrir a página da web no navegador padrão do Linux
                    Process.Start("xdg-open", apiTel);
                }
                else
                {
                    // Sistema operacional não suportado
                    MessageBox.Show("Sistema operacional não suportado.");
                }
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            ListarContatos(TxtPesquisa.Text.Trim());
        }

        private void MktTelefone_Leave(object sender, EventArgs e)
        {
            string telefone = MktTelefone.Text.Trim();

            if (telefone.Length > 15)
            {
                MktTelefone.Mask = "(99) 9 0000-0000";
            }
            else
            {
                MktTelefone.Mask = "(99) 0000-0000";
            }
        }
    }
}
