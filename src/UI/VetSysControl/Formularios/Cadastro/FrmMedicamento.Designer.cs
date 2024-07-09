namespace VetSysControl.FORMULARIOS.Cadastro {
    partial class FrmMedicamento {
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
            Btn_Buscar = new Button();
            Lbl_Qtd = new Label();
            Txt_Qtd = new TextBox();
            Dtp_Validade = new DateTimePicker();
            Lbl_Validade = new Label();
            Lbl_Lote = new Label();
            Txt_Lote = new TextBox();
            Lbl_Fabricante = new Label();
            Txt_Fabricante = new TextBox();
            Lbl_Tipo = new Label();
            Txt_Tipo = new TextBox();
            Lbl_Desc = new Label();
            Txt_Desc = new TextBox();
            Lbl_Nome = new Label();
            Txt_Nome = new TextBox();
            Lbl_Codigo = new Label();
            Txt_Codigo = new TextBox();
            Lbl_CadastroMed = new Label();
            Btn_Sair = new Button();
            Btn_Salvar = new Button();
            Btn_Editar = new Button();
            Btn_Excluir = new Button();
            Lbl_Valor = new Label();
            Lbl_Fornecedor = new Label();
            CmbBox_Fornecedor = new ComboBox();
            Lbl_UnidMed = new Label();
            Txt_UnidMed = new TextBox();
            Lbl_Dosagem = new Label();
            Txt_Dosagem = new TextBox();
            GrpBox_Quimicos = new GroupBox();
            DtGridView_Quimicos = new DataGridView();
            Btn_ExcluirComp = new Button();
            Btn_EditarComp = new Button();
            Btn_AddComp = new Button();
            Lbl_Compostos = new Label();
            Txt_Compostos = new TextBox();
            Grp_Fornecedor = new GroupBox();
            MskBox_Valor = new MaskedTextBox();
            GrpBox_Quimicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Quimicos).BeginInit();
            Grp_Fornecedor.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.Location = new Point(250, 82);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(75, 23);
            Btn_Buscar.TabIndex = 39;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Qtd
            // 
            Lbl_Qtd.AutoSize = true;
            Lbl_Qtd.Location = new Point(15, 78);
            Lbl_Qtd.Name = "Lbl_Qtd";
            Lbl_Qtd.Size = new Size(30, 15);
            Lbl_Qtd.TabIndex = 38;
            Lbl_Qtd.Text = "Qtd:";
            // 
            // Txt_Qtd
            // 
            Txt_Qtd.Location = new Point(91, 75);
            Txt_Qtd.MaxLength = 10;
            Txt_Qtd.Name = "Txt_Qtd";
            Txt_Qtd.Size = new Size(57, 23);
            Txt_Qtd.TabIndex = 37;
            // 
            // Dtp_Validade
            // 
            Dtp_Validade.Format = DateTimePickerFormat.Short;
            Dtp_Validade.Location = new Point(387, 46);
            Dtp_Validade.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            Dtp_Validade.Name = "Dtp_Validade";
            Dtp_Validade.Size = new Size(112, 23);
            Dtp_Validade.TabIndex = 36;
            // 
            // Lbl_Validade
            // 
            Lbl_Validade.AutoSize = true;
            Lbl_Validade.Location = new Point(306, 49);
            Lbl_Validade.Name = "Lbl_Validade";
            Lbl_Validade.Size = new Size(54, 15);
            Lbl_Validade.TabIndex = 35;
            Lbl_Validade.Text = "Validade:";
            // 
            // Lbl_Lote
            // 
            Lbl_Lote.AutoSize = true;
            Lbl_Lote.Location = new Point(14, 49);
            Lbl_Lote.Name = "Lbl_Lote";
            Lbl_Lote.Size = new Size(33, 15);
            Lbl_Lote.TabIndex = 34;
            Lbl_Lote.Text = "Lote:";
            // 
            // Txt_Lote
            // 
            Txt_Lote.Location = new Point(91, 46);
            Txt_Lote.MaxLength = 10;
            Txt_Lote.Name = "Txt_Lote";
            Txt_Lote.Size = new Size(165, 23);
            Txt_Lote.TabIndex = 33;
            // 
            // Lbl_Fabricante
            // 
            Lbl_Fabricante.AutoSize = true;
            Lbl_Fabricante.Location = new Point(227, 165);
            Lbl_Fabricante.Name = "Lbl_Fabricante";
            Lbl_Fabricante.Size = new Size(65, 15);
            Lbl_Fabricante.TabIndex = 32;
            Lbl_Fabricante.Text = "Fabricante:";
            // 
            // Txt_Fabricante
            // 
            Txt_Fabricante.Location = new Point(293, 162);
            Txt_Fabricante.MaxLength = 30;
            Txt_Fabricante.Name = "Txt_Fabricante";
            Txt_Fabricante.Size = new Size(147, 23);
            Txt_Fabricante.TabIndex = 31;
            // 
            // Lbl_Tipo
            // 
            Lbl_Tipo.AutoSize = true;
            Lbl_Tipo.Location = new Point(38, 165);
            Lbl_Tipo.Name = "Lbl_Tipo";
            Lbl_Tipo.Size = new Size(33, 15);
            Lbl_Tipo.TabIndex = 30;
            Lbl_Tipo.Text = "Tipo:";
            // 
            // Txt_Tipo
            // 
            Txt_Tipo.Location = new Point(105, 162);
            Txt_Tipo.MaxLength = 30;
            Txt_Tipo.Name = "Txt_Tipo";
            Txt_Tipo.Size = new Size(100, 23);
            Txt_Tipo.TabIndex = 29;
            // 
            // Lbl_Desc
            // 
            Lbl_Desc.AutoSize = true;
            Lbl_Desc.Location = new Point(38, 198);
            Lbl_Desc.Name = "Lbl_Desc";
            Lbl_Desc.Size = new Size(61, 15);
            Lbl_Desc.TabIndex = 28;
            Lbl_Desc.Text = "Descrição:";
            // 
            // Txt_Desc
            // 
            Txt_Desc.Location = new Point(105, 195);
            Txt_Desc.Multiline = true;
            Txt_Desc.Name = "Txt_Desc";
            Txt_Desc.Size = new Size(335, 152);
            Txt_Desc.TabIndex = 27;
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Location = new Point(38, 131);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(43, 15);
            Lbl_Nome.TabIndex = 26;
            Lbl_Nome.Text = "Nome:";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(105, 128);
            Txt_Nome.MaxLength = 70;
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(287, 23);
            Txt_Nome.TabIndex = 25;
            // 
            // Lbl_Codigo
            // 
            Lbl_Codigo.AutoSize = true;
            Lbl_Codigo.Location = new Point(38, 86);
            Lbl_Codigo.Name = "Lbl_Codigo";
            Lbl_Codigo.Size = new Size(49, 15);
            Lbl_Codigo.TabIndex = 24;
            Lbl_Codigo.Text = "Código:";
            // 
            // Txt_Codigo
            // 
            Txt_Codigo.Location = new Point(106, 83);
            Txt_Codigo.MaxLength = 30;
            Txt_Codigo.Name = "Txt_Codigo";
            Txt_Codigo.Size = new Size(119, 23);
            Txt_Codigo.TabIndex = 23;
            // 
            // Lbl_CadastroMed
            // 
            Lbl_CadastroMed.AutoSize = true;
            Lbl_CadastroMed.Location = new Point(37, 32);
            Lbl_CadastroMed.Name = "Lbl_CadastroMed";
            Lbl_CadastroMed.Size = new Size(152, 15);
            Lbl_CadastroMed.TabIndex = 22;
            Lbl_CadastroMed.Text = "Cadastro de Medicamentos";
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(994, 523);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 43;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Location = new Point(739, 523);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(75, 23);
            Btn_Salvar.TabIndex = 42;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            Btn_Editar.Location = new Point(825, 523);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(75, 23);
            Btn_Editar.TabIndex = 41;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Location = new Point(909, 523);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(75, 23);
            Btn_Excluir.TabIndex = 40;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // Lbl_Valor
            // 
            Lbl_Valor.AutoSize = true;
            Lbl_Valor.Location = new Point(15, 107);
            Lbl_Valor.Name = "Lbl_Valor";
            Lbl_Valor.Size = new Size(36, 15);
            Lbl_Valor.TabIndex = 45;
            Lbl_Valor.Text = "Valor:";
            // 
            // Lbl_Fornecedor
            // 
            Lbl_Fornecedor.AutoSize = true;
            Lbl_Fornecedor.Location = new Point(15, 19);
            Lbl_Fornecedor.Name = "Lbl_Fornecedor";
            Lbl_Fornecedor.Size = new Size(70, 15);
            Lbl_Fornecedor.TabIndex = 46;
            Lbl_Fornecedor.Text = "Fornecedor:";
            // 
            // CmbBox_Fornecedor
            // 
            CmbBox_Fornecedor.FormattingEnabled = true;
            CmbBox_Fornecedor.Location = new Point(91, 16);
            CmbBox_Fornecedor.Name = "CmbBox_Fornecedor";
            CmbBox_Fornecedor.Size = new Size(258, 23);
            CmbBox_Fornecedor.TabIndex = 47;
            // 
            // Lbl_UnidMed
            // 
            Lbl_UnidMed.AutoSize = true;
            Lbl_UnidMed.Location = new Point(159, 153);
            Lbl_UnidMed.Name = "Lbl_UnidMed";
            Lbl_UnidMed.Size = new Size(113, 15);
            Lbl_UnidMed.TabIndex = 49;
            Lbl_UnidMed.Text = "Unidade de Medida:";
            // 
            // Txt_UnidMed
            // 
            Txt_UnidMed.Location = new Point(278, 150);
            Txt_UnidMed.MaxLength = 10;
            Txt_UnidMed.Name = "Txt_UnidMed";
            Txt_UnidMed.Size = new Size(52, 23);
            Txt_UnidMed.TabIndex = 48;
            // 
            // Lbl_Dosagem
            // 
            Lbl_Dosagem.AutoSize = true;
            Lbl_Dosagem.Location = new Point(15, 153);
            Lbl_Dosagem.Name = "Lbl_Dosagem";
            Lbl_Dosagem.Size = new Size(60, 15);
            Lbl_Dosagem.TabIndex = 51;
            Lbl_Dosagem.Text = "Dosagem:";
            // 
            // Txt_Dosagem
            // 
            Txt_Dosagem.Location = new Point(81, 150);
            Txt_Dosagem.Name = "Txt_Dosagem";
            Txt_Dosagem.Size = new Size(72, 23);
            Txt_Dosagem.TabIndex = 50;
            // 
            // GrpBox_Quimicos
            // 
            GrpBox_Quimicos.Controls.Add(DtGridView_Quimicos);
            GrpBox_Quimicos.Controls.Add(Btn_ExcluirComp);
            GrpBox_Quimicos.Controls.Add(Btn_EditarComp);
            GrpBox_Quimicos.Controls.Add(Btn_AddComp);
            GrpBox_Quimicos.Controls.Add(Lbl_Compostos);
            GrpBox_Quimicos.Controls.Add(Txt_Compostos);
            GrpBox_Quimicos.Controls.Add(Lbl_Dosagem);
            GrpBox_Quimicos.Controls.Add(Txt_UnidMed);
            GrpBox_Quimicos.Controls.Add(Txt_Dosagem);
            GrpBox_Quimicos.Controls.Add(Lbl_UnidMed);
            GrpBox_Quimicos.Location = new Point(482, 260);
            GrpBox_Quimicos.Name = "GrpBox_Quimicos";
            GrpBox_Quimicos.Size = new Size(587, 189);
            GrpBox_Quimicos.TabIndex = 53;
            GrpBox_Quimicos.TabStop = false;
            GrpBox_Quimicos.Text = "Quimicos";
            // 
            // DtGridView_Quimicos
            // 
            DtGridView_Quimicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtGridView_Quimicos.Dock = DockStyle.Top;
            DtGridView_Quimicos.Location = new Point(3, 19);
            DtGridView_Quimicos.Name = "DtGridView_Quimicos";
            DtGridView_Quimicos.Size = new Size(581, 94);
            DtGridView_Quimicos.TabIndex = 54;
            // 
            // Btn_ExcluirComp
            // 
            Btn_ExcluirComp.Location = new Point(504, 145);
            Btn_ExcluirComp.Name = "Btn_ExcluirComp";
            Btn_ExcluirComp.Size = new Size(75, 23);
            Btn_ExcluirComp.TabIndex = 54;
            Btn_ExcluirComp.Text = "Excluir";
            Btn_ExcluirComp.UseVisualStyleBackColor = true;
            // 
            // Btn_EditarComp
            // 
            Btn_EditarComp.Location = new Point(424, 145);
            Btn_EditarComp.Name = "Btn_EditarComp";
            Btn_EditarComp.Size = new Size(75, 23);
            Btn_EditarComp.TabIndex = 54;
            Btn_EditarComp.Text = "Editar";
            Btn_EditarComp.UseVisualStyleBackColor = true;
            // 
            // Btn_AddComp
            // 
            Btn_AddComp.Location = new Point(343, 145);
            Btn_AddComp.Name = "Btn_AddComp";
            Btn_AddComp.Size = new Size(75, 23);
            Btn_AddComp.TabIndex = 54;
            Btn_AddComp.Text = "Adicionar";
            Btn_AddComp.UseVisualStyleBackColor = true;
            // 
            // Lbl_Compostos
            // 
            Lbl_Compostos.AutoSize = true;
            Lbl_Compostos.Location = new Point(15, 124);
            Lbl_Compostos.Name = "Lbl_Compostos";
            Lbl_Compostos.Size = new Size(66, 15);
            Lbl_Compostos.TabIndex = 54;
            Lbl_Compostos.Text = "Composto:";
            // 
            // Txt_Compostos
            // 
            Txt_Compostos.Location = new Point(81, 121);
            Txt_Compostos.MaxLength = 60;
            Txt_Compostos.Name = "Txt_Compostos";
            Txt_Compostos.Size = new Size(249, 23);
            Txt_Compostos.TabIndex = 53;
            // 
            // Grp_Fornecedor
            // 
            Grp_Fornecedor.Controls.Add(MskBox_Valor);
            Grp_Fornecedor.Controls.Add(Lbl_Fornecedor);
            Grp_Fornecedor.Controls.Add(Txt_Lote);
            Grp_Fornecedor.Controls.Add(CmbBox_Fornecedor);
            Grp_Fornecedor.Controls.Add(Lbl_Lote);
            Grp_Fornecedor.Controls.Add(Lbl_Validade);
            Grp_Fornecedor.Controls.Add(Lbl_Valor);
            Grp_Fornecedor.Controls.Add(Dtp_Validade);
            Grp_Fornecedor.Controls.Add(Txt_Qtd);
            Grp_Fornecedor.Controls.Add(Lbl_Qtd);
            Grp_Fornecedor.Location = new Point(482, 103);
            Grp_Fornecedor.Name = "Grp_Fornecedor";
            Grp_Fornecedor.Size = new Size(587, 151);
            Grp_Fornecedor.TabIndex = 54;
            Grp_Fornecedor.TabStop = false;
            Grp_Fornecedor.Text = "Fornecedor";
            // 
            // MskBox_Valor
            // 
            MskBox_Valor.Location = new Point(91, 104);
            MskBox_Valor.Name = "MskBox_Valor";
            MskBox_Valor.Size = new Size(100, 23);
            MskBox_Valor.TabIndex = 48;
            // 
            // FrmMedicamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 569);
            Controls.Add(Grp_Fornecedor);
            Controls.Add(GrpBox_Quimicos);
            Controls.Add(Btn_Sair);
            Controls.Add(Btn_Salvar);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Excluir);
            Controls.Add(Btn_Buscar);
            Controls.Add(Lbl_Fabricante);
            Controls.Add(Txt_Fabricante);
            Controls.Add(Lbl_Tipo);
            Controls.Add(Txt_Tipo);
            Controls.Add(Lbl_Desc);
            Controls.Add(Txt_Desc);
            Controls.Add(Lbl_Nome);
            Controls.Add(Txt_Nome);
            Controls.Add(Lbl_Codigo);
            Controls.Add(Txt_Codigo);
            Controls.Add(Lbl_CadastroMed);
            Name = "FrmMedicamento";
            Text = "Medicamento";
            Load += FrmMedicamento_Load;
            GrpBox_Quimicos.ResumeLayout(false);
            GrpBox_Quimicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtGridView_Quimicos).EndInit();
            Grp_Fornecedor.ResumeLayout(false);
            Grp_Fornecedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Buscar;
        private Label Lbl_Qtd;
        private TextBox Txt_Qtd;
        private DateTimePicker Dtp_Validade;
        private Label Lbl_Validade;
        private Label Lbl_Lote;
        private TextBox Txt_Lote;
        private Label Lbl_Fabricante;
        private TextBox Txt_Fabricante;
        private Label Lbl_Tipo;
        private TextBox Txt_Tipo;
        private Label Lbl_Desc;
        private TextBox Txt_Desc;
        private Label Lbl_Nome;
        private TextBox Txt_Nome;
        private Label Lbl_Codigo;
        private TextBox Txt_Codigo;
        private Label Lbl_CadastroMed;
        private Button Btn_Sair;
        private Button Btn_Salvar;
        private Button Btn_Editar;
        private Button Btn_Excluir;
        private Label Lbl_Valor;
        private Label Lbl_Fornecedor;
        private ComboBox CmbBox_Fornecedor;
        private Label Lbl_UnidMed;
        private TextBox Txt_UnidMed;
        private Label Lbl_Dosagem;
        private TextBox Txt_Dosagem;
        private GroupBox GrpBox_Quimicos;
        private Button Btn_ExcluirComp;
        private Button Btn_EditarComp;
        private Button Btn_AddComp;
        private Label Lbl_Compostos;
        private TextBox Txt_Compostos;
        private DataGridView DtGridView_Quimicos;
        private GroupBox Grp_Fornecedor;
        private MaskedTextBox MskBox_Valor;
    }
}