using Microsoft.Reporting.WinForms;
using SisTHWorks.Controller;
using SisTHWorks.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisTH.Forms.Relatorios { 
    public partial class frmRelPaciente : Form
    {
        private PacienteController pacienteCtrl;
        private PacienteEntity paciente;
        private frmRelPacienteFiltros frmFiltros;
        public frmRelPaciente()
        {
            InitializeComponent();
            frmFiltros = new frmRelPacienteFiltros();
        }

        private void FrmRelModelo_Load(object sender, EventArgs e)
        {
            pacienteCtrl = new PacienteController();
            DataTable dtModelo = pacienteCtrl.ReadRel();
            this.rptModelo.LocalReport.DataSources.Clear();
            this.rptModelo.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsPaciente", dtModelo));
            this.rptModelo.LocalReport.Refresh();
            this.rptModelo.RefreshReport();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            paciente = frmFiltros.Filtrar(this);
            if(paciente != null)
            {
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("id", paciente.Id == 0?(string)null :Convert.ToString(paciente.Id)));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("nome", paciente.Nome));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("mae", paciente.NomeMae));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("nascimento", paciente.Nascimento == null?(string) null:Convert.ToString(paciente.Nascimento)));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("cpf", paciente.Cpf));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("bairro", paciente.Bairro));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("cidade", paciente.Cidade));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("etnia", paciente.Etnia));
                this.rptModelo.LocalReport.SetParameters(new ReportParameter("profissao", paciente.Profissao));
                this.rptModelo.LocalReport.Refresh();
                this.rptModelo.RefreshReport();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("id", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("nome", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("mae", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("nascimento", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("cpf", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("bairro", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("cidade", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("etnia", (string) null));
            this.rptModelo.LocalReport.SetParameters(new ReportParameter("profissao", (string) null));
            this.rptModelo.LocalReport.Refresh();
            this.rptModelo.RefreshReport();
            frmFiltros = new frmRelPacienteFiltros();
        }
    }
}
