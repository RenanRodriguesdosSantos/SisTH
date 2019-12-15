namespace SisTH
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profissoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discriminadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profissãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoLogradouroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEnfermeirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatarUmProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem14,
            this.administradorToolStripMenuItem1,
            this.administradorToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atendimentoToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.enfermeiroToolStripMenuItem,
            this.profissoesToolStripMenuItem,
            this.discriminadorToolStripMenuItem,
            this.etniaToolStripMenuItem,
            this.fluxogramaToolStripMenuItem,
            this.pacienteToolStripMenuItem1,
            this.profissãoToolStripMenuItem,
            this.tipoLogradouroToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::SisTH.Properties.Resources.anchor;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.toolStripMenuItem1.Text = "Tabelas";
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.Image = global::SisTH.Properties.Resources.application_view_list;
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            this.atendimentoToolStripMenuItem.Click += new System.EventHandler(this.AtendimentoToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Image = global::SisTH.Properties.Resources.map;
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.pacienteToolStripMenuItem.Text = "Bairro";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.BairroToolStripMenuItem_Click);
            // 
            // enfermeiroToolStripMenuItem
            // 
            this.enfermeiroToolStripMenuItem.Image = global::SisTH.Properties.Resources.world;
            this.enfermeiroToolStripMenuItem.Name = "enfermeiroToolStripMenuItem";
            this.enfermeiroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.enfermeiroToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.enfermeiroToolStripMenuItem.Text = "Cidade";
            this.enfermeiroToolStripMenuItem.Click += new System.EventHandler(this.EnfermeiroToolStripMenuItem_Click);
            // 
            // profissoesToolStripMenuItem
            // 
            this.profissoesToolStripMenuItem.Image = global::SisTH.Properties.Resources.clock;
            this.profissoesToolStripMenuItem.Name = "profissoesToolStripMenuItem";
            this.profissoesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.profissoesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.profissoesToolStripMenuItem.Text = "Classificação";
            this.profissoesToolStripMenuItem.Click += new System.EventHandler(this.ClassificacaoToolStripMenuItem_Click_1);
            // 
            // discriminadorToolStripMenuItem
            // 
            this.discriminadorToolStripMenuItem.Image = global::SisTH.Properties.Resources.bug;
            this.discriminadorToolStripMenuItem.Name = "discriminadorToolStripMenuItem";
            this.discriminadorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.discriminadorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.discriminadorToolStripMenuItem.Text = "Discriminador";
            this.discriminadorToolStripMenuItem.Click += new System.EventHandler(this.DiscriminadorToolStripMenuItem_Click);
            // 
            // etniaToolStripMenuItem
            // 
            this.etniaToolStripMenuItem.Image = global::SisTH.Properties.Resources.group;
            this.etniaToolStripMenuItem.Name = "etniaToolStripMenuItem";
            this.etniaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.etniaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.etniaToolStripMenuItem.Text = "Etnia";
            this.etniaToolStripMenuItem.Click += new System.EventHandler(this.EtniaToolStripMenuItem_Click);
            // 
            // fluxogramaToolStripMenuItem
            // 
            this.fluxogramaToolStripMenuItem.Image = global::SisTH.Properties.Resources.chart_organisation;
            this.fluxogramaToolStripMenuItem.Name = "fluxogramaToolStripMenuItem";
            this.fluxogramaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fluxogramaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.fluxogramaToolStripMenuItem.Text = "Fluxograma";
            this.fluxogramaToolStripMenuItem.Click += new System.EventHandler(this.FluxogramaToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem1
            // 
            this.pacienteToolStripMenuItem1.Image = global::SisTH.Properties.Resources.user;
            this.pacienteToolStripMenuItem1.Name = "pacienteToolStripMenuItem1";
            this.pacienteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pacienteToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.pacienteToolStripMenuItem1.Text = "Paciente";
            this.pacienteToolStripMenuItem1.Click += new System.EventHandler(this.PacienteToolStripMenuItem1_Click);
            // 
            // profissãoToolStripMenuItem
            // 
            this.profissãoToolStripMenuItem.Image = global::SisTH.Properties.Resources.lorry;
            this.profissãoToolStripMenuItem.Name = "profissãoToolStripMenuItem";
            this.profissãoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.profissãoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.profissãoToolStripMenuItem.Text = "Profissão";
            this.profissãoToolStripMenuItem.Click += new System.EventHandler(this.ProfissãoToolStripMenuItem_Click);
            // 
            // tipoLogradouroToolStripMenuItem
            // 
            this.tipoLogradouroToolStripMenuItem.Image = global::SisTH.Properties.Resources.package;
            this.tipoLogradouroToolStripMenuItem.Name = "tipoLogradouroToolStripMenuItem";
            this.tipoLogradouroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tipoLogradouroToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.tipoLogradouroToolStripMenuItem.Text = "Tipo Logradouro";
            this.tipoLogradouroToolStripMenuItem.Click += new System.EventHandler(this.TipoLogradouroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
            this.toolStripMenuItem2.Image = global::SisTH.Properties.Resources.add;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuItem2.Text = "Cadastros";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::SisTH.Properties.Resources.application_add1;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem3.Text = "Atendimento";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::SisTH.Properties.Resources.map_add;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem4.Text = "Bairro";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::SisTH.Properties.Resources.world_add;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem5.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem5.Text = "Cidade";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::SisTH.Properties.Resources.clock_add;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.toolStripMenuItem6.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem6.Text = "Classificação";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ToolStripMenuItem6_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = global::SisTH.Properties.Resources.bug_add;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.toolStripMenuItem8.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem8.Text = "Discriminador";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.ToolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = global::SisTH.Properties.Resources.group_add;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItem9.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem9.Text = "Etnia";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.ToolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Image = global::SisTH.Properties.Resources.chart_organisation_add;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.toolStripMenuItem10.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem10.Text = "Fluxograma";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Image = global::SisTH.Properties.Resources.user_add;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItem11.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem11.Text = "Paciente";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.ToolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Image = global::SisTH.Properties.Resources.lorry_add;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItem12.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem12.Text = "Profissão";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.ToolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Image = global::SisTH.Properties.Resources.package_add;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItem13.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem13.Text = "Tipo Logradouro";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.ToolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25});
            this.toolStripMenuItem14.Image = global::SisTH.Properties.Resources.accept;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuItem14.Text = "Relatórios";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Image = global::SisTH.Properties.Resources.application_view_detail;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.toolStripMenuItem15.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem15.Text = "Atendimento";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.ToolStripMenuItem15_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Image = global::SisTH.Properties.Resources.map_go;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.toolStripMenuItem16.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem16.Text = "Bairro";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.ToolStripMenuItem16_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Image = global::SisTH.Properties.Resources.world_go;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.toolStripMenuItem17.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem17.Text = "Cidade";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.ToolStripMenuItem17_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Image = global::SisTH.Properties.Resources.clock_go;
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.toolStripMenuItem19.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem19.Text = "Classificação";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.ToolStripMenuItem19_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Image = global::SisTH.Properties.Resources.bug_go;
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItem20.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem20.Text = "Discriminador";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.ToolStripMenuItem20_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Image = global::SisTH.Properties.Resources.group_go;
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.toolStripMenuItem21.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem21.Text = "Etnia";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.ToolStripMenuItem21_Click);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Image = global::SisTH.Properties.Resources.chart_curve_go;
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.toolStripMenuItem22.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem22.Text = "Fluxograma";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.ToolStripMenuItem22_Click);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Image = global::SisTH.Properties.Resources.user_go;
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.toolStripMenuItem23.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem23.Text = "Paciente";
            this.toolStripMenuItem23.Click += new System.EventHandler(this.ToolStripMenuItem23_Click);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Image = global::SisTH.Properties.Resources.lorry_go;
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.toolStripMenuItem24.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem24.Text = "Profissão";
            this.toolStripMenuItem24.Click += new System.EventHandler(this.ToolStripMenuItem24_Click);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Image = global::SisTH.Properties.Resources.package_go;
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.toolStripMenuItem25.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem25.Text = "Tipo Logradouro";
            this.toolStripMenuItem25.Click += new System.EventHandler(this.ToolStripMenuItem25_Click);
            // 
            // administradorToolStripMenuItem1
            // 
            this.administradorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.listaDeEnfermeirosToolStripMenuItem});
            this.administradorToolStripMenuItem1.Image = global::SisTH.Properties.Resources.user_orange;
            this.administradorToolStripMenuItem1.Name = "administradorToolStripMenuItem1";
            this.administradorToolStripMenuItem1.Size = new System.Drawing.Size(111, 20);
            this.administradorToolStripMenuItem1.Text = "Administrador";
            this.administradorToolStripMenuItem1.Click += new System.EventHandler(this.AdministradorToolStripMenuItem1_Click);
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Enabled = false;
            this.novoUsuárioToolStripMenuItem.Image = global::SisTH.Properties.Resources.user_add;
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Enfermeiro";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.NovoUsuárioToolStripMenuItem_Click);
            // 
            // listaDeEnfermeirosToolStripMenuItem
            // 
            this.listaDeEnfermeirosToolStripMenuItem.Enabled = false;
            this.listaDeEnfermeirosToolStripMenuItem.Image = global::SisTH.Properties.Resources.user_red;
            this.listaDeEnfermeirosToolStripMenuItem.Name = "listaDeEnfermeirosToolStripMenuItem";
            this.listaDeEnfermeirosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeEnfermeirosToolStripMenuItem.Text = "Lista de Enfermeiros";
            this.listaDeEnfermeirosToolStripMenuItem.Click += new System.EventHandler(this.ListaDeEnfermeirosToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.trocarDeUsuárioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.administradorToolStripMenuItem.Image = global::SisTH.Properties.Resources.user_green;
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.administradorToolStripMenuItem.Text = "Enfermeiro";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = global::SisTH.Properties.Resources.key;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Alterar Senha";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.NovoToolStripMenuItem_Click);
            // 
            // trocarDeUsuárioToolStripMenuItem
            // 
            this.trocarDeUsuárioToolStripMenuItem.Image = global::SisTH.Properties.Resources.arrow_refresh;
            this.trocarDeUsuárioToolStripMenuItem.Name = "trocarDeUsuárioToolStripMenuItem";
            this.trocarDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trocarDeUsuárioToolStripMenuItem.Text = "Trocar de Usuário";
            this.trocarDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.TrocarDeUsuárioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::SisTH.Properties.Resources.door_out;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.relatarUmProblemaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Image = global::SisTH.Properties.Resources.help;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Image = global::SisTH.Properties.Resources.book;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // relatarUmProblemaToolStripMenuItem
            // 
            this.relatarUmProblemaToolStripMenuItem.Image = global::SisTH.Properties.Resources.cancel;
            this.relatarUmProblemaToolStripMenuItem.Name = "relatarUmProblemaToolStripMenuItem";
            this.relatarUmProblemaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.relatarUmProblemaToolStripMenuItem.Text = "Relatar um problema";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::SisTH.Properties.Resources.information;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA TRIAGEM HOSPITALAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profissoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discriminadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fluxogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem profissãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoLogradouroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEnfermeirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatarUmProblemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

