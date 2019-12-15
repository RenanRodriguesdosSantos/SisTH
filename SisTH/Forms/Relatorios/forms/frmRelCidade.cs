using Microsoft.Reporting.WinForms;
using SisTHWorks.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisTH.Forms.Relatorios
{
    public partial class frmRelCidade : Form
    {
        private CidadeController cidadeCtrl;
        public frmRelCidade()
        {
            InitializeComponent();
        }

        private void FrmRelModelo_Load(object sender, EventArgs e)
        {
            cidadeCtrl = new CidadeController();
            DataTable dtClassificacao = cidadeCtrl.ReadAll();
            this.rptModelo.LocalReport.DataSources.Clear();
            this.rptModelo.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsCidade", dtClassificacao));
            this.rptModelo.LocalReport.Refresh();
            this.rptModelo.RefreshReport();
            cbbUf.SelectedIndex = -1;
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                try
                {
                    this.rptModelo.LocalReport.SetParameters(new ReportParameter("id", txtId.Text));
                }
                catch
                {
                    MessageBox.Show("Preencha o campo Id corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.rptModelo.LocalReport.SetParameters(new ReportParameter("id", (string)null));
                    txtId.Text = "";
                }

            }
            else
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("id", (string)null));
            }
            if (txtNome.Text != "")
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("nome", txtNome.Text));
            }
            else
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("nome", (string)null));
            }
            if(cbbUf.SelectedIndex != -1 && cbbUf.SelectedIndex != 0)
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("uf", Convert.ToString(cbbUf.SelectedItem)));
            }
            else
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("uf", (string)null));
            }
            this.rptModelo.LocalReport.Refresh();
            this.rptModelo.RefreshReport();
        }
    }
}
