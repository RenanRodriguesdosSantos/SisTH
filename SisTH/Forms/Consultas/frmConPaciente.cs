using SisTH.Forms.Cadastros;
using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Windows.Forms;

namespace SisTH.Forms.Consultas
{
    public partial class frmConPaciente : Form
    {
        PacienteController pacienteCtrl;
        PacienteEntity paciente;

        public frmConPaciente(String Nome)
        {
            InitializeComponent();
            txtNome.Text = Nome;
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            if (this.dgvLisModelo.SelectedRows.Count != 1)
            {
                MessageBox.Show("Selecione uma linha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                paciente = new PacienteEntity();
                paciente.Id = Convert.ToInt32(dgvLisModelo.CurrentRow.Cells["ID"].Value);
                paciente.Nome = Convert.ToString(dgvLisModelo.CurrentRow.Cells["Nome"].Value);
                paciente.NomeMae = Convert.ToString(dgvLisModelo.CurrentRow.Cells[2].Value);
                paciente.Cpf = Convert.ToString(dgvLisModelo.CurrentRow.Cells["Cpf"].Value);
                paciente.Nascimento = Convert.ToDateTime(dgvLisModelo.CurrentRow.Cells["Nascimento"].Value);
                this.Close();
            }
        }

        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.paciente = null;
            this.Close();
        }

        private void BtnLisModeloPesquisar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String mae = txtNomeMae.Text;
            String nascimento = txtNascimento.Text;
            pacienteCtrl = new PacienteController();
            DateTime Nascimento = new DateTime(); ;
            bool isDate = true;
            try
            {
                Nascimento = Convert.ToDateTime(nascimento);
            }
            catch(Exception E)
            {
                isDate = false;
            }
            
            if (isDate)
            {
                dgvLisModelo.DataSource = pacienteCtrl.ReadByParametrs(nome, mae, Nascimento);
            }
            else
            {
                dgvLisModelo.DataSource = pacienteCtrl.ReadByParametrs(nome, mae);
            }

            dgvLisModelo.Update();
            dgvLisModelo.Refresh();
        }

        private void FrmConPaciente_Load(object sender, EventArgs e)
        {
            pacienteCtrl = new PacienteController();
            if (txtNome.Text == "")
            {
                dgvLisModelo.DataSource = pacienteCtrl.ReadAll();
                dgvLisModelo.Update();
                dgvLisModelo.Refresh();
            }
            else
            {
                dgvLisModelo.DataSource = pacienteCtrl.ReadByParametrs(txtNome.Text,"");
                dgvLisModelo.Update();
                dgvLisModelo.Refresh();
            }
        }

        private void BtnLisModeloCadastrar_Click(object sender, EventArgs e)
        {
            paciente = new PacienteEntity();
            paciente.Nome = txtNome.Text;
            paciente.NomeMae = txtNomeMae.Text;
            try
            {
                paciente.Nascimento = Convert.ToDateTime(txtNascimento.Text);
            }
            catch
            {
                paciente.Nascimento = null;
            }

            new frmCadPaciente(paciente).ShowDialog(this);
            pacienteCtrl = new PacienteController();
            dgvLisModelo.DataSource = pacienteCtrl.ReadUltimo();
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
                Int32 id = Convert.ToInt32(dgvLisModelo.CurrentRow.Cells["ID"].Value);
                new frmCadPaciente(null,id).ShowDialog(this);
                pacienteCtrl = new PacienteController();
                dgvLisModelo.DataSource = pacienteCtrl.ReadByParametrs(id);
                dgvLisModelo.Update();
                dgvLisModelo.Refresh();
            }
        }

        public PacienteEntity GetPaciente(IWin32Window telaPrincipal)
        {
            paciente = null;
            this.ShowDialog(telaPrincipal);
            return paciente;
        }

        private void FrmConPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.BtnCadModeloSalvar_Click(sender, e);
                    break;
                case Keys.Escape:
                    this.BtnCadModeloCancelar_Click(sender, e);
                    break;
            }
        }
    }
}
