namespace SisTH.Forms.Cadastros
{
    partial class frmCadCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCidade));
            this.pnlCadModeloBottom = new System.Windows.Forms.Panel();
            this.btnCadModeloSalvar = new System.Windows.Forms.Button();
            this.btnCadModeloCancelar = new System.Windows.Forms.Button();
            this.pnlCadCidadeMiddle = new System.Windows.Forms.Panel();
            this.tbcCadModelo = new System.Windows.Forms.TabControl();
            this.tbpCadModeloDados = new System.Windows.Forms.TabPage();
            this.cbbUf = new System.Windows.Forms.ComboBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lblCadCidadeNome = new System.Windows.Forms.Label();
            this.lblCadCidadeUF = new System.Windows.Forms.Label();
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
            this.pnlCadModeloBottom.Location = new System.Drawing.Point(0, 260);
            this.pnlCadModeloBottom.Name = "pnlCadModeloBottom";
            this.pnlCadModeloBottom.Size = new System.Drawing.Size(499, 47);
            this.pnlCadModeloBottom.TabIndex = 5;
            // 
            // btnCadModeloSalvar
            // 
            this.btnCadModeloSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadModeloSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadModeloSalvar.Image")));
            this.btnCadModeloSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadModeloSalvar.Location = new System.Drawing.Point(289, 4);
            this.btnCadModeloSalvar.Name = "btnCadModeloSalvar";
            this.btnCadModeloSalvar.Size = new System.Drawing.Size(100, 40);
            this.btnCadModeloSalvar.TabIndex = 3;
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
            this.btnCadModeloCancelar.Location = new System.Drawing.Point(395, 4);
            this.btnCadModeloCancelar.Name = "btnCadModeloCancelar";
            this.btnCadModeloCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCadModeloCancelar.TabIndex = 4;
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
            this.pnlCadCidadeMiddle.Size = new System.Drawing.Size(499, 233);
            this.pnlCadCidadeMiddle.TabIndex = 4;
            // 
            // tbcCadModelo
            // 
            this.tbcCadModelo.Controls.Add(this.tbpCadModeloDados);
            this.tbcCadModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCadModelo.Location = new System.Drawing.Point(0, 0);
            this.tbcCadModelo.Name = "tbcCadModelo";
            this.tbcCadModelo.SelectedIndex = 0;
            this.tbcCadModelo.Size = new System.Drawing.Size(499, 233);
            this.tbcCadModelo.TabIndex = 0;
            // 
            // tbpCadModeloDados
            // 
            this.tbpCadModeloDados.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCadModeloDados.Controls.Add(this.cbbUf);
            this.tbpCadModeloDados.Controls.Add(this.txNome);
            this.tbpCadModeloDados.Controls.Add(this.lblCadCidadeNome);
            this.tbpCadModeloDados.Controls.Add(this.lblCadCidadeUF);
            this.tbpCadModeloDados.Location = new System.Drawing.Point(4, 22);
            this.tbpCadModeloDados.Name = "tbpCadModeloDados";
            this.tbpCadModeloDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadModeloDados.Size = new System.Drawing.Size(491, 207);
            this.tbpCadModeloDados.TabIndex = 0;
            this.tbpCadModeloDados.Text = "Dados";
            // 
            // cbbUf
            // 
            this.cbbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUf.FormattingEnabled = true;
            this.cbbUf.Items.AddRange(new object[] {
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
            this.cbbUf.Location = new System.Drawing.Point(17, 93);
            this.cbbUf.Name = "cbbUf";
            this.cbbUf.Size = new System.Drawing.Size(128, 21);
            this.cbbUf.Sorted = true;
            this.cbbUf.TabIndex = 2;
            // 
            // txNome
            // 
            this.txNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txNome.Location = new System.Drawing.Point(17, 38);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(451, 20);
            this.txNome.TabIndex = 1;
            // 
            // lblCadCidadeNome
            // 
            this.lblCadCidadeNome.AutoSize = true;
            this.lblCadCidadeNome.Location = new System.Drawing.Point(14, 22);
            this.lblCadCidadeNome.Name = "lblCadCidadeNome";
            this.lblCadCidadeNome.Size = new System.Drawing.Size(35, 13);
            this.lblCadCidadeNome.TabIndex = 7;
            this.lblCadCidadeNome.Text = "Nome";
            // 
            // lblCadCidadeUF
            // 
            this.lblCadCidadeUF.AutoSize = true;
            this.lblCadCidadeUF.Location = new System.Drawing.Point(17, 78);
            this.lblCadCidadeUF.Name = "lblCadCidadeUF";
            this.lblCadCidadeUF.Size = new System.Drawing.Size(21, 13);
            this.lblCadCidadeUF.TabIndex = 9;
            this.lblCadCidadeUF.Text = "UF";
            // 
            // pnlCadModeloTop
            // 
            this.pnlCadModeloTop.BackColor = System.Drawing.Color.White;
            this.pnlCadModeloTop.Controls.Add(this.pcbCadModeloTitulo);
            this.pnlCadModeloTop.Controls.Add(this.lblCadModeloTitulo);
            this.pnlCadModeloTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadModeloTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCadModeloTop.Name = "pnlCadModeloTop";
            this.pnlCadModeloTop.Size = new System.Drawing.Size(499, 74);
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
            this.lblCadModeloTitulo.Size = new System.Drawing.Size(259, 29);
            this.lblCadModeloTitulo.TabIndex = 2;
            this.lblCadModeloTitulo.Text = "Cadastro de Cidades";
            // 
            // frmCadCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 307);
            this.Controls.Add(this.pnlCadModeloBottom);
            this.Controls.Add(this.pnlCadCidadeMiddle);
            this.Controls.Add(this.pnlCadModeloTop);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidades";
            this.Load += new System.EventHandler(this.FrmCadCidade_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadCidade_KeyDown);
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
        private System.Windows.Forms.ComboBox cbbUf;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lblCadCidadeUF;
        private System.Windows.Forms.Label lblCadCidadeNome;
    }
}