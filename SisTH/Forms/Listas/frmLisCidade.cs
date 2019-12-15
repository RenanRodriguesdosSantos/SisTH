using SisTH.Forms.Cadastros;
using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Windows.Forms;

namespace SisTH.Forms.Consultas
{
    public partial class frmLisCidade : Form
    {
        private CidadeController cidadeCtrl;
        private EnfermeiroEntity usuario;
        public frmLisCidade(EnfermeiroEntity Usuario)
        {
            InitializeComponent();
            this.usuario = Usuario;
        }

        private void AtualizarGrid()
        {
            cidadeCtrl = new CidadeController();
            dgvLisModelo.DataSource = cidadeCtrl.ReadAll();
            dgvLisModelo.Update();
            dgvLisModelo.Refresh();
        }

        private void FrmLisModelo_Load(object sender, EventArgs e)
        {
            this.Size = this.MdiParent.Size;
            lblNomeUser.Text = usuario.Nome;
            lblCoren.Text = Convert.ToString(usuario.Coren);
            this.AtualizarGrid();
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
                    int result = new CidadeController().Delete(id);
                    if (result != 0)
                    {
                        MessageBox.Show("Dados Excluidos com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.AtualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnLisModeloCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadCidade().ShowDialog(this);
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
                new frmCadCidade(id).ShowDialog(this);
                this.AtualizarGrid();
            }
        }
    }
}
