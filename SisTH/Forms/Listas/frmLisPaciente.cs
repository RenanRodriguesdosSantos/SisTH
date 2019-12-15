using SisTH.Forms.Cadastros;
using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Windows.Forms;

namespace SisTH.Forms.Listas
{
    public partial class frmLisPaciente : Form
    {
        private PacienteController pacienteCtrl;
        private EnfermeiroEntity usuario;

        public frmLisPaciente(EnfermeiroEntity Usuario)
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

        private void AtualizarGrid()
        {
            pacienteCtrl = new PacienteController();
            dgvLisModelo.DataSource = pacienteCtrl.ReadAll();
            dgvLisModelo.Update();
            dgvLisModelo.Refresh();
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
                    int result  = new PacienteController().Delete(id);
                    if (result != 0)
                    {
                        MessageBox.Show("Dados excluídos com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            new frmCadPaciente().ShowDialog(this);
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
                new frmCadPaciente(null,id).ShowDialog(this);
                this.AtualizarGrid();
            }
        }
    }
}
