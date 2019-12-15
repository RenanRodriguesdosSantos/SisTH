namespace SisTH.Forms.Cadastros
{
    partial class frmCadClassificacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadClassificacao));
            this.pnlCadModeloBottom = new System.Windows.Forms.Panel();
            this.btnCadModeloSalvar = new System.Windows.Forms.Button();
            this.btnCadModeloCancelar = new System.Windows.Forms.Button();
            this.pnlCadCidadeMiddle = new System.Windows.Forms.Panel();
            this.tbcCadModelo = new System.Windows.Forms.TabControl();
            this.tbpCadModeloDados = new System.Windows.Forms.TabPage();
            this.cadastroDiscriminador = new System.Windows.Forms.Button();
            this.cbbFluxograma = new System.Windows.Forms.ComboBox();
            this.cadastroFluxograma = new System.Windows.Forms.Button();
            this.cbbDiscriminador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCadModeloTop = new System.Windows.Forms.Panel();
            this.pcbCadModeloTitulo = new System.Windows.Forms.PictureBox();
            this.lblCadModeloTitulo = new System.Windows.Forms.Label();
            this.pnlCadModeloBottom.SuspendLayout();
            this.pnlCadCidadeMiddle.SuspendLayout();
            this.tbcCadModelo.SuspendLayout();
            this.tbpCadModeloDados.SuspendLayout();
            this.pnlCadModeloTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadModeloTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadModeloBottom
            // 
            this.pnlCadModeloBottom.BackColor = System.Drawing.Color.White;
            this.pnlCadModeloBottom.Controls.Add(this.btnCadModeloSalvar);
            this.pnlCadModeloBottom.Controls.Add(this.btnCadModeloCancelar);
            this.pnlCadModeloBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCadModeloBottom.Location = new System.Drawing.Point(0, 325);
            this.pnlCadModeloBottom.Name = "pnlCadModeloBottom";
            this.pnlCadModeloBottom.Size = new System.Drawing.Size(631, 47);
            this.pnlCadModeloBottom.TabIndex = 5;
            // 
            // btnCadModeloSalvar
            // 
            this.btnCadModeloSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadModeloSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadModeloSalvar.Image")));
            this.btnCadModeloSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadModeloSalvar.Location = new System.Drawing.Point(415, 4);
            this.btnCadModeloSalvar.Name = "btnCadModeloSalvar";
            this.btnCadModeloSalvar.Size = new System.Drawing.Size(100, 40);
            this.btnCadModeloSalvar.TabIndex = 2;
            this.btnCadModeloSalvar.Text = "&Salvar";
            this.btnCadModeloSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadModeloSalvar.UseVisualStyleBackColor = true;
            this.btnCadModeloSalvar.Click += new System.EventHandler(this.BtnCadModeloSalvar_Click);
            // 
            // btnCadModeloCancelar
            // 
            this.btnCadModeloCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadModeloCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadModeloCancelar.Image")));
            this.btnCadModeloCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadModeloCancelar.Location = new System.Drawing.Point(521, 4);
            this.btnCadModeloCancelar.Name = "btnCadModeloCancelar";
            this.btnCadModeloCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCadModeloCancelar.TabIndex = 1;
            this.btnCadModeloCancelar.Text = "&Cancelar";
            this.btnCadModeloCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadModeloCancelar.UseVisualStyleBackColor = true;
            this.btnCadModeloCancelar.Click += new System.EventHandler(this.BtnCadModeloCancelar_Click);
            // 
            // pnlCadCidadeMiddle
            // 
            this.pnlCadCidadeMiddle.Controls.Add(this.tbcCadModelo);
            this.pnlCadCidadeMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadCidadeMiddle.Location = new System.Drawing.Point(0, 74);
            this.pnlCadCidadeMiddle.Name = "pnlCadCidadeMiddle";
            this.pnlCadCidadeMiddle.Size = new System.Drawing.Size(631, 298);
            this.pnlCadCidadeMiddle.TabIndex = 4;
            // 
            // tbcCadModelo
            // 
            this.tbcCadModelo.Controls.Add(this.tbpCadModeloDados);
            this.tbcCadModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCadModelo.Location = new System.Drawing.Point(0, 0);
            this.tbcCadModelo.Name = "tbcCadModelo";
            this.tbcCadModelo.SelectedIndex = 0;
            this.tbcCadModelo.Size = new System.Drawing.Size(631, 298);
            this.tbcCadModelo.TabIndex = 0;
            // 
            // tbpCadModeloDados
            // 
            this.tbpCadModeloDados.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCadModeloDados.Controls.Add(this.cadastroDiscriminador);
            this.tbpCadModeloDados.Controls.Add(this.cbbFluxograma);
            this.tbpCadModeloDados.Controls.Add(this.cadastroFluxograma);
            this.tbpCadModeloDados.Controls.Add(this.cbbDiscriminador);
            this.tbpCadModeloDados.Controls.Add(this.label3);
            this.tbpCadModeloDados.Controls.Add(this.cbbCor);
            this.tbpCadModeloDados.Controls.Add(this.label2);
            this.tbpCadModeloDados.Controls.Add(this.label1);
            this.tbpCadModeloDados.Location = new System.Drawing.Point(4, 22);
            this.tbpCadModeloDados.Name = "tbpCadModeloDados";
            this.tbpCadModeloDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadModeloDados.Size = new System.Drawing.Size(623, 272);
            this.tbpCadModeloDados.TabIndex = 0;
            this.tbpCadModeloDados.Text = "Dados";
            // 
            // cadastroDiscriminador
            // 
            this.cadastroDiscriminador.Location = new System.Drawing.Point(517, 84);
            this.cadastroDiscriminador.Name = "cadastroDiscriminador";
            this.cadastroDiscriminador.Size = new System.Drawing.Size(67, 23);
            this.cadastroDiscriminador.TabIndex = 4;
            this.cadastroDiscriminador.Text = "Novo";
            this.cadastroDiscriminador.UseVisualStyleBackColor = true;
            this.cadastroDiscriminador.Click += new System.EventHandler(this.CadastroDiscriminador_Click);
            // 
            // cbbFluxograma
            // 
            this.cbbFluxograma.FormattingEnabled = true;
            this.cbbFluxograma.Location = new System.Drawing.Point(18, 36);
            this.cbbFluxograma.Name = "cbbFluxograma";
            this.cbbFluxograma.Size = new System.Drawing.Size(493, 21);
            this.cbbFluxograma.TabIndex = 1;
            // 
            // cadastroFluxograma
            // 
            this.cadastroFluxograma.Location = new System.Drawing.Point(517, 36);
            this.cadastroFluxograma.Name = "cadastroFluxograma";
            this.cadastroFluxograma.Size = new System.Drawing.Size(67, 23);
            this.cadastroFluxograma.TabIndex = 2;
            this.cadastroFluxograma.Text = "Novo";
            this.cadastroFluxograma.UseVisualStyleBackColor = true;
            this.cadastroFluxograma.Click += new System.EventHandler(this.CadastroFluxograma_Click);
            // 
            // cbbDiscriminador
            // 
            this.cbbDiscriminador.FormattingEnabled = true;
            this.cbbDiscriminador.Location = new System.Drawing.Point(18, 86);
            this.cbbDiscriminador.Name = "cbbDiscriminador";
            this.cbbDiscriminador.Size = new System.Drawing.Size(493, 21);
            this.cbbDiscriminador.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 21;
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
            this.cbbCor.Location = new System.Drawing.Point(18, 135);
            this.cbbCor.Name = "cbbCor";
            this.cbbCor.Size = new System.Drawing.Size(131, 21);
            this.cbbCor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Discriminador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fluxograma";
            // 
            // pnlCadModeloTop
            // 
            this.pnlCadModeloTop.BackColor = System.Drawing.Color.White;
            this.pnlCadModeloTop.Controls.Add(this.pcbCadModeloTitulo);
            this.pnlCadModeloTop.Controls.Add(this.lblCadModeloTitulo);
            this.pnlCadModeloTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadModeloTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCadModeloTop.Name = "pnlCadModeloTop";
            this.pnlCadModeloTop.Size = new System.Drawing.Size(631, 74);
            this.pnlCadModeloTop.TabIndex = 3;
            // 
            // pcbCadModeloTitulo
            // 
            this.pcbCadModeloTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pcbCadModeloTitulo.Image")));
            this.pcbCadModeloTitulo.Location = new System.Drawing.Point(10, 3);
            this.pcbCadModeloTitulo.Name = "pcbCadModeloTitulo";
            this.pcbCadModeloTitulo.Size = new System.Drawing.Size(64, 66);
            this.pcbCadModeloTitulo.TabIndex = 3;
            this.pcbCadModeloTitulo.TabStop = false;
            // 
            // lblCadModeloTitulo
            // 
            this.lblCadModeloTitulo.AutoSize = true;
            this.lblCadModeloTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadModeloTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCadModeloTitulo.Location = new System.Drawing.Point(80, 18);
            this.lblCadModeloTitulo.Name = "lblCadModeloTitulo";
            this.lblCadModeloTitulo.Size = new System.Drawing.Size(317, 29);
            this.lblCadModeloTitulo.TabIndex = 2;
            this.lblCadModeloTitulo.Text = "Cadastro de Classificação";
            // 
            // frmCadClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 372);
            this.Controls.Add(this.pnlCadModeloBottom);
            this.Controls.Add(this.pnlCadCidadeMiddle);
            this.Controls.Add(this.pnlCadModeloTop);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadClassificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE TRIAGEM HOSPITALAR";
            this.Load += new System.EventHandler(this.FrmCadClassificacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadClassificacao_KeyDown);
            this.pnlCadModeloBottom.ResumeLayout(false);
            this.pnlCadCidadeMiddle.ResumeLayout(false);
            this.tbcCadModelo.ResumeLayout(false);
            this.tbpCadModeloDados.ResumeLayout(false);
            this.tbpCadModeloDados.PerformLayout();
            this.pnlCadModeloTop.ResumeLayout(false);
            this.pnlCadModeloTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadModeloTitulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadModeloBottom;
        private System.Windows.Forms.Button btnCadModeloSalvar;
        private System.Windows.Forms.Button btnCadModeloCancelar;
        private System.Windows.Forms.Panel pnlCadCidadeMiddle;
        private System.Windows.Forms.TabControl tbcCadModelo;
        private System.Windows.Forms.TabPage tbpCadModeloDados;
        private System.Windows.Forms.Panel pnlCadModeloTop;
        private System.Windows.Forms.PictureBox pcbCadModeloTitulo;
        private System.Windows.Forms.Label lblCadModeloTitulo;
        private System.Windows.Forms.Button cadastroDiscriminador;
        private System.Windows.Forms.Button cadastroFluxograma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCor;
        private System.Windows.Forms.ComboBox cbbDiscriminador;
        private System.Windows.Forms.ComboBox cbbFluxograma;
    }
}