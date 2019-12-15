using SisTH.Forms.Consultas;
using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisTH.Forms.Cadastros
{
    public partial class frmCadAtendimento : Form
    {
        private PacienteEntity paciente;
        private EnfermeiroEntity usuario;
        private AtendimentoController atendimentoCtrl;
        private Int32 id;
        private AtendimentoEntity atendimento;

        public frmCadAtendimento(EnfermeiroEntity Usuario, Int32 Id = 0)
        {
            InitializeComponent();
            this.usuario = Usuario;
            this.id = Id;
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            if(paciente != null)
            {
                if(txtRegistro.Text != "" && txtDescricao.Text != "")
                {
                    Int32 Registro = 0;
                    Decimal? Saturacao = null, Fc = null, Tax = null, Hgt = null, Glasgow = null;
                    String Pa, Descricao;
                    bool conversao = true;

                    ClassificacaoEntity classificacao = new ClassificacaoEntity(); ;

                    if(txtFc.Text != "")
                    {
                        try
                        {
                            Fc = Convert.ToDecimal(txtFc.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Preencha o campo FC corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conversao = false;
                        }
                    }

                    if (txtSaturacao.Text != "")
                    {
                        try
                        {
                            Saturacao = Convert.ToDecimal(txtSaturacao.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Preencha o campo Saturação corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conversao = false;
                        }
                    }
                    if (txtGlasgow.Text != "")
                    {
                        try
                        {
                            Glasgow = Convert.ToDecimal(txtGlasgow.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Preencha o campo Glasgow corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conversao = false;
                        }
                    }
                    if (txtHgt.Text != "")
                    {
                        try
                        {
                            Hgt = Convert.ToDecimal(txtHgt.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Preencha o campo Hgt corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conversao = false;
                        }
                    }
                    if (txtFc.Text != "")
                    {
                        try
                        {
                            Fc = Convert.ToDecimal(txtFc.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Preencha o campo Fc corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conversao = false;
                        }
                    }
                    if (txtTax.Text != "")
                    {
                        try
                        {
                            Tax = Convert.ToDecimal(txtTax.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Preencha o campo Fc corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conversao = false;
                        }
                    }
                    if(txtPa.Text == "   X   ")
                    {
                        Pa = null;
                    }
                        
                    try
                    {
                        Registro = Convert.ToInt32(txtRegistro.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Preencha o campo Registro corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conversao = false;
                    }

                    if(cbbFluxograma.SelectedIndex == -1 && cbbDiscriminador.SelectedIndex == -1)
                    {
                        MessageBox.Show("Selecione um Fluxograma e um Discriminador!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conversao = false;
                    }
                    else
                    {
                        Int32 Fluxograma = (Int32)cbbFluxograma.SelectedValue;
                        Int32 Discriminador = (Int32)cbbDiscriminador.SelectedValue;
                        ClassificacaoController classificacaoCtrl = new ClassificacaoController();
                        classificacao = classificacaoCtrl.ReadClassificacao(Fluxograma, Discriminador);
                        if(classificacao.Id == 0)
                        {
                            MessageBox.Show("O Fluxograma e o Discrimador selecionados não têm relação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conversao = false;
                        }
                    }

                    if (conversao)
                    {
                        Descricao = txtDescricao.Text;
                        Pa = txtPa.Text;

                        atendimentoCtrl = new AtendimentoController();
                      
                        if (this.id == 0)
                        {
                            Int32 result = atendimentoCtrl.Save(Registro, Saturacao, Glasgow, Tax, Hgt, Pa, Fc, Descricao, classificacao.Id, paciente.Id, usuario.Id);

                            if (result != 0)
                            {
                                MessageBox.Show("Dados Salvos com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Não Foi Possível Salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            Int32 result = atendimentoCtrl.Update(this.id, Registro, Saturacao, Glasgow, Tax, Hgt, Pa, Fc, Descricao, classificacao.Id, paciente.Id, usuario.Id);

                            if (result != 0)
                            {
                                MessageBox.Show("Dados Atualizados com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Não Foi Possível Atualizar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o campo Registro e Descrição!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecione um paciente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            paciente = new frmConPaciente(txtNome.Text).GetPaciente(this);
            if(paciente != null)
            {
                txtNome.Text = paciente.Nome;
                txtNomeMae.Text = paciente.NomeMae;
                txtCpf.Text = paciente.Cpf;
                txtNascimento.Text = Convert.ToString(paciente.Nascimento);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new frmCadClassificacao().ShowDialog(this);
            this.prencherCombobox();
        }

        private void prencherCombobox()
        {
            PadraoController padraoCtrl = new PadraoController("Fluxograma");
            DataTable dt = padraoCtrl.ReadAll();
            cbbFluxograma.DisplayMember = "nome";
            cbbFluxograma.ValueMember = "Id";
            cbbFluxograma.DataSource = dt;

            padraoCtrl = new PadraoController("Discriminador");
            dt = padraoCtrl.ReadAll();
            cbbDiscriminador.DisplayMember = "nome";
            cbbDiscriminador.ValueMember = "Id";
            cbbDiscriminador.DataSource = dt;
        }
        private void FrmCadAtendimento_Load(object sender, EventArgs e)
        {
            this.prencherCombobox();
            cbbFluxograma.SelectedIndex = -1;
            cbbDiscriminador.SelectedIndex = -1;
            if(this.id != 0)
            {
                PacienteController pacienteCtrl = new PacienteController();
                ClassificacaoController classificacaoCtrl = new ClassificacaoController();
                atendimentoCtrl = new AtendimentoController();

                atendimento = atendimentoCtrl.Read(this.id);
                paciente = pacienteCtrl.Read(atendimento.IdPaciente);
                ClassificacaoEntity classificacao = classificacaoCtrl.Read(atendimento.IdClassificacao);

                txtRegistro.Text = Convert.ToString(atendimento.Registro);
                txtNome.Text = paciente.Nome;
                txtNascimento.Text = Convert.ToString(paciente.Nascimento);
                txtCpf.Text = paciente.Cpf;
                txtDescricao.Text = atendimento.Descricao;
                txtSaturacao.Text = Convert.ToString(atendimento.Saturacao);
                txtFc.Text = Convert.ToString(atendimento.Fc);
                txtGlasgow.Text = Convert.ToString(atendimento.Glasgow);
                txtHgt.Text = Convert.ToString(atendimento.Hgt);
                txtTax.Text = Convert.ToString(atendimento.Tax);
                txtPa.Text = atendimento.Pa;

                cbbDiscriminador.SelectedValue = classificacao.Fluxograma;
                cbbDiscriminador.SelectedValue = classificacao.Discriminador;
            }
        }

        private void FrmCadAtendimento_KeyDown(object sender, KeyEventArgs e)
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
