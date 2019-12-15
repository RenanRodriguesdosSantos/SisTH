using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisTH.Forms.Relatorios
{
    
    public partial class frmRelAtendimentoFiltros : Form
    {
        private PadraoController padraoCtrl;
        private DataTable dt;
        private AtendimentoEntity atendimento;
        public frmRelAtendimentoFiltros()
        {
            InitializeComponent();
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            atendimento = new AtendimentoEntity();
            if(txtId.Text != "")
            {
                try
                {
                    atendimento.Id = Convert.ToInt32(txtId.Text);
                }
                catch
                {
                    MessageBox.Show("Preencha o campo Id corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atendimento.Id = 0;
                }
            }
            else
            {
                atendimento.Id = 0;
            }
            if (txtRegistro.Text != "")
            {
                try
                {
                    atendimento.Registro = Convert.ToInt32(txtRegistro.Text);
                }
                catch
                {
                    MessageBox.Show("Preencha o campo Registro corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atendimento.Registro = 0;
                }
            }
            else
            {
                atendimento.Registro = 0;
            }

            String cpf = txtCpf.Text;

            atendimento.Paciente = txtNome.Text == "" ? null : txtNome.Text;
            atendimento.NomeMae = txtNomeMae.Text == "" ? null : txtNomeMae.Text;
            atendimento.Cpf = cpf == "   ,   ,   -" ? null : cpf.Substring(0, 3) + cpf.Substring(4, 3) + cpf.Substring(8, 3) + cpf.Substring(12, 2); ;
            atendimento.Enfermeiro = txtEnfermeiro.Text == "" ? null : txtCpf.Text;
            atendimento.Cor = cbbCor.SelectedIndex == -1 ? null : Convert.ToString(cbbCor.SelectedItem);
            try
            { 
                atendimento.Nascimento = Convert.ToDateTime(txtNascimento.Text);
            }
            catch
            {
                atendimento.Nascimento = null;
            }
            this.Close();
        }

        public AtendimentoEntity Filtrar(IWin32Window tela)
        {
            this.ShowDialog(tela);
            return atendimento;
        }

        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRelPacienteFiltros_Load(object sender, EventArgs e)
        {
            cbbCor.SelectedIndex = -1;
        }
    }
}
