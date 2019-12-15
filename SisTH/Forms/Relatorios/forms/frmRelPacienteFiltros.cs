using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisTH.Forms.Relatorios
{
    
    public partial class frmRelPacienteFiltros : Form
    {
        private PadraoController padraoCtrl;
        private DataTable dt;
        private PacienteEntity paciente;
        public frmRelPacienteFiltros()
        {
            InitializeComponent();
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            paciente = new PacienteEntity();
            if(txtId.Text != "")
            {
                try
                {
                    paciente.Id = Convert.ToInt32(txtId.Text);
                }
                catch
                {
                    MessageBox.Show("Preencha o campo Id corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    paciente.Id = 0;
                }
            }
            else
            {
                paciente.Id = 0;
            }

            String cpf = txtCpf.Text;

            paciente.Nome = txtNome.Text == "" ? null : txtNome.Text;
            paciente.NomeMae = txtNomeMae.Text == "" ? null : txtNomeMae.Text;
            paciente.Cpf = cpf == "   ,   ,   -" ? null : cpf.Substring(0, 3) + cpf.Substring(4, 3) + cpf.Substring(8, 3) + cpf.Substring(12, 2); ;
            try
            { 
                paciente.Nascimento = Convert.ToDateTime(txtNascimento.Text);
            }
            catch
            {
                paciente.Nascimento = null;
            }
            paciente.Etnia = cbbEtnia.SelectedIndex == -1? null : Convert.ToString(cbbEtnia.SelectedValue);
            paciente.Profissao = cbbProfissao.SelectedIndex == -1 ? null : Convert.ToString(cbbProfissao.SelectedValue);
            paciente.Bairro = cbbBairro.SelectedIndex == -1 ? null : Convert.ToString(cbbBairro.SelectedValue);
            paciente.Cidade = cbbCidade.SelectedIndex == -1 ? null : Convert.ToString(cbbCidade.SelectedValue);
            this.Close();
        }

        public PacienteEntity Filtrar(IWin32Window tela)
        {
            this.ShowDialog(tela);
            return paciente;
        }

        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preencherCbbBairro()
        {
            padraoCtrl = new PadraoController("Bairro");
            dt = padraoCtrl.ReadAll();
            cbbBairro.DisplayMember = "nome";
            cbbBairro.ValueMember = "nome";
            cbbBairro.DataSource = dt;
            cbbBairro.SelectedIndex = -1;
        }
        private void preencherCbbEtnia()
        {
            padraoCtrl = new PadraoController("Etnia");
            dt = padraoCtrl.ReadAll();
            cbbEtnia.DisplayMember = "nome";
            cbbEtnia.ValueMember = "nome";
            cbbEtnia.DataSource = dt;
            cbbEtnia.SelectedIndex = -1;
        }
        private void preencherCbbProfissao()
        {
            padraoCtrl = new PadraoController("Profissao");
            dt = padraoCtrl.ReadAll();
            cbbProfissao.DisplayMember = "nome";
            cbbProfissao.ValueMember = "nome";
            cbbProfissao.DataSource = dt;
            cbbProfissao.SelectedIndex = -1;
        }
        private void preencherCbbCidade()
        {
            CidadeController cidadeCtrl = new CidadeController();
            dt = cidadeCtrl.ReadAll();
            cbbCidade.DisplayMember = "Cidade";
            cbbCidade.ValueMember = "Cidade";
            cbbCidade.DataSource = dt;
            cbbCidade.SelectedIndex = -1;
        }

        private void FrmRelPacienteFiltros_Load(object sender, EventArgs e)
        {
            this.preencherCbbBairro();
            this.preencherCbbCidade();
            this.preencherCbbEtnia();
            this.preencherCbbProfissao();
        }
    }
}
