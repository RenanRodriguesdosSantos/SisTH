using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Windows.Forms;

namespace SisTH.Forms.Login
{
    public partial class frmAlterarSenha : Form
    {
        private EnfermeiroEntity usuario;
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text != ""  && txtConfirmarSenha.Text != "")
            {
                if(txtSenha.Text == txtConfirmarSenha.Text)
                {
                    usuario.Senha = txtSenha.Text;
                    int result = new EnfermeiroController().Update(usuario);
                    if(result != 0)
                    {
                        MessageBox.Show("Senha alterada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível alterar a senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senhas diferentes!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e)
        {
            frmLogin telaLogin = new frmLogin();
            usuario = telaLogin.ShowLogin(this);
            if (usuario == null)
            {
                this.Close();
            }
        }
    }
}
