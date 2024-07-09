namespace VetSysControl.FORMULARIOS.Cadastro {
    partial class FrmFuncionario {
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
            Lbl_CadastroFunc = new Label();
            Btn_Sair = new Button();
            Btn_Salvar = new Button();
            Btn_Editar = new Button();
            Btn_Excluir = new Button();
            CmbBox_Emp = new ComboBox();
            Lbl_Emp = new Label();
            CmbBox_Dept = new ComboBox();
            Lbl_Dept = new Label();
            CmbBox_Cargo = new ComboBox();
            Lbl_Cargo = new Label();
            Lbl_Nome = new Label();
            Txt_Nome = new TextBox();
            Lbl_CPF = new Label();
            Txt_CPF = new TextBox();
            Btn_Buscar = new Button();
            Lbl_DataNasc = new Label();
            Dtp_DataNasc = new DateTimePicker();
            Lbl_Endereco = new Label();
            Txt_Endereco = new TextBox();
            MskBox_Salario = new MaskedTextBox();
            Lbl_Salario = new Label();
            Lbl_Comissao = new Label();
            ChkBox_Inativo = new CheckBox();
            ChkBox_Terceirizado = new CheckBox();
            GrpBox_VetAnim = new GroupBox();
            ChkBox_AnimPesqu = new CheckBox();
            ChkBox_AnimExot = new CheckBox();
            ChkBox_AnimSelv = new CheckBox();
            ChkBox_AnimPortGrand = new CheckBox();
            ChkBox_AnimPortPeq = new CheckBox();
            GrpBox_VetFunc = new GroupBox();
            ChkBox_Pesquisa = new CheckBox();
            ChkBox_Farmac = new CheckBox();
            ChkBox_Anestesia = new CheckBox();
            ChkBox_VigilanInspec = new CheckBox();
            ChkBox_Lab = new CheckBox();
            ChkBox_ProdAnim = new CheckBox();
            ChkBox_ClinCirurg = new CheckBox();
            LstBox_Competencia = new ListBox();
            GrpBox_Competencias = new GroupBox();
            Btn_AddCompetencia = new Button();
            Btn_DelCompetencia = new Button();
            MskBox_Comissao = new MaskedTextBox();
            GrpBox_VetAnim.SuspendLayout();
            GrpBox_VetFunc.SuspendLayout();
            GrpBox_Competencias.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_CadastroFunc
            // 
            Lbl_CadastroFunc.AutoSize = true;
            Lbl_CadastroFunc.Location = new Point(37, 32);
            Lbl_CadastroFunc.Name = "Lbl_CadastroFunc";
            Lbl_CadastroFunc.Size = new Size(136, 15);
            Lbl_CadastroFunc.TabIndex = 24;
            Lbl_CadastroFunc.Text = "Cadastro de Funcionário";
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(994, 523);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 51;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(739, 523);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(75, 23);
            Btn_Salvar.TabIndex = 50;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            Btn_Editar.Location = new Point(825, 523);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(75, 23);
            Btn_Editar.TabIndex = 49;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Location = new Point(909, 523);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(75, 23);
            Btn_Excluir.TabIndex = 48;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // CmbBox_Emp
            // 
            CmbBox_Emp.FormattingEnabled = true;
            CmbBox_Emp.Location = new Point(515, 173);
            CmbBox_Emp.Name = "CmbBox_Emp";
            CmbBox_Emp.Size = new Size(162, 23);
            CmbBox_Emp.TabIndex = 97;
            // 
            // Lbl_Emp
            // 
            Lbl_Emp.AutoSize = true;
            Lbl_Emp.Location = new Point(454, 176);
            Lbl_Emp.Name = "Lbl_Emp";
            Lbl_Emp.Size = new Size(55, 15);
            Lbl_Emp.TabIndex = 96;
            Lbl_Emp.Text = "Empresa:";
            // 
            // CmbBox_Dept
            // 
            CmbBox_Dept.FormattingEnabled = true;
            CmbBox_Dept.Location = new Point(294, 173);
            CmbBox_Dept.Name = "CmbBox_Dept";
            CmbBox_Dept.Size = new Size(154, 23);
            CmbBox_Dept.TabIndex = 95;
            // 
            // Lbl_Dept
            // 
            Lbl_Dept.AutoSize = true;
            Lbl_Dept.Location = new Point(245, 176);
            Lbl_Dept.Name = "Lbl_Dept";
            Lbl_Dept.Size = new Size(38, 15);
            Lbl_Dept.TabIndex = 94;
            Lbl_Dept.Text = "Dept.:";
            // 
            // CmbBox_Cargo
            // 
            CmbBox_Cargo.FormattingEnabled = true;
            CmbBox_Cargo.Location = new Point(89, 173);
            CmbBox_Cargo.Name = "CmbBox_Cargo";
            CmbBox_Cargo.Size = new Size(150, 23);
            CmbBox_Cargo.TabIndex = 93;
            // 
            // Lbl_Cargo
            // 
            Lbl_Cargo.AutoSize = true;
            Lbl_Cargo.Location = new Point(37, 176);
            Lbl_Cargo.Name = "Lbl_Cargo";
            Lbl_Cargo.Size = new Size(42, 15);
            Lbl_Cargo.TabIndex = 92;
            Lbl_Cargo.Text = "Cargo:";
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Location = new Point(301, 87);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(43, 15);
            Lbl_Nome.TabIndex = 91;
            Lbl_Nome.Text = "Nome:";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(350, 84);
            Txt_Nome.MaxLength = 60;
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(299, 23);
            Txt_Nome.TabIndex = 90;
            // 
            // Lbl_CPF
            // 
            Lbl_CPF.AutoSize = true;
            Lbl_CPF.Location = new Point(37, 86);
            Lbl_CPF.Name = "Lbl_CPF";
            Lbl_CPF.Size = new Size(31, 15);
            Lbl_CPF.TabIndex = 89;
            Lbl_CPF.Text = "CPF:";
            // 
            // Txt_CPF
            // 
            Txt_CPF.Location = new Point(74, 83);
            Txt_CPF.MaxLength = 14;
            Txt_CPF.Name = "Txt_CPF";
            Txt_CPF.Size = new Size(128, 23);
            Txt_CPF.TabIndex = 88;
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.Location = new Point(208, 83);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(75, 23);
            Btn_Buscar.TabIndex = 98;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Lbl_DataNasc
            // 
            Lbl_DataNasc.AutoSize = true;
            Lbl_DataNasc.Location = new Point(673, 87);
            Lbl_DataNasc.Name = "Lbl_DataNasc";
            Lbl_DataNasc.Size = new Size(101, 15);
            Lbl_DataNasc.TabIndex = 99;
            Lbl_DataNasc.Text = "Data Nascimento:";
            // 
            // Dtp_DataNasc
            // 
            Dtp_DataNasc.Format = DateTimePickerFormat.Short;
            Dtp_DataNasc.Location = new Point(780, 84);
            Dtp_DataNasc.Name = "Dtp_DataNasc";
            Dtp_DataNasc.Size = new Size(102, 23);
            Dtp_DataNasc.TabIndex = 100;
            // 
            // Lbl_Endereco
            // 
            Lbl_Endereco.AutoSize = true;
            Lbl_Endereco.Location = new Point(37, 122);
            Lbl_Endereco.Name = "Lbl_Endereco";
            Lbl_Endereco.Size = new Size(59, 15);
            Lbl_Endereco.TabIndex = 101;
            Lbl_Endereco.Text = "Endereço:";
            // 
            // Txt_Endereco
            // 
            Txt_Endereco.Location = new Point(102, 119);
            Txt_Endereco.MaxLength = 100;
            Txt_Endereco.Name = "Txt_Endereco";
            Txt_Endereco.Size = new Size(547, 23);
            Txt_Endereco.TabIndex = 102;
            // 
            // MskBox_Salario
            // 
            MskBox_Salario.Location = new Point(88, 215);
            MskBox_Salario.Name = "MskBox_Salario";
            MskBox_Salario.Size = new Size(151, 23);
            MskBox_Salario.TabIndex = 103;
            // 
            // Lbl_Salario
            // 
            Lbl_Salario.AutoSize = true;
            Lbl_Salario.Location = new Point(37, 218);
            Lbl_Salario.Name = "Lbl_Salario";
            Lbl_Salario.Size = new Size(45, 15);
            Lbl_Salario.TabIndex = 104;
            Lbl_Salario.Text = "Salário:";
            // 
            // Lbl_Comissao
            // 
            Lbl_Comissao.AutoSize = true;
            Lbl_Comissao.Location = new Point(245, 218);
            Lbl_Comissao.Name = "Lbl_Comissao";
            Lbl_Comissao.Size = new Size(62, 15);
            Lbl_Comissao.TabIndex = 105;
            Lbl_Comissao.Text = "Comissão:";
            // 
            // ChkBox_Inativo
            // 
            ChkBox_Inativo.AutoSize = true;
            ChkBox_Inativo.Location = new Point(947, 86);
            ChkBox_Inativo.Name = "ChkBox_Inativo";
            ChkBox_Inativo.Size = new Size(62, 19);
            ChkBox_Inativo.TabIndex = 107;
            ChkBox_Inativo.Text = "Inativo";
            ChkBox_Inativo.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Terceirizado
            // 
            ChkBox_Terceirizado.AutoSize = true;
            ChkBox_Terceirizado.Location = new Point(712, 175);
            ChkBox_Terceirizado.Name = "ChkBox_Terceirizado";
            ChkBox_Terceirizado.Size = new Size(88, 19);
            ChkBox_Terceirizado.TabIndex = 108;
            ChkBox_Terceirizado.Text = "Terceirizado";
            ChkBox_Terceirizado.UseVisualStyleBackColor = true;
            // 
            // GrpBox_VetAnim
            // 
            GrpBox_VetAnim.Controls.Add(ChkBox_AnimPesqu);
            GrpBox_VetAnim.Controls.Add(ChkBox_AnimExot);
            GrpBox_VetAnim.Controls.Add(ChkBox_AnimSelv);
            GrpBox_VetAnim.Controls.Add(ChkBox_AnimPortGrand);
            GrpBox_VetAnim.Controls.Add(ChkBox_AnimPortPeq);
            GrpBox_VetAnim.Location = new Point(42, 278);
            GrpBox_VetAnim.Name = "GrpBox_VetAnim";
            GrpBox_VetAnim.Size = new Size(295, 104);
            GrpBox_VetAnim.TabIndex = 109;
            GrpBox_VetAnim.TabStop = false;
            GrpBox_VetAnim.Text = "Veterinário - Animal";
            // 
            // ChkBox_AnimPesqu
            // 
            ChkBox_AnimPesqu.AutoSize = true;
            ChkBox_AnimPesqu.Location = new Point(147, 47);
            ChkBox_AnimPesqu.Name = "ChkBox_AnimPesqu";
            ChkBox_AnimPesqu.Size = new Size(72, 19);
            ChkBox_AnimPesqu.TabIndex = 4;
            ChkBox_AnimPesqu.Text = "Pesquisa";
            ChkBox_AnimPesqu.UseVisualStyleBackColor = true;
            // 
            // ChkBox_AnimExot
            // 
            ChkBox_AnimExot.AutoSize = true;
            ChkBox_AnimExot.Location = new Point(147, 22);
            ChkBox_AnimExot.Name = "ChkBox_AnimExot";
            ChkBox_AnimExot.Size = new Size(65, 19);
            ChkBox_AnimExot.TabIndex = 3;
            ChkBox_AnimExot.Text = "Exótico";
            ChkBox_AnimExot.UseVisualStyleBackColor = true;
            // 
            // ChkBox_AnimSelv
            // 
            ChkBox_AnimSelv.AutoSize = true;
            ChkBox_AnimSelv.Location = new Point(9, 68);
            ChkBox_AnimSelv.Name = "ChkBox_AnimSelv";
            ChkBox_AnimSelv.Size = new Size(77, 19);
            ChkBox_AnimSelv.TabIndex = 2;
            ChkBox_AnimSelv.Text = "Selvagem";
            ChkBox_AnimSelv.UseVisualStyleBackColor = true;
            // 
            // ChkBox_AnimPortGrand
            // 
            ChkBox_AnimPortGrand.AutoSize = true;
            ChkBox_AnimPortGrand.Location = new Point(6, 43);
            ChkBox_AnimPortGrand.Name = "ChkBox_AnimPortGrand";
            ChkBox_AnimPortGrand.Size = new Size(95, 19);
            ChkBox_AnimPortGrand.TabIndex = 1;
            ChkBox_AnimPortGrand.Text = "Porte Grande";
            ChkBox_AnimPortGrand.UseVisualStyleBackColor = true;
            // 
            // ChkBox_AnimPortPeq
            // 
            ChkBox_AnimPortPeq.AutoSize = true;
            ChkBox_AnimPortPeq.Location = new Point(6, 18);
            ChkBox_AnimPortPeq.Name = "ChkBox_AnimPortPeq";
            ChkBox_AnimPortPeq.Size = new Size(104, 19);
            ChkBox_AnimPortPeq.TabIndex = 0;
            ChkBox_AnimPortPeq.Text = "Porte Pequeno";
            ChkBox_AnimPortPeq.UseVisualStyleBackColor = true;
            // 
            // GrpBox_VetFunc
            // 
            GrpBox_VetFunc.Controls.Add(ChkBox_Pesquisa);
            GrpBox_VetFunc.Controls.Add(ChkBox_Farmac);
            GrpBox_VetFunc.Controls.Add(ChkBox_Anestesia);
            GrpBox_VetFunc.Controls.Add(ChkBox_VigilanInspec);
            GrpBox_VetFunc.Controls.Add(ChkBox_Lab);
            GrpBox_VetFunc.Controls.Add(ChkBox_ProdAnim);
            GrpBox_VetFunc.Controls.Add(ChkBox_ClinCirurg);
            GrpBox_VetFunc.Location = new Point(42, 388);
            GrpBox_VetFunc.Name = "GrpBox_VetFunc";
            GrpBox_VetFunc.Size = new Size(295, 130);
            GrpBox_VetFunc.TabIndex = 110;
            GrpBox_VetFunc.TabStop = false;
            GrpBox_VetFunc.Text = "Veterinário - Função";
            // 
            // ChkBox_Pesquisa
            // 
            ChkBox_Pesquisa.AutoSize = true;
            ChkBox_Pesquisa.Location = new Point(141, 68);
            ChkBox_Pesquisa.Name = "ChkBox_Pesquisa";
            ChkBox_Pesquisa.Size = new Size(72, 19);
            ChkBox_Pesquisa.TabIndex = 6;
            ChkBox_Pesquisa.Text = "Pesquisa";
            ChkBox_Pesquisa.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Farmac
            // 
            ChkBox_Farmac.AutoSize = true;
            ChkBox_Farmac.Location = new Point(141, 18);
            ChkBox_Farmac.Name = "ChkBox_Farmac";
            ChkBox_Farmac.Size = new Size(74, 19);
            ChkBox_Farmac.TabIndex = 5;
            ChkBox_Farmac.Text = "Farmácia";
            ChkBox_Farmac.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Anestesia
            // 
            ChkBox_Anestesia.AutoSize = true;
            ChkBox_Anestesia.Location = new Point(141, 43);
            ChkBox_Anestesia.Name = "ChkBox_Anestesia";
            ChkBox_Anestesia.Size = new Size(76, 19);
            ChkBox_Anestesia.TabIndex = 4;
            ChkBox_Anestesia.Text = "Anestesia";
            ChkBox_Anestesia.UseVisualStyleBackColor = true;
            // 
            // ChkBox_VigilanInspec
            // 
            ChkBox_VigilanInspec.AutoSize = true;
            ChkBox_VigilanInspec.Location = new Point(6, 93);
            ChkBox_VigilanInspec.Name = "ChkBox_VigilanInspec";
            ChkBox_VigilanInspec.Size = new Size(127, 19);
            ChkBox_VigilanInspec.TabIndex = 3;
            ChkBox_VigilanInspec.Text = "Vigilancia Inspeção";
            ChkBox_VigilanInspec.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Lab
            // 
            ChkBox_Lab.AutoSize = true;
            ChkBox_Lab.Location = new Point(6, 68);
            ChkBox_Lab.Name = "ChkBox_Lab";
            ChkBox_Lab.Size = new Size(89, 19);
            ChkBox_Lab.TabIndex = 2;
            ChkBox_Lab.Text = "Laboratorial";
            ChkBox_Lab.UseVisualStyleBackColor = true;
            // 
            // ChkBox_ProdAnim
            // 
            ChkBox_ProdAnim.AutoSize = true;
            ChkBox_ProdAnim.Location = new Point(6, 43);
            ChkBox_ProdAnim.Name = "ChkBox_ProdAnim";
            ChkBox_ProdAnim.Size = new Size(118, 19);
            ChkBox_ProdAnim.TabIndex = 1;
            ChkBox_ProdAnim.Text = "Produção Animal";
            ChkBox_ProdAnim.UseVisualStyleBackColor = true;
            // 
            // ChkBox_ClinCirurg
            // 
            ChkBox_ClinCirurg.AutoSize = true;
            ChkBox_ClinCirurg.Location = new Point(6, 18);
            ChkBox_ClinCirurg.Name = "ChkBox_ClinCirurg";
            ChkBox_ClinCirurg.Size = new Size(113, 19);
            ChkBox_ClinCirurg.TabIndex = 0;
            ChkBox_ClinCirurg.Text = "Clínica Cirurgica";
            ChkBox_ClinCirurg.UseVisualStyleBackColor = true;
            // 
            // LstBox_Competencia
            // 
            LstBox_Competencia.Dock = DockStyle.Top;
            LstBox_Competencia.FormattingEnabled = true;
            LstBox_Competencia.ItemHeight = 15;
            LstBox_Competencia.Location = new Point(3, 19);
            LstBox_Competencia.Name = "LstBox_Competencia";
            LstBox_Competencia.Size = new Size(356, 154);
            LstBox_Competencia.TabIndex = 111;
            // 
            // GrpBox_Competencias
            // 
            GrpBox_Competencias.Controls.Add(Btn_AddCompetencia);
            GrpBox_Competencias.Controls.Add(Btn_DelCompetencia);
            GrpBox_Competencias.Controls.Add(LstBox_Competencia);
            GrpBox_Competencias.Location = new Point(350, 278);
            GrpBox_Competencias.Name = "GrpBox_Competencias";
            GrpBox_Competencias.Size = new Size(362, 240);
            GrpBox_Competencias.TabIndex = 112;
            GrpBox_Competencias.TabStop = false;
            GrpBox_Competencias.Text = "Competencias";
            // 
            // Btn_AddCompetencia
            // 
            Btn_AddCompetencia.Location = new Point(305, 177);
            Btn_AddCompetencia.Name = "Btn_AddCompetencia";
            Btn_AddCompetencia.Size = new Size(39, 23);
            Btn_AddCompetencia.TabIndex = 112;
            Btn_AddCompetencia.Text = "+";
            Btn_AddCompetencia.UseVisualStyleBackColor = true;
            // 
            // Btn_DelCompetencia
            // 
            Btn_DelCompetencia.Location = new Point(260, 177);
            Btn_DelCompetencia.Name = "Btn_DelCompetencia";
            Btn_DelCompetencia.Size = new Size(39, 23);
            Btn_DelCompetencia.TabIndex = 113;
            Btn_DelCompetencia.Text = "-";
            Btn_DelCompetencia.UseVisualStyleBackColor = true;
            // 
            // MskBox_Comissao
            // 
            MskBox_Comissao.Location = new Point(313, 215);
            MskBox_Comissao.Name = "MskBox_Comissao";
            MskBox_Comissao.Size = new Size(98, 23);
            MskBox_Comissao.TabIndex = 113;
            // 
            // FrmFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 569);
            Controls.Add(MskBox_Comissao);
            Controls.Add(GrpBox_Competencias);
            Controls.Add(GrpBox_VetFunc);
            Controls.Add(GrpBox_VetAnim);
            Controls.Add(ChkBox_Terceirizado);
            Controls.Add(ChkBox_Inativo);
            Controls.Add(Lbl_Comissao);
            Controls.Add(Lbl_Salario);
            Controls.Add(MskBox_Salario);
            Controls.Add(Txt_Endereco);
            Controls.Add(Lbl_Endereco);
            Controls.Add(Dtp_DataNasc);
            Controls.Add(Lbl_DataNasc);
            Controls.Add(Btn_Buscar);
            Controls.Add(CmbBox_Emp);
            Controls.Add(Lbl_Emp);
            Controls.Add(CmbBox_Dept);
            Controls.Add(Lbl_Dept);
            Controls.Add(CmbBox_Cargo);
            Controls.Add(Lbl_Cargo);
            Controls.Add(Lbl_Nome);
            Controls.Add(Txt_Nome);
            Controls.Add(Lbl_CPF);
            Controls.Add(Txt_CPF);
            Controls.Add(Btn_Sair);
            Controls.Add(Btn_Salvar);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Excluir);
            Controls.Add(Lbl_CadastroFunc);
            Name = "FrmFuncionario";
            Text = "FrmFuncionario";
            Load += FrmFuncionario_Load;
            GrpBox_VetAnim.ResumeLayout(false);
            GrpBox_VetAnim.PerformLayout();
            GrpBox_VetFunc.ResumeLayout(false);
            GrpBox_VetFunc.PerformLayout();
            GrpBox_Competencias.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_CadastroFunc;
        private Button Btn_Sair;
        private Button Btn_Salvar;
        private Button Btn_Editar;
        private Button Btn_Excluir;
        private ComboBox CmbBox_Emp;
        private Label Lbl_Emp;
        private ComboBox CmbBox_Dept;
        private Label Lbl_Dept;
        private ComboBox CmbBox_Cargo;
        private Label Lbl_Cargo;
        private Label Lbl_Nome;
        private TextBox Txt_Nome;
        private Label Lbl_CPF;
        private TextBox Txt_CPF;
        private Button Btn_Buscar;
        private Label Lbl_DataNasc;
        private DateTimePicker Dtp_DataNasc;
        private Label Lbl_Endereco;
        private TextBox Txt_Endereco;
        private MaskedTextBox MskBox_Salario;
        private Label Lbl_Salario;
        private Label Lbl_Comissao;
        private CheckBox ChkBox_Inativo;
        private CheckBox ChkBox_Terceirizado;
        private GroupBox GrpBox_VetAnim;
        private CheckBox ChkBox_AnimPesqu;
        private CheckBox ChkBox_AnimExot;
        private CheckBox ChkBox_AnimSelv;
        private CheckBox ChkBox_AnimPortGrand;
        private CheckBox ChkBox_AnimPortPeq;
        private GroupBox GrpBox_VetFunc;
        private CheckBox ChkBox_Pesquisa;
        private CheckBox ChkBox_Farmac;
        private CheckBox ChkBox_Anestesia;
        private CheckBox ChkBox_VigilanInspec;
        private CheckBox ChkBox_Lab;
        private CheckBox ChkBox_ProdAnim;
        private CheckBox ChkBox_ClinCirurg;
        private ListBox LstBox_Competencia;
        private GroupBox GrpBox_Competencias;
        private Button Btn_AddCompetencia;
        private Button Btn_DelCompetencia;
        private MaskedTextBox MskBox_Comissao;
    }
}