namespace SoftwareAniversariantes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1Inicial = new System.Windows.Forms.TabPage();
            this.btnPgRelatorios = new System.Windows.Forms.Button();
            this.btnPgEditar = new System.Windows.Forms.Button();
            this.btnPgCadastro = new System.Windows.Forms.Button();
            this.tabPage2Novo = new System.Windows.Forms.TabPage();
            this.btnPgRelatorios1 = new System.Windows.Forms.Button();
            this.btnPgInicio = new System.Windows.Forms.Button();
            this.btnAdicionarComunidade = new System.Windows.Forms.Button();
            this.panelComunidade = new System.Windows.Forms.Panel();
            this.btnFecharPnlComunidade = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.Label();
            this.Comunidade = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.ComboBox();
            this.btn_SalvarComunidade = new System.Windows.Forms.Button();
            this.txtNovaComunidade = new System.Windows.Forms.TextBox();
            this.chkUrbana = new System.Windows.Forms.CheckBox();
            this.chkRural = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.btnSalvarComunidade = new System.Windows.Forms.Button();
            this.chkDataFalecimentoDesconhecida = new System.Windows.Forms.CheckBox();
            this.dtpFalecimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataFalecimento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkVivo = new System.Windows.Forms.CheckBox();
            this.chkAnoImpreciso = new System.Windows.Forms.CheckBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtComunidade = new System.Windows.Forms.ComboBox();
            this.lblFieldComunidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCadastroTitulo = new System.Windows.Forms.Label();
            this.tabPage3Relatorios = new System.Windows.Forms.TabPage();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiltrarAniversariantes = new System.Windows.Forms.Button();
            this.dtpFiltroDataAniversario = new System.Windows.Forms.DateTimePicker();
            this.rbFiltroPorData = new System.Windows.Forms.RadioButton();
            this.cbMesFiltro = new System.Windows.Forms.ComboBox();
            this.rbFiltroPorMes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPgInicioRelatorio = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabPage1Inicial.SuspendLayout();
            this.tabPage2Novo.SuspendLayout();
            this.panelComunidade.SuspendLayout();
            this.tabPage3Relatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.TabPage1Inicial);
            this.tabControl1.Controls.Add(this.tabPage2Novo);
            this.tabControl1.Controls.Add(this.tabPage3Relatorios);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 560);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 16;
            // 
            // TabPage1Inicial
            // 
            this.TabPage1Inicial.Controls.Add(this.btnPgRelatorios);
            this.TabPage1Inicial.Controls.Add(this.btnPgEditar);
            this.TabPage1Inicial.Controls.Add(this.btnPgCadastro);
            this.TabPage1Inicial.Location = new System.Drawing.Point(4, 5);
            this.TabPage1Inicial.Name = "TabPage1Inicial";
            this.TabPage1Inicial.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1Inicial.Size = new System.Drawing.Size(912, 551);
            this.TabPage1Inicial.TabIndex = 0;
            this.TabPage1Inicial.Text = "Inicio";
            this.TabPage1Inicial.UseVisualStyleBackColor = true;
            // 
            // btnPgRelatorios
            // 
            this.btnPgRelatorios.Location = new System.Drawing.Point(403, 200);
            this.btnPgRelatorios.Name = "btnPgRelatorios";
            this.btnPgRelatorios.Size = new System.Drawing.Size(200, 40);
            this.btnPgRelatorios.TabIndex = 1;
            this.btnPgRelatorios.Text = "Relatórios";
            this.btnPgRelatorios.UseVisualStyleBackColor = true;
            this.btnPgRelatorios.Click += new System.EventHandler(this.btnPgRelatorios_Click);
            // 
            // btnPgEditar
            // 
            this.btnPgEditar.Location = new System.Drawing.Point(287, 345);
            this.btnPgEditar.Name = "btnPgEditar";
            this.btnPgEditar.Size = new System.Drawing.Size(200, 40);
            this.btnPgEditar.TabIndex = 0;
            this.btnPgEditar.Text = "Editar Cadastro";
            this.btnPgEditar.UseVisualStyleBackColor = true;
            this.btnPgEditar.Visible = false;
            this.btnPgEditar.Click += new System.EventHandler(this.btnPgCadastro_Click);
            // 
            // btnPgCadastro
            // 
            this.btnPgCadastro.Location = new System.Drawing.Point(182, 200);
            this.btnPgCadastro.Name = "btnPgCadastro";
            this.btnPgCadastro.Size = new System.Drawing.Size(200, 40);
            this.btnPgCadastro.TabIndex = 0;
            this.btnPgCadastro.Text = "Novo cadastro";
            this.btnPgCadastro.UseVisualStyleBackColor = true;
            this.btnPgCadastro.Click += new System.EventHandler(this.btnPgCadastro_Click);
            // 
            // tabPage2Novo
            // 
            this.tabPage2Novo.AutoScroll = true;
            this.tabPage2Novo.Controls.Add(this.txtCodigo);
            this.tabPage2Novo.Controls.Add(this.btnPgRelatorios1);
            this.tabPage2Novo.Controls.Add(this.btnPgInicio);
            this.tabPage2Novo.Controls.Add(this.btnAdicionarComunidade);
            this.tabPage2Novo.Controls.Add(this.panelComunidade);
            this.tabPage2Novo.Controls.Add(this.btnCancelar);
            this.tabPage2Novo.Controls.Add(this.btnEditarCadastro);
            this.tabPage2Novo.Controls.Add(this.btnNovoCadastro);
            this.tabPage2Novo.Controls.Add(this.btnSalvarComunidade);
            this.tabPage2Novo.Controls.Add(this.chkDataFalecimentoDesconhecida);
            this.tabPage2Novo.Controls.Add(this.dtpFalecimento);
            this.tabPage2Novo.Controls.Add(this.lblDataFalecimento);
            this.tabPage2Novo.Controls.Add(this.label3);
            this.tabPage2Novo.Controls.Add(this.lblStatus);
            this.tabPage2Novo.Controls.Add(this.chkVivo);
            this.tabPage2Novo.Controls.Add(this.chkAnoImpreciso);
            this.tabPage2Novo.Controls.Add(this.dtpNascimento);
            this.tabPage2Novo.Controls.Add(this.lblDataNascimento);
            this.tabPage2Novo.Controls.Add(this.txtComunidade);
            this.tabPage2Novo.Controls.Add(this.lblFieldComunidade);
            this.tabPage2Novo.Controls.Add(this.txtNome);
            this.tabPage2Novo.Controls.Add(this.label1);
            this.tabPage2Novo.Controls.Add(this.lblCadastroTitulo);
            this.tabPage2Novo.Location = new System.Drawing.Point(4, 5);
            this.tabPage2Novo.Name = "tabPage2Novo";
            this.tabPage2Novo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Novo.Size = new System.Drawing.Size(912, 551);
            this.tabPage2Novo.TabIndex = 1;
            this.tabPage2Novo.Text = "Novo Cadastro";
            this.tabPage2Novo.UseVisualStyleBackColor = true;
            // 
            // btnPgRelatorios1
            // 
            this.btnPgRelatorios1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPgRelatorios1.Location = new System.Drawing.Point(808, 480);
            this.btnPgRelatorios1.Name = "btnPgRelatorios1";
            this.btnPgRelatorios1.Size = new System.Drawing.Size(96, 32);
            this.btnPgRelatorios1.TabIndex = 29;
            this.btnPgRelatorios1.Text = "Relatórios";
            this.btnPgRelatorios1.UseVisualStyleBackColor = true;
            this.btnPgRelatorios1.Click += new System.EventHandler(this.btnPgRelatorio1_Click);
            // 
            // btnPgInicio
            // 
            this.btnPgInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPgInicio.Location = new System.Drawing.Point(696, 480);
            this.btnPgInicio.Name = "btnPgInicio";
            this.btnPgInicio.Size = new System.Drawing.Size(96, 32);
            this.btnPgInicio.TabIndex = 28;
            this.btnPgInicio.Text = "Início";
            this.btnPgInicio.UseVisualStyleBackColor = true;
            this.btnPgInicio.Click += new System.EventHandler(this.btnPgInicio_Click);
            // 
            // btnAdicionarComunidade
            // 
            this.btnAdicionarComunidade.Location = new System.Drawing.Point(560, 136);
            this.btnAdicionarComunidade.Name = "btnAdicionarComunidade";
            this.btnAdicionarComunidade.Size = new System.Drawing.Size(40, 30);
            this.btnAdicionarComunidade.TabIndex = 27;
            this.btnAdicionarComunidade.Text = "+";
            this.btnAdicionarComunidade.UseVisualStyleBackColor = true;
            this.btnAdicionarComunidade.Click += new System.EventHandler(this.btnAdicionarComunidade_Click_1);
            // 
            // panelComunidade
            // 
            this.panelComunidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelComunidade.Controls.Add(this.btnFecharPnlComunidade);
            this.panelComunidade.Controls.Add(this.Estado);
            this.panelComunidade.Controls.Add(this.Cidade);
            this.panelComunidade.Controls.Add(this.Comunidade);
            this.panelComunidade.Controls.Add(this.txtEstado);
            this.panelComunidade.Controls.Add(this.txtCidade);
            this.panelComunidade.Controls.Add(this.btn_SalvarComunidade);
            this.panelComunidade.Controls.Add(this.txtNovaComunidade);
            this.panelComunidade.Controls.Add(this.chkUrbana);
            this.panelComunidade.Controls.Add(this.chkRural);
            this.panelComunidade.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelComunidade.Location = new System.Drawing.Point(604, 7);
            this.panelComunidade.Name = "panelComunidade";
            this.panelComunidade.Size = new System.Drawing.Size(300, 228);
            this.panelComunidade.TabIndex = 26;
            this.panelComunidade.Visible = false;
            // 
            // btnFecharPnlComunidade
            // 
            this.btnFecharPnlComunidade.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFecharPnlComunidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFecharPnlComunidade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFecharPnlComunidade.ForeColor = System.Drawing.Color.Red;
            this.btnFecharPnlComunidade.Location = new System.Drawing.Point(274, 202);
            this.btnFecharPnlComunidade.Name = "btnFecharPnlComunidade";
            this.btnFecharPnlComunidade.Size = new System.Drawing.Size(23, 23);
            this.btnFecharPnlComunidade.TabIndex = 21;
            this.btnFecharPnlComunidade.Text = "X";
            this.btnFecharPnlComunidade.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFecharPnlComunidade.UseVisualStyleBackColor = false;
            this.btnFecharPnlComunidade.Click += new System.EventHandler(this.btnFecharPnlComunidade_Click);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(10, 109);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 20;
            this.Estado.Text = "Estado";
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Location = new System.Drawing.Point(10, 82);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(40, 13);
            this.Cidade.TabIndex = 19;
            this.Cidade.Text = "Cidade";
            // 
            // Comunidade
            // 
            this.Comunidade.AutoSize = true;
            this.Comunidade.Location = new System.Drawing.Point(4, 19);
            this.Comunidade.Name = "Comunidade";
            this.Comunidade.Size = new System.Drawing.Size(66, 13);
            this.Comunidade.TabIndex = 18;
            this.Comunidade.Text = "Comunidade";
            // 
            // txtEstado
            // 
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Location = new System.Drawing.Point(88, 106);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(200, 21);
            this.txtEstado.TabIndex = 17;
            // 
            // txtCidade
            // 
            this.txtCidade.FormattingEnabled = true;
            this.txtCidade.Location = new System.Drawing.Point(88, 79);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 21);
            this.txtCidade.TabIndex = 16;
            // 
            // btn_SalvarComunidade
            // 
            this.btn_SalvarComunidade.Location = new System.Drawing.Point(64, 142);
            this.btn_SalvarComunidade.Name = "btn_SalvarComunidade";
            this.btn_SalvarComunidade.Size = new System.Drawing.Size(180, 32);
            this.btn_SalvarComunidade.TabIndex = 15;
            this.btn_SalvarComunidade.Text = "Salvar comunidade";
            this.btn_SalvarComunidade.UseVisualStyleBackColor = true;
            this.btn_SalvarComunidade.Click += new System.EventHandler(this.btn_SalvarComunidade_Click_1);
            // 
            // txtNovaComunidade
            // 
            this.txtNovaComunidade.Location = new System.Drawing.Point(88, 16);
            this.txtNovaComunidade.Name = "txtNovaComunidade";
            this.txtNovaComunidade.Size = new System.Drawing.Size(200, 20);
            this.txtNovaComunidade.TabIndex = 12;
            // 
            // chkUrbana
            // 
            this.chkUrbana.AutoSize = true;
            this.chkUrbana.Location = new System.Drawing.Point(16, 62);
            this.chkUrbana.Name = "chkUrbana";
            this.chkUrbana.Size = new System.Drawing.Size(89, 17);
            this.chkUrbana.TabIndex = 14;
            this.chkUrbana.Text = "Zona Urbana";
            this.chkUrbana.UseVisualStyleBackColor = true;
            this.chkUrbana.CheckedChanged += new System.EventHandler(this.chkUrbana_CheckedChanged);
            // 
            // chkRural
            // 
            this.chkRural.AutoSize = true;
            this.chkRural.Location = new System.Drawing.Point(16, 39);
            this.chkRural.Name = "chkRural";
            this.chkRural.Size = new System.Drawing.Size(79, 17);
            this.chkRural.TabIndex = 13;
            this.chkRural.Text = "Zona Rural";
            this.chkRural.UseVisualStyleBackColor = true;
            this.chkRural.CheckedChanged += new System.EventHandler(this.chkRural_CheckedChanged_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(329, 419);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 40);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditarCadastro
            // 
            this.btnEditarCadastro.Location = new System.Drawing.Point(214, 480);
            this.btnEditarCadastro.Name = "btnEditarCadastro";
            this.btnEditarCadastro.Size = new System.Drawing.Size(200, 40);
            this.btnEditarCadastro.TabIndex = 21;
            this.btnEditarCadastro.Text = "Editar Cadastro";
            this.btnEditarCadastro.UseVisualStyleBackColor = true;
            this.btnEditarCadastro.Visible = false;
            this.btnEditarCadastro.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Location = new System.Drawing.Point(8, 480);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(200, 40);
            this.btnNovoCadastro.TabIndex = 21;
            this.btnNovoCadastro.Text = "Novo Cadastro";
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Visible = false;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastroReset);
            // 
            // btnSalvarComunidade
            // 
            this.btnSalvarComunidade.Location = new System.Drawing.Point(123, 419);
            this.btnSalvarComunidade.Name = "btnSalvarComunidade";
            this.btnSalvarComunidade.Size = new System.Drawing.Size(200, 40);
            this.btnSalvarComunidade.TabIndex = 21;
            this.btnSalvarComunidade.Text = "Salvar cadastro";
            this.btnSalvarComunidade.UseVisualStyleBackColor = true;
            this.btnSalvarComunidade.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chkDataFalecimentoDesconhecida
            // 
            this.chkDataFalecimentoDesconhecida.AutoSize = true;
            this.chkDataFalecimentoDesconhecida.Location = new System.Drawing.Point(32, 338);
            this.chkDataFalecimentoDesconhecida.Name = "chkDataFalecimentoDesconhecida";
            this.chkDataFalecimentoDesconhecida.Size = new System.Drawing.Size(191, 17);
            this.chkDataFalecimentoDesconhecida.TabIndex = 23;
            this.chkDataFalecimentoDesconhecida.Text = "Data de falecimento desconhecida";
            this.chkDataFalecimentoDesconhecida.UseVisualStyleBackColor = true;
            this.chkDataFalecimentoDesconhecida.CheckedChanged += new System.EventHandler(this.chkDataFalecimentoDesconhecida_CheckedChanged);
            // 
            // dtpFalecimento
            // 
            this.dtpFalecimento.Location = new System.Drawing.Point(32, 372);
            this.dtpFalecimento.Name = "dtpFalecimento";
            this.dtpFalecimento.Size = new System.Drawing.Size(340, 20);
            this.dtpFalecimento.TabIndex = 20;
            // 
            // lblDataFalecimento
            // 
            this.lblDataFalecimento.AutoSize = true;
            this.lblDataFalecimento.Location = new System.Drawing.Point(32, 308);
            this.lblDataFalecimento.Name = "lblDataFalecimento";
            this.lblDataFalecimento.Size = new System.Drawing.Size(102, 13);
            this.lblDataFalecimento.TabIndex = 33;
            this.lblDataFalecimento.Text = "Data de falecimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(120, 274);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status";
            // 
            // chkVivo
            // 
            this.chkVivo.AutoSize = true;
            this.chkVivo.Location = new System.Drawing.Point(32, 272);
            this.chkVivo.Name = "chkVivo";
            this.chkVivo.Size = new System.Drawing.Size(47, 17);
            this.chkVivo.TabIndex = 19;
            this.chkVivo.Text = "Vivo";
            this.chkVivo.UseVisualStyleBackColor = true;
            this.chkVivo.CheckedChanged += new System.EventHandler(this.chkVivo_CheckedChanged);
            // 
            // chkAnoImpreciso
            // 
            this.chkAnoImpreciso.AutoSize = true;
            this.chkAnoImpreciso.Location = new System.Drawing.Point(32, 240);
            this.chkAnoImpreciso.Name = "chkAnoImpreciso";
            this.chkAnoImpreciso.Size = new System.Drawing.Size(161, 17);
            this.chkAnoImpreciso.TabIndex = 22;
            this.chkAnoImpreciso.Text = "Ano de nascimento incorreto";
            this.chkAnoImpreciso.UseVisualStyleBackColor = true;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(32, 202);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(340, 20);
            this.dtpNascimento.TabIndex = 18;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(32, 182);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(102, 13);
            this.lblDataNascimento.TabIndex = 32;
            this.lblDataNascimento.Text = "Data de nascimento";
            // 
            // txtComunidade
            // 
            this.txtComunidade.FormattingEnabled = true;
            this.txtComunidade.Location = new System.Drawing.Point(32, 138);
            this.txtComunidade.Name = "txtComunidade";
            this.txtComunidade.Size = new System.Drawing.Size(520, 21);
            this.txtComunidade.TabIndex = 17;
            // 
            // lblFieldComunidade
            // 
            this.lblFieldComunidade.AutoSize = true;
            this.lblFieldComunidade.Location = new System.Drawing.Point(32, 118);
            this.lblFieldComunidade.Name = "lblFieldComunidade";
            this.lblFieldComunidade.Size = new System.Drawing.Size(66, 13);
            this.lblFieldComunidade.TabIndex = 31;
            this.lblFieldComunidade.Text = "Comunidade";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(520, 20);
            this.txtNome.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome completo";
            // 
            // lblCadastroTitulo
            // 
            this.lblCadastroTitulo.AutoSize = true;
            this.lblCadastroTitulo.Location = new System.Drawing.Point(32, 20);
            this.lblCadastroTitulo.Name = "lblCadastroTitulo";
            this.lblCadastroTitulo.Size = new System.Drawing.Size(105, 13);
            this.lblCadastroTitulo.TabIndex = 30;
            this.lblCadastroTitulo.Text = "Cadastro de morador";
            // 
            // tabPage3Relatorios
            // 
            this.tabPage3Relatorios.Controls.Add(this.dgvRelatorio);
            this.tabPage3Relatorios.Controls.Add(this.panel1);
            this.tabPage3Relatorios.Controls.Add(this.btnPgInicioRelatorio);
            this.tabPage3Relatorios.Location = new System.Drawing.Point(4, 5);
            this.tabPage3Relatorios.Name = "tabPage3Relatorios";
            this.tabPage3Relatorios.Size = new System.Drawing.Size(912, 551);
            this.tabPage3Relatorios.TabIndex = 2;
            this.tabPage3Relatorios.Text = "Relatorios";
            this.tabPage3Relatorios.UseVisualStyleBackColor = true;
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.AllowUserToAddRows = false;
            this.dgvRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Location = new System.Drawing.Point(24, 148);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.Size = new System.Drawing.Size(872, 316);
            this.dgvRelatorio.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnFiltrarAniversariantes);
            this.panel1.Controls.Add(this.dtpFiltroDataAniversario);
            this.panel1.Controls.Add(this.rbFiltroPorData);
            this.panel1.Controls.Add(this.cbMesFiltro);
            this.panel1.Controls.Add(this.rbFiltroPorMes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 120);
            this.panel1.TabIndex = 3;
            // 
            // btnFiltrarAniversariantes
            // 
            this.btnFiltrarAniversariantes.Location = new System.Drawing.Point(520, 40);
            this.btnFiltrarAniversariantes.Name = "btnFiltrarAniversariantes";
            this.btnFiltrarAniversariantes.Size = new System.Drawing.Size(200, 32);
            this.btnFiltrarAniversariantes.TabIndex = 2;
            this.btnFiltrarAniversariantes.Text = "Buscar aniversariantes";
            this.btnFiltrarAniversariantes.UseVisualStyleBackColor = true;
            this.btnFiltrarAniversariantes.Click += new System.EventHandler(this.btnFiltrarAniversariantes_Click);
            // 
            // dtpFiltroDataAniversario
            // 
            this.dtpFiltroDataAniversario.Enabled = false;
            this.dtpFiltroDataAniversario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroDataAniversario.Location = new System.Drawing.Point(200, 58);
            this.dtpFiltroDataAniversario.Name = "dtpFiltroDataAniversario";
            this.dtpFiltroDataAniversario.Size = new System.Drawing.Size(120, 20);
            this.dtpFiltroDataAniversario.TabIndex = 12;
            // 
            // rbFiltroPorData
            // 
            this.rbFiltroPorData.AutoSize = true;
            this.rbFiltroPorData.Location = new System.Drawing.Point(16, 60);
            this.rbFiltroPorData.Name = "rbFiltroPorData";
            this.rbFiltroPorData.Size = new System.Drawing.Size(153, 17);
            this.rbFiltroPorData.TabIndex = 11;
            this.rbFiltroPorData.TabStop = true;
            this.rbFiltroPorData.Text = "Por data (dia e mês exatos)";
            this.rbFiltroPorData.UseVisualStyleBackColor = true;
            this.rbFiltroPorData.CheckedChanged += new System.EventHandler(this.rbFiltroRelatorio_CheckedChanged);
            // 
            // cbMesFiltro
            // 
            this.cbMesFiltro.FormattingEnabled = true;
            this.cbMesFiltro.Items.AddRange(new object[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.cbMesFiltro.Location = new System.Drawing.Point(100, 28);
            this.cbMesFiltro.Name = "cbMesFiltro";
            this.cbMesFiltro.Size = new System.Drawing.Size(240, 21);
            this.cbMesFiltro.TabIndex = 1;
            // 
            // rbFiltroPorMes
            // 
            this.rbFiltroPorMes.AutoSize = true;
            this.rbFiltroPorMes.Checked = true;
            this.rbFiltroPorMes.Location = new System.Drawing.Point(16, 30);
            this.rbFiltroPorMes.Name = "rbFiltroPorMes";
            this.rbFiltroPorMes.Size = new System.Drawing.Size(63, 17);
            this.rbFiltroPorMes.TabIndex = 10;
            this.rbFiltroPorMes.TabStop = true;
            this.rbFiltroPorMes.Text = "Por mês";
            this.rbFiltroPorMes.UseVisualStyleBackColor = true;
            this.rbFiltroPorMes.CheckedChanged += new System.EventHandler(this.rbFiltroRelatorio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtros";
            // 
            // btnPgInicioRelatorio
            // 
            this.btnPgInicioRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPgInicioRelatorio.Location = new System.Drawing.Point(808, 480);
            this.btnPgInicioRelatorio.Name = "btnPgInicioRelatorio";
            this.btnPgInicioRelatorio.Size = new System.Drawing.Size(96, 32);
            this.btnPgInicioRelatorio.TabIndex = 5;
            this.btnPgInicioRelatorio.Text = "Início";
            this.btnPgInicioRelatorio.UseVisualStyleBackColor = true;
            this.btnPgInicioRelatorio.Click += new System.EventHandler(this.btnPgInicio_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(271, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 560);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPage1Inicial.ResumeLayout(false);
            this.tabPage2Novo.ResumeLayout(false);
            this.tabPage2Novo.PerformLayout();
            this.panelComunidade.ResumeLayout(false);
            this.panelComunidade.PerformLayout();
            this.tabPage3Relatorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage1Inicial;
        private System.Windows.Forms.TabPage tabPage2Novo;
        private System.Windows.Forms.TabPage tabPage3Relatorios;
        private System.Windows.Forms.Button btnPgCadastro;
        private System.Windows.Forms.Button btnAdicionarComunidade;
        private System.Windows.Forms.Panel panelComunidade;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.Label Comunidade;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.ComboBox txtCidade;
        private System.Windows.Forms.Button btn_SalvarComunidade;
        private System.Windows.Forms.TextBox txtNovaComunidade;
        private System.Windows.Forms.CheckBox chkUrbana;
        private System.Windows.Forms.CheckBox chkRural;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCadastroTitulo;
        private System.Windows.Forms.Label lblFieldComunidade;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblDataFalecimento;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkDataFalecimentoDesconhecida;
        private System.Windows.Forms.CheckBox chkAnoImpreciso;
        private System.Windows.Forms.Button btnSalvarComunidade;
        private System.Windows.Forms.DateTimePicker dtpFalecimento;
        private System.Windows.Forms.CheckBox chkVivo;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.ComboBox txtComunidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPgRelatorios;
        private System.Windows.Forms.Button btnPgRelatorios1;
        private System.Windows.Forms.Button btnPgInicio;
        private System.Windows.Forms.Button btnPgInicioRelatorio;
        private System.Windows.Forms.ComboBox cbMesFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFiltroPorMes;
        private System.Windows.Forms.RadioButton rbFiltroPorData;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataAniversario;
        private System.Windows.Forms.Button btnFiltrarAniversariantes;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Button btnPgEditar;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFecharPnlComunidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}

