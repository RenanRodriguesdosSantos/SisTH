using SisTH.Forms.Cadastros;
using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Windows.Forms;

namespace SisTH.Forms.Listas
{
    public partial class frmLisAtendimento : Form
    {
        private EnfermeiroEntity usuario;
        private AtendimentoController atendimentoCtrl;
        public frmLisAtendimento(EnfermeiroEntity Usuario)
        {
            InitializeComponent();
            this.usuario = Usuario;
        }

        private void FrmLisModelo_Load(object sender, EventArgs e)
        {
            this.Size = this.MdiParent.Size;
            lblNomeUser.Text = usuario.Nome;
            lblCoren.Text = Convert.ToString(usuario.Coren);
            this.AtualizarGrid();
        }

        private void BtnLisModeloCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadAtendimento(usuario).ShowDialog(this);
            this.AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            atendimentoCtrl = new AtendimentoController();
            dgvLisModelo.DataSource = atendimentoCtrl.ReadAll();
            dgvLisModelo.Update();
            dgvLisModelo.Refresh();
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
                new frmCadAtendimento(usuario, id).ShowDialog(this);
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
                    int result = new AtendimentoController().Delete(id);
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
