using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisTH.Forms.Cadastros
{
    public partial class frmCadPaciente : Form
    {
        Int32 id;
        private PacienteController pacienteCtrl;
        private PadraoController padraoCtrl;
        private DataTable dt;

        public frmCadPaciente(PacienteEntity paciente = null, Int32 Id = 0)
        {
            InitializeComponent();
            this.id = Id;
            txtNome.Text = paciente.Nome;
            txtNomeMae.Text = paciente.NomeMae;
            txtCpf.Text = paciente.Cpf;
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String mae = txtNomeMae.Text;
            String nascimento = txtNascimento.Text;
            String cpf = txtCpf.Text;
            String numero = txtNumero.Text;
            String logradouro = txtLogradouro.Text;
            String complemento = txtComplemento.Text;

            if (nome == "" || mae == "" || nascimento == "" || numero == "" || logradouro == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cbbBairro.SelectedIndex == -1 || cbbCidade.SelectedIndex == -1 || cbbEtnia.SelectedIndex == -1 || cbbNaturalidade.SelectedIndex == -1 || cbbProfissao.SelectedIndex == -1 || cbbTipoLogradouro.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todas as caixas de Seleção!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool conversao = true;
                Int32 Numero = 0;
                DateTime Nascimento = new DateTime();

                if(cpf.Length != 14)
                {
                    MessageBox.Show("Preencha corretamente o campo CPF com números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conversao = false;
                }
                else
                {
                    cpf = cpf.Substring(0, 3) + cpf.Substring(4, 3) + cpf.Substring(8, 3) + cpf.Substring(12, 2);
                }

                try
                {
                     Numero = Convert.ToInt32(numero);
                }
                catch 
                {
                    MessageBox.Show("Preencha o campo Número apenas com números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conversao = false;
                }

                try
                {
                    Nascimento = Convert.ToDateTime(nascimento);
                }
                catch
                {
                    MessageBox.Show("Preencha corretamente o campo Nascimento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conversao = false;
                }

                if (conversao)
                {
                    pacienteCtrl = new PacienteController();
                    if(complemento == "")
                    {
                        complemento = null;
                    }
                    Int32 idNaturalidade = (Int32) cbbNaturalidade.SelectedValue; ;
                    Int32 idEtnia = (Int32) cbbEtnia.SelectedValue;
                    Int32 idProfissao = (Int32) cbbProfissao.SelectedValue;
                    Int32 idTipoLogradouro = (Int32) cbbTipoLogradouro.SelectedValue;
                    Int32 idBairro = (Int32) cbbBairro.SelectedValue;
                    Int32 idCidade = (Int32) cbbCidade.SelectedValue;

                    if(this.id == 0){
                        Int32 result = pacienteCtrl.Save(nome, mae, cpf, Nascimento, logradouro, Numero, complemento, idBairro, idCidade, idNaturalidade, idEtnia, idTipoLogradouro,idProfissao);
                        if (result != 0)
                        {
                            MessageBox.Show("Dados Salvos com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Não Foi Possível Salvar!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Int32 result = pacienteCtrl.Update(this.id ,nome, mae, cpf, Nascimento, logradouro, Numero, complemento, idBairro, idCidade, idNaturalidade, idEtnia, idTipoLogradouro, idProfissao);
                        if (result != 0)
                        {
                            MessageBox.Show("Dados Atualizados com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Não Foi Possível Atualizar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }    
        }

        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new frmCadCidade().ShowDialog(this);
            this.preencherCbbCidade();
            this.preencherCbbNaturalidade();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new frmCadPadrao("Etnia", "Etnia").ShowDialog(this);
            this.preencherCbbEtnia();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new frmCadPadrao("Profissao", "Profissão").ShowDialog(this);
            this.preencherCbbProfissao();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new frmCadPadrao("TipoLogradouro", "Tipo de Logradouro").ShowDialog(this);
            this.preencherCbbTipoLogradouro();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new frmCadPadrao("Bairro", "Bairro").ShowDialog(this);
            this.preencherCbbBairro();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            new frmCadCidade().ShowDialog(this);
            this.preencherCbbCidade();
            this.preencherCbbNaturalidade();
        }

        private void FrmCadPaciente_Load(object sender, EventArgs e)
        {
            this.preencherCbbBairro();
            this.preencherCbbEtnia();
            this.preencherCbbProfissao();
            this.preencherCbbTipoLogradouro();
            this.preencherCbbCidade();
            this.preencherCbbNaturalidade();

            if(id != 0)
            {
                pacienteCtrl = new PacienteController();
                PacienteEntity paciente = pacienteCtrl.Read(id);
                txtNome.Text = paciente.Nome;
                txtNomeMae.Text = paciente.NomeMae;
                txtCpf.Text = paciente.Cpf;
                txtNascimento.Text = Convert.ToString(paciente.Nascimento);
                txtLogradouro.Text = paciente.Logradouro;
                txtNumero.Text = Convert.ToString(paciente.Numero);
                txtComplemento.Text = paciente.Complemento;
                cbbBairro.SelectedValue = paciente.IdBairro;
                cbbCidade.SelectedValue = paciente.IdCidade;
                cbbEtnia.SelectedValue = paciente.IdEtnia;
                cbbNaturalidade.SelectedValue = paciente.IdNaturalidade;
                cbbProfissao.SelectedValue = paciente.IdProfissao;
                cbbTipoLogradouro.SelectedValue = paciente.IdTipoLogradouro;
            }
        }
        private void preencherCbbBairro()
        {
            padraoCtrl = new PadraoController("Bairro");
            dt = padraoCtrl.ReadAll();
            cbbBairro.DisplayMember = "nome";
            cbbBairro.ValueMember = "Id";
            cbbBairro.DataSource = dt;
            cbbBairro.SelectedIndex = -1;
        }
        private void preencherCbbEtnia()
        {
            padraoCtrl = new PadraoController("Etnia");
            dt = padraoCtrl.ReadAll();
            cbbEtnia.DisplayMember = "nome";
            cbbEtnia.ValueMember = "Id";
            cbbEtnia.DataSource = dt;
            cbbEtnia.SelectedIndex = -1;
        }
        private void preencherCbbProfissao()
        {
            padraoCtrl = new PadraoController("Profissao");
            dt = padraoCtrl.ReadAll();
            cbbProfissao.DisplayMember = "nome";
            cbbProfissao.ValueMember = "Id";
            cbbProfissao.DataSource = dt;
            cbbProfissao.SelectedIndex = -1;
        }
        private void preencherCbbTipoLogradouro()
        {
            padraoCtrl = new PadraoController("TipoLogradouro");
            dt = padraoCtrl.ReadAll();
            cbbTipoLogradouro.DisplayMember = "nome";
            cbbTipoLogradouro.ValueMember = "Id";
            cbbTipoLogradouro.DataSource = dt;
            cbbTipoLogradouro.SelectedIndex = -1;
        }
        private void preencherCbbNaturalidade()
        {
            CidadeController cidadeCtrl = new CidadeController();
            dt = cidadeCtrl.ReadAll();
            cbbNaturalidade.DisplayMember = "Cidade";
            cbbNaturalidade.ValueMember = "id";
            cbbNaturalidade.DataSource = dt;
            cbbNaturalidade.SelectedIndex = -1;
        }
        private void preencherCbbCidade() {
            CidadeController cidadeCtrl = new CidadeController();
            dt = cidadeCtrl.ReadAll();
            cbbCidade.DisplayMember = "Cidade";
            cbbCidade.ValueMember = "id";
            cbbCidade.DataSource = dt;
            cbbCidade.SelectedIndex = -1;
        }

        private void FrmCadPaciente_KeyDown(object sender, KeyEventArgs e)
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
