using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace SisTH.Forms.Modelo
{
    public partial class frmRelModelo : Form
    {
        public frmRelModelo()
        {
            InitializeComponent();
        }

        private void FrmRelModelo_Load(object sender, EventArgs e)
        {

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
        }
    }
}
