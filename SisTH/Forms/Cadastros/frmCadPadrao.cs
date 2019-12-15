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

namespace SisTH.Forms.Cadastros
{
    public partial class frmCadPadrao : Form
    {
        private String tabela;
        private Int32 id;
        private PadraoController padraoCtrl;

        public frmCadPadrao(String Tabela, String Nome, Int32 Id = 0)
        {
            InitializeComponent();
            this.tabela = Tabela;
            this.Text = "Cadastro de " + Nome;
            this.lblCadModeloTitulo.Text = "Cadastro de " + Nome;
            this.id = Id;
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            if (this.id == 0)
            {
                if (nome != "")
                {
                    padraoCtrl = new PadraoController(this.tabela);
                    int result = padraoCtrl.Save(nome);

                    if (result != 0)
                    {
                        MessageBox.Show("Dados Salvos com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Não Foi Possível Salvar!",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o campo nome!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (nome != "")
                {
                    padraoCtrl = new PadraoController(this.tabela);
                    int result = padraoCtrl.Update(this.id,nome);

                    if (result != 0)
                    {
                        MessageBox.Show("Dados Atualizados com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Não Foi Atualizar!",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o campo nome!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadPadrao_Load(object sender, EventArgs e)
        {
            if(this.id != 0)
            {
                padraoCtrl = new PadraoController(this.tabela);
                PadraoEntity padrao = padraoCtrl.Read(this.id);
                txtNome.Text = padrao.Nome;
            } 
        }

        private void FrmCadPadrao_KeyDown(object sender, KeyEventArgs e)
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
