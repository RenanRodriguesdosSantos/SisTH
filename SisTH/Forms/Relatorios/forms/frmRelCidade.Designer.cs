namespace SisTH.Forms.Relatorios
{
    partial class frmRelCidade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CidadeEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptModelo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCadCidadeUF = new System.Windows.Forms.Label();
            this.cbbUf = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CidadeEntityBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CidadeEntityBindingSource
            // 
            this.CidadeEntityBindingSource.DataSource = typeof(SisTHWorks.Model.CidadeEntity);
            // 
            // rptModelo
            // 
            this.rptModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.CidadeEntityBindingSource;
            this.rptModelo.LocalReport.DataSources.Add(reportDataSource4);
            this.rptModelo.LocalReport.ReportEmbeddedResource = "SisTH.Forms.Relatorios.relatorio.rptRelCidade.rdlc";
            this.rptModelo.Location = new System.Drawing.Point(2, 91);
            this.rptModelo.Name = "rptModelo";
            this.rptModelo.ServerReport.BearerToken = null;
            this.rptModelo.Size = new System.Drawing.Size(685, 463);
            this.rptModelo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbUf);
            this.panel1.Controls.Add(this.lblCadCidadeUF);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAplicar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 82);
            this.panel1.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(20, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(109, 20);
            this.txtId.TabIndex = 8;
            this.txtId.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(555, 45);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(155, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(217, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblCadCidadeUF
            // 
            this.lblCadCidadeUF.AutoSize = true;
            this.lblCadCidadeUF.Location = new System.Drawing.Point(397, 31);
            this.lblCadCidadeUF.Name = "lblCadCidadeUF";
            this.lblCadCidadeUF.Size = new System.Drawing.Size(21, 13);
            this.lblCadCidadeUF.TabIndex = 11;
            this.lblCadCidadeUF.Text = "UF";
            // 
            // cbbUf
            // 
            this.cbbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUf.FormattingEnabled = true;
            this.cbbUf.Items.AddRange(new object[] {
            " ",
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbbUf.Location = new System.Drawing.Point(400, 47);
            this.cbbUf.Name = "cbbUf";
            this.cbbUf.Size = new System.Drawing.Size(128, 21);
            this.cbbUf.Sorted = true;
            this.cbbUf.TabIndex = 12;
            // 
            // frmRelCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rptModelo);
            this.MaximizeBox = false;
            this.Name = "frmRelCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SISTEMA DE TRIAGEM HOSPITALAR";
            this.Load += new System.EventHandler(this.FrmRelModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CidadeEntityBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptModelo;
        private System.Windows.Forms.BindingSource CidadeEntityBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCadCidadeUF;
        private System.Windows.Forms.ComboBox cbbUf;
    }
}