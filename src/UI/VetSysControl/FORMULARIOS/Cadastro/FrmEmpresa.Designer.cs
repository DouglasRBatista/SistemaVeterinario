namespace VetSysControl.FORMULARIOS.Cadastro {
    partial class FrmEmpresa {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Btn_Sair = new Button();
            Btn_Salvar = new Button();
            Btn_Editar = new Button();
            Btn_Excluir = new Button();
            Lbl_CadastroAtend = new Label();
            Btn_BuscarEmpresa = new Button();
            Txt_RazaoSoc = new TextBox();
            Lbl_RazaoSoc = new Label();
            Lbl_CodEmpresa = new Label();
            Txt_CodEmpresa = new TextBox();
            Txt_Endereco = new TextBox();
            Lbl_Endereco = new Label();
            MskBox_CNPJ = new MaskedTextBox();
            Lbl_CNPJ = new Label();
            Lbl_Telefone = new Label();
            MskBox_Telefone = new MaskedTextBox();
            Lbl_Unidade = new Label();
            CmbBox_Unidade = new ComboBox();
            PicBox_Logo = new PictureBox();
            GrpBox_Filial = new GroupBox();
            Lbl_FaturamentoFilial = new Label();
            Lbl_CustosFilial = new Label();
            MskBox_FaturamentoFilial = new MaskedTextBox();
            MskBox_CustosFilial = new MaskedTextBox();
            ChkBox_Farmacia = new CheckBox();
            MskBox_ProntoAtend = new MaskedTextBox();
            ChkBox_ProntoAtend = new CheckBox();
            MskBox_UnidHosp = new MaskedTextBox();
            ChkBox_UnidHosp = new CheckBox();
            MskBox_DayCare = new MaskedTextBox();
            ChkBox_DayCare = new CheckBox();
            GrpBox_Contrat = new GroupBox();
            Btn_AddServico = new Button();
            Btn_DelServico = new Button();
            ChkBox_UnidIntegr = new CheckBox();
            LstBox_Servicos = new ListBox();
            Lbl_CustosContr = new Label();
            Lbl_Servicos = new Label();
            MskBox_CustosContr = new MaskedTextBox();
            Lbl_FimContr = new Label();
            Lbl_InicioContr = new Label();
            Dtp_FimContr = new DateTimePicker();
            Dtp_InicioContr = new DateTimePicker();
            GrpBox_FarmLab = new GroupBox();
            Lbl_OBS = new Label();
            Lbl_DescFarmLab = new Label();
            Txt_OBS = new TextBox();
            Txt_Desc = new TextBox();
            ChkBox_Terceirizada = new CheckBox();
            Lbl_Filial = new Label();
            CmbBox_Filial = new ComboBox();
            ChkBox_Integr = new CheckBox();
            ChkBox_Filial = new CheckBox();
            ChkBox_Contr = new CheckBox();
            ChkBox_FarmLab = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)PicBox_Logo).BeginInit();
            GrpBox_Filial.SuspendLayout();
            GrpBox_Contrat.SuspendLayout();
            GrpBox_FarmLab.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(994, 523);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 63;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(739, 523);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(75, 23);
            Btn_Salvar.TabIndex = 62;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = true;
            Btn_Salvar.Click += Btn_Salvar_Click;
            // 
            // Btn_Editar
            // 
            Btn_Editar.Location = new Point(825, 523);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(75, 23);
            Btn_Editar.TabIndex = 61;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = true;
            Btn_Editar.Click += Btn_Editar_Click;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Location = new Point(909, 523);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(75, 23);
            Btn_Excluir.TabIndex = 60;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = true;
            Btn_Excluir.Click += Btn_Excluir_Click;
            // 
            // Lbl_CadastroAtend
            // 
            Lbl_CadastroAtend.AutoSize = true;
            Lbl_CadastroAtend.Location = new Point(37, 32);
            Lbl_CadastroAtend.Name = "Lbl_CadastroAtend";
            Lbl_CadastroAtend.Size = new Size(123, 15);
            Lbl_CadastroAtend.TabIndex = 64;
            Lbl_CadastroAtend.Text = "Cadastro de Empresas";
            // 
            // Btn_BuscarEmpresa
            // 
            Btn_BuscarEmpresa.Location = new Point(285, 94);
            Btn_BuscarEmpresa.Name = "Btn_BuscarEmpresa";
            Btn_BuscarEmpresa.Size = new Size(59, 23);
            Btn_BuscarEmpresa.TabIndex = 69;
            Btn_BuscarEmpresa.Text = "Buscar";
            Btn_BuscarEmpresa.UseVisualStyleBackColor = true;
            Btn_BuscarEmpresa.Click += Btn_BuscarEmpresa_Click;
            // 
            // Txt_RazaoSoc
            // 
            Txt_RazaoSoc.Location = new Point(445, 94);
            Txt_RazaoSoc.MaxLength = 100;
            Txt_RazaoSoc.Name = "Txt_RazaoSoc";
            Txt_RazaoSoc.Size = new Size(235, 23);
            Txt_RazaoSoc.TabIndex = 68;
            // 
            // Lbl_RazaoSoc
            // 
            Lbl_RazaoSoc.AutoSize = true;
            Lbl_RazaoSoc.Location = new Point(364, 97);
            Lbl_RazaoSoc.Name = "Lbl_RazaoSoc";
            Lbl_RazaoSoc.Size = new Size(75, 15);
            Lbl_RazaoSoc.TabIndex = 67;
            Lbl_RazaoSoc.Text = "Razão Social:";
            // 
            // Lbl_CodEmpresa
            // 
            Lbl_CodEmpresa.AutoSize = true;
            Lbl_CodEmpresa.Location = new Point(37, 97);
            Lbl_CodEmpresa.Name = "Lbl_CodEmpresa";
            Lbl_CodEmpresa.Size = new Size(49, 15);
            Lbl_CodEmpresa.TabIndex = 66;
            Lbl_CodEmpresa.Text = "Codigo:";
            // 
            // Txt_CodEmpresa
            // 
            Txt_CodEmpresa.Location = new Point(100, 94);
            Txt_CodEmpresa.MaxLength = 20;
            Txt_CodEmpresa.Name = "Txt_CodEmpresa";
            Txt_CodEmpresa.Size = new Size(175, 23);
            Txt_CodEmpresa.TabIndex = 65;
            // 
            // Txt_Endereco
            // 
            Txt_Endereco.Location = new Point(100, 123);
            Txt_Endereco.MaxLength = 100;
            Txt_Endereco.Name = "Txt_Endereco";
            Txt_Endereco.Size = new Size(580, 23);
            Txt_Endereco.TabIndex = 71;
            // 
            // Lbl_Endereco
            // 
            Lbl_Endereco.AutoSize = true;
            Lbl_Endereco.Location = new Point(37, 126);
            Lbl_Endereco.Name = "Lbl_Endereco";
            Lbl_Endereco.Size = new Size(59, 15);
            Lbl_Endereco.TabIndex = 70;
            Lbl_Endereco.Text = "Endereço:";
            // 
            // MskBox_CNPJ
            // 
            MskBox_CNPJ.Location = new Point(100, 152);
            MskBox_CNPJ.Mask = "99.999.999/9999-99";
            MskBox_CNPJ.Name = "MskBox_CNPJ";
            MskBox_CNPJ.Size = new Size(230, 23);
            MskBox_CNPJ.TabIndex = 72;
            // 
            // Lbl_CNPJ
            // 
            Lbl_CNPJ.AutoSize = true;
            Lbl_CNPJ.Location = new Point(37, 155);
            Lbl_CNPJ.Name = "Lbl_CNPJ";
            Lbl_CNPJ.Size = new Size(37, 15);
            Lbl_CNPJ.TabIndex = 73;
            Lbl_CNPJ.Text = "CNPJ:";
            // 
            // Lbl_Telefone
            // 
            Lbl_Telefone.AutoSize = true;
            Lbl_Telefone.Location = new Point(364, 155);
            Lbl_Telefone.Name = "Lbl_Telefone";
            Lbl_Telefone.Size = new Size(54, 15);
            Lbl_Telefone.TabIndex = 75;
            Lbl_Telefone.Text = "Telefone:";
            // 
            // MskBox_Telefone
            // 
            MskBox_Telefone.Location = new Point(445, 152);
            MskBox_Telefone.Mask = "(99) 99999-9999";
            MskBox_Telefone.Name = "MskBox_Telefone";
            MskBox_Telefone.Size = new Size(230, 23);
            MskBox_Telefone.TabIndex = 74;
            // 
            // Lbl_Unidade
            // 
            Lbl_Unidade.AutoSize = true;
            Lbl_Unidade.Location = new Point(37, 184);
            Lbl_Unidade.Name = "Lbl_Unidade";
            Lbl_Unidade.Size = new Size(54, 15);
            Lbl_Unidade.TabIndex = 76;
            Lbl_Unidade.Text = "Unidade:";
            // 
            // CmbBox_Unidade
            // 
            CmbBox_Unidade.FormattingEnabled = true;
            CmbBox_Unidade.Location = new Point(100, 181);
            CmbBox_Unidade.Name = "CmbBox_Unidade";
            CmbBox_Unidade.Size = new Size(230, 23);
            CmbBox_Unidade.TabIndex = 77;
            // 
            // PicBox_Logo
            // 
            PicBox_Logo.BorderStyle = BorderStyle.FixedSingle;
            PicBox_Logo.Location = new Point(739, 42);
            PicBox_Logo.Name = "PicBox_Logo";
            PicBox_Logo.Size = new Size(330, 190);
            PicBox_Logo.TabIndex = 78;
            PicBox_Logo.TabStop = false;
            // 
            // GrpBox_Filial
            // 
            GrpBox_Filial.Controls.Add(Lbl_FaturamentoFilial);
            GrpBox_Filial.Controls.Add(Lbl_CustosFilial);
            GrpBox_Filial.Controls.Add(MskBox_FaturamentoFilial);
            GrpBox_Filial.Controls.Add(MskBox_CustosFilial);
            GrpBox_Filial.Controls.Add(ChkBox_Farmacia);
            GrpBox_Filial.Controls.Add(MskBox_ProntoAtend);
            GrpBox_Filial.Controls.Add(ChkBox_ProntoAtend);
            GrpBox_Filial.Controls.Add(MskBox_UnidHosp);
            GrpBox_Filial.Controls.Add(ChkBox_UnidHosp);
            GrpBox_Filial.Controls.Add(MskBox_DayCare);
            GrpBox_Filial.Controls.Add(ChkBox_DayCare);
            GrpBox_Filial.Location = new Point(37, 256);
            GrpBox_Filial.Name = "GrpBox_Filial";
            GrpBox_Filial.Size = new Size(238, 301);
            GrpBox_Filial.TabIndex = 79;
            GrpBox_Filial.TabStop = false;
            GrpBox_Filial.Text = "Filial";
            // 
            // Lbl_FaturamentoFilial
            // 
            Lbl_FaturamentoFilial.AutoSize = true;
            Lbl_FaturamentoFilial.Location = new Point(6, 270);
            Lbl_FaturamentoFilial.Name = "Lbl_FaturamentoFilial";
            Lbl_FaturamentoFilial.Size = new Size(78, 15);
            Lbl_FaturamentoFilial.TabIndex = 90;
            Lbl_FaturamentoFilial.Text = "Faturamento:";
            // 
            // Lbl_CustosFilial
            // 
            Lbl_CustosFilial.AutoSize = true;
            Lbl_CustosFilial.Location = new Point(6, 241);
            Lbl_CustosFilial.Name = "Lbl_CustosFilial";
            Lbl_CustosFilial.Size = new Size(46, 15);
            Lbl_CustosFilial.TabIndex = 82;
            Lbl_CustosFilial.Text = "Custos:";
            // 
            // MskBox_FaturamentoFilial
            // 
            MskBox_FaturamentoFilial.Location = new Point(104, 267);
            MskBox_FaturamentoFilial.Name = "MskBox_FaturamentoFilial";
            MskBox_FaturamentoFilial.Size = new Size(113, 23);
            MskBox_FaturamentoFilial.TabIndex = 89;
            // 
            // MskBox_CustosFilial
            // 
            MskBox_CustosFilial.Location = new Point(104, 238);
            MskBox_CustosFilial.Name = "MskBox_CustosFilial";
            MskBox_CustosFilial.Size = new Size(113, 23);
            MskBox_CustosFilial.TabIndex = 88;
            // 
            // ChkBox_Farmacia
            // 
            ChkBox_Farmacia.AutoSize = true;
            ChkBox_Farmacia.Location = new Point(6, 164);
            ChkBox_Farmacia.Name = "ChkBox_Farmacia";
            ChkBox_Farmacia.Size = new Size(74, 19);
            ChkBox_Farmacia.TabIndex = 87;
            ChkBox_Farmacia.Text = "Farmacia";
            ChkBox_Farmacia.UseVisualStyleBackColor = true;
            // 
            // MskBox_ProntoAtend
            // 
            MskBox_ProntoAtend.Location = new Point(117, 121);
            MskBox_ProntoAtend.Name = "MskBox_ProntoAtend";
            MskBox_ProntoAtend.Size = new Size(100, 23);
            MskBox_ProntoAtend.TabIndex = 85;
            // 
            // ChkBox_ProntoAtend
            // 
            ChkBox_ProntoAtend.AutoSize = true;
            ChkBox_ProntoAtend.Location = new Point(6, 123);
            ChkBox_ProntoAtend.Name = "ChkBox_ProntoAtend";
            ChkBox_ProntoAtend.Size = new Size(100, 19);
            ChkBox_ProntoAtend.TabIndex = 86;
            ChkBox_ProntoAtend.Text = "Pronto Atend.";
            ChkBox_ProntoAtend.UseVisualStyleBackColor = true;
            // 
            // MskBox_UnidHosp
            // 
            MskBox_UnidHosp.Location = new Point(117, 79);
            MskBox_UnidHosp.Name = "MskBox_UnidHosp";
            MskBox_UnidHosp.Size = new Size(100, 23);
            MskBox_UnidHosp.TabIndex = 83;
            // 
            // ChkBox_UnidHosp
            // 
            ChkBox_UnidHosp.AutoSize = true;
            ChkBox_UnidHosp.Location = new Point(6, 81);
            ChkBox_UnidHosp.Name = "ChkBox_UnidHosp";
            ChkBox_UnidHosp.Size = new Size(111, 19);
            ChkBox_UnidHosp.TabIndex = 84;
            ChkBox_UnidHosp.Text = "Unid. Hospitalar";
            ChkBox_UnidHosp.UseVisualStyleBackColor = true;
            // 
            // MskBox_DayCare
            // 
            MskBox_DayCare.Location = new Point(117, 35);
            MskBox_DayCare.Name = "MskBox_DayCare";
            MskBox_DayCare.Size = new Size(100, 23);
            MskBox_DayCare.TabIndex = 82;
            // 
            // ChkBox_DayCare
            // 
            ChkBox_DayCare.AutoSize = true;
            ChkBox_DayCare.Location = new Point(6, 39);
            ChkBox_DayCare.Name = "ChkBox_DayCare";
            ChkBox_DayCare.Size = new Size(70, 19);
            ChkBox_DayCare.TabIndex = 82;
            ChkBox_DayCare.Text = "DayCare";
            ChkBox_DayCare.UseVisualStyleBackColor = true;
            // 
            // GrpBox_Contrat
            // 
            GrpBox_Contrat.Controls.Add(Btn_AddServico);
            GrpBox_Contrat.Controls.Add(Btn_DelServico);
            GrpBox_Contrat.Controls.Add(ChkBox_UnidIntegr);
            GrpBox_Contrat.Controls.Add(LstBox_Servicos);
            GrpBox_Contrat.Controls.Add(Lbl_CustosContr);
            GrpBox_Contrat.Controls.Add(Lbl_Servicos);
            GrpBox_Contrat.Controls.Add(MskBox_CustosContr);
            GrpBox_Contrat.Controls.Add(Lbl_FimContr);
            GrpBox_Contrat.Controls.Add(Lbl_InicioContr);
            GrpBox_Contrat.Controls.Add(Dtp_FimContr);
            GrpBox_Contrat.Controls.Add(Dtp_InicioContr);
            GrpBox_Contrat.Location = new Point(300, 256);
            GrpBox_Contrat.Name = "GrpBox_Contrat";
            GrpBox_Contrat.Size = new Size(200, 301);
            GrpBox_Contrat.TabIndex = 80;
            GrpBox_Contrat.TabStop = false;
            GrpBox_Contrat.Text = "Contratante";
            // 
            // Btn_AddServico
            // 
            Btn_AddServico.Location = new Point(155, 146);
            Btn_AddServico.Name = "Btn_AddServico";
            Btn_AddServico.Size = new Size(39, 23);
            Btn_AddServico.TabIndex = 82;
            Btn_AddServico.Text = "+";
            Btn_AddServico.UseVisualStyleBackColor = true;
            Btn_AddServico.Click += Btn_AddServico_Click;
            // 
            // Btn_DelServico
            // 
            Btn_DelServico.Location = new Point(155, 175);
            Btn_DelServico.Name = "Btn_DelServico";
            Btn_DelServico.Size = new Size(39, 23);
            Btn_DelServico.TabIndex = 83;
            Btn_DelServico.Text = "-";
            Btn_DelServico.UseVisualStyleBackColor = true;
            Btn_DelServico.Click += Btn_DelServico_Click;
            // 
            // ChkBox_UnidIntegr
            // 
            ChkBox_UnidIntegr.AutoSize = true;
            ChkBox_UnidIntegr.Location = new Point(8, 26);
            ChkBox_UnidIntegr.Name = "ChkBox_UnidIntegr";
            ChkBox_UnidIntegr.Size = new Size(123, 19);
            ChkBox_UnidIntegr.TabIndex = 95;
            ChkBox_UnidIntegr.Text = "Unidade Integrada";
            ChkBox_UnidIntegr.UseVisualStyleBackColor = true;
            // 
            // LstBox_Servicos
            // 
            LstBox_Servicos.FormattingEnabled = true;
            LstBox_Servicos.ItemHeight = 15;
            LstBox_Servicos.Location = new Point(6, 146);
            LstBox_Servicos.Name = "LstBox_Servicos";
            LstBox_Servicos.Size = new Size(143, 94);
            LstBox_Servicos.TabIndex = 94;
            // 
            // Lbl_CustosContr
            // 
            Lbl_CustosContr.AutoSize = true;
            Lbl_CustosContr.Location = new Point(13, 270);
            Lbl_CustosContr.Name = "Lbl_CustosContr";
            Lbl_CustosContr.Size = new Size(46, 15);
            Lbl_CustosContr.TabIndex = 91;
            Lbl_CustosContr.Text = "Custos:";
            // 
            // Lbl_Servicos
            // 
            Lbl_Servicos.AutoSize = true;
            Lbl_Servicos.Location = new Point(6, 127);
            Lbl_Servicos.Name = "Lbl_Servicos";
            Lbl_Servicos.Size = new Size(53, 15);
            Lbl_Servicos.TabIndex = 93;
            Lbl_Servicos.Text = "Servicos:";
            // 
            // MskBox_CustosContr
            // 
            MskBox_CustosContr.Location = new Point(65, 267);
            MskBox_CustosContr.Name = "MskBox_CustosContr";
            MskBox_CustosContr.Size = new Size(129, 23);
            MskBox_CustosContr.TabIndex = 92;
            // 
            // Lbl_FimContr
            // 
            Lbl_FimContr.AutoSize = true;
            Lbl_FimContr.Location = new Point(6, 104);
            Lbl_FimContr.Name = "Lbl_FimContr";
            Lbl_FimContr.Size = new Size(80, 15);
            Lbl_FimContr.TabIndex = 92;
            Lbl_FimContr.Text = "Fim Contrato:";
            // 
            // Lbl_InicioContr
            // 
            Lbl_InicioContr.AutoSize = true;
            Lbl_InicioContr.Location = new Point(6, 62);
            Lbl_InicioContr.Name = "Lbl_InicioContr";
            Lbl_InicioContr.Size = new Size(89, 15);
            Lbl_InicioContr.TabIndex = 91;
            Lbl_InicioContr.Text = "Início Contrato:";
            // 
            // Dtp_FimContr
            // 
            Dtp_FimContr.Format = DateTimePickerFormat.Short;
            Dtp_FimContr.Location = new Point(96, 98);
            Dtp_FimContr.Name = "Dtp_FimContr";
            Dtp_FimContr.Size = new Size(98, 23);
            Dtp_FimContr.TabIndex = 1;
            // 
            // Dtp_InicioContr
            // 
            Dtp_InicioContr.Format = DateTimePickerFormat.Short;
            Dtp_InicioContr.Location = new Point(96, 56);
            Dtp_InicioContr.Name = "Dtp_InicioContr";
            Dtp_InicioContr.Size = new Size(98, 23);
            Dtp_InicioContr.TabIndex = 0;
            // 
            // GrpBox_FarmLab
            // 
            GrpBox_FarmLab.Controls.Add(Lbl_OBS);
            GrpBox_FarmLab.Controls.Add(Lbl_DescFarmLab);
            GrpBox_FarmLab.Controls.Add(Txt_OBS);
            GrpBox_FarmLab.Controls.Add(Txt_Desc);
            GrpBox_FarmLab.Controls.Add(ChkBox_Terceirizada);
            GrpBox_FarmLab.Controls.Add(Lbl_Filial);
            GrpBox_FarmLab.Controls.Add(CmbBox_Filial);
            GrpBox_FarmLab.Controls.Add(ChkBox_Integr);
            GrpBox_FarmLab.Location = new Point(525, 256);
            GrpBox_FarmLab.Name = "GrpBox_FarmLab";
            GrpBox_FarmLab.Size = new Size(200, 301);
            GrpBox_FarmLab.TabIndex = 81;
            GrpBox_FarmLab.TabStop = false;
            GrpBox_FarmLab.Text = "Farmacia - Laboratório";
            // 
            // Lbl_OBS
            // 
            Lbl_OBS.AutoSize = true;
            Lbl_OBS.Location = new Point(6, 163);
            Lbl_OBS.Name = "Lbl_OBS";
            Lbl_OBS.Size = new Size(32, 15);
            Lbl_OBS.TabIndex = 101;
            Lbl_OBS.Text = "OBS:";
            // 
            // Lbl_DescFarmLab
            // 
            Lbl_DescFarmLab.AutoSize = true;
            Lbl_DescFarmLab.Location = new Point(6, 113);
            Lbl_DescFarmLab.Name = "Lbl_DescFarmLab";
            Lbl_DescFarmLab.Size = new Size(61, 15);
            Lbl_DescFarmLab.TabIndex = 100;
            Lbl_DescFarmLab.Text = "Descrição:";
            // 
            // Txt_OBS
            // 
            Txt_OBS.Location = new Point(6, 181);
            Txt_OBS.Multiline = true;
            Txt_OBS.Name = "Txt_OBS";
            Txt_OBS.Size = new Size(188, 77);
            Txt_OBS.TabIndex = 99;
            // 
            // Txt_Desc
            // 
            Txt_Desc.Location = new Point(6, 131);
            Txt_Desc.MaxLength = 20;
            Txt_Desc.Name = "Txt_Desc";
            Txt_Desc.Size = new Size(188, 23);
            Txt_Desc.TabIndex = 82;
            // 
            // ChkBox_Terceirizada
            // 
            ChkBox_Terceirizada.AutoSize = true;
            ChkBox_Terceirizada.Location = new Point(6, 26);
            ChkBox_Terceirizada.Name = "ChkBox_Terceirizada";
            ChkBox_Terceirizada.Size = new Size(87, 19);
            ChkBox_Terceirizada.TabIndex = 98;
            ChkBox_Terceirizada.Text = "Terceirizada";
            ChkBox_Terceirizada.UseVisualStyleBackColor = true;
            // 
            // Lbl_Filial
            // 
            Lbl_Filial.AutoSize = true;
            Lbl_Filial.Location = new Point(6, 78);
            Lbl_Filial.Name = "Lbl_Filial";
            Lbl_Filial.Size = new Size(34, 15);
            Lbl_Filial.TabIndex = 82;
            Lbl_Filial.Text = "Filial:";
            // 
            // CmbBox_Filial
            // 
            CmbBox_Filial.FormattingEnabled = true;
            CmbBox_Filial.Location = new Point(59, 75);
            CmbBox_Filial.Name = "CmbBox_Filial";
            CmbBox_Filial.Size = new Size(135, 23);
            CmbBox_Filial.TabIndex = 97;
            // 
            // ChkBox_Integr
            // 
            ChkBox_Integr.AutoSize = true;
            ChkBox_Integr.Location = new Point(6, 48);
            ChkBox_Integr.Name = "ChkBox_Integr";
            ChkBox_Integr.Size = new Size(124, 19);
            ChkBox_Integr.TabIndex = 96;
            ChkBox_Integr.Text = "Integrada a Clínica";
            ChkBox_Integr.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Filial
            // 
            ChkBox_Filial.AutoSize = true;
            ChkBox_Filial.Location = new Point(37, 231);
            ChkBox_Filial.Name = "ChkBox_Filial";
            ChkBox_Filial.Size = new Size(50, 19);
            ChkBox_Filial.TabIndex = 83;
            ChkBox_Filial.Text = "Filial";
            ChkBox_Filial.UseVisualStyleBackColor = true;
            ChkBox_Filial.CheckedChanged += ChkBox_Filial_CheckedChanged;
            // 
            // ChkBox_Contr
            // 
            ChkBox_Contr.AutoSize = true;
            ChkBox_Contr.Location = new Point(300, 231);
            ChkBox_Contr.Name = "ChkBox_Contr";
            ChkBox_Contr.Size = new Size(89, 19);
            ChkBox_Contr.TabIndex = 84;
            ChkBox_Contr.Text = "Contratante";
            ChkBox_Contr.UseVisualStyleBackColor = true;
            ChkBox_Contr.CheckedChanged += ChkBox_Contr_CheckedChanged;
            // 
            // ChkBox_FarmLab
            // 
            ChkBox_FarmLab.AutoSize = true;
            ChkBox_FarmLab.Location = new Point(525, 231);
            ChkBox_FarmLab.Name = "ChkBox_FarmLab";
            ChkBox_FarmLab.Size = new Size(146, 19);
            ChkBox_FarmLab.TabIndex = 85;
            ChkBox_FarmLab.Text = "Farmácia - Laboratório";
            ChkBox_FarmLab.UseVisualStyleBackColor = true;
            ChkBox_FarmLab.CheckedChanged += ChkBox_FarmLab_CheckedChanged;
            // 
            // FrmEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 569);
            Controls.Add(ChkBox_FarmLab);
            Controls.Add(ChkBox_Contr);
            Controls.Add(ChkBox_Filial);
            Controls.Add(GrpBox_Contrat);
            Controls.Add(GrpBox_FarmLab);
            Controls.Add(GrpBox_Filial);
            Controls.Add(PicBox_Logo);
            Controls.Add(CmbBox_Unidade);
            Controls.Add(Lbl_Unidade);
            Controls.Add(Lbl_Telefone);
            Controls.Add(MskBox_Telefone);
            Controls.Add(Lbl_CNPJ);
            Controls.Add(MskBox_CNPJ);
            Controls.Add(Txt_Endereco);
            Controls.Add(Lbl_Endereco);
            Controls.Add(Btn_BuscarEmpresa);
            Controls.Add(Txt_RazaoSoc);
            Controls.Add(Lbl_RazaoSoc);
            Controls.Add(Lbl_CodEmpresa);
            Controls.Add(Txt_CodEmpresa);
            Controls.Add(Lbl_CadastroAtend);
            Controls.Add(Btn_Sair);
            Controls.Add(Btn_Salvar);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Excluir);
            Name = "FrmEmpresa";
            Text = "FrmEmpresa";
            Load += FrmEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)PicBox_Logo).EndInit();
            GrpBox_Filial.ResumeLayout(false);
            GrpBox_Filial.PerformLayout();
            GrpBox_Contrat.ResumeLayout(false);
            GrpBox_Contrat.PerformLayout();
            GrpBox_FarmLab.ResumeLayout(false);
            GrpBox_FarmLab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Sair;
        private Button Btn_Salvar;
        private Button Btn_Editar;
        private Button Btn_Excluir;
        private Label Lbl_CadastroAtend;
        private Button Btn_BuscarEmpresa;
        private TextBox Txt_RazaoSoc;
        private Label Lbl_RazaoSoc;
        private Label Lbl_CodEmpresa;
        private TextBox Txt_CodEmpresa;
        private TextBox Txt_Endereco;
        private Label Lbl_Endereco;
        private MaskedTextBox MskBox_CNPJ;
        private Label Lbl_CNPJ;
        private Label Lbl_Telefone;
        private MaskedTextBox MskBox_Telefone;
        private Label Lbl_Unidade;
        private ComboBox CmbBox_Unidade;
        private PictureBox PicBox_Logo;
        private GroupBox GrpBox_Filial;
        private GroupBox GrpBox_Contrat;
        private GroupBox GrpBox_FarmLab;
        private CheckBox ChkBox_DayCare;
        private MaskedTextBox MskBox_FaturamentoFilial;
        private MaskedTextBox MskBox_CustosFilial;
        private CheckBox ChkBox_Farmacia;
        private MaskedTextBox MskBox_ProntoAtend;
        private CheckBox ChkBox_ProntoAtend;
        private MaskedTextBox MskBox_UnidHosp;
        private CheckBox ChkBox_UnidHosp;
        private MaskedTextBox MskBox_DayCare;
        private Label Lbl_CustosFilial;
        private Label Lbl_FaturamentoFilial;
        private Label Lbl_CustosContr;
        private Label Lbl_Servicos;
        private MaskedTextBox MskBox_CustosContr;
        private Label Lbl_FimContr;
        private Label Lbl_InicioContr;
        private DateTimePicker Dtp_FimContr;
        private DateTimePicker Dtp_InicioContr;
        private CheckBox ChkBox_UnidIntegr;
        private ListBox LstBox_Servicos;
        private Button Btn_AddServico;
        private Button Btn_DelServico;
        private CheckBox ChkBox_Integr;
        private Label Lbl_OBS;
        private Label Lbl_DescFarmLab;
        private TextBox Txt_OBS;
        private TextBox Txt_Desc;
        private CheckBox ChkBox_Terceirizada;
        private Label Lbl_Filial;
        private ComboBox CmbBox_Filial;
        private CheckBox ChkBox_Filial;
        private CheckBox ChkBox_Contr;
        private CheckBox ChkBox_FarmLab;
    }
}