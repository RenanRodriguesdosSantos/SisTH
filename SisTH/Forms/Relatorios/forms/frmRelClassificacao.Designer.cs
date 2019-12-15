namespace SisTH.Forms.Relatorios
{
    partial class frmRelClassificacao
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
            this.rptModelo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbFluxograma = new System.Windows.Forms.ComboBox();
            this.cbbDiscriminador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptModelo
            // 
            this.rptModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptModelo.LocalReport.ReportEmbeddedResource = "SisTH.Forms.Relatorios.relatorio.rptRelClassificacao.rdlc";
            this.rptModelo.Location = new System.Drawing.Point(2, 112);
            this.rptModelo.Name = "rptModelo";
            this.rptModelo.ServerReport.BearerToken = null;
            this.rptModelo.Size = new System.Drawing.Size(826, 506);
            this.rptModelo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 20);
            this.txtId.TabIndex = 4;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(672, 69);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbFluxograma);
            this.panel1.Controls.Add(this.cbbDiscriminador);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbCor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAplicar);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Location = new System.Drawing.Point(2, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 98);
            this.panel1.TabIndex = 6;
            // 
            // cbbFluxograma
            // 
            this.cbbFluxograma.FormattingEnabled = true;
            this.cbbFluxograma.Location = new System.Drawing.Point(161, 31);
            this.cbbFluxograma.Name = "cbbFluxograma";
            this.cbbFluxograma.Size = new System.Drawing.Size(493, 21);
            this.cbbFluxograma.TabIndex = 22;
            // 
            // cbbDiscriminador
            // 
            this.cbbDiscriminador.FormattingEnabled = true;
            this.cbbDiscriminador.Location = new System.Drawing.Point(161, 71);
            this.cbbDiscriminador.Name = "cbbDiscriminador";
            this.cbbDiscriminador.Size = new System.Drawing.Size(493, 21);
            this.cbbDiscriminador.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cor";
            // 
            // cbbCor
            // 
            this.cbbCor.FormattingEnabled = true;
            this.cbbCor.Items.AddRange(new object[] {
            "VERMELHO",
            "LARANJA",
            "AMARELO",
            "VERDE",
            "AZUL"});
            this.cbbCor.Location = new System.Drawing.Point(6, 71);
            this.cbbCor.Name = "cbbCor";
            this.cbbCor.Size = new System.Drawing.Size(131, 21);
            this.cbbCor.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Discriminador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fluxograma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "FILTROS";
            // 
            // frmRelClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rptModelo);
            this.Name = "frmRelClassificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SISTEMA DE TRIAGEM HOSPITALAR";
            this.Load += new System.EventHandler(this.FrmRelModelo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbFluxograma;
        private System.Windows.Forms.ComboBox cbbDiscriminador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}