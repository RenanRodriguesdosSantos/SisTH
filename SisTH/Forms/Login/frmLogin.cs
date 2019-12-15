using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisTH.Forms.Login
{
    public partial class frmLogin : Form
    {
        private EnfermeiroController enfermeiroCtrl;
        private EnfermeiroEntity enfermeiro;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String senha = txtSenha.Text;
            
            if(usuario == "" || senha == "")
            {
                MessageBox.Show("Informe o Login e a Senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                enfermeiroCtrl = new EnfermeiroController();
                enfermeiro = enfermeiroCtrl.Login(usuario, senha);

                if (enfermeiro.Nome == null)
                {
                    MessageBox.Show("Login ou Senha estão incorretos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enfermeiro = null;
                }
                else
                {
                   this.Close();
                }
            }
        }

        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public EnfermeiroEntity ShowLogin(IWin32Window form)
        {
            this.ShowDialog(form);
            return enfermeiro;
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
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
