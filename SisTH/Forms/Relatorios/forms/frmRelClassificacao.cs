using Microsoft.Reporting.WinForms;
using SisTHWorks.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisTH.Forms.Relatorios
{
    public partial class frmRelClassificacao : Form
    {
        public frmRelClassificacao()
        {
            InitializeComponent();
        }

        private void FrmRelModelo_Load(object sender, EventArgs e)
        {
            PadraoController padraoCtrl = new PadraoController("Fluxograma");
            DataTable dt = padraoCtrl.ReadAll();
            cbbFluxograma.DisplayMember = "nome";
            cbbFluxograma.ValueMember = "nome";
            cbbFluxograma.DataSource = dt;
            cbbFluxograma.SelectedIndex = -1;

            padraoCtrl = new PadraoController("Discriminador");
            dt = padraoCtrl.ReadAll();
            cbbDiscriminador.DisplayMember = "nome";
            cbbDiscriminador.ValueMember = "nome";
            cbbDiscriminador.DataSource = dt;
            cbbDiscriminador.SelectedIndex = -1;
            cbbCor.SelectedIndex = -1;

            ClassificacaoController classificacaoCtrl = new ClassificacaoController();
            DataTable dtClassificacao = classificacaoCtrl.ReadAll();
            this.rptModelo.LocalReport.DataSources.Clear();
            this.rptModelo.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsClassificacao", dtClassificacao));
            this.rptModelo.LocalReport.Refresh();
            this.rptModelo.RefreshReport();
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
            if(cbbCor.SelectedIndex != -1)
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("cor", Convert.ToString(cbbCor.SelectedItem)));
            }
            else
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("cor", (string)null));
            }
            if(cbbFluxograma.SelectedIndex != -1)
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("fluxograma", Convert.ToString(cbbFluxograma.SelectedValue)));
            }
            else
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("fluxograma", (string)null));
            }
            if(cbbDiscriminador.SelectedIndex != -1)
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("discriminador", Convert.ToString(cbbDiscriminador.SelectedValue)));
            }
            else
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("discriminador", (string)null));
            }
            this.rptModelo.LocalReport.Refresh();
            this.rptModelo.RefreshReport();
        }
    }
}
