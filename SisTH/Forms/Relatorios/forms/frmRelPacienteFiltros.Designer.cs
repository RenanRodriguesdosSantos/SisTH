namespace SisTH.Forms.Relatorios
{
    partial class frmRelPacienteFiltros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelPacienteFiltros));
            this.pnlCadModeloBottom = new System.Windows.Forms.Panel();
            this.btnCadModeloSalvar = new System.Windows.Forms.Button();
            this.btnCadModeloCancelar = new System.Windows.Forms.Button();
            this.pnlCadCidadeMiddle = new System.Windows.Forms.Panel();
            this.tbcCadModelo = new System.Windows.Forms.TabControl();
            this.tbpCadModeloDados = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbBairro = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbProfissao = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbEtnia = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlCadModeloTop = new System.Windows.Forms.Panel();
            this.pcbCadModeloTitulo = new System.Windows.Forms.PictureBox();
            this.lblCadModeloTitulo = new System.Windows.Forms.Label();
            this.pnlCadModeloBottom.SuspendLayout();
            this.pnlCadCidadeMiddle.SuspendLayout();
            this.tbcCadModelo.SuspendLayout();
            this.tbpCadModeloDados.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlCadModeloBottom.Location = new System.Drawing.Point(0, 467);
            this.pnlCadModeloBottom.Name = "pnlCadModeloBottom";
            this.pnlCadModeloBottom.Size = new System.Drawing.Size(442, 47);
            this.pnlCadModeloBottom.TabIndex = 5;
            // 
            // btnCadModeloSalvar
            // 
            this.btnCadModeloSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadModeloSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadModeloSalvar.Image")));
            this.btnCadModeloSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadModeloSalvar.Location = new System.Drawing.Point(215, 3);
            this.btnCadModeloSalvar.Name = "btnCadModeloSalvar";
            this.btnCadModeloSalvar.Size = new System.Drawing.Size(100, 40);
            this.btnCadModeloSalvar.TabIndex = 2;
            this.btnCadModeloSalvar.Text = "&Aplicar";
            this.btnCadModeloSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadModeloSalvar.UseVisualStyleBackColor = true;
            this.btnCadModeloSalvar.Click += new System.EventHandler(this.BtnCadModeloSalvar_Click);
            // 
            // btnCadModeloCancelar
            // 
            this.btnCadModeloCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadModeloCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadModeloCancelar.Image")));
            this.btnCadModeloCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadModeloCancelar.Location = new System.Drawing.Point(321, 3);
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
            this.pnlCadCidadeMiddle.Size = new System.Drawing.Size(442, 440);
            this.pnlCadCidadeMiddle.TabIndex = 4;
            // 
            // tbcCadModelo
            // 
            this.tbcCadModelo.Controls.Add(this.tbpCadModeloDados);
            this.tbcCadModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCadModelo.Location = new System.Drawing.Point(0, 0);
            this.tbcCadModelo.Name = "tbcCadModelo";
            this.tbcCadModelo.SelectedIndex = 0;
            this.tbcCadModelo.Size = new System.Drawing.Size(442, 440);
            this.tbcCadModelo.TabIndex = 0;
            // 
            // tbpCadModeloDados
            // 
            this.tbpCadModeloDados.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCadModeloDados.Controls.Add(this.panel1);
            this.tbpCadModeloDados.Location = new System.Drawing.Point(4, 22);
            this.tbpCadModeloDados.Name = "tbpCadModeloDados";
            this.tbpCadModeloDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadModeloDados.Size = new System.Drawing.Size(434, 414);
            this.tbpCadModeloDados.TabIndex = 0;
            this.tbpCadModeloDados.Text = "Dados";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbCidade);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cbbBairro);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbbProfissao);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbbEtnia);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtCpf);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNomeMae);
            this.panel1.Controls.Add(this.txtNascimento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 408);
            this.panel1.TabIndex = 7;
            // 
            // cbbCidade
            // 
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(17, 326);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(395, 21);
            this.cbbCidade.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Cidade";
            // 
            // cbbBairro
            // 
            this.cbbBairro.FormattingEnabled = true;
            this.cbbBairro.Location = new System.Drawing.Point(17, 279);
            this.cbbBairro.Name = "cbbBairro";
            this.cbbBairro.Size = new System.Drawing.Size(395, 21);
            this.cbbBairro.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Bairro";
            // 
            // cbbProfissao
            // 
            this.cbbProfissao.FormattingEnabled = true;
            this.cbbProfissao.Location = new System.Drawing.Point(17, 234);
            this.cbbProfissao.Name = "cbbProfissao";
            this.cbbProfissao.Size = new System.Drawing.Size(395, 21);
            this.cbbProfissao.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Profissão";
            // 
            // cbbEtnia
            // 
            this.cbbEtnia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbbEtnia.FormattingEnabled = true;
            this.cbbEtnia.Location = new System.Drawing.Point(17, 187);
            this.cbbEtnia.Name = "cbbEtnia";
            this.cbbEtnia.Size = new System.Drawing.Size(395, 21);
            this.cbbEtnia.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Etnia";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(305, 55);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(108, 20);
            this.txtCpf.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cpf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mãe";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMae.Location = new System.Drawing.Point(17, 148);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(395, 20);
            this.txtNomeMae.TabIndex = 12;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(158, 53);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(111, 20);
            this.txtNascimento.TabIndex = 10;
            this.txtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(17, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(395, 20);
            this.txtNome.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "FILTROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(17, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(111, 20);
            this.txtId.TabIndex = 4;
            // 
            // pnlCadModeloTop
            // 
            this.pnlCadModeloTop.BackColor = System.Drawing.Color.White;
            this.pnlCadModeloTop.Controls.Add(this.pcbCadModeloTitulo);
            this.pnlCadModeloTop.Controls.Add(this.lblCadModeloTitulo);
            this.pnlCadModeloTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadModeloTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCadModeloTop.Name = "pnlCadModeloTop";
            this.pnlCadModeloTop.Size = new System.Drawing.Size(442, 74);
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
            this.lblCadModeloTitulo.Size = new System.Drawing.Size(268, 29);
            this.lblCadModeloTitulo.TabIndex = 2;
            this.lblCadModeloTitulo.Text = "Filtros para Pacientes";
            // 
            // frmRelPacienteFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 514);
            this.Controls.Add(this.pnlCadModeloBottom);
            this.Controls.Add(this.pnlCadCidadeMiddle);
            this.Controls.Add(this.pnlCadModeloTop);
            this.MaximizeBox = false;
            this.Name = "frmRelPacienteFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE TRIAGEM HOSPITALAR";
            this.Load += new System.EventHandler(this.FrmRelPacienteFiltros_Load);
            this.pnlCadModeloBottom.ResumeLayout(false);
            this.pnlCadCidadeMiddle.ResumeLayout(false);
            this.tbcCadModelo.ResumeLayout(false);
            this.tbpCadModeloDados.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbbProfissao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbEtnia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbBairro;
        private System.Windows.Forms.Label label15;
    }
}