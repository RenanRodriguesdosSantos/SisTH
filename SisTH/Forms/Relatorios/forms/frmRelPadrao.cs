using Microsoft.Reporting.WinForms;
using SisTHWorks.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisTH.Forms.Relatorios
{
    public partial class frmRelPadrao : Form
    {
        private String tabela;
        private String nome;
        private PadraoController padraoCtrl;
        public frmRelPadrao(String Nome, String Tabela)
        {
            InitializeComponent();
            this.nome = Nome;
            this.tabela = Tabela;
        }

        private void FrmRelModelo_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Relatório de " + this.nome;
            padraoCtrl = new PadraoController(this.tabela);
            DataTable dtPadrao = padraoCtrl.ReadAll();
            this.rptModelo.LocalReport.DataSources.Clear();
            this.rptModelo.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsPadrao", dtPadrao));
            this.rptModelo.LocalReport.Refresh();
            this.rptModelo.RefreshReport();
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                try
                {
                    this.rptModelo.LocalReport.SetParameters(new ReportParameter("id", txtId.Text));
                }
                catch
                {
                    MessageBox.Show("Preencha o campo Id corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.rptModelo.LocalReport.SetParameters(new ReportParameter("id", (string) null));
                    txtId.Text = "";
                }

            }
            else
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("id", (string) null));
            }
            if (txtNome.Text != "")
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("nome", txtNome.Text));
            }
            else
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("nome", (string) null));

            }
            this.rptModelo.LocalReport.Refresh();
            this.rptModelo.RefreshReport();
        }
    }
}
