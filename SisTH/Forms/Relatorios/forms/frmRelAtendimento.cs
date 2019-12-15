using Microsoft.Reporting.WinForms;
using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisTH.Forms.Relatorios
{
    public partial class frmRelAtendimento : Form
    {
        private AtendimentoController atendimentoCtrl;
        private AtendimentoEntity atendimento;
        private frmRelAtendimentoFiltros frmFiltros;

        public frmRelAtendimento()
        {
            InitializeComponent();
            frmFiltros = new frmRelAtendimentoFiltros();
        }

        private void FrmRelModelo_Load(object sender, EventArgs e)
        {
            atendimentoCtrl = new AtendimentoController();
            DataTable dtAtendimento = atendimentoCtrl.ReadRel();
            this.rptModelo.LocalReport.DataSources.Clear();
            this.rptModelo.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsAtendimento", dtAtendimento));
            this.rptModelo.LocalReport.Refresh();
            this.rptModelo.RefreshReport();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            atendimento = frmFiltros.Filtrar(this);
            if (atendimento != null)
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("id", atendimento.Id == 0 ? (string)null : Convert.ToString(atendimento.Id)));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("registro", atendimento.Registro == 0 ? (string)null : Convert.ToString(atendimento.Registro)));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("paciente", atendimento.Paciente));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("mae", atendimento.NomeMae));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("nascimento", atendimento.Nascimento == null ? (string)null : Convert.ToString(atendimento.Nascimento)));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("cpf", atendimento.Cpf));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("enfermeiro", atendimento.Enfermeiro));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("cor", atendimento.Cor));
                this.rptModelo.LocalReport.Refresh();
                this.rptModelo.RefreshReport();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("id",(string)null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("registro",(string)null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("paciente", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("mae", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("nascimento", (string)null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("cpf", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("enfermeiro", (string)null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("cor", (string) null));
            this.rptModelo.LocalReport.Refresh();
            this.rptModelo.RefreshReport();
            this.frmFiltros = new frmRelAtendimentoFiltros();
        }
    }
}
