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
    public partial class frmCadCidade : Form
    {
        private CidadeController cidadeCtrl;
        private Int32 id;

        public frmCadCidade(Int32 Id = 0)
        {
            InitializeComponent();
            this.id = Id;
        }

        private void BtnCadModeloSalvar_Click(object sender, EventArgs e)
        {
            String uf = Convert.ToString(cbbUf.SelectedItem);
            String nome = txNome.Text;
            if(uf == "" || nome == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cidadeCtrl = new CidadeController();
                if(this.id == 0)
                {
                    int result = cidadeCtrl.Save(nome,uf);
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
                    int result = cidadeCtrl.Update(this.id, nome, uf);
                    if (result != 0)
                    {
                        MessageBox.Show("Dados Atualizados com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Não Foi Possível Atualizar!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
        }

        private void BtnCadModeloCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadCidade_Load(object sender, EventArgs e)
        {
            if(id != 0)
            {
                cidadeCtrl = new CidadeController();
                CidadeEntity cidade = cidadeCtrl.Read(this.id);
                txNome.Text = cidade.Nome;
                cbbUf.SelectedItem = cidade.Uf;
            }  
        }

        private void FrmCadCidade_KeyDown(object sender, KeyEventArgs e)
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
