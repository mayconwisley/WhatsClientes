using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private async void ListarContatos()
        {

            DgvListarContato.DataSource = await _contatoRepository.ListarContatos();
        }
        private void LimparCampos()
        {
            MktTelefone.Clear();
            TxtNome.Clear();
        }
        private void FrmContato_Load(object sender, EventArgs e)
        {
            ListarContatos();
        }

        private async void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Contato contato = new();

            try
            {
                contato.Nome = TxtNome.Text.Trim();
                contato.Telefone = MktTelefone.Text.Trim();

                await _contatoRepository.Inserir(contato);
                LimparCampos();
                ListarContatos();
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
                ListarContatos();
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
                contato.Nome = TxtNome.Text.Trim();
                contato.Telefone = MktTelefone.Text.Trim();

                await _contatoRepository.Alterar(contato);
                LimparCampos();
                ListarContatos();
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
                id = int.Parse(DgvListarContato.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtNome.Text = DgvListarContato.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                MktTelefone.Text = DgvListarContato.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
