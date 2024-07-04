namespace VetSysControl.FORMULARIOS.Consulta {
    partial class FrmConsultaFun {
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
            GrpBox_ConsultaPet = new GroupBox();
            GrpBox_VetFunc = new GroupBox();
            ChkBox_Pesquisa = new CheckBox();
            ChkBox_Farmac = new CheckBox();
            ChkBox_Anestesia = new CheckBox();
            ChkBox_VigilanInspec = new CheckBox();
            ChkBox_Lab = new CheckBox();
            ChkBox_ProdAnim = new CheckBox();
            ChkBox_ClinCirurg = new CheckBox();
            GrpBox_VetAnim = new GroupBox();
            ChkBox_AnimPesqu = new CheckBox();
            ChkBox_AnimExot = new CheckBox();
            ChkBox_AnimSelv = new CheckBox();
            ChkBox_AnimPortGrand = new CheckBox();
            ChkBox_AnimPortPeq = new CheckBox();
            CmbBox_Emp = new ComboBox();
            Lbl_Emp = new Label();
            GrpBox_Inativo = new GroupBox();
            RBtn_NaoInativo = new RadioButton();
            RBtn_SimInativo = new RadioButton();
            GrpBox_Terceirizado = new GroupBox();
            RBtn_NaoTerceirizado = new RadioButton();
            RBtn_SimTerceirizado = new RadioButton();
            CmbBox_Dept = new ComboBox();
            Lbl_Dept = new Label();
            CmbBox_Cargo = new ComboBox();
            Lbl_Cargo = new Label();
            Lbl_Nome = new Label();
            Txt_Nome = new TextBox();
            Btn_Buscar = new Button();
            Lbl_CPF = new Label();
            Txt_CPF = new TextBox();
            DtGridView_Func = new DataGridView();
            GrpBox_ConsultaPet.SuspendLayout();
            GrpBox_VetFunc.SuspendLayout();
            GrpBox_VetAnim.SuspendLayout();
            GrpBox_Inativo.SuspendLayout();
            GrpBox_Terceirizado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Func).BeginInit();
            SuspendLayout();
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(994, 523);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 60;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // GrpBox_ConsultaPet
            // 
            GrpBox_ConsultaPet.Controls.Add(GrpBox_VetAnim);
            GrpBox_ConsultaPet.Controls.Add(GrpBox_VetFunc);
            GrpBox_ConsultaPet.Controls.Add(CmbBox_Emp);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Emp);
            GrpBox_ConsultaPet.Controls.Add(GrpBox_Inativo);
            GrpBox_ConsultaPet.Controls.Add(GrpBox_Terceirizado);
            GrpBox_ConsultaPet.Controls.Add(CmbBox_Dept);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Dept);
            GrpBox_ConsultaPet.Controls.Add(CmbBox_Cargo);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Cargo);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Nome);
            GrpBox_ConsultaPet.Controls.Add(Txt_Nome);
            GrpBox_ConsultaPet.Controls.Add(Btn_Buscar);
            GrpBox_ConsultaPet.Controls.Add(Lbl_CPF);
            GrpBox_ConsultaPet.Controls.Add(Txt_CPF);
            GrpBox_ConsultaPet.Location = new Point(12, 12);
            GrpBox_ConsultaPet.Name = "GrpBox_ConsultaPet";
            GrpBox_ConsultaPet.Size = new Size(1068, 143);
            GrpBox_ConsultaPet.TabIndex = 61;
            GrpBox_ConsultaPet.TabStop = false;
            GrpBox_ConsultaPet.Text = "Consulta";
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
            GrpBox_VetFunc.Location = new Point(672, 16);
            GrpBox_VetFunc.Name = "GrpBox_VetFunc";
            GrpBox_VetFunc.Size = new Size(223, 117);
            GrpBox_VetFunc.TabIndex = 90;
            GrpBox_VetFunc.TabStop = false;
            GrpBox_VetFunc.Text = "Veterinário - Função";
            // 
            // ChkBox_Pesquisa
            // 
            ChkBox_Pesquisa.AutoSize = true;
            ChkBox_Pesquisa.Location = new Point(141, 40);
            ChkBox_Pesquisa.Name = "ChkBox_Pesquisa";
            ChkBox_Pesquisa.Size = new Size(72, 19);
            ChkBox_Pesquisa.TabIndex = 6;
            ChkBox_Pesquisa.Text = "Pesquisa";
            ChkBox_Pesquisa.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Farmac
            // 
            ChkBox_Farmac.AutoSize = true;
            ChkBox_Farmac.Location = new Point(6, 95);
            ChkBox_Farmac.Name = "ChkBox_Farmac";
            ChkBox_Farmac.Size = new Size(74, 19);
            ChkBox_Farmac.TabIndex = 5;
            ChkBox_Farmac.Text = "Farmácia";
            ChkBox_Farmac.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Anestesia
            // 
            ChkBox_Anestesia.AutoSize = true;
            ChkBox_Anestesia.Location = new Point(141, 18);
            ChkBox_Anestesia.Name = "ChkBox_Anestesia";
            ChkBox_Anestesia.Size = new Size(76, 19);
            ChkBox_Anestesia.TabIndex = 4;
            ChkBox_Anestesia.Text = "Anestesia";
            ChkBox_Anestesia.UseVisualStyleBackColor = true;
            // 
            // ChkBox_VigilanInspec
            // 
            ChkBox_VigilanInspec.AutoSize = true;
            ChkBox_VigilanInspec.Location = new Point(6, 77);
            ChkBox_VigilanInspec.Name = "ChkBox_VigilanInspec";
            ChkBox_VigilanInspec.Size = new Size(127, 19);
            ChkBox_VigilanInspec.TabIndex = 3;
            ChkBox_VigilanInspec.Text = "Vigilancia Inspeção";
            ChkBox_VigilanInspec.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Lab
            // 
            ChkBox_Lab.AutoSize = true;
            ChkBox_Lab.Location = new Point(6, 58);
            ChkBox_Lab.Name = "ChkBox_Lab";
            ChkBox_Lab.Size = new Size(89, 19);
            ChkBox_Lab.TabIndex = 2;
            ChkBox_Lab.Text = "Laboratorial";
            ChkBox_Lab.UseVisualStyleBackColor = true;
            // 
            // ChkBox_ProdAnim
            // 
            ChkBox_ProdAnim.AutoSize = true;
            ChkBox_ProdAnim.Location = new Point(6, 37);
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
            // GrpBox_VetAnim
            // 
            GrpBox_VetAnim.Controls.Add(ChkBox_AnimPesqu);
            GrpBox_VetAnim.Controls.Add(ChkBox_AnimExot);
            GrpBox_VetAnim.Controls.Add(ChkBox_AnimSelv);
            GrpBox_VetAnim.Controls.Add(ChkBox_AnimPortGrand);
            GrpBox_VetAnim.Controls.Add(ChkBox_AnimPortPeq);
            GrpBox_VetAnim.Location = new Point(534, 16);
            GrpBox_VetAnim.Name = "GrpBox_VetAnim";
            GrpBox_VetAnim.Size = new Size(131, 117);
            GrpBox_VetAnim.TabIndex = 89;
            GrpBox_VetAnim.TabStop = false;
            GrpBox_VetAnim.Text = "Veterinário - Animal";
            // 
            // ChkBox_AnimPesqu
            // 
            ChkBox_AnimPesqu.AutoSize = true;
            ChkBox_AnimPesqu.Location = new Point(6, 93);
            ChkBox_AnimPesqu.Name = "ChkBox_AnimPesqu";
            ChkBox_AnimPesqu.Size = new Size(72, 19);
            ChkBox_AnimPesqu.TabIndex = 4;
            ChkBox_AnimPesqu.Text = "Pesquisa";
            ChkBox_AnimPesqu.UseVisualStyleBackColor = true;
            // 
            // ChkBox_AnimExot
            // 
            ChkBox_AnimExot.AutoSize = true;
            ChkBox_AnimExot.Location = new Point(6, 76);
            ChkBox_AnimExot.Name = "ChkBox_AnimExot";
            ChkBox_AnimExot.Size = new Size(65, 19);
            ChkBox_AnimExot.TabIndex = 3;
            ChkBox_AnimExot.Text = "Exótico";
            ChkBox_AnimExot.UseVisualStyleBackColor = true;
            // 
            // ChkBox_AnimSelv
            // 
            ChkBox_AnimSelv.AutoSize = true;
            ChkBox_AnimSelv.Location = new Point(6, 57);
            ChkBox_AnimSelv.Name = "ChkBox_AnimSelv";
            ChkBox_AnimSelv.Size = new Size(77, 19);
            ChkBox_AnimSelv.TabIndex = 2;
            ChkBox_AnimSelv.Text = "Selvagem";
            ChkBox_AnimSelv.UseVisualStyleBackColor = true;
            // 
            // ChkBox_AnimPortGrand
            // 
            ChkBox_AnimPortGrand.AutoSize = true;
            ChkBox_AnimPortGrand.Location = new Point(6, 37);
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
            // CmbBox_Emp
            // 
            CmbBox_Emp.FormattingEnabled = true;
            CmbBox_Emp.Location = new Point(409, 57);
            CmbBox_Emp.Name = "CmbBox_Emp";
            CmbBox_Emp.Size = new Size(119, 23);
            CmbBox_Emp.TabIndex = 87;
            // 
            // Lbl_Emp
            // 
            Lbl_Emp.AutoSize = true;
            Lbl_Emp.Location = new Point(354, 60);
            Lbl_Emp.Name = "Lbl_Emp";
            Lbl_Emp.Size = new Size(55, 15);
            Lbl_Emp.TabIndex = 86;
            Lbl_Emp.Text = "Empresa:";
            // 
            // GrpBox_Inativo
            // 
            GrpBox_Inativo.Controls.Add(RBtn_NaoInativo);
            GrpBox_Inativo.Controls.Add(RBtn_SimInativo);
            GrpBox_Inativo.Location = new Point(993, 16);
            GrpBox_Inativo.Name = "GrpBox_Inativo";
            GrpBox_Inativo.Size = new Size(64, 64);
            GrpBox_Inativo.TabIndex = 85;
            GrpBox_Inativo.TabStop = false;
            GrpBox_Inativo.Text = "Inativo";
            // 
            // RBtn_NaoInativo
            // 
            RBtn_NaoInativo.AutoSize = true;
            RBtn_NaoInativo.Location = new Point(6, 37);
            RBtn_NaoInativo.Name = "RBtn_NaoInativo";
            RBtn_NaoInativo.Size = new Size(47, 19);
            RBtn_NaoInativo.TabIndex = 88;
            RBtn_NaoInativo.TabStop = true;
            RBtn_NaoInativo.Text = "Não";
            RBtn_NaoInativo.UseVisualStyleBackColor = true;
            // 
            // RBtn_SimInativo
            // 
            RBtn_SimInativo.AutoSize = true;
            RBtn_SimInativo.Location = new Point(6, 17);
            RBtn_SimInativo.Name = "RBtn_SimInativo";
            RBtn_SimInativo.Size = new Size(45, 19);
            RBtn_SimInativo.TabIndex = 88;
            RBtn_SimInativo.TabStop = true;
            RBtn_SimInativo.Text = "Sim";
            RBtn_SimInativo.UseVisualStyleBackColor = true;
            // 
            // GrpBox_Terceirizado
            // 
            GrpBox_Terceirizado.Controls.Add(RBtn_NaoTerceirizado);
            GrpBox_Terceirizado.Controls.Add(RBtn_SimTerceirizado);
            GrpBox_Terceirizado.Location = new Point(901, 16);
            GrpBox_Terceirizado.Name = "GrpBox_Terceirizado";
            GrpBox_Terceirizado.Size = new Size(86, 64);
            GrpBox_Terceirizado.TabIndex = 84;
            GrpBox_Terceirizado.TabStop = false;
            GrpBox_Terceirizado.Text = "Terceirizado";
            // 
            // RBtn_NaoTerceirizado
            // 
            RBtn_NaoTerceirizado.AutoSize = true;
            RBtn_NaoTerceirizado.Location = new Point(6, 37);
            RBtn_NaoTerceirizado.Name = "RBtn_NaoTerceirizado";
            RBtn_NaoTerceirizado.Size = new Size(47, 19);
            RBtn_NaoTerceirizado.TabIndex = 86;
            RBtn_NaoTerceirizado.TabStop = true;
            RBtn_NaoTerceirizado.Text = "Não";
            RBtn_NaoTerceirizado.UseVisualStyleBackColor = true;
            // 
            // RBtn_SimTerceirizado
            // 
            RBtn_SimTerceirizado.AutoSize = true;
            RBtn_SimTerceirizado.Location = new Point(6, 17);
            RBtn_SimTerceirizado.Name = "RBtn_SimTerceirizado";
            RBtn_SimTerceirizado.Size = new Size(45, 19);
            RBtn_SimTerceirizado.TabIndex = 87;
            RBtn_SimTerceirizado.TabStop = true;
            RBtn_SimTerceirizado.Text = "Sim";
            RBtn_SimTerceirizado.UseVisualStyleBackColor = true;
            // 
            // CmbBox_Dept
            // 
            CmbBox_Dept.FormattingEnabled = true;
            CmbBox_Dept.Location = new Point(229, 58);
            CmbBox_Dept.Name = "CmbBox_Dept";
            CmbBox_Dept.Size = new Size(110, 23);
            CmbBox_Dept.TabIndex = 83;
            // 
            // Lbl_Dept
            // 
            Lbl_Dept.AutoSize = true;
            Lbl_Dept.Location = new Point(180, 61);
            Lbl_Dept.Name = "Lbl_Dept";
            Lbl_Dept.Size = new Size(38, 15);
            Lbl_Dept.TabIndex = 82;
            Lbl_Dept.Text = "Dept.:";
            // 
            // CmbBox_Cargo
            // 
            CmbBox_Cargo.FormattingEnabled = true;
            CmbBox_Cargo.Location = new Point(58, 58);
            CmbBox_Cargo.Name = "CmbBox_Cargo";
            CmbBox_Cargo.Size = new Size(119, 23);
            CmbBox_Cargo.TabIndex = 81;
            // 
            // Lbl_Cargo
            // 
            Lbl_Cargo.AutoSize = true;
            Lbl_Cargo.Location = new Point(6, 61);
            Lbl_Cargo.Name = "Lbl_Cargo";
            Lbl_Cargo.Size = new Size(42, 15);
            Lbl_Cargo.TabIndex = 79;
            Lbl_Cargo.Text = "Cargo:";
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Location = new Point(180, 19);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(43, 15);
            Lbl_Nome.TabIndex = 76;
            Lbl_Nome.Text = "Nome:";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(229, 16);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(299, 23);
            Txt_Nome.TabIndex = 75;
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.Location = new Point(982, 110);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(75, 23);
            Btn_Buscar.TabIndex = 72;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Lbl_CPF
            // 
            Lbl_CPF.AutoSize = true;
            Lbl_CPF.Location = new Point(6, 19);
            Lbl_CPF.Name = "Lbl_CPF";
            Lbl_CPF.Size = new Size(31, 15);
            Lbl_CPF.TabIndex = 71;
            Lbl_CPF.Text = "CPF:";
            // 
            // Txt_CPF
            // 
            Txt_CPF.Location = new Point(58, 16);
            Txt_CPF.Name = "Txt_CPF";
            Txt_CPF.Size = new Size(119, 23);
            Txt_CPF.TabIndex = 70;
            // 
            // DtGridView_Func
            // 
            DtGridView_Func.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGridView_Func.Location = new Point(12, 161);
            DtGridView_Func.Name = "DtGridView_Func";
            DtGridView_Func.Size = new Size(1068, 356);
            DtGridView_Func.TabIndex = 62;
            // 
            // FrmConsultaFun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 569);
            Controls.Add(DtGridView_Func);
            Controls.Add(GrpBox_ConsultaPet);
            Controls.Add(Btn_Sair);
            Name = "FrmConsultaFun";
            Text = "ConsultaFunc";
            GrpBox_ConsultaPet.ResumeLayout(false);
            GrpBox_ConsultaPet.PerformLayout();
            GrpBox_VetFunc.ResumeLayout(false);
            GrpBox_VetFunc.PerformLayout();
            GrpBox_VetAnim.ResumeLayout(false);
            GrpBox_VetAnim.PerformLayout();
            GrpBox_Inativo.ResumeLayout(false);
            GrpBox_Inativo.PerformLayout();
            GrpBox_Terceirizado.ResumeLayout(false);
            GrpBox_Terceirizado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Func).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Buscar;
        private Button Btn_Sair;
        private GroupBox GrpBox_ConsultaPet;
        private Label Lbl_Nome;
        private TextBox Txt_Nome;
        private Label Lbl_CPF;
        private TextBox Txt_CPF;
        private DataGridView DtGridView_Func;
        private GroupBox GrpBox_Inativo;
        private GroupBox GrpBox_Terceirizado;
        private ComboBox CmbBox_Dept;
        private Label Lbl_Dept;
        private ComboBox CmbBox_Cargo;
        private Label Lbl_Cargo;
        private GroupBox GrpBox_VetAnim;
        private ComboBox CmbBox_Emp;
        private Label Lbl_Emp;
        private RadioButton RBtn_NaoInativo;
        private RadioButton RBtn_SimInativo;
        private RadioButton RBtn_NaoTerceirizado;
        private RadioButton RBtn_SimTerceirizado;
        private CheckBox ChkBox_AnimPesqu;
        private CheckBox ChkBox_AnimExot;
        private CheckBox ChkBox_AnimSelv;
        private CheckBox ChkBox_AnimPortGrand;
        private CheckBox ChkBox_AnimPortPeq;
        private GroupBox GrpBox_VetFunc;
        private CheckBox ChkBox_Anestesia;
        private CheckBox ChkBox_VigilanInspec;
        private CheckBox ChkBox_Lab;
        private CheckBox ChkBox_ProdAnim;
        private CheckBox ChkBox_ClinCirurg;
        private CheckBox ChkBox_Pesquisa;
        private CheckBox ChkBox_Farmac;
    }
}