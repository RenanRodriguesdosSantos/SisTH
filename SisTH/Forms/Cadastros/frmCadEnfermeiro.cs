using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Windows.Forms;

namespace SisTH.Forms.Cadastros
{
    public partial class frmCadEnfermeiro : Form
    {
        private EnfermeiroController enfermeiroCtrl;
        private Int32 id;
        public frmCadEnfermeiro(Int32 Id = 0)
        {
            InitializeComponent();
            this.id = Id;
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            String nome, senha, confirmar, login, coren;
            nome = txtNome.Text;
            senha = txtSenha.Text;
            confirmar = txtConfirmarSenha.Text;
            login = txtLogin.Text;
            coren = txtCoren.Text;

            if(nome == "" || senha == "" || confirmar == "" || login == "" || coren == ""){
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(senha == confirmar)
                {
                    Int32 Coren = 0;
                    bool conversao = true;
                    try
                    {
                        Coren = Convert.ToInt32(coren);
                    }
                    catch
                    {
                        MessageBox.Show("Dados Salvos com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conversao = false;
                    }
                    if (conversao)
                    {
                        enfermeiroCtrl = new EnfermeiroController();
                        if(this.id == 0)
                        {
                            int result = enfermeiroCtrl.Save(nome, Coren, login, senha);
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
                            int result = enfermeiroCtrl.Update(this.id,nome, Coren, login, senha);
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
                else
                {
                    MessageBox.Show("Senhas diferentes!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadEnfermeiro_Load(object sender, EventArgs e)
        {
            if(this.id != 0)
            {
                enfermeiroCtrl = new EnfermeiroController();
                EnfermeiroEntity enfermeiro = enfermeiroCtrl.Read(this.id);
                txtNome.Text = enfermeiro.Nome;
                txtCoren.Text = Convert.ToString(enfermeiro.Coren);
                txtLogin.Text = enfermeiro.Login;
            }
        }

        private void FrmCadEnfermeiro_KeyDown(object sender, KeyEventArgs e)
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
