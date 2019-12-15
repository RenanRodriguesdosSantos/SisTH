using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisTH.Forms.Cadastros
{
    public partial class frmCadClassificacao : Form
    {
        private ClassificacaoController classificacaoCtrl;
        private Int32 id;
        public frmCadClassificacao(Int32 Id = 0)
        {
            InitializeComponent();
            this.id = Id;
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            if (cbbCor.SelectedIndex == -1 || cbbFluxograma.SelectedIndex == -1 || cbbDiscriminador.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                classificacaoCtrl = new ClassificacaoController();

                
                Int32 idFluxograma = (Int32)cbbFluxograma.SelectedValue;
                Int32 idDiscriminador = (Int32)cbbDiscriminador.SelectedValue;
                Int32 idCor = cbbCor.SelectedIndex;

                if(this.id == 0)
                {
                    int result = classificacaoCtrl.Save(idFluxograma, idDiscriminador, idCor);
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
                    int result = classificacaoCtrl.Update(this.id, idFluxograma, idDiscriminador, idCor);
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
        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroFluxograma_Click(object sender, EventArgs e)
        {
            new frmCadPadrao("Fluxograma", "Fluxograma").ShowDialog(this);
            this.preencherCombobox();
        }

        private void CadastroDiscriminador_Click(object sender, EventArgs e)
        {
            new frmCadPadrao("Discriminador", "Discriminador").ShowDialog(this);
            this.preencherCombobox();
        }

        private void FrmCadClassificacao_Load(object sender, EventArgs e)
        {
            this.preencherCombobox();
            if(this.id != 0)
            {
                classificacaoCtrl = new ClassificacaoController();
                ClassificacaoEntity classificacao = classificacaoCtrl.Read(this.id);
                cbbCor.SelectedIndex = classificacao.Cor;
                cbbFluxograma.SelectedValue = classificacao.Fluxograma;
                cbbDiscriminador.SelectedValue = classificacao.Discriminador;
            }
        }

        private void FrmCadClassificacao_KeyDown(object sender, KeyEventArgs e)
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
        private void preencherCombobox()
        {
            PadraoController padraoCtrl = new PadraoController("Fluxograma");
            DataTable dt = padraoCtrl.ReadAll();
            cbbFluxograma.DisplayMember = "nome";
            cbbFluxograma.ValueMember = "Id";
            cbbFluxograma.DataSource = dt;
            cbbFluxograma.SelectedIndex = -1;

            padraoCtrl = new PadraoController("Discriminador");
            dt = padraoCtrl.ReadAll();
            cbbDiscriminador.DisplayMember = "nome";
            cbbDiscriminador.ValueMember = "Id";
            cbbDiscriminador.DataSource = dt;
            cbbDiscriminador.SelectedIndex = -1;
        }
    }
}
