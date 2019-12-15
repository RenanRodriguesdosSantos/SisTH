using SisTH.Forms.Cadastros;
using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Windows.Forms;

namespace SisTH.Forms.Consultas
{
    public partial class frmLisPadrao : Form
    {
        private PadraoController padraoCtrl;
        private String nome;
        private String tabela;

        public frmLisPadrao(EnfermeiroEntity Enfermeiro, String Tabela, String Nome)
        {
            InitializeComponent();
            this.nome = Nome;
            this.tabela = Tabela;
            lblNomeUser.Text = Enfermeiro.Nome;
            lblCoren.Text = Convert.ToString(Enfermeiro.Coren);
        }

        private void AtualizarGrid()
        {
            padraoCtrl = new PadraoController(this.tabela);
            dgvLisModelo.DataSource = padraoCtrl.ReadAll();
            dgvLisModelo.Update();
            dgvLisModelo.Refresh();
        }

        private void FrmLisModelo_Load(object sender, EventArgs e)
        {
            this.Size = this.MdiParent.Size;
            this.lblTitulo.Text = "Lista de " + this.nome;
            this.AtualizarGrid();
        }

        private void BtnLisModeloCadastrar_Click(object sender, EventArgs e)
        {
            frmCadPadrao frmCadPadrao = new frmCadPadrao(this.tabela, this.nome);
            frmCadPadrao.ShowDialog(this);
            this.AtualizarGrid();
        }

        private void BtnLisModeloEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvLisModelo.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione uma linha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Int32 id = Convert.ToInt32(dgvLisModelo.CurrentRow.Cells["Id"].Value);
                new frmCadPadrao(this.tabela, this.nome, id).ShowDialog(this);
                this.AtualizarGrid();
            }
        }

        private void BtnLisModeloExcluir_Click(object sender, EventArgs e)
        {
            if (this.dgvLisModelo.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione uma linha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Deseja realmente excluir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Int32 id = Convert.ToInt32(dgvLisModelo.CurrentRow.Cells["Id"].Value);
                    int result = new PadraoController(this.tabela).Delete(id);
                    if (result != 0)
                    {
                        this.AtualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

