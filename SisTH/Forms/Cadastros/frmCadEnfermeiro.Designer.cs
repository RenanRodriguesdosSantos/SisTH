namespace SisTH.Forms.Cadastros
{
    partial class frmCadEnfermeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEnfermeiro));
            this.pnlCadModeloBottom = new System.Windows.Forms.Panel();
            this.btnCadModeloSalvar = new System.Windows.Forms.Button();
            this.btnCadModeloCancelar = new System.Windows.Forms.Button();
            this.pnlCadCidadeMiddle = new System.Windows.Forms.Panel();
            this.tbcCadModelo = new System.Windows.Forms.TabControl();
            this.tbpCadModeloDados = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCoren = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.pnlCadModeloBottom.Location = new System.Drawing.Point(0, 399);
            this.pnlCadModeloBottom.Name = "pnlCadModeloBottom";
            this.pnlCadModeloBottom.Size = new System.Drawing.Size(389, 47);
            this.pnlCadModeloBottom.TabIndex = 5;
            // 
            // btnCadModeloSalvar
            // 
            this.btnCadModeloSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadModeloSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadModeloSalvar.Image")));
            this.btnCadModeloSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadModeloSalvar.Location = new System.Drawing.Point(165, 3);
            this.btnCadModeloSalvar.Name = "btnCadModeloSalvar";
            this.btnCadModeloSalvar.Size = new System.Drawing.Size(100, 40);
            this.btnCadModeloSalvar.TabIndex = 6;
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
            this.btnCadModeloCancelar.Location = new System.Drawing.Point(271, 3);
            this.btnCadModeloCancelar.Name = "btnCadModeloCancelar";
            this.btnCadModeloCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCadModeloCancelar.TabIndex = 7;
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
            this.pnlCadCidadeMiddle.Size = new System.Drawing.Size(389, 372);
            this.pnlCadCidadeMiddle.TabIndex = 4;
            // 
            // tbcCadModelo
            // 
            this.tbcCadModelo.Controls.Add(this.tbpCadModeloDados);
            this.tbcCadModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCadModelo.Location = new System.Drawing.Point(0, 0);
            this.tbcCadModelo.Name = "tbcCadModelo";
            this.tbcCadModelo.SelectedIndex = 0;
            this.tbcCadModelo.Size = new System.Drawing.Size(389, 372);
            this.tbcCadModelo.TabIndex = 0;
            // 
            // tbpCadModeloDados
            // 
            this.tbpCadModeloDados.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCadModeloDados.Controls.Add(this.label5);
            this.tbpCadModeloDados.Controls.Add(this.txtNome);
            this.tbpCadModeloDados.Controls.Add(this.txtCoren);
            this.tbpCadModeloDados.Controls.Add(this.label4);
            this.tbpCadModeloDados.Controls.Add(this.txtConfirmarSenha);
            this.tbpCadModeloDados.Controls.Add(this.label3);
            this.tbpCadModeloDados.Controls.Add(this.label1);
            this.tbpCadModeloDados.Controls.Add(this.txtLogin);
            this.tbpCadModeloDados.Controls.Add(this.txtSenha);
            this.tbpCadModeloDados.Controls.Add(this.label2);
            this.tbpCadModeloDados.Location = new System.Drawing.Point(4, 22);
            this.tbpCadModeloDados.Name = "tbpCadModeloDados";
            this.tbpCadModeloDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadModeloDados.Size = new System.Drawing.Size(381, 346);
            this.tbpCadModeloDados.TabIndex = 0;
            this.tbpCadModeloDados.Text = "Dados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Coren";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(19, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(307, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCoren
            // 
            this.txtCoren.Location = new System.Drawing.Point(19, 141);
            this.txtCoren.Name = "txtCoren";
            this.txtCoren.Size = new System.Drawing.Size(223, 20);
            this.txtCoren.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Confirmar Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(19, 255);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(223, 20);
            this.txtConfirmarSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nome";
            // 
            // txtLogin
            // 
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Location = new System.Drawing.Point(19, 88);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(307, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(19, 197);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(223, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Login";
            // 
            // pnlCadModeloTop
            // 
            this.pnlCadModeloTop.BackColor = System.Drawing.Color.White;
            this.pnlCadModeloTop.Controls.Add(this.pcbCadModeloTitulo);
            this.pnlCadModeloTop.Controls.Add(this.lblCadModeloTitulo);
            this.pnlCadModeloTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadModeloTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCadModeloTop.Name = "pnlCadModeloTop";
            this.pnlCadModeloTop.Size = new System.Drawing.Size(389, 74);
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
            this.lblCadModeloTitulo.Size = new System.Drawing.Size(304, 29);
            this.lblCadModeloTitulo.TabIndex = 2;
            this.lblCadModeloTitulo.Text = "Cadastro de Enfermeiros";
            // 
            // frmCadEnfermeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 446);
            this.Controls.Add(this.pnlCadModeloBottom);
            this.Controls.Add(this.pnlCadCidadeMiddle);
            this.Controls.Add(this.pnlCadModeloTop);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadEnfermeiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Enfermeiros";
            this.Load += new System.EventHandler(this.FrmCadEnfermeiro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadEnfermeiro_KeyDown);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCoren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.Label label2;
    }
}