namespace VetSysControl.FORMULARIOS.Consulta {
    partial class FrmConsultaEmp {
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
            ChkBox_FarmLab = new CheckBox();
            ChkBox_Contr = new CheckBox();
            ChkBox_Filial = new CheckBox();
            MskBox_CNPJ = new MaskedTextBox();
            MskTxt_Telefone = new MaskedTextBox();
            Lbl_CNPJ = new Label();
            Lbl_RazaoSocial = new Label();
            Txt_RazaoSocial = new TextBox();
            Lbl_Telefone = new Label();
            Lbl_Codigo = new Label();
            Txt_Codigo = new TextBox();
            Btn_Buscar = new Button();
            DtGridView_Empresa = new DataGridView();
            GrpBox_ConsultaPet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Empresa).BeginInit();
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
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // GrpBox_ConsultaPet
            // 
            GrpBox_ConsultaPet.Controls.Add(ChkBox_FarmLab);
            GrpBox_ConsultaPet.Controls.Add(ChkBox_Contr);
            GrpBox_ConsultaPet.Controls.Add(ChkBox_Filial);
            GrpBox_ConsultaPet.Controls.Add(MskBox_CNPJ);
            GrpBox_ConsultaPet.Controls.Add(MskTxt_Telefone);
            GrpBox_ConsultaPet.Controls.Add(Lbl_CNPJ);
            GrpBox_ConsultaPet.Controls.Add(Lbl_RazaoSocial);
            GrpBox_ConsultaPet.Controls.Add(Txt_RazaoSocial);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Telefone);
            GrpBox_ConsultaPet.Controls.Add(Lbl_Codigo);
            GrpBox_ConsultaPet.Controls.Add(Txt_Codigo);
            GrpBox_ConsultaPet.Controls.Add(Btn_Buscar);
            GrpBox_ConsultaPet.Location = new Point(12, 12);
            GrpBox_ConsultaPet.Name = "GrpBox_ConsultaPet";
            GrpBox_ConsultaPet.Size = new Size(1068, 72);
            GrpBox_ConsultaPet.TabIndex = 61;
            GrpBox_ConsultaPet.TabStop = false;
            GrpBox_ConsultaPet.Text = "Consulta";
            // 
            // ChkBox_FarmLab
            // 
            ChkBox_FarmLab.AutoSize = true;
            ChkBox_FarmLab.Location = new Point(199, 46);
            ChkBox_FarmLab.Name = "ChkBox_FarmLab";
            ChkBox_FarmLab.Size = new Size(146, 19);
            ChkBox_FarmLab.TabIndex = 97;
            ChkBox_FarmLab.Text = "Farmácia - Laboratório";
            ChkBox_FarmLab.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Contr
            // 
            ChkBox_Contr.AutoSize = true;
            ChkBox_Contr.Location = new Point(88, 46);
            ChkBox_Contr.Name = "ChkBox_Contr";
            ChkBox_Contr.Size = new Size(89, 19);
            ChkBox_Contr.TabIndex = 96;
            ChkBox_Contr.Text = "Contratante";
            ChkBox_Contr.UseVisualStyleBackColor = true;
            // 
            // ChkBox_Filial
            // 
            ChkBox_Filial.AutoSize = true;
            ChkBox_Filial.Location = new Point(20, 46);
            ChkBox_Filial.Name = "ChkBox_Filial";
            ChkBox_Filial.Size = new Size(50, 19);
            ChkBox_Filial.TabIndex = 95;
            ChkBox_Filial.Text = "Filial";
            ChkBox_Filial.UseVisualStyleBackColor = true;
            // 
            // MskBox_CNPJ
            // 
            MskBox_CNPJ.Location = new Point(577, 16);
            MskBox_CNPJ.Mask = "99.999.999/9999-99";
            MskBox_CNPJ.Name = "MskBox_CNPJ";
            MskBox_CNPJ.Size = new Size(230, 23);
            MskBox_CNPJ.TabIndex = 94;
            // 
            // MskTxt_Telefone
            // 
            MskTxt_Telefone.Location = new Point(879, 16);
            MskTxt_Telefone.Name = "MskTxt_Telefone";
            MskTxt_Telefone.Size = new Size(164, 23);
            MskTxt_Telefone.TabIndex = 93;
            // 
            // Lbl_CNPJ
            // 
            Lbl_CNPJ.AutoSize = true;
            Lbl_CNPJ.Location = new Point(534, 19);
            Lbl_CNPJ.Name = "Lbl_CNPJ";
            Lbl_CNPJ.Size = new Size(37, 15);
            Lbl_CNPJ.TabIndex = 92;
            Lbl_CNPJ.Text = "CNPJ:";
            // 
            // Lbl_RazaoSocial
            // 
            Lbl_RazaoSocial.AutoSize = true;
            Lbl_RazaoSocial.Location = new Point(180, 19);
            Lbl_RazaoSocial.Name = "Lbl_RazaoSocial";
            Lbl_RazaoSocial.Size = new Size(75, 15);
            Lbl_RazaoSocial.TabIndex = 91;
            Lbl_RazaoSocial.Text = "Razão Social:";
            // 
            // Txt_RazaoSocial
            // 
            Txt_RazaoSocial.Location = new Point(261, 16);
            Txt_RazaoSocial.MaxLength = 60;
            Txt_RazaoSocial.Name = "Txt_RazaoSocial";
            Txt_RazaoSocial.Size = new Size(267, 23);
            Txt_RazaoSocial.TabIndex = 90;
            // 
            // Lbl_Telefone
            // 
            Lbl_Telefone.AutoSize = true;
            Lbl_Telefone.Location = new Point(819, 19);
            Lbl_Telefone.Name = "Lbl_Telefone";
            Lbl_Telefone.Size = new Size(54, 15);
            Lbl_Telefone.TabIndex = 89;
            Lbl_Telefone.Text = "Telefone:";
            // 
            // Lbl_Codigo
            // 
            Lbl_Codigo.AutoSize = true;
            Lbl_Codigo.Location = new Point(6, 19);
            Lbl_Codigo.Name = "Lbl_Codigo";
            Lbl_Codigo.Size = new Size(49, 15);
            Lbl_Codigo.TabIndex = 88;
            Lbl_Codigo.Text = "Código:";
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Location = new Point(58, 16);
            Txt_Codigo.MaxLength = 14;
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(119, 23);
            Txt_Codigo.TabIndex = 87;
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.Location = new Point(982, 43);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(75, 23);
            Btn_Buscar.TabIndex = 72;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // DtGridView_Empresa
            // 
            DtGridView_Empresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGridView_Empresa.Location = new Point(12, 90);
            DtGridView_Empresa.MultiSelect = false;
            DtGridView_Empresa.Name = "DtGridView_Empresa";
            DtGridView_Empresa.ReadOnly = true;
            DtGridView_Empresa.Size = new Size(1068, 427);
            DtGridView_Empresa.TabIndex = 62;
            DtGridView_Empresa.CellDoubleClick += DtGridView_Empresa_CellDoubleClick;
            // 
            // FrmConsultaEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 569);
            Controls.Add(DtGridView_Empresa);
            Controls.Add(GrpBox_ConsultaPet);
            Controls.Add(Btn_Sair);
            Name = "FrmConsultaEmp";
            Text = "ConsultaCliente";
            Load += FrmConsultaCli_Load;
            GrpBox_ConsultaPet.ResumeLayout(false);
            GrpBox_ConsultaPet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Empresa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Buscar;
        private Button Btn_Sair;
        private GroupBox GrpBox_ConsultaPet;
        private DataGridView DtGridView_Empresa;
        private CheckBox ChkBox_FarmLab;
        private CheckBox ChkBox_Contr;
        private CheckBox ChkBox_Filial;
        private MaskedTextBox MskBox_CNPJ;
        private MaskedTextBox MskTxt_Telefone;
        private Label Lbl_CNPJ;
        private Label Lbl_RazaoSocial;
        private TextBox Txt_RazaoSocial;
        private Label Lbl_Telefone;
        private Label Lbl_Codigo;
        private TextBox Txt_Codigo;
    }
}