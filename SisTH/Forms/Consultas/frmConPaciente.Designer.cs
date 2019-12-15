namespace SisTH.Forms.Consultas
{
    partial class frmConPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConPaciente));
            this.pnlCadModeloBottom = new System.Windows.Forms.Panel();
            this.btnLisModeloEditar = new System.Windows.Forms.Button();
            this.btnLisModeloCadastrar = new System.Windows.Forms.Button();
            this.btnCadModeloSalvar = new System.Windows.Forms.Button();
            this.btnCadModeloCancelar = new System.Windows.Forms.Button();
            this.btnLisModeloPesquisar = new System.Windows.Forms.Button();
            this.pnlCadCidadeMiddle = new System.Windows.Forms.Panel();
            this.tbcCadModelo = new System.Windows.Forms.TabControl();
            this.tbpCadModeloDados = new System.Windows.Forms.TabPage();
            this.dgvLisModelo = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCadModeloTop = new System.Windows.Forms.Panel();
            this.pcbCadModeloTitulo = new System.Windows.Forms.PictureBox();
            this.lblCadModeloTitulo = new System.Windows.Forms.Label();
            this.pnlCadModeloBottom.SuspendLayout();
            this.pnlCadCidadeMiddle.SuspendLayout();
            this.tbcCadModelo.SuspendLayout();
            this.tbpCadModeloDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLisModelo)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlCadModeloTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadModeloTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadModeloBottom
            // 
            this.pnlCadModeloBottom.BackColor = System.Drawing.Color.White;
            this.pnlCadModeloBottom.Controls.Add(this.btnLisModeloEditar);
            this.pnlCadModeloBottom.Controls.Add(this.btnLisModeloCadastrar);
            this.pnlCadModeloBottom.Controls.Add(this.btnCadModeloSalvar);
            this.pnlCadModeloBottom.Controls.Add(this.btnCadModeloCancelar);
            this.pnlCadModeloBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCadModeloBottom.Location = new System.Drawing.Point(0, 462);
            this.pnlCadModeloBottom.Name = "pnlCadModeloBottom";
            this.pnlCadModeloBottom.Size = new System.Drawing.Size(658, 47);
            this.pnlCadModeloBottom.TabIndex = 5;
            // 
            // btnLisModeloEditar
            // 
            this.btnLisModeloEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisModeloEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnLisModeloEditar.Image")));
            this.btnLisModeloEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLisModeloEditar.Location = new System.Drawing.Point(342, 3);
            this.btnLisModeloEditar.Name = "btnLisModeloEditar";
            this.btnLisModeloEditar.Size = new System.Drawing.Size(100, 40);
            this.btnLisModeloEditar.TabIndex = 6;
            this.btnLisModeloEditar.Text = "&Editar";
            this.btnLisModeloEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLisModeloEditar.UseVisualStyleBackColor = true;
            this.btnLisModeloEditar.Click += new System.EventHandler(this.BtnLisModeloEditar_Click);
            // 
            // btnLisModeloCadastrar
            // 
            this.btnLisModeloCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisModeloCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnLisModeloCadastrar.Image")));
            this.btnLisModeloCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLisModeloCadastrar.Location = new System.Drawing.Point(236, 3);
            this.btnLisModeloCadastrar.Name = "btnLisModeloCadastrar";
            this.btnLisModeloCadastrar.Size = new System.Drawing.Size(100, 40);
            this.btnLisModeloCadastrar.TabIndex = 5;
            this.btnLisModeloCadastrar.Text = "&Cadastrar";
            this.btnLisModeloCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLisModeloCadastrar.UseVisualStyleBackColor = true;
            this.btnLisModeloCadastrar.Click += new System.EventHandler(this.BtnLisModeloCadastrar_Click);
            // 
            // btnCadModeloSalvar
            // 
            this.btnCadModeloSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadModeloSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadModeloSalvar.Image")));
            this.btnCadModeloSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadModeloSalvar.Location = new System.Drawing.Point(448, 3);
            this.btnCadModeloSalvar.Name = "btnCadModeloSalvar";
            this.btnCadModeloSalvar.Size = new System.Drawing.Size(100, 40);
            this.btnCadModeloSalvar.TabIndex = 7;
            this.btnCadModeloSalvar.Text = "&Confirmar";
            this.btnCadModeloSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadModeloSalvar.UseVisualStyleBackColor = true;
            this.btnCadModeloSalvar.Click += new System.EventHandler(this.BtnCadModeloSalvar_Click);
            // 
            // btnCadModeloCancelar
            // 
            this.btnCadModeloCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadModeloCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadModeloCancelar.Image")));
            this.btnCadModeloCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadModeloCancelar.Location = new System.Drawing.Point(554, 3);
            this.btnCadModeloCancelar.Name = "btnCadModeloCancelar";
            this.btnCadModeloCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCadModeloCancelar.TabIndex = 8;
            this.btnCadModeloCancelar.Text = "&Cancelar";
            this.btnCadModeloCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadModeloCancelar.UseVisualStyleBackColor = true;
            this.btnCadModeloCancelar.Click += new System.EventHandler(this.BtnCadModeloCancelar_Click);
            // 
            // btnLisModeloPesquisar
            // 
            this.btnLisModeloPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisModeloPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnLisModeloPesquisar.Image")));
            this.btnLisModeloPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLisModeloPesquisar.Location = new System.Drawing.Point(451, 45);
            this.btnLisModeloPesquisar.Name = "btnLisModeloPesquisar";
            this.btnLisModeloPesquisar.Size = new System.Drawing.Size(100, 40);
            this.btnLisModeloPesquisar.TabIndex = 4;
            this.btnLisModeloPesquisar.Text = "&Pesquisar";
            this.btnLisModeloPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLisModeloPesquisar.UseVisualStyleBackColor = true;
            this.btnLisModeloPesquisar.Click += new System.EventHandler(this.BtnLisModeloPesquisar_Click);
            // 
            // pnlCadCidadeMiddle
            // 
            this.pnlCadCidadeMiddle.Controls.Add(this.tbcCadModelo);
            this.pnlCadCidadeMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadCidadeMiddle.Location = new System.Drawing.Point(0, 74);
            this.pnlCadCidadeMiddle.Name = "pnlCadCidadeMiddle";
            this.pnlCadCidadeMiddle.Size = new System.Drawing.Size(658, 435);
            this.pnlCadCidadeMiddle.TabIndex = 4;
            // 
            // tbcCadModelo
            // 
            this.tbcCadModelo.Controls.Add(this.tbpCadModeloDados);
            this.tbcCadModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCadModelo.Location = new System.Drawing.Point(0, 0);
            this.tbcCadModelo.Name = "tbcCadModelo";
            this.tbcCadModelo.SelectedIndex = 0;
            this.tbcCadModelo.Size = new System.Drawing.Size(658, 435);
            this.tbcCadModelo.TabIndex = 0;
            // 
            // tbpCadModeloDados
            // 
            this.tbpCadModeloDados.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCadModeloDados.Controls.Add(this.dgvLisModelo);
            this.tbpCadModeloDados.Controls.Add(this.panel3);
            this.tbpCadModeloDados.Location = new System.Drawing.Point(4, 22);
            this.tbpCadModeloDados.Name = "tbpCadModeloDados";
            this.tbpCadModeloDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadModeloDados.Size = new System.Drawing.Size(650, 409);
            this.tbpCadModeloDados.TabIndex = 0;
            this.tbpCadModeloDados.Text = "Dados";
            // 
            // dgvLisModelo
            // 
            this.dgvLisModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLisModelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLisModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLisModelo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLisModelo.EnableHeadersVisualStyles = false;
            this.dgvLisModelo.Location = new System.Drawing.Point(6, 102);
            this.dgvLisModelo.Name = "dgvLisModelo";
            this.dgvLisModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLisModelo.Size = new System.Drawing.Size(637, 260);
            this.dgvLisModelo.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnLisModeloPesquisar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtNomeMae);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.txtNascimento);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 95);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome da Mãe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMae.Location = new System.Drawing.Point(17, 61);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(403, 20);
            this.txtNomeMae.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(17, 14);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(403, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(451, 14);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(92, 20);
            this.txtNascimento.TabIndex = 2;
            this.txtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nascimento";
            // 
            // pnlCadModeloTop
            // 
            this.pnlCadModeloTop.BackColor = System.Drawing.Color.White;
            this.pnlCadModeloTop.Controls.Add(this.pcbCadModeloTitulo);
            this.pnlCadModeloTop.Controls.Add(this.lblCadModeloTitulo);
            this.pnlCadModeloTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCadModeloTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCadModeloTop.Name = "pnlCadModeloTop";
            this.pnlCadModeloTop.Size = new System.Drawing.Size(658, 74);
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
            this.lblCadModeloTitulo.Size = new System.Drawing.Size(276, 29);
            this.lblCadModeloTitulo.TabIndex = 2;
            this.lblCadModeloTitulo.Text = "Pesquisa por Paciente";
            // 
            // frmConPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 509);
            this.Controls.Add(this.pnlCadModeloBottom);
            this.Controls.Add(this.pnlCadCidadeMiddle);
            this.Controls.Add(this.pnlCadModeloTop);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmConPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE TRIAGEM HOSPITALAR";
            this.Load += new System.EventHandler(this.FrmConPaciente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConPaciente_KeyDown);
            this.pnlCadModeloBottom.ResumeLayout(false);
            this.pnlCadCidadeMiddle.ResumeLayout(false);
            this.tbcCadModelo.ResumeLayout(false);
            this.tbpCadModeloDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLisModelo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLisModeloPesquisar;
        private System.Windows.Forms.Button btnLisModeloEditar;
        private System.Windows.Forms.Button btnLisModeloCadastrar;
        private System.Windows.Forms.DataGridView dgvLisModelo;
    }
}