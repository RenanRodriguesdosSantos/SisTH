using System;
using System.Windows.Forms;
using SisTH.Forms.Cadastros;
using SisTH.Forms.Consultas;
using SisTH.Forms.Listas;
using SisTH.Forms.Modelo;
using SisTH.Forms.Relatorios;
using SisTH.Forms.Login;
using SisTHWorks.Model;

namespace SisTH
{
    public partial class frmPrincipal : Form
    {
        EnfermeiroEntity usuario;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin telaLogin = new frmLogin();
            usuario = telaLogin.ShowLogin(this);
            if(usuario == null)
            {
                this.Close();
            }
            else
            {
                if(usuario.Id == 1)
                {
                    this.novoUsuárioToolStripMenuItem.Enabled = true;
                    this.listaDeEnfermeirosToolStripMenuItem.Enabled = true;
                }
            }
        }
        private void DiscriminadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisPadrao frmLisPadrao = new frmLisPadrao(usuario,"Discriminador", "Discriminadores");
            frmLisPadrao.MdiParent = this;
            frmLisPadrao.Show();
        }

        private void EtniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisPadrao frmLisPadrao = new frmLisPadrao(usuario,"Etnia", "Etnias");
            frmLisPadrao.MdiParent = this;
            frmLisPadrao.Show();
        }

        private void FluxogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisPadrao frmLisPadrao = new frmLisPadrao(usuario,"Fluxograma", "Fluxogramas");
            frmLisPadrao.MdiParent = this;
            frmLisPadrao.Show(); 
        }

        private void ProfissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisPadrao frmLisPadrao = new frmLisPadrao(usuario,"Profissao", "Profissões");
            frmLisPadrao.MdiParent = this;
            frmLisPadrao.Show();
        }

        private void TipoLogradouroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisPadrao frmLisPadrao = new frmLisPadrao(usuario,"TipoLogradouro", "Tipos de Logradouros");
            frmLisPadrao.MdiParent = this;
            frmLisPadrao.Show();
        }

        private void AtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisAtendimento frmLisAtendimento = new frmLisAtendimento(usuario);
            frmLisAtendimento.MdiParent = this;
            frmLisAtendimento.Show();
        }

        private void BairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisPadrao frmLisPadrao = new frmLisPadrao(usuario,"Bairro", "Bairros");
            frmLisPadrao.MdiParent = this;
            frmLisPadrao.Show();
        }

        private void ClassificacaoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisClassificacao frmLisClassificacao = new frmLisClassificacao(this.usuario);
            frmLisClassificacao.MdiParent = this;
            frmLisClassificacao.Show();
        }

        private void EnfermeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisCidade frmLisCidade = new frmLisCidade(this.usuario);
            frmLisCidade.MdiParent = this;
            frmLisCidade.Show();
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            new frmCadClassificacao().ShowDialog(this);
        }

        private void ListaDeEnfermeirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisEnfermeiro frmLisEnfermeiro = new frmLisEnfermeiro(this.usuario);
            frmLisEnfermeiro.MdiParent = this;
            frmLisEnfermeiro.Show();
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            new frmCadCidade().ShowDialog(this);
        }

        private void PacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
            frmLisPaciente frmLisPaciente = new frmLisPaciente(this.usuario);
            frmLisPaciente.MdiParent = this;
            frmLisPaciente.Show();
        }

        private void ToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            frmRelCidade frmResCidade = new frmRelCidade();
            frmResCidade.ShowDialog(this);
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmCadPaciente frmCadPaciente = new frmCadPaciente();
            frmCadPaciente.ShowDialog(this);
        }

        private void NovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadEnfermeiro frmCadEnfermeiro = new frmCadEnfermeiro();
            frmCadEnfermeiro.ShowDialog(this);
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCadAtendimento frmCadAtendimento = new frmCadAtendimento(usuario);
            frmCadAtendimento.ShowDialog(this);
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmCadPadrao frmCadPadrao = new frmCadPadrao("Bairro", "Bairro");
            frmCadPadrao.ShowDialog(this);
        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmCadPadrao frmCadPadrao = new frmCadPadrao("Discriminador", "Discriminador");
            frmCadPadrao.ShowDialog(this);
        }

        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmCadPadrao frmCadPadrao = new frmCadPadrao("Enia", "Etnia");
            frmCadPadrao.ShowDialog(this);
        }

        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmCadPadrao frmCadPadrao = new frmCadPadrao("Fluxograma", "Fluxograma");
            frmCadPadrao.ShowDialog(this);
        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmCadPadrao frmCadPadrao = new frmCadPadrao("Profissao", "Profissão");
            frmCadPadrao.ShowDialog(this);
        }

        private void ToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmCadPadrao frmCadPadrao = new frmCadPadrao("TipoLogradouro", "Tipo Logradouro");
            frmCadPadrao.ShowDialog(this);
        }

        private void ToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            new frmRelClassificacao().ShowDialog(this);
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAlterarSenha().ShowDialog(this);
        }

        private void ToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            new frmRelPadrao("Bairro", "Bairro").ShowDialog(this);
        }

        private void ToolStripMenuItem20_Click(object sender, EventArgs e)
        {
            new frmRelPadrao("Discriminador", "Discriminador").ShowDialog(this);
        }

        private void ToolStripMenuItem23_Click(object sender, EventArgs e)
        {
            new frmRelPaciente().ShowDialog(this);
        }

        private void ToolStripMenuItem21_Click(object sender, EventArgs e)
        {
            new frmRelPadrao("Etnia", "Etnia").ShowDialog(this);
        }

        private void ToolStripMenuItem22_Click(object sender, EventArgs e)
        {
            new frmRelPadrao("Fluxograma", "Fluxograma").ShowDialog(this);
        }

        private void ToolStripMenuItem24_Click(object sender, EventArgs e)
        {
            new frmRelPadrao("Profissão", "Profissao").ShowDialog(this);
        }

        private void ToolStripMenuItem25_Click(object sender, EventArgs e)
        {
            new frmRelPadrao("Tipo Logradouro", "TipoLogradouro").ShowDialog(this);
        }

        private void ToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            new frmRelAtendimento().ShowDialog(this);
        }

        private void AdministradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void TrocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.novoUsuárioToolStripMenuItem.Enabled = false;
            this.listaDeEnfermeirosToolStripMenuItem.Enabled = false;
            frmLogin telaLogin = new frmLogin();
            usuario = telaLogin.ShowLogin(this);
            if (usuario == null)
            {
                this.Close();
            }
            else
            {
                if (usuario.Id == 1)
                {
                    this.novoUsuárioToolStripMenuItem.Enabled = true;
                    this.listaDeEnfermeirosToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }     
        }
    }
}
